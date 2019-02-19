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
    public partial class Work : Form
    {
        Dictionary<string, MyWorkshop> workshops = new Dictionary<string, MyWorkshop>();
        private MyWorkshop currentWorkshop;
       

        public Work()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.AddWokshop();
        }

        private void listWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listWorkshops.SelectedIndex!=-1)
            {
                string str = listWorkshops.SelectedItem.ToString();
                currentWorkshop = workshops[str];
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            this.ShowWorkshop();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.DeleteWorkshop();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.EditWorkShop();
        }

        private void AddItem(string name, MyWorkshop workshop)
        {
            listWorkshops.Items.Add(name);
            workshops.Add(name,workshop);
        }

        private void RemoveItem(string name)
        {
            listWorkshops.Items.Remove(name);
            workshops.Remove(name);
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            this.AddWokshop();   
        }

        private void MenuShow_Click(object sender, EventArgs e)
        {
            this.ShowWorkshop(); 
        }

        private void MenuDelete_Click(object sender, EventArgs e)
        {
            this.DeleteWorkshop(); 
        }

        private void MenuEdit_Click(object sender, EventArgs e)
        {
            this.EditWorkShop();  
        }

        private void EditWorkShop()
        {
            if (currentWorkshop != null)
            {
                AddDialog dlg = new AddDialog(currentWorkshop);
                dlg.ShowDialog();
                if (dlg.WorkshopName != "Отмена")
                {
                    if (dlg.WorkshopName != "" && dlg.Products.Count > 0 && dlg.NumbersOfWorkers >= 0)
                    {
                        if (currentWorkshop.Name != dlg.WorkshopName)
                        {
                            currentWorkshop.Chief = dlg.Chief;
                            currentWorkshop.NumberOfWorkers = dlg.NumbersOfWorkers;
                            currentWorkshop.ListOfTheProductRange = dlg.Products;
                            this.RemoveItem(currentWorkshop.Name);
                            currentWorkshop.Name = dlg.WorkshopName;
                            this.AddItem(dlg.WorkshopName, currentWorkshop);
                            this.Refresh();
                        }
                        else
                        {
                            currentWorkshop.Chief = dlg.Chief;
                            currentWorkshop.NumberOfWorkers = dlg.NumbersOfWorkers;
                            currentWorkshop.ListOfTheProductRange = dlg.Products;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введены неверные данные", "Ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Данные не выбраны");
                return;
            }
        }

        private void AddWokshop()
        {
            AddDialog dlg = new AddDialog();
            dlg.ShowDialog();
            if (dlg.WorkshopName != "Отмена")
            {
                if (dlg.WorkshopName != "" && dlg.Products.Count > 0 && dlg.NumbersOfWorkers >= 0)
                {
                    MyWorkshop workshop = new MyWorkshop(dlg.WorkshopName, dlg.Chief, dlg.NumbersOfWorkers);
                    workshop.ListOfTheProductRange = dlg.Products;
                    this.AddItem(workshop.Name, workshop);
                    listWorkshops.SelectedItem = workshop.Name;
                    //listWorkshops.Items[listWorkshops.Items.Count - 1]
                }
                else
                {
                    MessageBox.Show("Введены неверные данные", "Ввод данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void MenuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа написана в процессе выполнения лабораторной работы");
        }

        private void DeleteWorkshop()
        {
            if(currentWorkshop!=null)
            {
                this.RemoveItem(currentWorkshop.Name);
                if(listWorkshops.Items.Count<1)
                {
                    currentWorkshop = null;
                }
            }
            else
            {
                MessageBox.Show("Данные не выбраны");
            }
        }

private void ShowWorkshop()
        {
            if(currentWorkshop!=null)
            {
                MessageBox.Show(currentWorkshop.ToString());
            }
            else
            {
                MessageBox.Show("Данные не выбраны");
            }
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            this.AddWokshop();
        }

        private void toolStripShow_Click(object sender, EventArgs e)
        {
            this.ShowWorkshop();
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            this.DeleteWorkshop();
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            this.EditWorkShop();
        }

    }
}

   
