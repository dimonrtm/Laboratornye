using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab_4
{
    public partial class Blank : Form
    {
        private MyWorkshop currentWorkshop;
        private Dictionary<string, MyWorkshop> workshops = new Dictionary<string, MyWorkshop>();
        private XmlSerializer formatter = new XmlSerializer(typeof(MyWorkshop[]));

        public Blank()
        {
            InitializeComponent();
        }

        public string DocName
        { get; set; }

        public MyWorkshop[] Workshops
        {
            get
            {
                MyWorkshop[] works = workshops.Values.ToArray<MyWorkshop>();
                return works;
            }
           set
            {
                MyWorkshop[] works = value;
                OuterAdd(works);
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            AddItemForm aif = new AddItemForm();
            aif.ShowDialog();
            if (aif.AddedWorkshop.Name != "Отмена")
            {
                if (aif.AddedWorkshop.Name != "" && aif.AddedWorkshop.ListOfTheProductRange.Count > 0)
                {
                    currentWorkshop = aif.AddedWorkshop;
                    workshops.Add(currentWorkshop.Name, currentWorkshop);
                    AddItemListWorkshops(currentWorkshop);
                }
                else
                {
                    MessageBox.Show("Введены неверные данные");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void ShowWorkshop()
        {
            if (listWorkshops.FocusedItem != null)
            {
                MessageBox.Show(currentWorkshop.ToString());
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void DeleteWorkshop()
        {
            if (listWorkshops.FocusedItem != null)
            {

                listWorkshops.Items.Remove(listWorkshops.FocusedItem);
                if (listWorkshops.Items.Count > 0)
                {
                    listWorkshops.Items[0].Focused = true;
                    listWorkshops.Items[0].Selected = true;
                }
                workshops.Remove(currentWorkshop.Name);
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void ShowItem_Click(object sender, EventArgs e)
        {
            ShowWorkshop();
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            DeleteWorkshop();
        }

        //private void listWorkshops_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    currentWorkshop = workshops[listWorkshops.FocusedItem.Text];
        //}

        private void EditWorkshop()
        {
            if (listWorkshops.FocusedItem != null)
            {
                int index = listWorkshops.Items.IndexOf(listWorkshops.FocusedItem);
                workshops.Remove(currentWorkshop.Name);
                EditItemForm eif = new EditItemForm(currentWorkshop);
                eif.ShowDialog();
                currentWorkshop = eif.EditedWorkshop;
                workshops.Add(currentWorkshop.Name, currentWorkshop);
                ListViewItem lvi2 = CreateItemListWorkshops(currentWorkshop);
                listWorkshops.Items[index] = lvi2;
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка");
            }
        }

        private void AddItemListWorkshops(MyWorkshop mw)
        {
            ListViewItem lvi = new ListViewItem(mw.Name);
            lvi.SubItems.Add(mw.Chief.FullName);
            lvi.SubItems.Add(mw.NumberOfWorkers.ToString());
            lvi.SubItems.Add(mw[0].Name + "...");
            listWorkshops.Items.Add(lvi);
            listWorkshops.Items[listWorkshops.Items.IndexOf(lvi)].Focused = true;
            listWorkshops.Items[listWorkshops.Items.IndexOf(lvi)].Selected = true;
        }

        private void AddItemListWorkshopsForFile(MyWorkshop mw)
        {
            ListViewItem lvi = new ListViewItem(mw.Name);
            lvi.SubItems.Add(mw.Chief.FullName);
            lvi.SubItems.Add(mw.NumberOfWorkers.ToString());
            lvi.SubItems.Add(mw[0].Name + "...");
            listWorkshops.Items.Add(lvi);
            
        }

        private ListViewItem CreateItemListWorkshops(MyWorkshop mw)
        {
            ListViewItem lvi = new ListViewItem(mw.Name);
            lvi.SubItems.Add(mw.Chief.FullName);
            lvi.SubItems.Add(mw.NumberOfWorkers.ToString());
            lvi.SubItems.Add(mw[0].Name + "...");
            return lvi;
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            EditWorkshop();
        }

        private void listWorkshops_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listWorkshops.FocusedItem != null)
            {
                if (workshops.ContainsKey(listWorkshops.FocusedItem.Text))
                {
                    currentWorkshop = workshops[listWorkshops.FocusedItem.Text];
                }
            }
        }

        private void toolStripAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void toolStripShow_Click(object sender, EventArgs e)
        {
            ShowWorkshop();
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            DeleteWorkshop();
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            EditWorkshop();
        }

        public void Save(string saveFileName)
        { 
            MyWorkshop[] works = workshops.Values.ToArray<MyWorkshop>();

            using (FileStream saveFile = new FileStream(saveFileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(saveFile, works);
            }
        }

        public void Open(string openFileName)
        {
            MyWorkshop[] works;
            using (FileStream openWorkshop = new FileStream(openFileName, FileMode.OpenOrCreate))
            {
                works = (MyWorkshop[])formatter.Deserialize(openWorkshop);
            }
            OuterAdd(works);
        }

        public void Cut()
        {
            Form1 frm = (Form1)this.MdiParent;
            frm.BufferedWorkshop = currentWorkshop;
            DeleteWorkshop();
        }

        public void Copy()
        {
            Form1 frm = (Form1)this.MdiParent;
            frm.BufferedWorkshop = currentWorkshop;
        }

        public void Paste()
        {
            Form1 frm = (Form1)this.MdiParent;
            currentWorkshop = frm.BufferedWorkshop;
            if(!workshops.ContainsKey(currentWorkshop.Name))
            {
                workshops.Add(currentWorkshop.Name, currentWorkshop);
                AddItemListWorkshops(currentWorkshop);
            }
            frm.BufferedWorkshop = null;
        }

        private void OuterAdd(MyWorkshop[] works)
        {
            for (int i = 0; i < works.Length; i++)
            {
                if (!workshops.ContainsKey(works[i].Name))
                {
                    workshops.Add(works[i].Name, works[i]);
                    AddItemListWorkshopsForFile(works[i]);
                    currentWorkshop = works[i];
                }
            }
            listWorkshops.Items[listWorkshops.Items.Count - 1].Focused = true;
            listWorkshops.Items[listWorkshops.Items.Count - 1].Selected = true;
        }
    }
}
