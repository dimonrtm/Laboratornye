using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class EditItemForm : Form
    {
        private MyWorkshop mw = new MyWorkshop();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public EditItemForm(MyWorkshop editedWorkshop)
        {
            InitializeComponent();
            mw = editedWorkshop;
        }

        public MyWorkshop EditedWorkshop
        {
            get
            {
                return mw;
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            int productId;
            try
            {
                productId = Convert.ToInt32(textNumberProducts.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                return;
            }
            string productName = textProductName.Text;
            int quantity;
            try
            {
                quantity = Convert.ToInt32(textQuantity.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                mw.Name = "Отмена";
                Close();
                return;
            }

            if ( productName != "")
            { 
                if (!products.ContainsKey(productName))
                {
                    listProducts.Items.Add(productName);
                    listProducts.SelectedItem = productName;
                    mw.AddProduct(productId, productName, quantity);
                    Product product = new Product(productId, productName, quantity);
                    products.Add(productName, product);
                }
                else
                {
                    MessageBox.Show("Продукт стаким названием уже добавлен");
                }
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (listProducts.SelectedItem != null)
            {
                mw.RemoveProduct(products[(string)listProducts.SelectedItem]);
                products.Remove((string)listProducts.SelectedItem);
                listProducts.Items.Remove(listProducts.SelectedItem);
            }
            else
            {
                MessageBox.Show("Выберите изделие");
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string name;
            if(checkWorkshopName.Checked==true)
            {
               name = textWorkshopName.Text;
                mw.Name = name;
            }
            if (checkWorkshopChief.Checked == true)
            {
                string fullName = textWorkshopChiefFullname.Text;
                string position = textWorkshopChiefPosition.Text;
                int salary;
                try
                {
                    salary = Convert.ToInt32(textSalary.Text);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Введены неверные данные");
                    Close();
                    return;
                }
                Employee chief = new Employee(fullName, position, salary);
                mw.Chief = chief;
            }
            if(checkBox1.Checked==true)
            {
                int numberOfWorkers;
                try
                {
                    numberOfWorkers = Convert.ToInt32(textNumberOfWorkers.Text);
                    mw.NumberOfWorkers = numberOfWorkers;
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                    return;
                }
            }
            Close();
        }

        private void checkWorkshopName_CheckedChanged(object sender, EventArgs e)
        {
            if(checkWorkshopName.Checked==true)
            {
                textWorkshopName.Visible = true;
            }
            else
            {
                textWorkshopName.Visible = false;
            }
        }

        private void checkWorkshopChief_CheckedChanged(object sender, EventArgs e)
        {
            if(checkWorkshopChief.Checked==true)
            {
                ChiefVisible(true);  
            }
            else
            {
                ChiefVisible(false);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                textNumberOfWorkers.Visible = true;
            }
            else
            {
                textNumberOfWorkers.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                ProductVisible(true); 
            }
            else
            {
                ProductVisible(false);
            }
        }

        private void ChiefVisible(Boolean visible)
        {
            label1.Visible = visible;
            textWorkshopChiefFullname.Visible = visible;
            label2.Visible = visible;
            textWorkshopChiefPosition.Visible = visible;
            label3.Visible = visible;
            textSalary.Visible = visible;
        }

        private void ProductVisible(Boolean visible)
        {
            listProducts.Visible = visible;
            label4.Visible = visible;
            label5.Visible = visible;
            label6.Visible = visible;
            textNumberProducts.Visible = visible;
            textProductName.Visible = visible;
            textQuantity.Visible = visible;
            AddProduct.Visible = visible;
            DeleteProduct.Visible = visible;
            if(visible==true&&listProducts.Items.Count==0)
            {
                for(int i=0;i<mw.ListOfTheProductRange.Count;i++)
                {
                    listProducts.Items.Add(mw[i].Name);
                    products.Add(mw[i].Name, mw[i]);
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            mw.Name = "Отмена";
            Close();
        }
    }
}
