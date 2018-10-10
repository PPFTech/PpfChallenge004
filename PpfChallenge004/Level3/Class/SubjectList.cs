using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpfChallenge004.Level3
{
    public class SubjectList
    {
        #region "Privte"
        /// <summary>
        /// お題リスト
        /// </summary>
        private List<Subject> Items = new List<Subject>();

        /// <summary>
        /// 出題インデックスリスト
        /// </summary>
        private List<int> Indexes = new List<int>();

        /// <summary>
        /// 現在のインデックス
        /// </summary>
        private int CurrentIndex = -1;
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SubjectList()
        {
            // お題作成
            Create();
        }
        #endregion

        #region "Property"
        /// <summary>
        /// 現在のインデックスを取得
        /// </summary>
        /// <returns></returns>
        public int Index
        {
            get { return CurrentIndex; }
        }

        /// <summary>
        /// お題のカウント数を取得
        /// </summary>
        /// <returns></returns>
        public int Count
        {
            get { return Items.Count; }
        }

        /// <summary>
        /// 現在の項目を取得
        /// </summary>
        /// <returns></returns>
        public Subject Item
        {
            get
            {
                // 問題数を超える場合には、カウントを0に戻す
                if (CurrentIndex >= Count)
                    CurrentIndex = 0;

                return Items[CurrentIndex];
            }
        }

        /// <summary>
        /// 次の項目を取得
        /// </summary>
        /// <returns></returns>
        public Subject Next
        {
            get {
                // カウントを1つアップする
                CurrentIndex += 1;

                // 問題数を超える場合には、カウントを0に戻す
                if (CurrentIndex >= Count)
                    CurrentIndex = 0;

                // 該当する項目を返す
                return Items[CurrentIndex];
            }
        }
        #endregion

        #region "Method"
        /// <summary>
        /// お題リスト作成
        /// </summary>
        public void Create()
        {
            // お題を作成(とりあえず20問)
            Items.Clear();
            Items.Add(new Subject("ほ,げ,ほ,げ", "HO,GE,HO,GE"));
            Items.Add(new Subject("ピー,ピー,エ,フ", "PI-,PI-,E,FU"));
            Items.Add(new Subject("ほ,にゃ,ら,ら", "HO,NYA,RA,RA"));
            Items.Add(new Subject("カ,ル,シ,ウ,ム", "KA,RU,SI,U,MU"));
            Items.Add(new Subject("山,田,太,郎", "YA,MA,DA,TA,RO,U"));
            Items.Add(new Subject("大,阪,市,中,央,区", "O,O,SA,KA,SI,TYU,U,O,U,KU"));
            Items.Add(new Subject("シー,シャー,プ", "SI-,SYA-,PU"));
            Items.Add(new Subject("2,0,1,8,/,0,9,/,0,6", "2,0,1,8,/,0,9,/,0,6"));
            Items.Add(new Subject("チ,ベッ,ト,ス,ナ,ギ,ツ,ネ", "TI,BE,TTO,SU,NA,GI,TU,NE"));
            Items.Add(new Subject("寿,限,無,寿,限,無", "JU,GE,MU,JU,GE,MU"));
            Items.Add(new Subject("島,流,し", "SI,MA,NA,GA,SI"));
            Items.Add(new Subject("打,ち,首,獄,門", "U,TI,KU,BI,GO,KU,MO,N"));
            Items.Add(new Subject("ハ,シ,ビ,ロ,コ,ウ", "HA,SI,BI,RO,KO,U"));
            Items.Add(new Subject("五,連,休", "GO,RE,NN,KYU,U"));
            Items.Add(new Subject("メ,ガ,ネ,メ,ガ,ネ", "ME,GA,NE,ME,GA,NE"));
            Items.Add(new Subject("無,茶,ぶ,り", "MU,TYA,BU,RI"));
            Items.Add(new Subject("ぱ,ぱ,ぱ,ぱ,ぱ", "PA,PA,PA,PA,PA"));
            Items.Add(new Subject("も,も,も,も,も", "MO,MO,MO,MO,MO"));
            Items.Add(new Subject("師,匠,ク,ラ,ス", "SI,SYO,U,KU,RA,SU"));
            Items.Add(new Subject("( *´艸｀)", "KA,O,MO,JI"));

            // お題の順序をランダムに指定
            Random rand = new Random();
            for (int i = 0; i < Count; i++)
            {
                // リストへの挿入位置を乱数で決定
                int index = rand.Next(0, Count - 1);
                // 指定した位置へお題の順序インデックスを挿入
                // (挿入位置までまだデータがなければ、そのまま追加)
                if (index > Indexes.Count)
                    Indexes.Add(i);
                else
                    Indexes.Insert(index, i);
            }

            CurrentIndex = 0;
        }
        #endregion
    }
}
