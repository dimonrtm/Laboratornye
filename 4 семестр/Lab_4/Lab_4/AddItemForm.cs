using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class AddItemForm : Form
    {
        private MyWorkshop mw=new MyWorkshop();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public MyWorkshop AddedWorkshop
        {
            get
            {
                return mw;
            }
            set
            {
                mw = value;
            }
        }

        public AddItemForm()
        {
            InitializeComponent();
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int productId;
            try
            {
               productId = Convert.ToInt32(textProductId.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
                productId = -1;
            }
            string productName = textProductName.Text;
            int quantity;
            try
            {
                quantity = Convert.ToInt32(textQuantity.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
                quantity = -1;
            }

            if(productId>=0&&quantity>=0&&productName!="")
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

        private void Delete_Click(object sender, EventArgs e)
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
            mw.Name = textWorkshopName.Text;
            string chiefFullname = textWorkshopChiefFullname.Text;
            string chiefPosition = textWorkshopChiefPosition.Text;
            int chiefSalary;
            try
            {
                chiefSalary = Convert.ToInt32(textWorkshopChiefSalary.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                mw.Name = "";
                chiefSalary = -1;
            }
            if (chiefSalary > 0)
            {
                Employee chief = new Employee(chiefFullname, chiefPosition, chiefSalary);
                mw.Chief = chief;
            }
            try
            {
                mw.NumberOfWorkers = Convert.ToInt32(textWorkshopNumber.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                mw.Name = "";
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            mw.Name = "Отмена";
            Close();
        }
    }
}
