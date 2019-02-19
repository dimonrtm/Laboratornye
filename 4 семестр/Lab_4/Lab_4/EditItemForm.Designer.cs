namespace Lab_4
{
    partial class EditItemForm
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
            this.checkWorkshopName = new System.Windows.Forms.CheckBox();
            this.textWorkshopName = new System.Windows.Forms.TextBox();
            this.checkWorkshopChief = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textWorkshopChiefFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textWorkshopChiefPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textNumberOfWorkers = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumberProducts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkWorkshopName
            // 
            this.checkWorkshopName.AutoSize = true;
            this.checkWorkshopName.Location = new System.Drawing.Point(27, 26);
            this.checkWorkshopName.Name = "checkWorkshopName";
            this.checkWorkshopName.Size = new System.Drawing.Size(102, 17);
            this.checkWorkshopName.TabIndex = 0;
            this.checkWorkshopName.Text = "Название цеха";
            this.checkWorkshopName.UseVisualStyleBackColor = true;
            this.checkWorkshopName.CheckedChanged += new System.EventHandler(this.checkWorkshopName_CheckedChanged);
            // 
            // textWorkshopName
            // 
            this.textWorkshopName.Location = new System.Drawing.Point(195, 26);
            this.textWorkshopName.Name = "textWorkshopName";
            this.textWorkshopName.Size = new System.Drawing.Size(100, 20);
            this.textWorkshopName.TabIndex = 1;
            this.textWorkshopName.Visible = false;
            // 
            // checkWorkshopChief
            // 
            this.checkWorkshopChief.AutoSize = true;
            this.checkWorkshopChief.Location = new System.Drawing.Point(136, 90);
            this.checkWorkshopChief.Name = "checkWorkshopChief";
            this.checkWorkshopChief.Size = new System.Drawing.Size(107, 17);
            this.checkWorkshopChief.TabIndex = 2;
            this.checkWorkshopChief.Text = "Начальник цеха";
            this.checkWorkshopChief.UseVisualStyleBackColor = true;
            this.checkWorkshopChief.CheckedChanged += new System.EventHandler(this.checkWorkshopChief_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            this.label1.Visible = false;
            // 
            // textWorkshopChiefFullname
            // 
            this.textWorkshopChiefFullname.Location = new System.Drawing.Point(195, 131);
            this.textWorkshopChiefFullname.Name = "textWorkshopChiefFullname";
            this.textWorkshopChiefFullname.Size = new System.Drawing.Size(100, 20);
            this.textWorkshopChiefFullname.TabIndex = 4;
            this.textWorkshopChiefFullname.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Должность";
            this.label2.Visible = false;
            // 
            // textWorkshopChiefPosition
            // 
            this.textWorkshopChiefPosition.Location = new System.Drawing.Point(195, 170);
            this.textWorkshopChiefPosition.Name = "textWorkshopChiefPosition";
            this.textWorkshopChiefPosition.Size = new System.Drawing.Size(100, 20);
            this.textWorkshopChiefPosition.TabIndex = 6;
            this.textWorkshopChiefPosition.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Зарплата";
            this.label3.Visible = false;
            // 
            // textSalary
            // 
            this.textSalary.Location = new System.Drawing.Point(195, 205);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(100, 20);
            this.textSalary.TabIndex = 8;
            this.textSalary.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Количество работников";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textNumberOfWorkers
            // 
            this.textNumberOfWorkers.Location = new System.Drawing.Point(195, 257);
            this.textNumberOfWorkers.Name = "textNumberOfWorkers";
            this.textNumberOfWorkers.Size = new System.Drawing.Size(100, 20);
            this.textNumberOfWorkers.TabIndex = 10;
            this.textNumberOfWorkers.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(37, 302);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(258, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Список номенклатуры выпускаемых изделий";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.Location = new System.Drawing.Point(59, 337);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(236, 134);
            this.listProducts.TabIndex = 12;
            this.listProducts.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Номер продукта";
            this.label4.Visible = false;
            // 
            // textNumberProducts
            // 
            this.textNumberProducts.Location = new System.Drawing.Point(195, 500);
            this.textNumberProducts.Name = "textNumberProducts";
            this.textNumberProducts.Size = new System.Drawing.Size(100, 20);
            this.textNumberProducts.TabIndex = 14;
            this.textNumberProducts.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Название продукта";
            this.label5.Visible = false;
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(195, 534);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(100, 20);
            this.textProductName.TabIndex = 16;
            this.textProductName.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Количество продуктов";
            this.label6.Visible = false;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(195, 569);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 20);
            this.textQuantity.TabIndex = 18;
            this.textQuantity.Visible = false;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(89, 610);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 23);
            this.AddProduct.TabIndex = 19;
            this.AddProduct.Text = "Добавить";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Visible = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(220, 610);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.DeleteProduct.TabIndex = 20;
            this.DeleteProduct.Text = "Удалить";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Visible = false;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(89, 657);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 21;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(220, 657);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 698);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNumberProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textNumberOfWorkers);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textWorkshopChiefPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textWorkshopChiefFullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkWorkshopChief);
            this.Controls.Add(this.textWorkshopName);
            this.Controls.Add(this.checkWorkshopName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkWorkshopName;
        private System.Windows.Forms.TextBox textWorkshopName;
        private System.Windows.Forms.CheckBox checkWorkshopChief;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWorkshopChiefFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWorkshopChiefPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textNumberOfWorkers;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNumberProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}