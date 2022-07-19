using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using System.Data.SqlClient;
//
using System.IO;

namespace imageDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBoxLoadImage.Load(OD.FileName);
        }

        string connectionString = "Data Source=DESKTOP-NQF55SP;Initial Catalog=sqldb;Integrated Security=True";

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pictureBoxLoadImage.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@image", image);
            command.CommandText = "INSERT INTO ImageTable (image) VALUES (@image)";

            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Image was added");
            else
                MessageBox.Show("Image was not added");

            con.Close();
        }

        private void buttonFetch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = con.CreateCommand();
            con.Open();

            command.Parameters.AddWithValue("@id", textBoxID.Text);
            command.CommandText = "SELECT * FROM ImageTable WHERE id = @id";
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MemoryStream stream = new MemoryStream(reader.GetSqlBytes(1).Buffer);
                pictureBoxFetch.Image = Image.FromStream(stream);
            }

            con.Close();
        }
    }
}
