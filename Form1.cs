using Microsoft.Data.SqlClient;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            userNameTB.Text = "sa";
            passwordTB.Text = "1234";
        }

        private void authBTN_Click(object sender, System.EventArgs e)
        {
            string userName = userNameTB.Text;
            string password = passwordTB.Text;
            userNameTB.Text = string.Empty;
            passwordTB.Text = string.Empty;

            string pathToConectionString = Application.StartupPath.ToString();
            pathToConectionString += "/" + "ConectionString.json";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            if (!File.Exists(pathToConectionString))
            {
                MessageBox.Show("Згенеруйте файл підключеня через нашу програму");
                return;
            }
            else
            {
                using (FileStream file = new FileStream(pathToConectionString, FileMode.Open))
                {
                    GetContectionString.getstr = JsonSerializer.Deserialize<string>(file);
                    GetContectionString.getstr += $"User ID = {userName};" + $"Password= {password};";
                }
            }

            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("getPermission", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string permission = reader[0].ToString();

                            givePermission.permission = permission == "0" ? "ASSISTANT" : "MASTER";
                        }
                    }

                    reader.Close();

                    MessageBox.Show($"Підключення успішне!");

                    var PCForm = new PCBuilder();
                    PCForm.Show();
                    Hide();
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Не вдалося підключитися до бази даних: {ex}");
                }

            }
        }

        private void exitAppBTN_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}