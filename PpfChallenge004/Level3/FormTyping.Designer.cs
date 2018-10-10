namespace PpfChallenge004.Level3
{
    partial class FormTyping
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTyping));
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelJudge = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSubject = new System.Windows.Forms.Panel();
            this.labelSubjectWord = new System.Windows.Forms.Label();
            this.labelSubjectKana = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.timerFlick = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutKeyboard = new System.Windows.Forms.TableLayoutPanel();
            this.labelKey1B = new System.Windows.Forms.Label();
            this.labelKey1A = new System.Windows.Forms.Label();
            this.labelKey19 = new System.Windows.Forms.Label();
            this.labelKey18 = new System.Windows.Forms.Label();
            this.labelKey17 = new System.Windows.Forms.Label();
            this.labelKey16 = new System.Windows.Forms.Label();
            this.labelKey15 = new System.Windows.Forms.Label();
            this.labelKey13 = new System.Windows.Forms.Label();
            this.labelKey12 = new System.Windows.Forms.Label();
            this.labelKey11 = new System.Windows.Forms.Label();
            this.labelKey14 = new System.Windows.Forms.Label();
            this.labelKey21 = new System.Windows.Forms.Label();
            this.labelKey23 = new System.Windows.Forms.Label();
            this.labelKey24 = new System.Windows.Forms.Label();
            this.labelKey25 = new System.Windows.Forms.Label();
            this.labelKey26 = new System.Windows.Forms.Label();
            this.labelKey27 = new System.Windows.Forms.Label();
            this.labelKey28 = new System.Windows.Forms.Label();
            this.labelKey29 = new System.Windows.Forms.Label();
            this.labelKey2A = new System.Windows.Forms.Label();
            this.labelKey2B = new System.Windows.Forms.Label();
            this.labelKey22 = new System.Windows.Forms.Label();
            this.labelKey31 = new System.Windows.Forms.Label();
            this.labelKey32 = new System.Windows.Forms.Label();
            this.labelKey33 = new System.Windows.Forms.Label();
            this.labelKey34 = new System.Windows.Forms.Label();
            this.labelKey35 = new System.Windows.Forms.Label();
            this.labelKey36 = new System.Windows.Forms.Label();
            this.labelKey37 = new System.Windows.Forms.Label();
            this.labelKey38 = new System.Windows.Forms.Label();
            this.labelKey39 = new System.Windows.Forms.Label();
            this.labelKey3A = new System.Windows.Forms.Label();
            this.labelKey3B = new System.Windows.Forms.Label();
            this.labelKey41 = new System.Windows.Forms.Label();
            this.labelKey42 = new System.Windows.Forms.Label();
            this.labelKey43 = new System.Windows.Forms.Label();
            this.labelKey44 = new System.Windows.Forms.Label();
            this.labelKey45 = new System.Windows.Forms.Label();
            this.labelKey46 = new System.Windows.Forms.Label();
            this.labelKey47 = new System.Windows.Forms.Label();
            this.labelKey48 = new System.Windows.Forms.Label();
            this.labelKey49 = new System.Windows.Forms.Label();
            this.labelKey4A = new System.Windows.Forms.Label();
            this.labelKey4B = new System.Windows.Forms.Label();
            this.labelKey2C = new System.Windows.Forms.Label();
            this.labelKey3C = new System.Windows.Forms.Label();
            this.panelComplete = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSubject.SuspendLayout();
            this.tableLayoutKeyboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 20F);
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMessage.Location = new System.Drawing.Point(3, 212);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(873, 70);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "目指せ！タイピングの鬼☆　＼＿ﾍ(ω｀*)KATAKATAKATAKATA";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInput
            // 
            this.labelInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInput.BackColor = System.Drawing.Color.Beige;
            this.labelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInput.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 22F);
            this.labelInput.Location = new System.Drawing.Point(3, 282);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(873, 35);
            this.labelInput.TabIndex = 2;
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelJudge
            // 
            this.labelJudge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJudge.BackColor = System.Drawing.Color.Transparent;
            this.labelJudge.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F);
            this.labelJudge.ForeColor = System.Drawing.Color.LawnGreen;
            this.labelJudge.Location = new System.Drawing.Point(3, 317);
            this.labelJudge.Name = "labelJudge";
            this.labelJudge.Size = new System.Drawing.Size(873, 37);
            this.labelJudge.TabIndex = 3;
            this.labelJudge.Text = "O K !";
            this.labelJudge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelSubject, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelJudge, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelMessage, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 354);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelSubject
            // 
            this.panelSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSubject.BackColor = System.Drawing.Color.Beige;
            this.panelSubject.Controls.Add(this.labelSubjectWord);
            this.panelSubject.Controls.Add(this.labelSubjectKana);
            this.panelSubject.Location = new System.Drawing.Point(3, 3);
            this.panelSubject.Name = "panelSubject";
            this.panelSubject.Size = new System.Drawing.Size(873, 206);
            this.panelSubject.TabIndex = 0;
            // 
            // labelSubjectWord
            // 
            this.labelSubjectWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubjectWord.BackColor = System.Drawing.Color.Beige;
            this.labelSubjectWord.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 32F);
            this.labelSubjectWord.Location = new System.Drawing.Point(4, 41);
            this.labelSubjectWord.Name = "labelSubjectWord";
            this.labelSubjectWord.Size = new System.Drawing.Size(865, 74);
            this.labelSubjectWord.TabIndex = 0;
            this.labelSubjectWord.Text = "ほ にゃ ら ら";
            this.labelSubjectWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelSubjectKana
            // 
            this.labelSubjectKana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubjectKana.BackColor = System.Drawing.Color.Beige;
            this.labelSubjectKana.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 22F);
            this.labelSubjectKana.Location = new System.Drawing.Point(6, 139);
            this.labelSubjectKana.Name = "labelSubjectKana";
            this.labelSubjectKana.Size = new System.Drawing.Size(862, 41);
            this.labelSubjectKana.TabIndex = 1;
            this.labelSubjectKana.Text = "HO NYA RA RA";
            this.labelSubjectKana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F);
            this.buttonStart.Location = new System.Drawing.Point(16, 364);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 38);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "スタート";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStop.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F);
            this.buttonStop.Location = new System.Drawing.Point(388, 364);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(120, 38);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "ゲーム中止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonAbort_Click);
            this.buttonStop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // buttonRanking
            // 
            this.buttonRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRanking.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F);
            this.buttonRanking.Location = new System.Drawing.Point(772, 364);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(120, 38);
            this.buttonRanking.TabIndex = 3;
            this.buttonRanking.Text = "ランキング";
            this.buttonRanking.UseVisualStyleBackColor = true;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            this.buttonRanking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // timerFlick
            // 
            this.timerFlick.Tick += new System.EventHandler(this.timerFlick_Tick);
            // 
            // tableLayoutKeyboard
            // 
            this.tableLayoutKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutKeyboard.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.ColumnCount = 27;
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.80732F));
            this.tableLayoutKeyboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.009701F));
            this.tableLayoutKeyboard.Controls.Add(this.labelKey1B, 20, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey1A, 18, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey19, 16, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey18, 14, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey17, 12, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey16, 10, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey15, 8, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey13, 4, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey12, 2, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey11, 0, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey14, 6, 0);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey21, 1, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey23, 5, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey24, 7, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey25, 9, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey26, 11, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey27, 13, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey28, 15, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey29, 17, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey2A, 19, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey2B, 21, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey22, 3, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey31, 2, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey32, 4, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey33, 6, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey34, 8, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey35, 10, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey36, 12, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey37, 14, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey38, 16, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey39, 18, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey3A, 20, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey3B, 22, 4);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey41, 3, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey42, 5, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey43, 7, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey44, 9, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey45, 11, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey46, 13, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey47, 15, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey48, 17, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey49, 19, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey4A, 21, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey4B, 23, 6);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey2C, 23, 2);
            this.tableLayoutKeyboard.Controls.Add(this.labelKey3C, 24, 4);
            this.tableLayoutKeyboard.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14F);
            this.tableLayoutKeyboard.Location = new System.Drawing.Point(16, 414);
            this.tableLayoutKeyboard.Name = "tableLayoutKeyboard";
            this.tableLayoutKeyboard.RowCount = 7;
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutKeyboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutKeyboard.Size = new System.Drawing.Size(873, 185);
            this.tableLayoutKeyboard.TabIndex = 0;
            // 
            // labelKey1B
            // 
            this.labelKey1B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey1B.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey1B, 2);
            this.labelKey1B.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey1B.Image = ((System.Drawing.Image)(resources.GetObject("labelKey1B.Image")));
            this.labelKey1B.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey1B.Location = new System.Drawing.Point(663, 0);
            this.labelKey1B.Name = "labelKey1B";
            this.labelKey1B.Size = new System.Drawing.Size(60, 44);
            this.labelKey1B.TabIndex = 10;
            this.labelKey1B.Text = "-";
            // 
            // labelKey1A
            // 
            this.labelKey1A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey1A.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey1A, 2);
            this.labelKey1A.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey1A.Image = ((System.Drawing.Image)(resources.GetObject("labelKey1A.Image")));
            this.labelKey1A.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey1A.Location = new System.Drawing.Point(597, 0);
            this.labelKey1A.Name = "labelKey1A";
            this.labelKey1A.Size = new System.Drawing.Size(60, 44);
            this.labelKey1A.TabIndex = 9;
            this.labelKey1A.Text = "0";
            // 
            // labelKey19
            // 
            this.labelKey19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey19.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey19, 2);
            this.labelKey19.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey19.Image = ((System.Drawing.Image)(resources.GetObject("labelKey19.Image")));
            this.labelKey19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey19.Location = new System.Drawing.Point(531, 0);
            this.labelKey19.Name = "labelKey19";
            this.labelKey19.Size = new System.Drawing.Size(60, 44);
            this.labelKey19.TabIndex = 8;
            this.labelKey19.Text = "9";
            // 
            // labelKey18
            // 
            this.labelKey18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey18.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey18, 2);
            this.labelKey18.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey18.Image = ((System.Drawing.Image)(resources.GetObject("labelKey18.Image")));
            this.labelKey18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey18.Location = new System.Drawing.Point(465, 0);
            this.labelKey18.Name = "labelKey18";
            this.labelKey18.Size = new System.Drawing.Size(60, 44);
            this.labelKey18.TabIndex = 7;
            this.labelKey18.Text = "8";
            // 
            // labelKey17
            // 
            this.labelKey17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey17.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey17, 2);
            this.labelKey17.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey17.Image = ((System.Drawing.Image)(resources.GetObject("labelKey17.Image")));
            this.labelKey17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey17.Location = new System.Drawing.Point(399, 0);
            this.labelKey17.Name = "labelKey17";
            this.labelKey17.Size = new System.Drawing.Size(60, 44);
            this.labelKey17.TabIndex = 6;
            this.labelKey17.Text = "7";
            // 
            // labelKey16
            // 
            this.labelKey16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey16.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey16, 2);
            this.labelKey16.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey16.Image = ((System.Drawing.Image)(resources.GetObject("labelKey16.Image")));
            this.labelKey16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey16.Location = new System.Drawing.Point(333, 0);
            this.labelKey16.Name = "labelKey16";
            this.labelKey16.Size = new System.Drawing.Size(60, 44);
            this.labelKey16.TabIndex = 5;
            this.labelKey16.Text = "6";
            // 
            // labelKey15
            // 
            this.labelKey15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey15.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey15, 2);
            this.labelKey15.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey15.Image = ((System.Drawing.Image)(resources.GetObject("labelKey15.Image")));
            this.labelKey15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey15.Location = new System.Drawing.Point(267, 0);
            this.labelKey15.Name = "labelKey15";
            this.labelKey15.Size = new System.Drawing.Size(60, 44);
            this.labelKey15.TabIndex = 4;
            this.labelKey15.Text = "5";
            // 
            // labelKey13
            // 
            this.labelKey13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey13.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey13, 2);
            this.labelKey13.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey13.Image = ((System.Drawing.Image)(resources.GetObject("labelKey13.Image")));
            this.labelKey13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey13.Location = new System.Drawing.Point(135, 0);
            this.labelKey13.Name = "labelKey13";
            this.labelKey13.Size = new System.Drawing.Size(60, 44);
            this.labelKey13.TabIndex = 2;
            this.labelKey13.Text = "3";
            // 
            // labelKey12
            // 
            this.labelKey12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey12.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey12, 2);
            this.labelKey12.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey12.Image = ((System.Drawing.Image)(resources.GetObject("labelKey12.Image")));
            this.labelKey12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey12.Location = new System.Drawing.Point(69, 0);
            this.labelKey12.Name = "labelKey12";
            this.labelKey12.Size = new System.Drawing.Size(60, 44);
            this.labelKey12.TabIndex = 1;
            this.labelKey12.Text = "2";
            // 
            // labelKey11
            // 
            this.labelKey11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey11.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey11, 2);
            this.labelKey11.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey11.Image = ((System.Drawing.Image)(resources.GetObject("labelKey11.Image")));
            this.labelKey11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey11.Location = new System.Drawing.Point(3, 0);
            this.labelKey11.Name = "labelKey11";
            this.labelKey11.Size = new System.Drawing.Size(60, 44);
            this.labelKey11.TabIndex = 0;
            this.labelKey11.Text = "1";
            // 
            // labelKey14
            // 
            this.labelKey14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey14.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey14, 2);
            this.labelKey14.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey14.Image = ((System.Drawing.Image)(resources.GetObject("labelKey14.Image")));
            this.labelKey14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey14.Location = new System.Drawing.Point(201, 0);
            this.labelKey14.Name = "labelKey14";
            this.labelKey14.Size = new System.Drawing.Size(60, 44);
            this.labelKey14.TabIndex = 3;
            this.labelKey14.Text = "4";
            // 
            // labelKey21
            // 
            this.labelKey21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey21.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey21, 2);
            this.labelKey21.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey21.Image = ((System.Drawing.Image)(resources.GetObject("labelKey21.Image")));
            this.labelKey21.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey21.Location = new System.Drawing.Point(36, 47);
            this.labelKey21.Name = "labelKey21";
            this.labelKey21.Size = new System.Drawing.Size(60, 44);
            this.labelKey21.TabIndex = 11;
            this.labelKey21.Text = "Q";
            // 
            // labelKey23
            // 
            this.labelKey23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey23.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey23, 2);
            this.labelKey23.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey23.Image = ((System.Drawing.Image)(resources.GetObject("labelKey23.Image")));
            this.labelKey23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey23.Location = new System.Drawing.Point(168, 47);
            this.labelKey23.Name = "labelKey23";
            this.labelKey23.Size = new System.Drawing.Size(60, 44);
            this.labelKey23.TabIndex = 13;
            this.labelKey23.Text = "E";
            // 
            // labelKey24
            // 
            this.labelKey24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey24.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey24, 2);
            this.labelKey24.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey24.Image = ((System.Drawing.Image)(resources.GetObject("labelKey24.Image")));
            this.labelKey24.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey24.Location = new System.Drawing.Point(234, 47);
            this.labelKey24.Name = "labelKey24";
            this.labelKey24.Size = new System.Drawing.Size(60, 44);
            this.labelKey24.TabIndex = 14;
            this.labelKey24.Text = "R";
            // 
            // labelKey25
            // 
            this.labelKey25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey25.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey25, 2);
            this.labelKey25.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey25.Image = ((System.Drawing.Image)(resources.GetObject("labelKey25.Image")));
            this.labelKey25.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey25.Location = new System.Drawing.Point(300, 47);
            this.labelKey25.Name = "labelKey25";
            this.labelKey25.Size = new System.Drawing.Size(60, 44);
            this.labelKey25.TabIndex = 15;
            this.labelKey25.Text = "T";
            // 
            // labelKey26
            // 
            this.labelKey26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey26.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey26, 2);
            this.labelKey26.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey26.Image = ((System.Drawing.Image)(resources.GetObject("labelKey26.Image")));
            this.labelKey26.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey26.Location = new System.Drawing.Point(366, 47);
            this.labelKey26.Name = "labelKey26";
            this.labelKey26.Size = new System.Drawing.Size(60, 44);
            this.labelKey26.TabIndex = 16;
            this.labelKey26.Text = "Y";
            // 
            // labelKey27
            // 
            this.labelKey27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey27.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey27, 2);
            this.labelKey27.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey27.Image = ((System.Drawing.Image)(resources.GetObject("labelKey27.Image")));
            this.labelKey27.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey27.Location = new System.Drawing.Point(432, 47);
            this.labelKey27.Name = "labelKey27";
            this.labelKey27.Size = new System.Drawing.Size(60, 44);
            this.labelKey27.TabIndex = 17;
            this.labelKey27.Text = "U";
            // 
            // labelKey28
            // 
            this.labelKey28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey28.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey28, 2);
            this.labelKey28.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey28.Image = ((System.Drawing.Image)(resources.GetObject("labelKey28.Image")));
            this.labelKey28.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey28.Location = new System.Drawing.Point(498, 47);
            this.labelKey28.Name = "labelKey28";
            this.labelKey28.Size = new System.Drawing.Size(60, 44);
            this.labelKey28.TabIndex = 18;
            this.labelKey28.Text = "I";
            // 
            // labelKey29
            // 
            this.labelKey29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey29.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey29, 2);
            this.labelKey29.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey29.Image = ((System.Drawing.Image)(resources.GetObject("labelKey29.Image")));
            this.labelKey29.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey29.Location = new System.Drawing.Point(564, 47);
            this.labelKey29.Name = "labelKey29";
            this.labelKey29.Size = new System.Drawing.Size(60, 44);
            this.labelKey29.TabIndex = 19;
            this.labelKey29.Text = "O";
            // 
            // labelKey2A
            // 
            this.labelKey2A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey2A.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey2A, 2);
            this.labelKey2A.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey2A.Image = ((System.Drawing.Image)(resources.GetObject("labelKey2A.Image")));
            this.labelKey2A.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey2A.Location = new System.Drawing.Point(630, 47);
            this.labelKey2A.Name = "labelKey2A";
            this.labelKey2A.Size = new System.Drawing.Size(60, 44);
            this.labelKey2A.TabIndex = 20;
            this.labelKey2A.Text = "P";
            // 
            // labelKey2B
            // 
            this.labelKey2B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey2B.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey2B, 2);
            this.labelKey2B.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey2B.Image = ((System.Drawing.Image)(resources.GetObject("labelKey2B.Image")));
            this.labelKey2B.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey2B.Location = new System.Drawing.Point(696, 47);
            this.labelKey2B.Name = "labelKey2B";
            this.labelKey2B.Size = new System.Drawing.Size(60, 44);
            this.labelKey2B.TabIndex = 21;
            this.labelKey2B.Text = "@";
            // 
            // labelKey22
            // 
            this.labelKey22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey22.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey22, 2);
            this.labelKey22.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey22.Image = ((System.Drawing.Image)(resources.GetObject("labelKey22.Image")));
            this.labelKey22.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey22.Location = new System.Drawing.Point(102, 47);
            this.labelKey22.Name = "labelKey22";
            this.labelKey22.Size = new System.Drawing.Size(60, 44);
            this.labelKey22.TabIndex = 12;
            this.labelKey22.Text = "W";
            // 
            // labelKey31
            // 
            this.labelKey31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey31.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey31, 2);
            this.labelKey31.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey31.Image = ((System.Drawing.Image)(resources.GetObject("labelKey31.Image")));
            this.labelKey31.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey31.Location = new System.Drawing.Point(69, 94);
            this.labelKey31.Name = "labelKey31";
            this.labelKey31.Size = new System.Drawing.Size(60, 44);
            this.labelKey31.TabIndex = 23;
            this.labelKey31.Text = "A";
            // 
            // labelKey32
            // 
            this.labelKey32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey32.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey32, 2);
            this.labelKey32.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey32.Image = ((System.Drawing.Image)(resources.GetObject("labelKey32.Image")));
            this.labelKey32.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey32.Location = new System.Drawing.Point(135, 94);
            this.labelKey32.Name = "labelKey32";
            this.labelKey32.Size = new System.Drawing.Size(60, 44);
            this.labelKey32.TabIndex = 24;
            this.labelKey32.Text = "S";
            // 
            // labelKey33
            // 
            this.labelKey33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey33.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey33, 2);
            this.labelKey33.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey33.Image = ((System.Drawing.Image)(resources.GetObject("labelKey33.Image")));
            this.labelKey33.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey33.Location = new System.Drawing.Point(201, 94);
            this.labelKey33.Name = "labelKey33";
            this.labelKey33.Size = new System.Drawing.Size(60, 44);
            this.labelKey33.TabIndex = 25;
            this.labelKey33.Text = "D";
            // 
            // labelKey34
            // 
            this.labelKey34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey34.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey34, 2);
            this.labelKey34.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey34.Image = ((System.Drawing.Image)(resources.GetObject("labelKey34.Image")));
            this.labelKey34.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey34.Location = new System.Drawing.Point(267, 94);
            this.labelKey34.Name = "labelKey34";
            this.labelKey34.Size = new System.Drawing.Size(60, 44);
            this.labelKey34.TabIndex = 26;
            this.labelKey34.Text = "F";
            // 
            // labelKey35
            // 
            this.labelKey35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey35.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey35, 2);
            this.labelKey35.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey35.Image = ((System.Drawing.Image)(resources.GetObject("labelKey35.Image")));
            this.labelKey35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey35.Location = new System.Drawing.Point(333, 94);
            this.labelKey35.Name = "labelKey35";
            this.labelKey35.Size = new System.Drawing.Size(60, 44);
            this.labelKey35.TabIndex = 27;
            this.labelKey35.Text = "G";
            // 
            // labelKey36
            // 
            this.labelKey36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey36.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey36, 2);
            this.labelKey36.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey36.Image = ((System.Drawing.Image)(resources.GetObject("labelKey36.Image")));
            this.labelKey36.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey36.Location = new System.Drawing.Point(399, 94);
            this.labelKey36.Name = "labelKey36";
            this.labelKey36.Size = new System.Drawing.Size(60, 44);
            this.labelKey36.TabIndex = 28;
            this.labelKey36.Text = "H";
            // 
            // labelKey37
            // 
            this.labelKey37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey37.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey37, 2);
            this.labelKey37.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey37.Image = ((System.Drawing.Image)(resources.GetObject("labelKey37.Image")));
            this.labelKey37.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey37.Location = new System.Drawing.Point(465, 94);
            this.labelKey37.Name = "labelKey37";
            this.labelKey37.Size = new System.Drawing.Size(60, 44);
            this.labelKey37.TabIndex = 29;
            this.labelKey37.Text = "J";
            // 
            // labelKey38
            // 
            this.labelKey38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey38.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey38, 2);
            this.labelKey38.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey38.Image = ((System.Drawing.Image)(resources.GetObject("labelKey38.Image")));
            this.labelKey38.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey38.Location = new System.Drawing.Point(531, 94);
            this.labelKey38.Name = "labelKey38";
            this.labelKey38.Size = new System.Drawing.Size(60, 44);
            this.labelKey38.TabIndex = 30;
            this.labelKey38.Text = "K";
            // 
            // labelKey39
            // 
            this.labelKey39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey39.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey39, 2);
            this.labelKey39.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey39.Image = ((System.Drawing.Image)(resources.GetObject("labelKey39.Image")));
            this.labelKey39.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey39.Location = new System.Drawing.Point(597, 94);
            this.labelKey39.Name = "labelKey39";
            this.labelKey39.Size = new System.Drawing.Size(60, 44);
            this.labelKey39.TabIndex = 31;
            this.labelKey39.Text = "L";
            // 
            // labelKey3A
            // 
            this.labelKey3A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey3A.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey3A, 2);
            this.labelKey3A.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey3A.Image = ((System.Drawing.Image)(resources.GetObject("labelKey3A.Image")));
            this.labelKey3A.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey3A.Location = new System.Drawing.Point(663, 94);
            this.labelKey3A.Name = "labelKey3A";
            this.labelKey3A.Size = new System.Drawing.Size(60, 44);
            this.labelKey3A.TabIndex = 32;
            this.labelKey3A.Text = ";";
            // 
            // labelKey3B
            // 
            this.labelKey3B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey3B.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey3B, 2);
            this.labelKey3B.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey3B.Image = ((System.Drawing.Image)(resources.GetObject("labelKey3B.Image")));
            this.labelKey3B.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey3B.Location = new System.Drawing.Point(729, 94);
            this.labelKey3B.Name = "labelKey3B";
            this.labelKey3B.Size = new System.Drawing.Size(60, 44);
            this.labelKey3B.TabIndex = 33;
            this.labelKey3B.Text = ":";
            // 
            // labelKey41
            // 
            this.labelKey41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey41.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey41, 2);
            this.labelKey41.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey41.Image = ((System.Drawing.Image)(resources.GetObject("labelKey41.Image")));
            this.labelKey41.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey41.Location = new System.Drawing.Point(102, 141);
            this.labelKey41.Name = "labelKey41";
            this.labelKey41.Size = new System.Drawing.Size(60, 44);
            this.labelKey41.TabIndex = 35;
            this.labelKey41.Text = "Z";
            // 
            // labelKey42
            // 
            this.labelKey42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey42.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey42, 2);
            this.labelKey42.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey42.Image = ((System.Drawing.Image)(resources.GetObject("labelKey42.Image")));
            this.labelKey42.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey42.Location = new System.Drawing.Point(168, 141);
            this.labelKey42.Name = "labelKey42";
            this.labelKey42.Size = new System.Drawing.Size(60, 44);
            this.labelKey42.TabIndex = 36;
            this.labelKey42.Text = "X";
            // 
            // labelKey43
            // 
            this.labelKey43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey43.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey43, 2);
            this.labelKey43.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey43.Image = ((System.Drawing.Image)(resources.GetObject("labelKey43.Image")));
            this.labelKey43.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey43.Location = new System.Drawing.Point(234, 141);
            this.labelKey43.Name = "labelKey43";
            this.labelKey43.Size = new System.Drawing.Size(60, 44);
            this.labelKey43.TabIndex = 37;
            this.labelKey43.Text = "C";
            // 
            // labelKey44
            // 
            this.labelKey44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey44.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey44, 2);
            this.labelKey44.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey44.Image = ((System.Drawing.Image)(resources.GetObject("labelKey44.Image")));
            this.labelKey44.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey44.Location = new System.Drawing.Point(300, 141);
            this.labelKey44.Name = "labelKey44";
            this.labelKey44.Size = new System.Drawing.Size(60, 44);
            this.labelKey44.TabIndex = 38;
            this.labelKey44.Text = "V";
            // 
            // labelKey45
            // 
            this.labelKey45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey45.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey45, 2);
            this.labelKey45.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey45.Image = ((System.Drawing.Image)(resources.GetObject("labelKey45.Image")));
            this.labelKey45.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey45.Location = new System.Drawing.Point(366, 141);
            this.labelKey45.Name = "labelKey45";
            this.labelKey45.Size = new System.Drawing.Size(60, 44);
            this.labelKey45.TabIndex = 39;
            this.labelKey45.Text = "B";
            // 
            // labelKey46
            // 
            this.labelKey46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey46.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey46, 2);
            this.labelKey46.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey46.Image = ((System.Drawing.Image)(resources.GetObject("labelKey46.Image")));
            this.labelKey46.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey46.Location = new System.Drawing.Point(432, 141);
            this.labelKey46.Name = "labelKey46";
            this.labelKey46.Size = new System.Drawing.Size(60, 44);
            this.labelKey46.TabIndex = 40;
            this.labelKey46.Text = "N";
            // 
            // labelKey47
            // 
            this.labelKey47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey47.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey47, 2);
            this.labelKey47.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey47.Image = ((System.Drawing.Image)(resources.GetObject("labelKey47.Image")));
            this.labelKey47.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey47.Location = new System.Drawing.Point(498, 141);
            this.labelKey47.Name = "labelKey47";
            this.labelKey47.Size = new System.Drawing.Size(60, 44);
            this.labelKey47.TabIndex = 41;
            this.labelKey47.Text = "M";
            // 
            // labelKey48
            // 
            this.labelKey48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey48.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey48, 2);
            this.labelKey48.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey48.Image = ((System.Drawing.Image)(resources.GetObject("labelKey48.Image")));
            this.labelKey48.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey48.Location = new System.Drawing.Point(564, 141);
            this.labelKey48.Name = "labelKey48";
            this.labelKey48.Size = new System.Drawing.Size(60, 44);
            this.labelKey48.TabIndex = 42;
            this.labelKey48.Text = ",";
            // 
            // labelKey49
            // 
            this.labelKey49.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey49.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey49, 2);
            this.labelKey49.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey49.Image = ((System.Drawing.Image)(resources.GetObject("labelKey49.Image")));
            this.labelKey49.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey49.Location = new System.Drawing.Point(630, 141);
            this.labelKey49.Name = "labelKey49";
            this.labelKey49.Size = new System.Drawing.Size(60, 44);
            this.labelKey49.TabIndex = 43;
            this.labelKey49.Text = ".";
            // 
            // labelKey4A
            // 
            this.labelKey4A.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey4A.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey4A, 2);
            this.labelKey4A.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey4A.Image = ((System.Drawing.Image)(resources.GetObject("labelKey4A.Image")));
            this.labelKey4A.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey4A.Location = new System.Drawing.Point(696, 141);
            this.labelKey4A.Name = "labelKey4A";
            this.labelKey4A.Size = new System.Drawing.Size(60, 44);
            this.labelKey4A.TabIndex = 44;
            this.labelKey4A.Text = "/";
            // 
            // labelKey4B
            // 
            this.labelKey4B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey4B.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey4B, 2);
            this.labelKey4B.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey4B.Image = ((System.Drawing.Image)(resources.GetObject("labelKey4B.Image")));
            this.labelKey4B.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey4B.Location = new System.Drawing.Point(762, 141);
            this.labelKey4B.Name = "labelKey4B";
            this.labelKey4B.Size = new System.Drawing.Size(60, 44);
            this.labelKey4B.TabIndex = 45;
            this.labelKey4B.Text = "\\";
            // 
            // labelKey2C
            // 
            this.labelKey2C.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey2C.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey2C, 2);
            this.labelKey2C.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey2C.Image = ((System.Drawing.Image)(resources.GetObject("labelKey2C.Image")));
            this.labelKey2C.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey2C.Location = new System.Drawing.Point(762, 47);
            this.labelKey2C.Name = "labelKey2C";
            this.labelKey2C.Size = new System.Drawing.Size(60, 44);
            this.labelKey2C.TabIndex = 22;
            this.labelKey2C.Text = "[";
            // 
            // labelKey3C
            // 
            this.labelKey3C.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelKey3C.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutKeyboard.SetColumnSpan(this.labelKey3C, 2);
            this.labelKey3C.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 16F);
            this.labelKey3C.Image = ((System.Drawing.Image)(resources.GetObject("labelKey3C.Image")));
            this.labelKey3C.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelKey3C.Location = new System.Drawing.Point(795, 94);
            this.labelKey3C.Name = "labelKey3C";
            this.labelKey3C.Size = new System.Drawing.Size(60, 44);
            this.labelKey3C.TabIndex = 34;
            this.labelKey3C.Text = "]";
            // 
            // panelComplete
            // 
            this.panelComplete.BackColor = System.Drawing.Color.Transparent;
            this.panelComplete.BackgroundImage = global::PpfChallenge004.Level3.Properties.Resources.FireWorks1;
            this.panelComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelComplete.Location = new System.Drawing.Point(0, 0);
            this.panelComplete.Name = "panelComplete";
            this.panelComplete.Size = new System.Drawing.Size(169, 190);
            this.panelComplete.TabIndex = 4;
            this.panelComplete.Visible = false;
            // 
            // FormTyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 611);
            this.Controls.Add(this.panelComplete);
            this.Controls.Add(this.tableLayoutKeyboard);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(920, 650);
            this.MinimumSize = new System.Drawing.Size(920, 650);
            this.Name = "FormTyping";
            this.Text = "ほにゃららタイピング";
            this.Load += new System.EventHandler(this.FormTyping_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormTyping_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSubject.ResumeLayout(false);
            this.tableLayoutKeyboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelJudge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSubject;
        private System.Windows.Forms.Label labelSubjectWord;
        private System.Windows.Forms.Label labelSubjectKana;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRanking;
        private System.Windows.Forms.Timer timerFlick;
        private System.Windows.Forms.TableLayoutPanel tableLayoutKeyboard;
        private System.Windows.Forms.Label labelKey1B;
        private System.Windows.Forms.Label labelKey1A;
        private System.Windows.Forms.Label labelKey19;
        private System.Windows.Forms.Label labelKey18;
        private System.Windows.Forms.Label labelKey17;
        private System.Windows.Forms.Label labelKey16;
        private System.Windows.Forms.Label labelKey15;
        private System.Windows.Forms.Label labelKey13;
        private System.Windows.Forms.Label labelKey12;
        private System.Windows.Forms.Label labelKey11;
        private System.Windows.Forms.Label labelKey14;
        private System.Windows.Forms.Label labelKey21;
        private System.Windows.Forms.Label labelKey23;
        private System.Windows.Forms.Label labelKey24;
        private System.Windows.Forms.Label labelKey25;
        private System.Windows.Forms.Label labelKey26;
        private System.Windows.Forms.Label labelKey27;
        private System.Windows.Forms.Label labelKey28;
        private System.Windows.Forms.Label labelKey29;
        private System.Windows.Forms.Label labelKey2A;
        private System.Windows.Forms.Label labelKey2B;
        private System.Windows.Forms.Label labelKey22;
        private System.Windows.Forms.Label labelKey31;
        private System.Windows.Forms.Label labelKey32;
        private System.Windows.Forms.Label labelKey33;
        private System.Windows.Forms.Label labelKey34;
        private System.Windows.Forms.Label labelKey35;
        private System.Windows.Forms.Label labelKey36;
        private System.Windows.Forms.Label labelKey37;
        private System.Windows.Forms.Label labelKey38;
        private System.Windows.Forms.Label labelKey39;
        private System.Windows.Forms.Label labelKey3A;
        private System.Windows.Forms.Label labelKey3B;
        private System.Windows.Forms.Label labelKey41;
        private System.Windows.Forms.Label labelKey42;
        private System.Windows.Forms.Label labelKey43;
        private System.Windows.Forms.Label labelKey44;
        private System.Windows.Forms.Label labelKey45;
        private System.Windows.Forms.Label labelKey46;
        private System.Windows.Forms.Label labelKey47;
        private System.Windows.Forms.Label labelKey48;
        private System.Windows.Forms.Label labelKey49;
        private System.Windows.Forms.Label labelKey4A;
        private System.Windows.Forms.Label labelKey4B;
        private System.Windows.Forms.Label labelKey2C;
        private System.Windows.Forms.Label labelKey3C;
        private System.Windows.Forms.Panel panelComplete;
    }
}

