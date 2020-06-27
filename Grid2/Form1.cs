using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGrid
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        int n;

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            while (!int.TryParse(tbSize.Text, out n)|n<1)
            {
                MessageBox.Show("Ошибка в данных!");
                tbSize.Focus();
                return;
            }
            gridMain.ColumnCount = gridMain.RowCount = n;
            Random value = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    gridMain[i, j].Value = value.Next(0,10);
        }
    }
}
