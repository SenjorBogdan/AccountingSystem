namespace Accounting_system.User
{
    partial class ReturnGoods
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
            this.btnExit = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.quantityRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IDRichTextBox = new System.Windows.Forms.RichTextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityTxtLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(292, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(289, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(75, 20);
            this.idTextBox.TabIndex = 14;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(289, 99);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Повернути";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(292, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(69, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID Продукта";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(515, 14);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 13);
            this.quantityLabel.TabIndex = 26;
            this.quantityLabel.Text = "Кількість";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(448, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 25;
            this.nameLabel.Text = "Назва";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(386, 14);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 24;
            this.IDLabel.Text = "ID";
            // 
            // quantityRichTextBox
            // 
            this.quantityRichTextBox.Location = new System.Drawing.Point(518, 33);
            this.quantityRichTextBox.Name = "quantityRichTextBox";
            this.quantityRichTextBox.Size = new System.Drawing.Size(44, 245);
            this.quantityRichTextBox.TabIndex = 23;
            this.quantityRichTextBox.Text = "";
            // 
            // NameRichTextBox
            // 
            this.NameRichTextBox.Location = new System.Drawing.Point(427, 33);
            this.NameRichTextBox.Name = "NameRichTextBox";
            this.NameRichTextBox.Size = new System.Drawing.Size(94, 245);
            this.NameRichTextBox.TabIndex = 22;
            this.NameRichTextBox.Text = "";
            // 
            // IDRichTextBox
            // 
            this.IDRichTextBox.Location = new System.Drawing.Point(370, 33);
            this.IDRichTextBox.Name = "IDRichTextBox";
            this.IDRichTextBox.Size = new System.Drawing.Size(60, 245);
            this.IDRichTextBox.TabIndex = 21;
            this.IDRichTextBox.Text = "";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(289, 73);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(75, 20);
            this.quantityTextBox.TabIndex = 27;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // quantityTxtLabel
            // 
            this.quantityTxtLabel.AutoSize = true;
            this.quantityTxtLabel.Location = new System.Drawing.Point(300, 57);
            this.quantityTxtLabel.Name = "quantityTxtLabel";
            this.quantityTxtLabel.Size = new System.Drawing.Size(53, 13);
            this.quantityTxtLabel.TabIndex = 28;
            this.quantityTxtLabel.Text = "Кількість";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Accounting_system.Properties.Resources._return;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ReturnGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(572, 282);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quantityTxtLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.quantityRichTextBox);
            this.Controls.Add(this.NameRichTextBox);
            this.Controls.Add(this.IDRichTextBox);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnExit);
            this.Name = "ReturnGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Повернути товар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.RichTextBox quantityRichTextBox;
        private System.Windows.Forms.RichTextBox NameRichTextBox;
        private System.Windows.Forms.RichTextBox IDRichTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityTxtLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}