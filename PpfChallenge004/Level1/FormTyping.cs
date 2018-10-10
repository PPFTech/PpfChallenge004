using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PpfChallenge004.Level1
{
    public partial class FormTyping : Form
    {
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
            char c = e.KeyChar;

            // 入力文字を画面上に表示(必ず大文字で)
            labelInput.Text = c.ToString().ToUpper();
        }
        #endregion

        #region "Method"
        /// <summary>
        /// フォーム初期化
        /// </summary>
        private void InitializeForm()
        {
            labelSubject.Text = "A";
            labelInput.Text = "";
        }
        #endregion
    }
}
