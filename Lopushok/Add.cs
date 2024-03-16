using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lopushok
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        string path = "Host=localhost;Username=postgres;Password=pgadmin;Database=Lopushok";
        string pathImage = "";

        private void Badd_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = "insert into products(name, articul,minprice,picture,type,count,number) values (@name, @articul,@minprice,@picture,@type,@count,@number)";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                command.Parameters.AddWithValue("@name", name.Text);
                command.Parameters.AddWithValue("@articul", Tarticul.Text);
                command.Parameters.AddWithValue("@minprice", Tminprice.Text);
                command.Parameters.AddWithValue("@picture", pathImage);
                command.Parameters.AddWithValue("@type", Ctypes.Text);
                command.Parameters.AddWithValue("@count", Tminprice.Text);
                command.Parameters.AddWithValue("@number", Tnumber.Text);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }

      private void Bpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            pathImage = openFile.FileName;
        }
    }
}
