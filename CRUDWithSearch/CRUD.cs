using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDWithSearch
{
    class CRUD
    {
        public static string conString = "Data Source=MSI-WILLARD; Initial Catalog = TestDB; User Id=sa; Password=Gbkarate";
        public static string sql = string.Empty;
        public static SqlConnection con = new SqlConnection(conString);
        public static SqlCommand cmd = default(SqlCommand);

        public static DataTable PerformCRUD(SqlCommand com)
        {
            SqlDataAdapter da = default(SqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(
                    "An error occured: " + ex.Message,
                    "Failed to execute SQL Statement : IBasskung Tutorial",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            return dt;
        }
    }
}
 