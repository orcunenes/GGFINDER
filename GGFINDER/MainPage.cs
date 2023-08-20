using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SQLite;
using System.Runtime.Remoting.Contexts;
using GGFINDER.Utils;
using GGFINDER.Formfiles;

namespace GGFINDER
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == string.Empty)
            {
                usernamehidden.Text = "USERNAME CAN'T BE EMPTY";
                usernamehidden.Visible = true;
            }
            if (passwordtxt.Text == string.Empty)
            {
                passwordhidden.Text = "PASSWORD CAN'T BE EMPTY";
                passwordhidden.Visible = true;
            }
            string query = "SELECT * FROM USERS WHERE username = @Username";
            DatabaseHelper.connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, DatabaseHelper.connection))
            {
                command.Parameters.AddWithValue("@Username", usernametxt.Text);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        result.Text = "USERNAME IS NOT REGISTERED";
                        result.Visible = true;

                    }
                    else
                    {
                        while (reader.Read())
                        {
                            if (usernametxt.Text == reader["username"].ToString() && passwordtxt.Text == reader["password"].ToString())
                            {
                                Main main = new Main();
                                main.loggedinusername= reader["username"].ToString();
                                this.Hide();
                                main.Show();
                            }
                            else
                            {
                                result.Text = "USERNAME OR PASSWORD WRONG";
                                result.Visible = true;
                            }

                        }
                    }
                }
            }
            DatabaseHelper.connection.Close();

        }

        private void registerlbl_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
    }
}
