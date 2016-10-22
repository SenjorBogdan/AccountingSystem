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
            this.components = new System.ComponentModel.Container();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.userBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new Accounting_system.DatabaseDataSet1();
            this.userBaseTableAdapter = new Accounting_system.DatabaseDataSet1TableAdapters.UserBaseTableAdapter();
            this.privilegeCheckBox = new System.Windows.Forms.CheckBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.btnAddPrivileges = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.baseUserRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(137, 185);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Добавити";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(135, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(122, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(133, 92);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(85, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID Користувача";
            // 
            // userBaseBindingSource
            // 
            this.userBaseBindingSource.DataMember = "UserBase";
            this.userBaseBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBaseTableAdapter
            // 
            this.userBaseTableAdapter.ClearBeforeFill = true;
            // 
            // privilegeCheckBox
            // 
            this.privilegeCheckBox.AutoSize = true;
            this.privilegeCheckBox.Location = new System.Drawing.Point(102, 264);
            this.privilegeCheckBox.Name = "privilegeCheckBox";
            this.privilegeCheckBox.Size = new System.Drawing.Size(155, 17);
            this.privilegeCheckBox.TabIndex = 10;
            this.privilegeCheckBox.Text = "Дати/Забрати привілегію";
            this.privilegeCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(104, 162);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(135, 17);
            this.statusCheckBox.TabIndex = 11;
            this.statusCheckBox.Text = "Дати/Забрати статус";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnAddPrivileges
            // 
            this.btnAddPrivileges.Location = new System.Drawing.Point(135, 287);
            this.btnAddPrivileges.Name = "btnAddPrivileges";
            this.btnAddPrivileges.Size = new System.Drawing.Size(75, 23);
            this.btnAddPrivileges.TabIndex = 7;
            this.btnAddPrivileges.Text = "Добавити";
            this.btnAddPrivileges.UseVisualStyleBackColor = true;
            this.btnAddPrivileges.Click += new System.EventHandler(this.AddPrivileges_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(388, 418);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 13;
            this.RefreshButton.Text = "Обновити";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // baseUserRichTextBox
            // 
            this.baseUserRichTextBox.Location = new System.Drawing.Point(388, 43);
            this.baseUserRichTextBox.Name = "baseUserRichTextBox";
            this.baseUserRichTextBox.Size = new System.Drawing.Size(282, 371);
            this.baseUserRichTextBox.TabIndex = 12;
            this.baseUserRichTextBox.Text = "";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.baseUserRichTextBox);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.privilegeCheckBox);
            this.Controls.Add(this.btnAddPrivileges);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddUser);
            this.Name = "AddUser";
            this.Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)(this.userBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource userBaseBindingSource;
        private DatabaseDataSet1TableAdapters.UserBaseTableAdapter userBaseTableAdapter;
        private System.Windows.Forms.CheckBox privilegeCheckBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Button btnAddPrivileges;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.RichTextBox baseUserRichTextBox;
    }
}