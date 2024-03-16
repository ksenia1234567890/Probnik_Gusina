using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Lopushok
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        string path = "Host=localhost;Username=postgres;Password=pgadmin;Database=Lopushok";
        List<UCproduct> products = new List<UCproduct>();
        int count = 0;

        private void FormProduct_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = "select * from products";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);  
                NpgsqlDataReader reader = command.ExecuteReader();
                connect.Open();
                    while(reader.Read())
                    {
                        UCproduct product = new UCproduct();
                        product.Name = reader.GetValue(0).ToString();
                        product.Articul = reader.GetValue(1).ToString();
                        product.Minprice = reader.GetValue(2).ToString();
                        product.Picture = reader.GetValue(3).ToString();
                        product.Type = reader.GetValue(4).ToString();
                    products.Add(product);
                        count++;
                    }
                connect.Close();
            }
            int i = 0;
            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = "select material from product_material";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                NpgsqlDataReader reader = command.ExecuteReader();
                connect.Open();
                    while (reader.Read())
                    {
                    products[i].Material = reader.GetValue(0).ToString();
                    i++;
                    }
                connect.Close();
            }

            // Добавление типов в комбобокс

            using (NpgsqlConnection connect = new NpgsqlConnection(path))
            {
                string query = "select type from products";
                NpgsqlCommand command = new NpgsqlCommand(query, connect);
                NpgsqlDataReader reader = command.ExecuteReader();
                connect.Open();
                while (reader.Read())
                {
                    if(comboBox2.Items.Contains(reader.GetValue(0).ToString()))
                    {
                        comboBox2.Items.Add(reader.GetValue(0).ToString()))
                    }
                }
                connect.Close();
            }


            PageInstall();
        }

        public void PageInstall()
        {
            for(int i=0; i<products.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(products[i]);
            }
        }

        // Добавить продукцию

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        // Применение фильтра
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if(comboBox2.SelectedItem.ToString()=="Все типы")
            {
                PageInstall();
            }
            for(int i=0;i<products.Count();i++)
            {
                if (products[i].Type == comboBox2.SelectedItem.ToString())
                {
                    flowLayoutPanel1.Controls.Add(products[i]);
                }
            }
        }
    }
}
