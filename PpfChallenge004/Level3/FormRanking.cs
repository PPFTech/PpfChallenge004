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
    public partial class FormRanking : Form
    {
        #region "Private"
        /// <summary>
        /// ランキングリスト
        /// </summary>
        private Ranking RankingList;
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormRanking(Ranking rank)
        {
            InitializeComponent();

            // パラメータ設定
            RankingList = rank;
        }
        #endregion

        #region "Event"
        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRanking_Load(object sender, EventArgs e)
        {
            DispRanking();
        }

        /// <summary>
        /// [とじる]ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        #endregion

        #region "Method"
        /// <summary>
        /// ランキング表示
        /// </summary>
        private void DispRanking()
        {
            for (int i = 0; i < RankingList.Count; i++)
            {
                // 表示形式に成形
                decimal sec = RankingList.EllapsedSec[i];
                string order = RankingList.Order[i].ToString() + "位";
                string ellapsed = string.Format("{0:00}:{1:00}:{2:00}",　sec / 3600, sec / 60, sec % 60);
                string date = RankingList.ChallengeDate[i].ToString("yyyy/MM/dd  HH:mm:ss");
                // ランキングリストに追加
                string[] item = {order, ellapsed, date};
                listViewRanking.Items.Add(new ListViewItem(item));
            }
        }
        #endregion
    }
}
