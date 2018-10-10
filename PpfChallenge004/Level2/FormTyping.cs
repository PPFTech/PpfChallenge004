using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpfChallenge004.Level2
{
    public partial class FormTyping : Form
    {
        #region "Enum"
        /// <summary>
        /// 判定ステータス
        /// </summary>
        private enum JudgeStatus
        {
            Start,      // 開始
            Pass,       // 合格
            Fail,       // 不合格
            Clear       // クリア
        }
        #endregion

        #region "Private"
        /// <summary>
        /// お題リスト
        /// </summary>
        private List<Subject> SubjectList = new List<Subject>();

        /// <summary>
        /// 入力内容
        /// </summary>
        private string InputWord = "";

        /// <summary>
        /// 入力文字インデックス
        /// </summary>
        private int InputCharIndex = 0;
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
            // お題内容作成
            CreateSubject();

            // フォーム初期化
            InitializeForm();
        }

        /// <summary>
        /// キー押下イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTyping_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 入力された文字の検出
            string c = e.KeyChar.ToString().ToUpper();

            // タイピング処理
            TypingProcess(c);
        }
        #endregion

        #region "Method"
        /// <summary>
        /// お題作成
        /// </summary>
        private void CreateSubject()
        {
            SubjectList.Add(new Subject("ほ,にゃ,ら,ら", "HO,NYA,RA,RA"));
        }

        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitializeForm()
        {
            // お題
            labelSubjectWord.Text = SubjectList[0].WordString(" "); // 空白で結合
            labelSubjectKana.Text = SubjectList[0].KanaString(" "); // 空白で結合
            // 入力欄
            labelInput.Text = "";
            InputWord = "";
            // Pass/Fail表示欄
            DispJudge(JudgeStatus.Start);
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
            string correctKana = SubjectList[0].KanaString("");     // そのまま結合
            string correctChar = correctKana.Substring(InputCharIndex, 1);

            // 入力文字との比較
            if (inputChar == correctChar)
                judge = true;

            return judge;
        }

        /// <summary>
        /// 判定結果の表示
        /// </summary>
        /// <param name="judge"></param>
        private void DispJudge(JudgeStatus judge)
        {
            switch (judge)
            {
                case JudgeStatus.Start:
                    labelJudge.Text = "";
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
                    labelJudge.Text = "C l e a r !";
                    labelJudge.ForeColor = Color.Aquamarine;
                    break;
            }
        }

        /// <summary>
        /// タイピング処理
        /// </summary>
        /// <param name="c">入力文字</param>
        private void TypingProcess(string c)
        {
            // お題のカナ全文
            string kana = SubjectList[0].KanaString("");  // そのまま結合

            // 既にすべて入力されていれば、以降は無視する
            if (InputCharIndex >= kana.Length)
                return;

            // 入力内容があっているか否かの判定
            if (JudgeInput(c))
            {
                // 入力単語用変数に、入力文字を追加し表示
                InputWord += c;
                labelInput.Text = InputWord;
                // インデックスを一つ進める
                InputCharIndex += 1;
                // 判定結果の表示
                DispJudge(JudgeStatus.Pass);
            }
            else
            {
                // 間違った文字をつけて、いったん表示
                labelInput.Text = InputWord + c;
                // 判定結果の表示
                DispJudge(JudgeStatus.Fail);
            }

            // 完了していれば、クリア表示する
            if (kana == labelInput.Text)
                DispJudge(JudgeStatus.Clear);
        }
        #endregion
    }
}
