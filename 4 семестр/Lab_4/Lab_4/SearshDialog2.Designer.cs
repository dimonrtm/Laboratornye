namespace Lab_4
{
    partial class SearshDialog2
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
            this.textNumberOfWorkers = new System.Windows.Forms.TextBox();
            this.Searsh = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество работников цеха";
            // 
            // textNumberOfWorkers
            // 
            this.textNumberOfWorkers.Location = new System.Drawing.Point(215, 13);
            this.textNumberOfWorkers.Name = "textNumberOfWorkers";
            this.textNumberOfWorkers.Size = new System.Drawing.Size(100, 20);
            this.textNumberOfWorkers.TabIndex = 1;
            // 
            // Searsh
            // 
            this.Searsh.Location = new System.Drawing.Point(77, 51);
            this.Searsh.Name = "Searsh";
            this.Searsh.Size = new System.Drawing.Size(75, 23);
            this.Searsh.TabIndex = 2;
            this.Searsh.Text = "Найти";
            this.Searsh.UseVisualStyleBackColor = true;
            this.Searsh.Click += new System.EventHandler(this.Searsh_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(215, 51);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SearshDialog2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 86);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Searsh);
            this.Controls.Add(this.textNumberOfWorkers);
            this.Controls.Add(this.label1);
            this.Name = "SearshDialog2";
            this.Text = "SearshDialog2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumberOfWorkers;
        private System.Windows.Forms.Button Searsh;
        private System.Windows.Forms.Button Cancel;
    }
}