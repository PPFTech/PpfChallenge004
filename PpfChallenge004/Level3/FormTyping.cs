using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpfChallenge004.Level3
{
    public partial class FormTyping : Form
    {
        #region "Enum"
        /// <summary>
        /// プレイステータス
        /// </summary>
        private enum PlayStatus
        {
            Ready,      // 待機状態
            Playing,    // プレイ中
            Abort       // 中止
        }

        /// <summary>
        /// 判定ステータス
        /// </summary>
        private enum JudgeStatus
        {
            Ready,      // 待機中
            Start,      // 開始
            Pass,       // 合格
            Fail,       // 不合格
            Clear       // クリア
        }
        #endregion

        #region "Private"
        /// <summary>
        /// 出題項目数
        /// </summary>
        private const int SubjectMaxCount = 10;

        /// <summary>
        /// 出題位置
        /// </summary>
        private int SubjectIndex = 0;

        /// <summary>
        /// お題リスト
        /// </summary>
        private SubjectList Subjects = new SubjectList();

        /// <summary>
        /// プレイステータス
        /// </summary>
        private PlayStatus CurrentStatus = PlayStatus.Ready;

        /// <summary>
        /// 入力内容
        /// </summary>
        private string InputWord = "";

        /// <summary>
        /// 入力文字インデックス
        /// </summary>
        private int InputCharIndex = 0;

        /// <summary>
        /// 時間測定－開始時間
        /// </summary>
        private DateTime StartTime;

        /// <summary>
        /// 時間測定－終了時間
        /// </summary>
        private DateTime StopTime;

        /// <summary>
        /// ランキングリスト
        /// </summary>
        private Ranking RankingList = new Ranking();

        /// <summary>
        /// 現在の判定メッセージ(ちらつき表示のための保管用)
        /// </summary>
        private string CurrentJudgeMessage = "";

        /// <summary>
        /// キーボードレイアウト表示ラベルリスト
        /// </summary>
        private List<Label> KeyboardLayout = new List<Label>();

        /// <summary>
        /// 検索用テキスト表示ラベルリスト
        /// </summary>
        private List<string> KeyboardText = new List<string>();
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormTyping()
        {
            InitializeComponent();
        }
        #endregion

        #region "Event"
        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTyping_Load(object sender, EventArgs e)
        {
            // フォーム初期化
            InitializeForm();

            // ランキングデータ読み込み
            RankingList.Load();
        }

        /// <summary>
        /// キー押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 停止中であれば何もしない
            if (CurrentStatus == PlayStatus.Ready)
                return;

            // 入力された文字の検出
            string c = e.KeyChar.ToString().ToUpper();

            // 押されたキー表示を画面に反映
            ReactKeyboard(c);

            // タイピング処理
            TypingProcess(c);
        }

        /// <summary>
        /// 各種ボタンがキー押下イベントを受け取ってしまった時は、スルーしてフォームに渡す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormTyping_KeyPress(null, e);
        }

        /// <summary>
        /// キーボードに表示を反応させる(バックグラウンド処理)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundReactKeyboard_DoWork(object sender, DoWorkEventArgs e)
        {
            // キーボードインデックスの取得
            int index = (int)(e.Argument);

            // キーボードをON表示にする
            int waitMsec = 250;     // 待機時間(msec)
            int waitOnce = 50;      // 1回あたりの待機時間(msec)
            int waitTime = waitMsec / waitOnce;
            KeyboardLayout[index].Image = Properties.Resources.KeyboardOn;
            Application.DoEvents();

            // ON表示のまま一定時間待機
            for (int i = 0; i < waitTime; i++)
            {
                System.Threading.Thread.Sleep(waitOnce);
                Application.DoEvents();
            }

            // キーボードをOFF表示に戻す
            KeyboardLayout[index].Image = Properties.Resources.KeyboardOff;
            Application.DoEvents();

            // イベント完了
            e.Result = "Complete";
        }

        /// <summary>
        /// [スタート]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // 各種クリア
            ClearSubject();
            ClearInput();

            // ステータス設定
            SetStatus(PlayStatus.Playing);
            DispJudge(JudgeStatus.Start);

            // 最初の問題を表示
            DispSubject();

            // 開始時刻設定
            StartTime = DateTime.Now;
        }

        /// <summary>
        /// [ゲーム中止]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbort_Click(object sender, EventArgs e)
        {
            // ステータス設定
            SetStatus(PlayStatus.Abort);
            DispJudge(JudgeStatus.Ready);
        }

        /// <summary>
        /// [ランキング]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRanking_Click(object sender, EventArgs e)
        {
            FormRanking frm = new FormRanking(RankingList);
            frm.ShowDialog();
            frm.Dispose();
        }

        /// <summary>
        /// タイマー表示(ちらつき)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFlick_Tick(object sender, EventArgs e)
        {
            // メッセージがちらちらするようにする
            // ※VisibleをON/OFFすると、いらないところまでちらちらするので、
            //   表示テキストを出したり消したりする方向で設定
            if (CurrentJudgeMessage == "")
            {
                CurrentJudgeMessage = labelJudge.Text;
                labelJudge.Text = "";
            }
            else
            {
                labelJudge.Text = CurrentJudgeMessage;
                CurrentJudgeMessage = "";
            }
        }
        #endregion

        #region "Method"
         /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitializeForm()
        {
            // お題
            ClearSubject();
            // 入力欄
            ClearInput();
            // タイトル表示
            DispTitle();
            // Pass/Fail表示欄
            DispJudge(JudgeStatus.Ready);
            // ステータス設定
            SetStatus(PlayStatus.Ready);
            // タイマー設定
            SetFlickTimer(true);
            // キーボードレイアウトの初期設定
            InitKeyboardLayout();
        }

        /// <summary>
        /// キーボードレイアウトの初期化
        /// </summary>
        private void InitKeyboardLayout()
        {
            // いったんクリア
            KeyboardLayout.Clear();
            KeyboardText.Clear();

            // リストにレイアウトを追加
            KeyboardLayout.AddRange(new List<Label>()
            {
                labelKey11, labelKey12, labelKey13, labelKey14, labelKey15, labelKey16, labelKey17, labelKey18,
                labelKey19, labelKey1A, labelKey1B,
                labelKey21, labelKey22, labelKey23, labelKey24, labelKey25, labelKey26, labelKey27, labelKey28,
                labelKey29, labelKey2A, labelKey2B, labelKey2C,
                labelKey31, labelKey32, labelKey33, labelKey34, labelKey35, labelKey36, labelKey37, labelKey38,
                labelKey39, labelKey3A, labelKey3B, labelKey3C,
                labelKey41, labelKey42, labelKey43, labelKey44, labelKey45, labelKey46, labelKey47, labelKey48,
                labelKey49, labelKey4A, labelKey4B
            });

            // 検索用テキストに、各ラベルの表示テキストを設定しておく
            foreach (Label lbl in KeyboardLayout)
            {
                KeyboardText.Add(lbl.Text);
            }
        }

        /// <summary>
        /// ステータス設定
        /// </summary>
        /// <param name="status"></param>
        private void SetStatus(PlayStatus status)
        {
            // 現在のステータスに設定
            CurrentStatus = status;

            // 合わせてボタン制御 ON/OFF
            EnableButtons();
        }

        /// <summary>
        /// ボタンのEnable設定
        /// </summary>
        private void EnableButtons()
        {
            switch (CurrentStatus)
            {
                case PlayStatus.Ready:
                case PlayStatus.Abort:
                    buttonStart.Enabled = true;
                    buttonStop.Enabled = false;
                    buttonRanking.Enabled = true;
                    break;
                case PlayStatus.Playing:
                    buttonStart.Enabled = false;
                    buttonStop.Enabled = true;
                    buttonRanking.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// お題表示のクリア
        /// </summary>
        private void ClearSubject()
        {
            labelSubjectWord.Text = "";
            labelSubjectKana.Text = "";
            SubjectIndex = 0;
        }

        /// <summary>
        /// お題を表示する
        /// </summary>
        private void DispSubject()
        {
            // 次の項目を決定
            Subject Next = Subjects.Next;
            // 決定した項目を表示として反映
            labelSubjectWord.Text = Next.WordString(" "); // 空白で結合
            labelSubjectKana.Text = Next.KanaString(" "); // 空白で結合
            // インデックスを増やしておく
            SubjectIndex += 1;
        }

        /// <summary>
        /// 入力欄クリア
        /// </summary>
        private void ClearInput()
        {
            // 入力用変数クリア
            InputCharIndex = 0;
            InputWord = "";
            // 表示クリア
            labelInput.Text = "";
        }

        /// <summary>
        /// 入力欄表示
        /// </summary>
        /// <param name="input"></param>
        private void DispInput(string input)
        {
            labelInput.Text = input;
        }

        /// <summary>
        /// インプット文字の判定
        /// </summary>
        /// <param name="inputChar">インプット文字</param>
        /// <returns></returns>
        private bool JudgeInput(string inputChar)
        {
            bool judge = false;

            // 正解文字の取得
            string correctKana = Subjects.Item.KanaString("");     // そのまま結合
            string correctChar = correctKana.Substring(InputCharIndex, 1);

            // 入力文字との比較
            if (inputChar == correctChar)
                judge = true;

            return judge;
        }

        /// <summary>
        /// タイトル表示
        /// </summary>
        private void DispTitle()
        {
            labelSubjectWord.Text = "ほにゃららタイピング";
            labelSubjectKana.Text = "(★´3`)ノ Let's try!";
        }

        /// <summary>
        /// 判定結果の表示
        /// </summary>
        /// <param name="judge"></param>
        private void DispJudge(JudgeStatus judge)
        {
            switch (judge)
            {
                case JudgeStatus.Ready:
                    labelJudge.Text = "Please Click [スタート] !";
                    labelJudge.ForeColor = Color.Tomato;
                    break;
                case JudgeStatus.Start:
                    labelJudge.Text = "G o G o !";
                    labelJudge.ForeColor = Color.White;
                    break;
                case JudgeStatus.Pass:
                    labelJudge.Text = "O K !";
                    labelJudge.ForeColor = Color.LawnGreen;
                    break;
                case JudgeStatus.Fail:
                    labelJudge.Text = "M i s s !";
                    labelJudge.ForeColor = Color.Magenta;
                    break;
                case JudgeStatus.Clear:
                    // 結果表示
                    labelJudge.Text = "C l e a r !";
                    labelJudge.ForeColor = Color.Aquamarine;
                    break;
            }

            // その時点のメッセージを保管しておく
            CurrentJudgeMessage = labelJudge.Text;
        }

        /// <summary>
        /// ちらつき表示用タイマーON/OFF
        /// </summary>
        /// <param name="status"></param>
        private void SetFlickTimer(bool status)
        {
            if (status)
            {
                timerFlick.Interval = 500;  // 0.5sec
                timerFlick.Start();
                CurrentJudgeMessage = "";
            }
            else
            {
                timerFlick.Stop();
                CurrentJudgeMessage = "";
            }
        }

        /// <summary>
        /// タイピング処理
        /// </summary>
        /// <param name="c">入力文字</param>
        private void TypingProcess(string c)
        {
            // お題のカナ全文
            string kana = Subjects.Item.KanaString("");  // そのまま結合

            // 既にすべて入力されていれば、以降は無視する
            if (InputCharIndex >= kana.Length)
                return;

            // 入力内容があっているか否かの判定
            if (JudgeInput(c))
            {
                // 入力単語用変数に、入力文字を追加し表示
                InputWord += c;
                DispInput(InputWord);
                // インデックスを一つ進める
                InputCharIndex += 1;
                // 判定結果の表示
                DispJudge(JudgeStatus.Pass);
            }
            else
            {
                // 間違った文字をつけて、いったん表示
                DispInput(InputWord + c);
                // 判定結果の表示
                DispJudge(JudgeStatus.Fail);
            }

            // 完了処理
            if (kana == labelInput.Text)
                CompleteGame();

        }

        /// <summary>
        /// キーボードに表示を反応させる
        /// </summary>
        /// <param name="c"></param>
        private void ReactKeyboard(string c)
        {
            // 本来の処理と切り離して、別スレッドで処理する
            int arg = KeyboardText.IndexOf(c);
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += BackgroundReactKeyboard_DoWork;
            worker.RunWorkerAsync(arg);

        }

        /// <summary>
        /// 完了処理
        /// </summary>
        private void CompleteGame()
        {
            // クリア表示
            DispJudge(JudgeStatus.Clear);

            // 次の表示
            if (SubjectIndex < SubjectMaxCount - 1)
            {
                // さらに、次の問題があれば表示
                DispSubject();
                ClearInput();
                DispJudge(JudgeStatus.Start);
            }
            else
            {
                // 次の問題がなければ完了メッセージを表示
                CompleteMessage();
                // 花火を打ち上げる
                LaunchFireworks();
                // なければ終了
                StopTime = DateTime.Now;
                SetStatus(PlayStatus.Ready);
                DispJudge(JudgeStatus.Ready);
                // 時間を記録
                RecordTime();
                // 表示をクリア
                ClearSubject();
                ClearInput();
                // タイトル表示に戻す
                DispTitle();
             }
        }

        /// <summary>
        /// 経過時間を記録
        /// </summary>
        private void RecordTime()
        {
            int ellapse = (int)StopTime.Subtract(StartTime).TotalSeconds;
            DateTime date = DateTime.Now;

            // ランキングデータに追加し、時間でソート
            RankingList.Add(ellapse, date);
            RankingList.Sort();
            // ランキングカウント数を超えた場合は、最後の要素は削除する
            if (RankingList.Count > Ranking.MaxCount)
                RankingList.RemoveAt(Ranking.MaxCount);
            // データを保存
            RankingList.Save();
        }

        /// <summary>
        /// 完了表示
        /// </summary>
        private void CompleteMessage()
        {
            // 下のメッセージのちらつきは止める
            timerFlick.Stop();

            // テキスト色を目立つ色に変更
            labelSubjectWord.ForeColor = Color.Gold;
            labelSubjectKana.ForeColor = Color.Gold;

            // クリアメッセージをちらちらさせる
            for (int i = 0; i < 4; i++) { 
                if (i % 2 == 0)
                {
                    labelSubjectWord.Text = "～ C l e a r ～";
                    labelSubjectKana.Text = "Congratulations!";
                }
                else
                {
                    labelSubjectWord.Text = "";
                    labelSubjectKana.Text = "";
                }
                System.Threading.Thread.Sleep(500);
                Application.DoEvents();
            }

            // テキスト色を元に戻す
            labelSubjectWord.ForeColor = SystemColors.ControlText;
            labelSubjectKana.ForeColor = SystemColors.ControlText;

            // 下のメッセージのちらつきを再開
            timerFlick.Start();
        }

        /// <summary>
        /// 花火を打ち上げる
        /// </summary>
        private void LaunchFireworks()
        {
            Image[] fireworks = { Properties.Resources.FireWorks1,
                                  Properties.Resources.FireWorks2,
                                  Properties.Resources.FireWorks3};

            // パネル位置サイズ調整・表示
            panelComplete.Size = this.Size;
            panelComplete.Location = new Point(0, 0);
            panelComplete.Visible = true;

            // 花火を3回打ち上げ
            for (int i = 0; i < 3; i++)
            {
                foreach (Image img in fireworks)
                {
                    panelComplete.BackgroundImage = img;
                    Sleep(500);
                }
            }

            // パネル表示OFF
            panelComplete.Visible = false;
            Application.DoEvents();
        }

        /// <summary>
        /// スリープ
        /// </summary>
        /// <param name="waitMs"></param>
        private void Sleep(int waitMs)
        {
            for (int i = 0; i < waitMs/100; i++)
            {
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        #endregion

    }
}
