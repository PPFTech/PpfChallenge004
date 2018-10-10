using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpfChallenge004.Level2
{
    class Subject
    {
        #region "Public"
        /// <summary>
        /// 単語リスト
        /// </summary>
        public List<string> Word = new List<string>();

        /// <summary>
        /// 単語カナリスト
        /// </summary>
        public List<string> Kana = new List<string>();
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="WordWithComma">単語文字列(カンマ区切り)</param>
        /// <param name="KanaWithComma">カナ文字列(カンマ区切り)</param>
        public Subject(string WordWithComma, string KanaWithComma)
        {
            // カンマで分解し、リストとして保管
            Word = WordWithComma.Split(',').ToList();
            Kana = KanaWithComma.Split(',').ToList();
        }
        #endregion

        #region "Method"
        /// <summary>
        /// 単語文字列
        /// </summary>
        /// <param name="joinChar">結合文字</param>
        /// <returns></returns>
        public string WordString(string joinChar)
        {
            string str = string.Join(joinChar, Word);
            return str.ToUpper();
        }

        /// <summary>
        /// カナ文字列
        /// </summary>
        /// <param name="joinChar">結合文字</param>
        /// <returns></returns>
        public string KanaString(string joinChar)
        {
            string str = string.Join(joinChar, Kana);
            return str.ToUpper();
        }
        #endregion
    }
}
