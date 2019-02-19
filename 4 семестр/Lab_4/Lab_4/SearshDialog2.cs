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
    public partial class SearshDialog2 : Form
    {
        public SearshDialog2()
        {
            InitializeComponent();
        }

        public int NumberOfWorkers
        {
            get
            {
                try
                {
                    return Convert.ToInt32(textNumberOfWorkers.Text);
                }
                catch(FormatException ex)
                {
                    return -1;
                }
            }
        }

        private void Searsh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
