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
    public partial class Form1 : Form
    {
        private int openDoc;
        private MyWorkshop buferedWorkshop;

        public Form1()
        {
            InitializeComponent();
        }

        public MyWorkshop BufferedWorkshop
        {
            get
            {
                return buferedWorkshop;
            }
            set
            {
                buferedWorkshop = value;
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = new Blank();
            frm.DocName = "Документ" + ++openDoc;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveWorkshopsDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveWorkshopsDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank frm = (Blank)this.ActiveMdiChild;
                if (frm != null)
                {
                    frm.Save(saveWorkshopsDialog1.FileName);
                    frm.MdiParent = this;
                    frm.DocName = saveWorkshopsDialog1.FileName;
                    frm.Text = frm.DocName;
                }
                else
                {
                    MessageBox.Show("Нет активных форм");
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWorkshopsDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openWorkshopsDialog1.ShowDialog() == DialogResult.OK)
            {
                Blank frm = new Blank();
                frm.Open(openWorkshopsDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openWorkshopsDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)this.ActiveMdiChild;
            if (frm != null)
            {
                frm.Cut();
            }
            else
            {
                MessageBox.Show("Нет активных форм");
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)this.ActiveMdiChild;
            if (frm != null)
            {
                frm.Copy();
            }
            else
            {
                MessageBox.Show("Нет активных форм");
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)this.ActiveMdiChild;
            if (frm != null)
            {
                frm.Paste();
            }
            else
            {
                MessageBox.Show("Нет активных форм");
            }
        }

        private void поИмениНачальникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blank frm = (Blank)this.ActiveMdiChild;
            SearshDialog1 sd = new SearshDialog1();
            sd.ShowDialog();
            MyWorkshop[] works = frm.Workshops;
            IEnumerable<MyWorkshop> filteredWorkshops = works.Where(n => n.Chief.FullName == sd.ChiefName);
            works = filteredWorkshops.ToArray();
            Blank blank = new Blank();
            blank.Workshops = works;
            blank.MdiParent = this;
            blank.DocName = "Выборка по имени начальника";
            blank.Text = blank.DocName;
            blank.Show();
        }

        private void поКоличествуРаботниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearshDialog2 sd = new SearshDialog2();
            WorkshopQwery(n => n.NumberOfWorkers == sd.NumberOfWorkers, "Выборка по количеству работников",sd);
        }

        private void поКоличествуВыпускаемыхИзделийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearshDialog2 sd = new SearshDialog2();
            WorkshopQwery(n => n.ListOfTheProductRange.Count == sd.NumberOfWorkers, "Выборка по количеству выпускаемых изделий",sd);
        }

        private void WorkshopQwery(Func<MyWorkshop, bool> predicate,string docName,SearshDialog2 sd)
        {
            Blank frm = (Blank)this.ActiveMdiChild;
            sd.ShowDialog();
            MyWorkshop[] works = frm.Workshops;
            if (sd.NumberOfWorkers != -1)
            {
                IEnumerable<MyWorkshop> filteredWorkshops = works.Where(predicate);
                works = filteredWorkshops.ToArray();
                Blank blank = new Blank();
                blank.Workshops = works;
                blank.MdiParent = this;
                blank.DocName = docName;
                blank.Text = blank.DocName;
                blank.Show();
            }
            else
            {
                MessageBox.Show("Введены неверные данные");
            }
        }
    }
}


