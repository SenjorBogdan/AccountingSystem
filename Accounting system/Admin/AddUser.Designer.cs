namespace Accounting_system.Admin
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.privilegeCheckBox = new System.Windows.Forms.CheckBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.btnAddPrivileges = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.IDRichTextBox = new System.Windows.Forms.RichTextBox();
            this.loginRichTextBox = new System.Windows.Forms.RichTextBox();
            this.statusRichTextBox = new System.Windows.Forms.RichTextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.privilegesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.privilegesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(132, 334);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Добавити";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(568, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(119, 285);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(127, 269);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID Користувача";
            // 
            // privilegeCheckBox
            // 
            this.privilegeCheckBox.AutoSize = true;
            this.privilegeCheckBox.Location = new System.Drawing.Point(92, 375);
            this.privilegeCheckBox.Name = "privilegeCheckBox";
            this.privilegeCheckBox.Size = new System.Drawing.Size(155, 17);
            this.privilegeCheckBox.TabIndex = 10;
            this.privilegeCheckBox.Text = "Дати/Забрати привілегію";
            this.privilegeCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(73, 311);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(192, 17);
            this.statusCheckBox.TabIndex = 11;
            this.statusCheckBox.Text = "Дати/Забрати статус активності";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnAddPrivileges
            // 
            this.btnAddPrivileges.Location = new System.Drawing.Point(137, 395);
            this.btnAddPrivileges.Name = "btnAddPrivileges";
            this.btnAddPrivileges.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrivileges.TabIndex = 7;
            this.btnAddPrivileges.Text = "Добавити";
            this.btnAddPrivileges.UseVisualStyleBackColor = true;
            this.btnAddPrivileges.Click += new System.EventHandler(this.AddPrivileges_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(463, 395);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Обновити";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // IDRichTextBox
            // 
            this.IDRichTextBox.Location = new System.Drawing.Point(373, 21);
            this.IDRichTextBox.Name = "IDRichTextBox";
            this.IDRichTextBox.Size = new System.Drawing.Size(55, 371);
            this.IDRichTextBox.TabIndex = 12;
            this.IDRichTextBox.Text = "";
            // 
            // loginRichTextBox
            // 
            this.loginRichTextBox.Location = new System.Drawing.Point(425, 21);
            this.loginRichTextBox.Name = "loginRichTextBox";
            this.loginRichTextBox.Size = new System.Drawing.Size(116, 371);
            this.loginRichTextBox.TabIndex = 14;
            this.loginRichTextBox.Text = "";
            // 
            // statusRichTextBox
            // 
            this.statusRichTextBox.Location = new System.Drawing.Point(537, 21);
            this.statusRichTextBox.Name = "statusRichTextBox";
            this.statusRichTextBox.Size = new System.Drawing.Size(58, 371);
            this.statusRichTextBox.TabIndex = 15;
            this.statusRichTextBox.Text = "";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(384, 5);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 16;
            this.IDlabel.Text = "ID";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(460, 5);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(34, 13);
            this.loginLabel.TabIndex = 17;
            this.loginLabel.Text = "Логін";
            // 
            // privilegesRichTextBox
            // 
            this.privilegesRichTextBox.Location = new System.Drawing.Point(593, 21);
            this.privilegesRichTextBox.Name = "privilegesRichTextBox";
            this.privilegesRichTextBox.Size = new System.Drawing.Size(50, 371);
            this.privilegesRichTextBox.TabIndex = 18;
            this.privilegesRichTextBox.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(543, 5);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 19;
            this.statusLabel.Text = "Статус";
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.AutoSize = true;
            this.privilegesLabel.Location = new System.Drawing.Point(590, 5);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(57, 13);
            this.privilegesLabel.TabIndex = 20;
            this.privilegesLabel.Text = "Привілегії";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(682, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.privilegesLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.privilegesRichTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.statusRichTextBox);
            this.Controls.Add(this.loginRichTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.IDRichTextBox);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.privilegeCheckBox);
            this.Controls.Add(this.btnAddPrivileges);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddUser);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавити користувача";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.CheckBox privilegeCheckBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Button btnAddPrivileges;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.RichTextBox IDRichTextBox;
        private System.Windows.Forms.RichTextBox loginRichTextBox;
        private System.Windows.Forms.RichTextBox statusRichTextBox;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.RichTextBox privilegesRichTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label privilegesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}