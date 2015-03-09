namespace Ticketing
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DiscountComboBox = new System.Windows.Forms.ComboBox();
            this.ticketNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.shbmitButton = new System.Windows.Forms.Button();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ticketNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscountComboBox
            // 
            this.DiscountComboBox.FormattingEnabled = true;
            this.DiscountComboBox.Location = new System.Drawing.Point(71, 12);
            this.DiscountComboBox.Name = "DiscountComboBox";
            this.DiscountComboBox.Size = new System.Drawing.Size(263, 20);
            this.DiscountComboBox.TabIndex = 0;
            // 
            // ticketNumericUpDown
            // 
            this.ticketNumericUpDown.Location = new System.Drawing.Point(71, 56);
            this.ticketNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ticketNumericUpDown.Name = "ticketNumericUpDown";
            this.ticketNumericUpDown.Size = new System.Drawing.Size(64, 22);
            this.ticketNumericUpDown.TabIndex = 1;
            this.ticketNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ticketNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // shbmitButton
            // 
            this.shbmitButton.Location = new System.Drawing.Point(155, 56);
            this.shbmitButton.Name = "shbmitButton";
            this.shbmitButton.Size = new System.Drawing.Size(75, 23);
            this.shbmitButton.TabIndex = 2;
            this.shbmitButton.Text = "加入清單";
            this.shbmitButton.UseVisualStyleBackColor = true;
            this.shbmitButton.Click += new System.EventHandler(this.shbmitButton_Click);
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(12, 108);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(408, 264);
            this.resultRichTextBox.TabIndex = 3;
            this.resultRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "優待折扣";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "張數";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.shbmitButton);
            this.Controls.Add(this.ticketNumericUpDown);
            this.Controls.Add(this.DiscountComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ticketNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DiscountComboBox;
        private System.Windows.Forms.NumericUpDown ticketNumericUpDown;
        private System.Windows.Forms.Button shbmitButton;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

