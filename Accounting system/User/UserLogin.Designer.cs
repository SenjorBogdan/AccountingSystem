﻿namespace Accounting_system.User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOrderProduct = new System.Windows.Forms.Button();
            this.btnReturnGoods = new System.Windows.Forms.Button();
            this.btnHistoryShopping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(208, 296);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOrderProduct
            // 
            this.btnOrderProduct.Location = new System.Drawing.Point(82, 130);
            this.btnOrderProduct.Name = "btnOrderProduct";
            this.btnOrderProduct.Size = new System.Drawing.Size(97, 34);
            this.btnOrderProduct.TabIndex = 13;
            this.btnOrderProduct.Text = "Замовити товар";
            this.btnOrderProduct.UseVisualStyleBackColor = true;
            this.btnOrderProduct.Click += new System.EventHandler(this.btnOrderProduct_Click);
            // 
            // btnReturnGoods
            // 
            this.btnReturnGoods.Location = new System.Drawing.Point(185, 130);
            this.btnReturnGoods.Name = "btnReturnGoods";
            this.btnReturnGoods.Size = new System.Drawing.Size(104, 34);
            this.btnReturnGoods.TabIndex = 14;
            this.btnReturnGoods.Text = "Повернути товар";
            this.btnReturnGoods.UseVisualStyleBackColor = true;
            this.btnReturnGoods.Click += new System.EventHandler(this.btnReturnGoods_Click);
            // 
            // btnHistoryShopping
            // 
            this.btnHistoryShopping.Location = new System.Drawing.Point(295, 130);
            this.btnHistoryShopping.Name = "btnHistoryShopping";
            this.btnHistoryShopping.Size = new System.Drawing.Size(114, 34);
            this.btnHistoryShopping.TabIndex = 15;
            this.btnHistoryShopping.Text = "Переглянути історію покупок";
            this.btnHistoryShopping.UseVisualStyleBackColor = true;
            this.btnHistoryShopping.Click += new System.EventHandler(this.btnHistoryShopping_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 331);
            this.Controls.Add(this.btnHistoryShopping);
            this.Controls.Add(this.btnReturnGoods);
            this.Controls.Add(this.btnOrderProduct);
            this.Controls.Add(this.btnExit);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управління";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrderProduct;
        private System.Windows.Forms.Button btnReturnGoods;
        private System.Windows.Forms.Button btnHistoryShopping;
    }
}