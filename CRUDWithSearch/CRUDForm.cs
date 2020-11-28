using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CRUDWithSearch;

namespace CRUDWithSearch
{
    public partial class CRUDForm : Form
    {
        private string ID = "";

        public CRUDForm()
        {
            InitializeComponent();
            ResetMe();
        }

        private void ResetMe()
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

        private void CRUDFormLoad(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void LoadData(string keyword)
        {
            CRUD.sql = "SElECT AUTO_ID, FIRST_NAME, LAST_NAME, FIRST_NAME + LAST_NAME AS FULL_NAME, GENDER " +
                    "FROM TBL_CRUD " +
                    "WHERE FIRST_NAME + LAST_NAME LIKE '%" + keyword + "%' OR GENDER = '" + keyword + "'";

            CRUD.cmd = new SqlCommand(CRUD.sql, CRUD.con);
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("keyword", keyword);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("number of rows: " + dt.Rows.Count.ToString());
            }

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "First Name";
            dgv1.Columns[2].HeaderText = "Last Name";
            dgv1.Columns[3].HeaderText = "Full Name";
            dgv1.Columns[4].HeaderText = "Gender";

            dgv1.Columns[0].Width = 70;
            dgv1.Columns[1].Width = 150;
            dgv1.Columns[2].Width = 150;
            dgv1.Columns[3].Width = 200;
            dgv1.Columns[4].Width = 90;

            if (dgv1.Rows.Count > 0)
            {
                dgv1.CurrentCell = dgv1.Rows[0].Cells[0];
            }
        }

        private void Execute(string msSql, string param)
        {
            CRUD.cmd = new SqlCommand(msSql, CRUD.con);
            AddParameters(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void AddParameters(string str)
        {
            CRUD.cmd.Parameters.Clear();
            CRUD.cmd.Parameters.AddWithValue("firsName", firstNameTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("lastName", firstNameTextBox.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("gender", genderCombobox.SelectedItem.ToString());

            if (str == "Update" || str == "Delete" && !string.IsNullOrEmpty(this.ID))
            {
                CRUD.cmd.Parameters.AddWithValue("id", this.ID);
            }
        }

        private void InsertButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(lastNameTextBox.Text.Trim()))
            {
                MessageBox.Show(
                    "Please input first name and last name.",
                    "Insert Date: ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            CRUD.sql = "INSERT INTO TBL_CRUD(" +
                "FIRST_NAME, LAST_NAME, GENDER) " +
                "VALUES('" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + genderCombobox.SelectedItem + "')";
            Execute(CRUD.sql, "insert");

            MessageBox.Show("The record has been saved.", "Insert Data : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData("");

            ResetMe();


        }

        private void dgv1CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.ID = Convert.ToString(dgv1.CurrentRow.Cells[9].Value);
                updateButton.Text = "Update (" + this.ID + ")";
                deleteButton.Text = "Delete (" + this.ID + ")";

                firstNameTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                lastNameTextBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);

                genderCombobox.SelectedItem = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);

            }
        }

        private void UpdateButtonClick(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count == 0)
            {
                MessageBox.Show(dgv1.Rows.Count.ToString() + " No rows found.", "Update Data : ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            if (updateButton.Text == "Update ()")
            {
                MessageBox.Show("The record has been saved.",
                   "Insert Data : ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(lastNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input first name and last name.",
                    "Insert Data : ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CRUD.sql = "UPDATE TBL_CRUD SET FIRST_NAME = @firstName, LAST_NAME = @lastName, GENDER = @gender WHERE AUTO_ID = @id";

            Execute(CRUD.sql, "Update");

            MessageBox.Show("The record has been updated.",
                   "Insert Data : ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadData("");

            ResetMe();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (dgv1.Rows.Count == 0)
            {
                MessageBox.Show(dgv1.Rows.Count.ToString() + " No rows found.", "Update Data : ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }

            if (deleteButton.Text == "Delete ()")
            {
                MessageBox.Show("The record has been saved.",
                   "Insert Data : ",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }

            if(MessageBox.Show("Do you want to permanently delete the selected record",
                    "Delete Data : ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM TBL_CRUD WHERE AUTO_ID, = @id";
                Execute(CRUD.sql, "Delete");
                MessageBox.Show("The record has been deleted", "Delete Data : ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadData("");
            }
            ResetMe();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(keywordTextBox.Text.Trim()))
            {
                LoadData("");
            }
            else
            {
                LoadData(keywordTextBox.Text.Trim());
            }

            ResetMe();

            if (keywordTextBox.CanSelect)
            {
                keywordTextBox.Select();
            }
        }
    }
}
