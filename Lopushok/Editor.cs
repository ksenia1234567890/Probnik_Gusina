using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class Editor : Form
    {
        UCproduct product;
        public Editor(UCproduct product)
        {
            InitializeComponent();
            this.product = product;
        }
        string path = "Host=localhost;Username=postgres;Password=pgadmin;Database=Lopushok";

        private void Editor_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = $"select * from products where name={product.Name}";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                NpgsqlDataReader reader = command.ExecuteReader();
                connect.Open();
                while (reader.Read())
                {
                    name.Text = reader.GetValue(0).ToString();
                    Tarticul.Text = reader.GetValue(1).ToString();
                    Tminprice.Text = reader.GetValue(2).ToString();
                    Tpicture.Text = reader.GetValue(3).ToString();
                    Ctypes.Text= reader.GetValue(4).ToString();
                    TcountPeople.Text = reader.GetValue(5).ToString();
                    Tnumber.Text = reader.GetValue(6).ToString();
                }
                connect.Close();
            }
        }

        private void Badd_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = "update products set articul=@articul,minprice=@minprice,picture=@picture,type=@type,count=@count,number=@number where name=@name)";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                command.Parameters.AddWithValue("@name", name.Text);
                command.Parameters.AddWithValue("@articul", Tarticul.Text);
                command.Parameters.AddWithValue("@minprice", Tminprice.Text);
                command.Parameters.AddWithValue("@picture", Tpicture.Text);
                command.Parameters.AddWithValue("@type", Ctypes.Text);
                command.Parameters.AddWithValue("@count", Tminprice.Text);
                command.Parameters.AddWithValue("@number", Tnumber.Text);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }

        private void Bdelete_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = "delete from products where name=@name)";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                command.Parameters.AddWithValue("@name", name.Text);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
        }
    }
}
