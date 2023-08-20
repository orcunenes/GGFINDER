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
using GGFINDER.Utils;
using System.Data.SQLite;
using System.Runtime.Remoting.Contexts;

namespace GGFINDER.Formfiles
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (passwordtxt.Text == string.Empty || usernametxt.Text == string.Empty)
            {
                MessageBox.Show("Your Username or Password Can't be Empty");
            }
            else
            {
                DatabaseHelper.connection.Open();
                string sql = "Insert into USERS(username,password) Values('" + usernametxt.Text + "','" + passwordtxt.Text + "')";
                if (checkusername(usernametxt.Text))
                {
                    SQLiteCommand cmd = new SQLiteCommand(sql, DatabaseHelper.connection);
                    cmd.ExecuteReader();
                    MessageBox.Show("Registered Successfully!");
                    Main main = new Main();
                    main.loggedinusername = usernametxt.Text;
                    main.Show();
                    this.Close();

                }

                DatabaseHelper.connection.Close();
            }

        }


        private bool checkusername(string username)
        {
            string query = "SELECT * FROM USERS WHERE username = @Username";
            using (SQLiteCommand command = new SQLiteCommand(query, DatabaseHelper.connection))
            {
                command.Parameters.AddWithValue("@Username", username);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("This Username Already Registered!");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
