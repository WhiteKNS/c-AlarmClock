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

namespace DataBase
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            /*string connectionString =
           "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + "C:\\Users\\NATALYA\\Downloads\\Student Database.mdb; Persist Security Info = True; User ID = admin";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT EmailName from Instructors";
                   // + "WHERE Section N > 2 "
                    //+ "ORDER BY section N DESC;";

            int paramValue = 5;

            using (OleDbConnection connection =
                new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connection;
                    //cmd.CommandText = "Select * from Classes";
                    // cmd.CommandText = "Select DepartmentID from Classes";
                    cmd.CommandText = queryString;
                    StringBuilder sb = new StringBuilder();
                    IDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString());
                        sb.Append(string.Format("{0}", reader[0].ToString()) + System.Environment.NewLine);
                    }
                    reader.Close();
                }
                catch (System.Data.OleDb.OleDbException lolex)
                {
                    Console.WriteLine(lolex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this window?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonSearchMain_Click(object sender, EventArgs e)
        {
            // Application.Run(new Search());
            Search searchForm = new Search();
            searchForm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close this window?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Me", "Exit", MessageBoxButtons.OK);
        }
    }
 }
