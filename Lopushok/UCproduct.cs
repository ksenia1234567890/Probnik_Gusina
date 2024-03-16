using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class UCproduct : UserControl
    {
        public UCproduct()
        {
            InitializeComponent();
        }
        public string picture = "";

        public string Name
        {
            get
            {
                return name.Text;
            }
            set
            {
                name.Text = value;
            }
        }
        public string Type
        {
            get
            {
                return type.Text;
            }
            set
            {
                type.Text = value;
            }
        }
        public string Articul
        {
            get
            {
                return articul.Text;
            }
            set
            {
                articul.Text = value;
            }
        }
        public string Minprice
        {
            get
            {
                return minprice.Text;
            }
            set
            {
                minprice.Text = value;
            }
        }
        public string Material
        {
            get
            {
                return material.Text;
            }
            set
            {
                material.Text = value;
            }
        }
        public string Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
            }
        }

        private void UCproduct_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor(this);
            editor.ShowDialog();
        }
    }
}
