using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftwareEF;

namespace SoftwareEF.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            SoftwareDbContext context = new SoftwareDbContext();
            List<SoftwareList> softwares = context.SoftwareList.ToList();

            dataGridViewSoftwareList.DataSource = softwares;

        }
    }
}
