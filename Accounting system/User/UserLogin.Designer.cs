namespace Accounting_system.User
{
    partial class UserLogin
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
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnOrderProduct = new System.Windows.Forms.Button();
            this.btnReturnGoods = new System.Windows.Forms.Button();
            this.btnHistoryShopping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(134, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(36, 12);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(241, 29);
            this.btnRegistration.TabIndex = 6;
            this.btnRegistration.Text = "Зареєструватися";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.Location = new System.Drawing.Point(36, 59);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(241, 29);
            this.btnViewProduct.TabIndex = 12;
            this.btnViewProduct.Text = "Переглянути товар";
            this.btnViewProduct.UseVisualStyleBackColor = true;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnOrderProduct
            // 
            this.btnOrderProduct.Location = new System.Drawing.Point(36, 100);
            this.btnOrderProduct.Name = "btnOrderProduct";
            this.btnOrderProduct.Size = new System.Drawing.Size(241, 29);
            this.btnOrderProduct.TabIndex = 13;
            this.btnOrderProduct.Text = "Замовити товар";
            this.btnOrderProduct.UseVisualStyleBackColor = true;
            this.btnOrderProduct.Click += new System.EventHandler(this.btnOrderProduct_Click);
            // 
            // btnReturnGoods
            // 
            this.btnReturnGoods.Location = new System.Drawing.Point(36, 139);
            this.btnReturnGoods.Name = "btnReturnGoods";
            this.btnReturnGoods.Size = new System.Drawing.Size(241, 29);
            this.btnReturnGoods.TabIndex = 14;
            this.btnReturnGoods.Text = "Повернути товар";
            this.btnReturnGoods.UseVisualStyleBackColor = true;
            this.btnReturnGoods.Click += new System.EventHandler(this.btnReturnGoods_Click);
            // 
            // btnHistoryShopping
            // 
            this.btnHistoryShopping.Location = new System.Drawing.Point(36, 182);
            this.btnHistoryShopping.Name = "btnHistoryShopping";
            this.btnHistoryShopping.Size = new System.Drawing.Size(241, 29);
            this.btnHistoryShopping.TabIndex = 15;
            this.btnHistoryShopping.Text = "Переглянути історію покупок";
            this.btnHistoryShopping.UseVisualStyleBackColor = true;
            this.btnHistoryShopping.Click += new System.EventHandler(this.btnHistoryShopping_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 319);
            this.Controls.Add(this.btnHistoryShopping);
            this.Controls.Add(this.btnReturnGoods);
            this.Controls.Add(this.btnOrderProduct);
            this.Controls.Add(this.btnViewProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegistration);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnOrderProduct;
        private System.Windows.Forms.Button btnReturnGoods;
        private System.Windows.Forms.Button btnHistoryShopping;
    }
}