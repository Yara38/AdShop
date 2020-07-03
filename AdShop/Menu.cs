using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdShop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonOpenManager_Click(object sender, EventArgs e)
        {
            Form formManager = new FormManager();
            formManager.Show();
        }

        private void buttonOpenIndividuals_Click(object sender, EventArgs e)
        {
            Form formIndividuals = new FormIndividuals();
            formIndividuals.Show();
        }

        private void buttonOpenEntity_Click(object sender, EventArgs e)
        {
           
        }
    }
}
