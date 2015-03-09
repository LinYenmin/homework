namespace AllyControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AttackButton = new System.Windows.Forms.Button();
            this.player1PictureBox = new System.Windows.Forms.PictureBox();
            this.player2PictureBox = new System.Windows.Forms.PictureBox();
            this.player3PictureBox = new System.Windows.Forms.PictureBox();
            this.player4PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player1HpLabel = new System.Windows.Forms.Label();
            this.player4HpLabel = new System.Windows.Forms.Label();
            this.player3HpLabel = new System.Windows.Forms.Label();
            this.player2HpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusRichTextBox
            // 
            this.statusRichTextBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statusRichTextBox.Location = new System.Drawing.Point(12, 278);
            this.statusRichTextBox.Name = "statusRichTextBox";
            this.statusRichTextBox.Size = new System.Drawing.Size(659, 153);
            this.statusRichTextBox.TabIndex = 0;
            this.statusRichTextBox.Text = "";
            // 
            // AttackButton
            // 
            this.AttackButton.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AttackButton.Location = new System.Drawing.Point(702, 356);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(181, 75);
            this.AttackButton.TabIndex = 1;
            this.AttackButton.Text = "模擬攻擊";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // player1PictureBox
            // 
            this.player1PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.player1PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player1PictureBox.Image")));
            this.player1PictureBox.Location = new System.Drawing.Point(12, 12);
            this.player1PictureBox.Name = "player1PictureBox";
            this.player1PictureBox.Size = new System.Drawing.Size(141, 161);
            this.player1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player1PictureBox.TabIndex = 2;
            this.player1PictureBox.TabStop = false;
            this.player1PictureBox.Click += new System.EventHandler(this.player1PictureBox_Click);
            // 
            // player2PictureBox
            // 
            this.player2PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.player2PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player2PictureBox.Image")));
            this.player2PictureBox.Location = new System.Drawing.Point(184, 12);
            this.player2PictureBox.Name = "player2PictureBox";
            this.player2PictureBox.Size = new System.Drawing.Size(141, 161);
            this.player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player2PictureBox.TabIndex = 3;
            this.player2PictureBox.TabStop = false;
            this.player2PictureBox.Click += new System.EventHandler(this.player2PictureBox_Click);
            // 
            // player3PictureBox
            // 
            this.player3PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.player3PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player3PictureBox.Image")));
            this.player3PictureBox.Location = new System.Drawing.Point(357, 12);
            this.player3PictureBox.Name = "player3PictureBox";
            this.player3PictureBox.Size = new System.Drawing.Size(141, 161);
            this.player3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player3PictureBox.TabIndex = 4;
            this.player3PictureBox.TabStop = false;
            this.player3PictureBox.Click += new System.EventHandler(this.player3PictureBox_Click);
            // 
            // player4PictureBox
            // 
            this.player4PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.player4PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("player4PictureBox.Image")));
            this.player4PictureBox.Location = new System.Drawing.Point(530, 12);
            this.player4PictureBox.Name = "player4PictureBox";
            this.player4PictureBox.Size = new System.Drawing.Size(141, 161);
            this.player4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.player4PictureBox.TabIndex = 5;
            this.player4PictureBox.TabStop = false;
            this.player4PictureBox.Click += new System.EventHandler(this.player4PictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(13, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "生命值:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(526, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "生命值:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(353, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "生命值:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(180, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "生命值:";
            // 
            // player1HpLabel
            // 
            this.player1HpLabel.AutoSize = true;
            this.player1HpLabel.BackColor = System.Drawing.Color.Transparent;
            this.player1HpLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player1HpLabel.Location = new System.Drawing.Point(13, 233);
            this.player1HpLabel.Name = "player1HpLabel";
            this.player1HpLabel.Size = new System.Drawing.Size(22, 24);
            this.player1HpLabel.TabIndex = 10;
            this.player1HpLabel.Text = "0";
            // 
            // player4HpLabel
            // 
            this.player4HpLabel.AutoSize = true;
            this.player4HpLabel.BackColor = System.Drawing.Color.Transparent;
            this.player4HpLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player4HpLabel.Location = new System.Drawing.Point(526, 233);
            this.player4HpLabel.Name = "player4HpLabel";
            this.player4HpLabel.Size = new System.Drawing.Size(22, 24);
            this.player4HpLabel.TabIndex = 11;
            this.player4HpLabel.Text = "0";
            // 
            // player3HpLabel
            // 
            this.player3HpLabel.AutoSize = true;
            this.player3HpLabel.BackColor = System.Drawing.Color.Transparent;
            this.player3HpLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player3HpLabel.Location = new System.Drawing.Point(353, 233);
            this.player3HpLabel.Name = "player3HpLabel";
            this.player3HpLabel.Size = new System.Drawing.Size(22, 24);
            this.player3HpLabel.TabIndex = 12;
            this.player3HpLabel.Text = "0";
            // 
            // player2HpLabel
            // 
            this.player2HpLabel.AutoSize = true;
            this.player2HpLabel.BackColor = System.Drawing.Color.Transparent;
            this.player2HpLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.player2HpLabel.Location = new System.Drawing.Point(180, 233);
            this.player2HpLabel.Name = "player2HpLabel";
            this.player2HpLabel.Size = new System.Drawing.Size(22, 24);
            this.player2HpLabel.TabIndex = 13;
            this.player2HpLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(908, 443);
            this.Controls.Add(this.player2HpLabel);
            this.Controls.Add(this.player3HpLabel);
            this.Controls.Add(this.player4HpLabel);
            this.Controls.Add(this.player1HpLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player4PictureBox);
            this.Controls.Add(this.player3PictureBox);
            this.Controls.Add(this.player2PictureBox);
            this.Controls.Add(this.player1PictureBox);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.statusRichTextBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player3PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player4PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox statusRichTextBox;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.PictureBox player1PictureBox;
        private System.Windows.Forms.PictureBox player2PictureBox;
        private System.Windows.Forms.PictureBox player3PictureBox;
        private System.Windows.Forms.PictureBox player4PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label player1HpLabel;
        private System.Windows.Forms.Label player4HpLabel;
        private System.Windows.Forms.Label player3HpLabel;
        private System.Windows.Forms.Label player2HpLabel;
    }
}

