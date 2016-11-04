namespace Accounting_system.Admin
{
    partial class DeleteGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGoods));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteGoods = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lbDeleteLabel = new System.Windows.Forms.Label();
            this.IDRichTextBox = new System.Windows.Forms.RichTextBox();
            this.NameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.quantityRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityDeleteLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(520, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteGoods
            // 
            this.btnDeleteGoods.Location = new System.Drawing.Point(284, 320);
            this.btnDeleteGoods.Name = "btnDeleteGoods";
            this.btnDeleteGoods.Size = new System.Drawing.Size(73, 23);
            this.btnDeleteGoods.TabIndex = 1;
            this.btnDeleteGoods.Text = "Видалити";
            this.btnDeleteGoods.UseVisualStyleBackColor = true;
            this.btnDeleteGoods.Click += new System.EventHandler(this.btnDeleteGoods_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(183, 294);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(75, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lbDeleteLabel
            // 
            this.lbDeleteLabel.AutoSize = true;
            this.lbDeleteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDeleteLabel.Location = new System.Drawing.Point(124, 297);
            this.lbDeleteLabel.Name = "lbDeleteLabel";
            this.lbDeleteLabel.Size = new System.Drawing.Size(57, 13);
            this.lbDeleteLabel.TabIndex = 4;
            this.lbDeleteLabel.Text = "ID Товару";
            // 
            // IDRichTextBox
            // 
            this.IDRichTextBox.Location = new System.Drawing.Point(403, 26);
            this.IDRichTextBox.Name = "IDRichTextBox";
            this.IDRichTextBox.Size = new System.Drawing.Size(60, 288);
            this.IDRichTextBox.TabIndex = 5;
            this.IDRichTextBox.Text = "";
            // 
            // NameRichTextBox
            // 
            this.NameRichTextBox.Location = new System.Drawing.Point(460, 26);
            this.NameRichTextBox.Name = "NameRichTextBox";
            this.NameRichTextBox.Size = new System.Drawing.Size(94, 288);
            this.NameRichTextBox.TabIndex = 6;
            this.NameRichTextBox.Text = "";
            // 
            // quantityRichTextBox
            // 
            this.quantityRichTextBox.Location = new System.Drawing.Point(551, 26);
            this.quantityRichTextBox.Name = "quantityRichTextBox";
            this.quantityRichTextBox.Size = new System.Drawing.Size(44, 288);
            this.quantityRichTextBox.TabIndex = 7;
            this.quantityRichTextBox.Text = "";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDLabel.Location = new System.Drawing.Point(419, 7);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.Location = new System.Drawing.Point(481, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Назва";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityLabel.Location = new System.Drawing.Point(542, 7);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(53, 13);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Кількість";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(183, 323);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(75, 20);
            this.quantityTextBox.TabIndex = 11;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // quantityDeleteLabel
            // 
            this.quantityDeleteLabel.AutoSize = true;
            this.quantityDeleteLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantityDeleteLabel.Location = new System.Drawing.Point(128, 326);
            this.quantityDeleteLabel.Name = "quantityDeleteLabel";
            this.quantityDeleteLabel.Size = new System.Drawing.Size(53, 13);
            this.quantityDeleteLabel.TabIndex = 12;
            this.quantityDeleteLabel.Text = "Кількість";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(599, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quantityDeleteLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.quantityRichTextBox);
            this.Controls.Add(this.NameRichTextBox);
            this.Controls.Add(this.IDRichTextBox);
            this.Controls.Add(this.lbDeleteLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnDeleteGoods);
            this.Controls.Add(this.btnExit);
            this.Name = "DeleteGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Видалити товар";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteGoods;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label lbDeleteLabel;
        private System.Windows.Forms.RichTextBox IDRichTextBox;
        private System.Windows.Forms.RichTextBox NameRichTextBox;
        private System.Windows.Forms.RichTextBox quantityRichTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityDeleteLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}