namespace PpfChallenge004.Level3
{
    partial class FormRanking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRanking));
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewRanking = new System.Windows.Forms.ListView();
            this.columnOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.Khaki;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitle.Location = new System.Drawing.Point(17, 24);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(424, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ランキング";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewRanking
            // 
            this.listViewRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrder,
            this.columnTime,
            this.columnDateTime});
            this.listViewRanking.Location = new System.Drawing.Point(17, 57);
            this.listViewRanking.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRanking.Name = "listViewRanking";
            this.listViewRanking.Size = new System.Drawing.Size(424, 262);
            this.listViewRanking.TabIndex = 1;
            this.listViewRanking.UseCompatibleStateImageBehavior = false;
            this.listViewRanking.View = System.Windows.Forms.View.Details;
            // 
            // columnOrder
            // 
            this.columnOrder.Text = "順位";
            this.columnOrder.Width = 100;
            // 
            // columnTime
            // 
            this.columnTime.Text = "時間";
            this.columnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnTime.Width = 100;
            // 
            // columnDateTime
            // 
            this.columnDateTime.Text = "日時";
            this.columnDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnDateTime.Width = 220;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonClose.Location = new System.Drawing.Point(179, 327);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 31);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "とじる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(458, 371);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listViewRanking);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRanking";
            this.Text = "ほにゃららタイピング～ランキング";
            this.Load += new System.EventHandler(this.FormRanking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewRanking;
        private System.Windows.Forms.ColumnHeader columnOrder;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnDateTime;
        private System.Windows.Forms.Button buttonClose;
    }
}