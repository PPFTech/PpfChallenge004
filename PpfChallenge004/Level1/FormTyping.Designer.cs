namespace PpfChallenge004.Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTyping));
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubject.BackColor = System.Drawing.Color.Beige;
            this.labelSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSubject.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 48F);
            this.labelSubject.Location = new System.Drawing.Point(15, 20);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(533, 174);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "A";
            this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14F);
            this.labelMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMessage.Location = new System.Drawing.Point(15, 204);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(533, 33);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "上の文字を、キーボードで入力してみよう！";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine
            // 
            this.labelLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLine.Location = new System.Drawing.Point(16, 296);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(530, 2);
            this.labelLine.TabIndex = 3;
            // 
            // labelInput
            // 
            this.labelInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInput.BackColor = System.Drawing.Color.Beige;
            this.labelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInput.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 22F);
            this.labelInput.Location = new System.Drawing.Point(20, 250);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(533, 48);
            this.labelInput.TabIndex = 4;
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTyping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 331);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.labelSubject);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTyping";
            this.Text = "ほにゃららタイピング";
            this.Load += new System.EventHandler(this.FormTyping_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormTyping_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelInput;
    }
}

