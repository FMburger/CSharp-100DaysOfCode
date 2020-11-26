using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDWithSearch
{
    public partial class CRUDForm : Form
    {
        public CRUDForm()
        {
            InitializeComponent();
            resetME();
        }

        private void resetME()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            keywordTextBox.Clear();
            if (genderCombobox.Items.Count > 0)
            {
                genderCombobox.SelectedIndex = 0;
            }

            updateButton.Text = "Update ()";
            deleteButton.Text = "Delete ()";
        }

        private void CRUDForm_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string keywordd)
        {
            //TODO
        }
        private void execute(string msSql, string param )
        {
            CRUD.cmd = new SqlCommand(msSql, CRUD.con);
            AddParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }
        private void AddParameters(string param)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("firsName", firstNameTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("lastName", firstNameTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("gender", genderCombobox.SelectedItem.ToString());

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.ID)
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.ID);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(lastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input first name and last name.",
                    "Insert Date: iBasskung Tutorial", MessageBoxButtons.OK, MessageBoxButtons.Information);
                return;
            }
        }
    }
}
