using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Test_25_05_2024
{
    public partial class Form1 : Form
    {
        string connectionString =
        "Server=NUMESHJ; Database = ABC ; Trusted_Connection = True";

        public Form1()
        {
            InitializeComponent();
        }

        public void cleardata()
        {
            txt_basicSal.Text = string.Empty;
            txt_name.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            addmember();
            GetMemberData();

        }

        private void addmember()
        {
            try
            {
                var name = txt_name.Text;
                var basicsal = txt_basicSal.Text;

                var query = "INSERT INTO Employee(Name, Basic_Salary) VALUES (@name, @basicsal)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@basicsal", basicsal);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    cleardata();
                    MessageBox.Show("Name and the Salary has been saved");
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetMemberData();
        }

        private void GetMemberData()
        {
            string query = "SELECT * FROM Employee";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dt);
                    connection.Close();
                    member.DataSource = dt;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
        }

        private void member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = member.Rows[e.RowIndex];
                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_basicSal.Text = row.Cells["Basic_Salary"].Value.ToString();
            }
        }

        private void member_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = member.Rows[e.RowIndex];
                txt_name.Text = row.Cells["Name"].Value.ToString();
                txt_basicSal.Text = row.Cells["Basic_Salary"].Value.ToString();
                txt_id.Text = row.Cells["ID"].Value.ToString();

            }

        }

        private void UpdateMember ()
        {
            string updatequery = "UPDATE Employee SET Name=@name, Basic_Salary=@basicsal WHERE ID =@id";

            var id = txt_id.Text;
            var name = txt_name.Text;
            var basicsal = txt_basicSal.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(updatequery, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@basicsal", basicsal);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update Sucessfully");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
