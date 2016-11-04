namespace Accounting_system.User
{
    partial class HistoryShopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryShopping));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.quantityRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IDRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(113, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(352, 244);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(117, 25);
            this.btnClearHistory.TabIndex = 14;
            this.btnClearHistory.Text = "Очистити історію ";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(463, 3);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 13);
            this.quantityLabel.TabIndex = 20;
            this.quantityLabel.Text = "Кількість";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(396, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Назва";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(334, 3);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 18;
            this.IDLabel.Text = "ID";
            // 
            // quantityRichTextBox
            // 
            this.quantityRichTextBox.Location = new System.Drawing.Point(466, 22);
            this.quantityRichTextBox.Name = "quantityRichTextBox";
            this.quantityRichTextBox.Size = new System.Drawing.Size(44, 216);
            this.quantityRichTextBox.TabIndex = 17;
            this.quantityRichTextBox.Text = "";
            // 
            // NameRichTextBox
            // 
            this.NameRichTextBox.Location = new System.Drawing.Point(375, 22);
            this.NameRichTextBox.Name = "NameRichTextBox";
            this.NameRichTextBox.Size = new System.Drawing.Size(94, 216);
            this.NameRichTextBox.TabIndex = 16;
            this.NameRichTextBox.Text = "";
            // 
            // IDRichTextBox
            // 
            this.IDRichTextBox.Location = new System.Drawing.Point(312, 22);
            this.IDRichTextBox.Name = "IDRichTextBox";
            this.IDRichTextBox.Size = new System.Drawing.Size(66, 216);
            this.IDRichTextBox.TabIndex = 15;
            this.IDRichTextBox.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // HistoryShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(516, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.quantityRichTextBox);
            this.Controls.Add(this.NameRichTextBox);
            this.Controls.Add(this.IDRichTextBox);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.btnExit);
            this.Name = "HistoryShopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Історія покупок";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.RichTextBox quantityRichTextBox;
        private System.Windows.Forms.RichTextBox NameRichTextBox;
        private System.Windows.Forms.RichTextBox IDRichTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}