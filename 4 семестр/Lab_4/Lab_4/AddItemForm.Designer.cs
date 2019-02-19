namespace Lab_4
{
    partial class AddItemForm
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
            this.textWorkshopName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textWorkshopChiefFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textWorkshopChiefPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textWorkshopChiefSalary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textWorkshopNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textProductId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название цеха";
            // 
            // textWorkshopName
            // 
            this.textWorkshopName.Location = new System.Drawing.Point(184, 24);
            this.textWorkshopName.Name = "textWorkshopName";
            this.textWorkshopName.Size = new System.Drawing.Size(114, 20);
            this.textWorkshopName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Начальник цеха";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // textWorkshopChiefFullname
            // 
            this.textWorkshopChiefFullname.Location = new System.Drawing.Point(184, 109);
            this.textWorkshopChiefFullname.Name = "textWorkshopChiefFullname";
            this.textWorkshopChiefFullname.Size = new System.Drawing.Size(114, 20);
            this.textWorkshopChiefFullname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Должность";
            // 
            // textWorkshopChiefPosition
            // 
            this.textWorkshopChiefPosition.Location = new System.Drawing.Point(184, 157);
            this.textWorkshopChiefPosition.Name = "textWorkshopChiefPosition";
            this.textWorkshopChiefPosition.Size = new System.Drawing.Size(114, 20);
            this.textWorkshopChiefPosition.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Зарплата";
            // 
            // textWorkshopChiefSalary
            // 
            this.textWorkshopChiefSalary.Location = new System.Drawing.Point(184, 205);
            this.textWorkshopChiefSalary.Name = "textWorkshopChiefSalary";
            this.textWorkshopChiefSalary.Size = new System.Drawing.Size(114, 20);
            this.textWorkshopChiefSalary.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Количество работников";
            // 
            // textWorkshopNumber
            // 
            this.textWorkshopNumber.Location = new System.Drawing.Point(184, 244);
            this.textWorkshopNumber.Name = "textWorkshopNumber";
            this.textWorkshopNumber.Size = new System.Drawing.Size(114, 20);
            this.textWorkshopNumber.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Список номенклатуры выпускаемых изделий";
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.Location = new System.Drawing.Point(32, 328);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(266, 134);
            this.listProducts.TabIndex = 12;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(111, 609);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 13;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(223, 609);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер продукта";
            // 
            // textProductId
            // 
            this.textProductId.Location = new System.Drawing.Point(184, 479);
            this.textProductId.Name = "textProductId";
            this.textProductId.Size = new System.Drawing.Size(114, 20);
            this.textProductId.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Название продукта";
            // 
            // textProductName
            // 
            this.textProductName.Location = new System.Drawing.Point(184, 515);
            this.textProductName.Name = "textProductName";
            this.textProductName.Size = new System.Drawing.Size(114, 20);
            this.textProductName.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Количество изделий";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(184, 552);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(114, 20);
            this.textQuantity.TabIndex = 20;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(111, 661);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 21;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(223, 661);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 708);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textProductName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textProductId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textWorkshopNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textWorkshopChiefSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textWorkshopChiefPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textWorkshopChiefFullname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textWorkshopName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textWorkshopName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textWorkshopChiefFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textWorkshopChiefPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textWorkshopChiefSalary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textWorkshopNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textProductId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}