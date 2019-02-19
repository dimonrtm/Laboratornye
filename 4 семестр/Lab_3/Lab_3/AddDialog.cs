using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_2;

namespace Lab_3
{
    public partial class AddDialog : Form
    {
        private List<string> products = new List<string>();

        public string WorkshopName
        {
            get
            {
                return txtName.Text;
            }
            set
            {
                txtName.Text = value;
            }
        }

        public string Chief
        {
            get
            {
                return txtChief.Text;
            }
            set
            {
                txtChief.Text = value;
            }
        }

        public int NumbersOfWorkers
        {
            get
            {
                try
                {
                    return Convert.ToInt32(txtNumbOfWork.Text);
                }
                catch (FormatException e)
                {
                    MessageBox.Show(e.Message);
                    return -1;
                }
            }
            set
            {
                txtNumbOfWork.Text = value.ToString();
            }
        }

        public List<string> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
                foreach(string product in products)
                {
                    listBox1.Items.Add(product);
                }
            }
        }

        public AddDialog()
        {
            
            InitializeComponent();
        }

        public AddDialog(Lab_2.MyWorkshop workshop)
        {
           InitializeComponent();
            WorkshopName = workshop.Name;
            Chief = workshop.Chief;
            NumbersOfWorkers = workshop.NumberOfWorkers;
            Products = workshop.ListOfTheProductRange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = txtProduct.Text;
            products.Add(str);
            listBox1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkshopName = "Отмена";
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            products.Remove(listBox1.SelectedItem.ToString());
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
