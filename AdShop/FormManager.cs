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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
            ShowManager();
        }

        void ShowManager()
        {
            listViewManager.Items.Clear();
            foreach (ManagerSet managerSet in Program.adDb.ManagerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    managerSet.id.ToString(), managerSet.FirstName, managerSet.MiddleName, managerSet.LastName, managerSet.Email
                });
                item.Tag = managerSet;
                listViewManager.Items.Add(item);
            }
            listViewManager.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ManagerSet managerSet = new ManagerSet();
            managerSet.FirstName = textBoxFirstName.Text;
            managerSet.MiddleName = textBoxMiddleName.Text;
            managerSet.LastName = textBoxLastName.Text;
            managerSet.Email = textBoxEmail.Text;
            Program.adDb.ManagerSet.Add(managerSet);
            Program.adDb.SaveChanges();
            ShowManager();
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;
                managerSet.FirstName = textBoxFirstName.Text;
                managerSet.MiddleName = textBoxMiddleName.Text;
                managerSet.LastName = textBoxLastName.Text;
                managerSet.Email = textBoxEmail.Text;
                Program.adDb.SaveChanges();
                ShowManager();
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManager.SelectedItems.Count == 1)
                {
                    ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;
                    Program.adDb.ManagerSet.Remove(managerSet);
                    Program.adDb.SaveChanges();
                    ShowManager();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listViewManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewManager.SelectedItems.Count == 1)
            {
                ManagerSet managerSet = listViewManager.SelectedItems[0].Tag as ManagerSet;
                textBoxFirstName.Text = managerSet.FirstName;
                textBoxMiddleName.Text = managerSet.MiddleName;
                textBoxLastName.Text = managerSet.LastName;
                textBoxEmail.Text = managerSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
        }
    }
}
