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
    public partial class SearshDialog1 : Form
    {
        public SearshDialog1()
        {
            InitializeComponent();
        }

        public string ChiefName
        {
            get
            {
                return textChiefName.Text;
            }
        }

        private void Searsh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textChiefName.Text = "Отмена";
            Close();
        }
    }
}
