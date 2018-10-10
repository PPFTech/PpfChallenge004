using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace PpfChallenge004.Level3
{
    public class Ranking
    {
        #region "Public"
        /// <summary>
        /// ランキング最大保管数
        /// </summary>
        public static int MaxCount = 10;

        /// <summary>
        /// 順位
        /// </summary>
        public List<int> Order = new List<int>();

        /// <summary>
        /// 経過時間(秒)
        /// </summary>
        public List<int> EllapsedSec = new List<int>();

        /// <summary>
        /// 挑戦日時
        /// </summary>
        public List<DateTime> ChallengeDate = new List<DateTime>();
        #endregion

        #region "Property"
        /// <summary>
        /// データ数取得
        /// </summary>
        public int Count
        {
            get { return Order.Count(); }
        }

        /// <summary>
        /// ファイルパス
        /// </summary>
        public string Filepath
        {
            get {
                string execdir = Directory.GetParent(Application.ExecutablePath).ToString();
                string filename = Path.Combine(execdir, "ranking.xml");
                return filename;
            }
        }
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Ranking()
        {
            Clear();
        }
        #endregion

        #region "Method"
        /// <summary>
        /// クリア
        /// </summary>
        public void Clear()
        {
            Order.Clear();
            EllapsedSec.Clear();
            ChallengeDate.Clear();
        }

        /// <summary>
        /// コピー
        /// </summary>
        public void CopyFrom(Ranking rank)
        {
            // いったんクリア
            Clear();

            // データ追加
            Order.AddRange(rank.Order);
            EllapsedSec.AddRange(rank.EllapsedSec);
            ChallengeDate.AddRange(rank.ChallengeDate);
        }

        /// <summary>
        /// データ追加
        /// </summary>
        /// <param name="ellapsed">経過時間(秒)</param>
        /// <param name="challenge">挑戦日時</param>
        public void Add(int ellapsed, DateTime challenge)
        {
            Order.Add(Count + 1);   // とりあえず末尾の番号
            EllapsedSec.Add(ellapsed);
            ChallengeDate.Add(challenge);
        }

        /// <summary>
        /// 並べ替え
        /// </summary>
        public void Sort()
        {
            // まずは時間情報のみを並べ替え
            for (int i = 0; i < Count - 1; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (EllapsedSec[i] > EllapsedSec[j])
                    {
                        Swap(EllapsedSec, i, j);
                        Swap(ChallengeDate, i, j);
                    }
                }
            }

            // 順位は、後から連番で振りなおす
            for (int i = 0; i < Count - 1; i++)
            {
                Order[i] = i + 1;
            }
        }

        /// <summary>
        /// データ削除
        /// </summary>
        /// <param name="index">インデックス</param>
        public void RemoveAt(int index)
        {
            Order.RemoveAt(index);
            EllapsedSec.RemoveAt(index);
            ChallengeDate.RemoveAt(index);
        }


        /// <summary>
        /// 項目の順番を入れ替える(int)
        /// </summary>
        /// <param name="Items">項目</param>
        /// <param name="index1">インデックス1</param>
        /// <param name="index2">インデックス2</param>
        private void Swap(List<int> Items, int index1, int index2)
        {
            int tmp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = tmp;
        }

        /// <summary>
        /// 項目の順番を入れ替える(DateTime)
        /// </summary>
        /// <param name="Items">項目</param>
        /// <param name="index1">インデックス1</param>
        /// <param name="index2">インデックス2</param>
        private void Swap(List<DateTime> Items, int index1, int index2)
        {
            DateTime tmp = Items[index1];
            Items[index1] = Items[index2];
            Items[index2] = tmp;
        }

        /// <summary>
        /// データ保存
        /// </summary>
        public void Save()
        {
            try { 
                XmlSerializer xml = new XmlSerializer(typeof(Ranking));
                StreamWriter sw = new StreamWriter(Filepath, false, new UTF8Encoding(false));
                xml.Serialize(sw, this);
                sw.Close();
            }
            catch (Exception ex)
            {
                // 無視
            }
        }

        /// <summary>
        /// データ読み込み
        /// </summary>
        public void Load()
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Ranking));
                StreamReader sr = new StreamReader(Filepath, new UTF8Encoding(false));
                Ranking rank = (Ranking)xml.Deserialize(sr);
                CopyFrom(rank);
                sr.Close();
            }
            catch (Exception ex)
            {
                // 無視
            }
        }
        #endregion
    }
}
