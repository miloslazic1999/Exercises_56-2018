using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_56_2018
{
    public partial class Form1 : Form
    {
        private SqlConnection connection { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Ucitaj(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();

            var query = @"SELECT Id, StudentName, StudentIndex, Points FROM ExerciseResults";
            var cmd = new SqlCommand(query, connection);

            var reader = cmd.ExecuteReader();

            listBoxExerciseResults.Items.Clear();

            while(reader.Read())
            {
                var id = reader.GetInt32(reader.GetOrdinal("Id"));
                var name = reader.GetString(reader.GetOrdinal("StudentName"));
                var index = reader.GetString(reader.GetOrdinal("StudentIndex"));
                var points = reader.GetInt32(reader.GetOrdinal("Points"));

                listBoxExerciseResults.Items.Add(new ExerciseResult(id, name, index, points));
            }

            connection.Close();
        }
    }
}
