namespace WindowsClient
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.buttonGetInStock = new System.Windows.Forms.Button();
            this.labelInStock = new System.Windows.Forms.Label();
            this.buttonGetProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelInStockValue = new System.Windows.Forms.Label();
            this.labelOnOrderValue = new System.Windows.Forms.Label();
            this.textBoxInStock = new System.Windows.Forms.TextBox();
            this.textBoxOnOrder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id:";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(77, 24);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductId.TabIndex = 1;
            // 
            // buttonGetInStock
            // 
            this.buttonGetInStock.Location = new System.Drawing.Point(183, 22);
            this.buttonGetInStock.Name = "buttonGetInStock";
            this.buttonGetInStock.Size = new System.Drawing.Size(75, 23);
            this.buttonGetInStock.TabIndex = 2;
            this.buttonGetInStock.Text = "Get in Stock";
            this.buttonGetInStock.UseVisualStyleBackColor = true;
            this.buttonGetInStock.Click += new System.EventHandler(this.buttonGetInStock_Click);
            // 
            // labelInStock
            // 
            this.labelInStock.AutoSize = true;
            this.labelInStock.Location = new System.Drawing.Point(277, 27);
            this.labelInStock.Name = "labelInStock";
            this.labelInStock.Size = new System.Drawing.Size(29, 13);
            this.labelInStock.TabIndex = 3;
            this.labelInStock.Text = "label";
            // 
            // buttonGetProduct
            // 
            this.buttonGetProduct.Location = new System.Drawing.Point(183, 51);
            this.buttonGetProduct.Name = "buttonGetProduct";
            this.buttonGetProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonGetProduct.TabIndex = 4;
            this.buttonGetProduct.Text = "Get product";
            this.buttonGetProduct.UseVisualStyleBackColor = true;
            this.buttonGetProduct.Click += new System.EventHandler(this.buttonGetProduct_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(264, 51);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateProduct.TabIndex = 5;
            this.buttonUpdateProduct.Text = "Update product";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Product name:";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(148, 107);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(29, 13);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit price:";
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(148, 124);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.labelUnitPrice.TabIndex = 9;
            this.labelUnitPrice.Text = "label";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "In Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "On Order:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Value:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Value:";
            // 
            // labelInStockValue
            // 
            this.labelInStockValue.AutoSize = true;
            this.labelInStockValue.Location = new System.Drawing.Point(343, 162);
            this.labelInStockValue.Name = "labelInStockValue";
            this.labelInStockValue.Size = new System.Drawing.Size(29, 13);
            this.labelInStockValue.TabIndex = 14;
            this.labelInStockValue.Text = "label";
            // 
            // labelOnOrderValue
            // 
            this.labelOnOrderValue.AutoSize = true;
            this.labelOnOrderValue.Location = new System.Drawing.Point(343, 179);
            this.labelOnOrderValue.Name = "labelOnOrderValue";
            this.labelOnOrderValue.Size = new System.Drawing.Size(29, 13);
            this.labelOnOrderValue.TabIndex = 15;
            this.labelOnOrderValue.Text = "label";
            // 
            // textBoxInStock
            // 
            this.textBoxInStock.Location = new System.Drawing.Point(99, 159);
            this.textBoxInStock.Name = "textBoxInStock";
            this.textBoxInStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxInStock.TabIndex = 16;
            // 
            // textBoxOnOrder
            // 
            this.textBoxOnOrder.Location = new System.Drawing.Point(99, 185);
            this.textBoxOnOrder.Name = "textBoxOnOrder";
            this.textBoxOnOrder.Size = new System.Drawing.Size(100, 20);
            this.textBoxOnOrder.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 253);
            this.Controls.Add(this.textBoxOnOrder);
            this.Controls.Add(this.textBoxInStock);
            this.Controls.Add(this.labelOnOrderValue);
            this.Controls.Add(this.labelInStockValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.buttonGetProduct);
            this.Controls.Add(this.labelInStock);
            this.Controls.Add(this.buttonGetInStock);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Button buttonGetInStock;
        private System.Windows.Forms.Label labelInStock;
        private System.Windows.Forms.Button buttonGetProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelInStockValue;
        private System.Windows.Forms.Label labelOnOrderValue;
        private System.Windows.Forms.TextBox textBoxInStock;
        private System.Windows.Forms.TextBox textBoxOnOrder;
    }
}

