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
    public partial class FormIndividuals : Form
    {
        public FormIndividuals()
        {
            InitializeComponent();
            ShowManager();
            comboBoxGender.SelectedIndex = 0;
            IndividualsSet();
        }
        void ShowManager()
        {
            comboBoxManager.Items.Clear();
            foreach (ManagerSet managerSet in Program.adDb.ManagerSet)
            {
                string[] item = { managerSet.id.ToString() + ".", managerSet.FirstName, managerSet.MiddleName, managerSet.LastName };
                comboBoxManager.Items.Add(string.Join(" ", item));
            }
        }
        void IndividualsSet()
        {

            listViewIndividuals.Items.Clear();
            foreach (IndividualsSet Individuals in Program.adDb.IndividualsSet)
            {
                if (Individuals.Gender == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                         Individuals.id.ToString(), Individuals.inn.ToString(), Individuals.FirstName, Individuals.MiddleName, Individuals.LastName, Individuals.Gender.ToString(), Individuals.Email, Individuals.idManager.ToString()
                    });
                    item.Tag = Individuals;
                    listViewIndividuals.Items.Add(item);
                }
                else 
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                      Individuals.id.ToString(), Individuals.inn.ToString(), Individuals.FirstName, Individuals.MiddleName, Individuals.LastName, Individuals.Gender.ToString(), Individuals.Email, Individuals.idManager.ToString()
                    });
                    item.Tag = Individuals;
                    listViewIndividuals.Items.Add(item);
                }
            }
            listViewIndividuals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


            private void buttonAdd_Click(object sender, EventArgs e)
            {
            IndividualsSet Individuals = new IndividualsSet();
            Individuals.inn = Convert.ToInt64(textBoxinn.Text);
            Individuals.FirstName = textBoxFirstName.Text;
            Individuals.MiddleName = textBoxMiddleName.Text;
            Individuals.LastName = textBoxLastName.Text;
            Individuals.Email = textBoxEmail.Text;
            Individuals.idManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);

            if (comboBoxGender.SelectedIndex == 0)
            {
                Individuals.Gender = 0;
                Individuals.inn = Convert.ToInt64(textBoxinn.Text);
                Individuals.FirstName = textBoxFirstName.Text;
                Individuals.MiddleName = textBoxMiddleName.Text;
                Individuals.LastName = textBoxLastName.Text;
                Individuals.Email = textBoxEmail.Text;
                Individuals.idManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
            }
            else
            {
                Individuals.Gender = 1;
                Individuals.inn = Convert.ToInt64(textBoxinn.Text);
                Individuals.FirstName = textBoxFirstName.Text;
                Individuals.MiddleName = textBoxMiddleName.Text;
                Individuals.LastName = textBoxLastName.Text;
                Individuals.Email = textBoxEmail.Text;
                Individuals.idManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
            }
            Program.adDb.IndividualsSet.Add(Individuals);
            Program.adDb.SaveChanges();
            IndividualsSet();
            }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedIndex == 0)
            {
                textBoxinn.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }
            else
            {
                textBoxinn.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedIndex == 0)
            {
                if (listViewIndividuals.SelectedItems.Count == 1)
                {
                    IndividualsSet Individuals = new IndividualsSet();
                    Individuals.inn = Convert.ToInt64(textBoxinn.Text);
                    Individuals.FirstName = textBoxFirstName.Text;
                    Individuals.MiddleName = textBoxMiddleName.Text;
                    Individuals.LastName = textBoxLastName.Text;
                    Individuals.Email = textBoxEmail.Text;
                    Individuals.idManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                    Program.adDb.SaveChanges();
                    IndividualsSet();
                }
            }
            else
            {
                  if (listViewIndividuals.SelectedItems.Count == 1)
                  {
                        IndividualsSet Individuals = new IndividualsSet();
                        Individuals.inn = Convert.ToInt64(textBoxinn.Text);
                        Individuals.FirstName = textBoxFirstName.Text;
                        Individuals.MiddleName = textBoxMiddleName.Text;
                        Individuals.LastName = textBoxLastName.Text;
                        Individuals.Email = textBoxEmail.Text;
                        Individuals.idManager = Convert.ToInt32(comboBoxManager.SelectedItem.ToString().Split('.')[0]);
                        Program.adDb.SaveChanges();
                        IndividualsSet();
                  }
            }
        }

        private void listViewIndividuals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIndividuals.SelectedItems.Count == 1)
            {
                IndividualsSet Individuals = listViewIndividuals.SelectedItems[0].Tag as IndividualsSet;
                textBoxinn.Text = Individuals.inn.ToString();
                textBoxFirstName.Text = Individuals.FirstName.ToString();
                textBoxMiddleName.Text = Individuals.MiddleName.ToString();
                textBoxLastName.Text = Individuals.LastName.ToString();
                textBoxEmail.Text = Individuals.Email.ToString();
                comboBoxManager.SelectedIndex = comboBoxManager.FindString(Individuals.idManager.ToString());
            }
            else
            {
                textBoxinn.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxEmail.Text = "";
                comboBoxManager.SelectedItem = null;
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxGender.SelectedIndex == 0)
                {
                    if (listViewIndividuals.SelectedItems.Count == 1)
                    {
                        IndividualsSet Individuals = listViewIndividuals.SelectedItems[0].Tag as IndividualsSet;
                        Program.adDb.IndividualsSet.Remove(Individuals);
                        Program.adDb.SaveChanges();
                        IndividualsSet();
                    }
                    textBoxinn.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxMiddleName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxEmail.Text = "";
                }
                else if (comboBoxGender.SelectedIndex == 1)
                {
                    if (listViewIndividuals.SelectedItems.Count == 1)
                    {
                        IndividualsSet Individuals = listViewIndividuals.SelectedItems[0].Tag as IndividualsSet;
                        Program.adDb.IndividualsSet.Remove(Individuals);
                        Program.adDb.SaveChanges();
                        IndividualsSet();
                    }
                    textBoxinn.Text = "";
                    textBoxFirstName.Text = "";
                    textBoxMiddleName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxEmail.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

