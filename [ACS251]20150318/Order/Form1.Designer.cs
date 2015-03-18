namespace Order
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
            this.OrderRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OrderRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.OrderRichTextBox3 = new System.Windows.Forms.RichTextBox();
            this.OrderRichTextBox4 = new System.Windows.Forms.RichTextBox();
            this.OrderRichTextBox5 = new System.Windows.Forms.RichTextBox();
            this.OrderRichTextBox6 = new System.Windows.Forms.RichTextBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toGoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderRichTextBox1
            // 
            this.OrderRichTextBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderRichTextBox1.Location = new System.Drawing.Point(40, 56);
            this.OrderRichTextBox1.Name = "OrderRichTextBox1";
            this.OrderRichTextBox1.Size = new System.Drawing.Size(182, 182);
            this.OrderRichTextBox1.TabIndex = 0;
            this.OrderRichTextBox1.Text = "";
            // 
            // OrderRichTextBox2
            // 
            this.OrderRichTextBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderRichTextBox2.Location = new System.Drawing.Point(250, 56);
            this.OrderRichTextBox2.Name = "OrderRichTextBox2";
            this.OrderRichTextBox2.Size = new System.Drawing.Size(182, 182);
            this.OrderRichTextBox2.TabIndex = 1;
            this.OrderRichTextBox2.Text = "";
            // 
            // OrderRichTextBox3
            // 
            this.OrderRichTextBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderRichTextBox3.Location = new System.Drawing.Point(449, 56);
            this.OrderRichTextBox3.Name = "OrderRichTextBox3";
            this.OrderRichTextBox3.Size = new System.Drawing.Size(182, 182);
            this.OrderRichTextBox3.TabIndex = 2;
            this.OrderRichTextBox3.Text = "";
            // 
            // OrderRichTextBox4
            // 
            this.OrderRichTextBox4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderRichTextBox4.Location = new System.Drawing.Point(40, 244);
            this.OrderRichTextBox4.Name = "OrderRichTextBox4";
            this.OrderRichTextBox4.Size = new System.Drawing.Size(182, 182);
            this.OrderRichTextBox4.TabIndex = 3;
            this.OrderRichTextBox4.Text = "";
            // 
            // OrderRichTextBox5
            // 
            this.OrderRichTextBox5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderRichTextBox5.Location = new System.Drawing.Point(250, 244);
            this.OrderRichTextBox5.Name = "OrderRichTextBox5";
            this.OrderRichTextBox5.Size = new System.Drawing.Size(182, 182);
            this.OrderRichTextBox5.TabIndex = 4;
            this.OrderRichTextBox5.Text = "";
            // 
            // OrderRichTextBox6
            // 
            this.OrderRichTextBox6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderRichTextBox6.Location = new System.Drawing.Point(449, 244);
            this.OrderRichTextBox6.Name = "OrderRichTextBox6";
            this.OrderRichTextBox6.Size = new System.Drawing.Size(182, 182);
            this.OrderRichTextBox6.TabIndex = 5;
            this.OrderRichTextBox6.Text = "";
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.OrderButton.Location = new System.Drawing.Point(654, 102);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(75, 50);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "隨機\r\n點餐";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ReadyButton
            // 
            this.ReadyButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ReadyButton.Location = new System.Drawing.Point(654, 307);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(75, 50);
            this.ReadyButton.TabIndex = 7;
            this.ReadyButton.Text = "出餐";
            this.ReadyButton.UseVisualStyleBackColor = true;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "未出餐數:";
            // 
            // toGoLabel
            // 
            this.toGoLabel.AutoSize = true;
            this.toGoLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toGoLabel.Location = new System.Drawing.Point(132, 20);
            this.toGoLabel.Name = "toGoLabel";
            this.toGoLabel.Size = new System.Drawing.Size(20, 21);
            this.toGoLabel.TabIndex = 9;
            this.toGoLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Order.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 438);
            this.Controls.Add(this.toGoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.OrderRichTextBox6);
            this.Controls.Add(this.OrderRichTextBox5);
            this.Controls.Add(this.OrderRichTextBox4);
            this.Controls.Add(this.OrderRichTextBox3);
            this.Controls.Add(this.OrderRichTextBox2);
            this.Controls.Add(this.OrderRichTextBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OrderRichTextBox1;
        private System.Windows.Forms.RichTextBox OrderRichTextBox2;
        private System.Windows.Forms.RichTextBox OrderRichTextBox3;
        private System.Windows.Forms.RichTextBox OrderRichTextBox4;
        private System.Windows.Forms.RichTextBox OrderRichTextBox5;
        private System.Windows.Forms.RichTextBox OrderRichTextBox6;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toGoLabel;
    }
}

