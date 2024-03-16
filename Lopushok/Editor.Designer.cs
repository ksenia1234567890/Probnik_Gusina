namespace Lopushok
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.Badd = new System.Windows.Forms.Button();
            this.Ctypes = new System.Windows.Forms.ComboBox();
            this.Tmaterial = new System.Windows.Forms.TextBox();
            this.Tminprice = new System.Windows.Forms.TextBox();
            this.Tnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TcountPeople = new System.Windows.Forms.TextBox();
            this.minprice = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tname = new System.Windows.Forms.Label();
            this.Tarticul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bdelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tpicture = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Badd
            // 
            this.Badd.Location = new System.Drawing.Point(434, 381);
            this.Badd.Name = "Badd";
            this.Badd.Size = new System.Drawing.Size(142, 30);
            this.Badd.TabIndex = 18;
            this.Badd.Text = "Изменить";
            this.Badd.UseVisualStyleBackColor = true;
            this.Badd.Click += new System.EventHandler(this.Badd_Click);
            // 
            // Ctypes
            // 
            this.Ctypes.FormattingEnabled = true;
            this.Ctypes.Location = new System.Drawing.Point(80, 238);
            this.Ctypes.Name = "Ctypes";
            this.Ctypes.Size = new System.Drawing.Size(132, 21);
            this.Ctypes.TabIndex = 17;
            // 
            // Tmaterial
            // 
            this.Tmaterial.Location = new System.Drawing.Point(307, 239);
            this.Tmaterial.Name = "Tmaterial";
            this.Tmaterial.Size = new System.Drawing.Size(132, 20);
            this.Tmaterial.TabIndex = 11;
            // 
            // Tminprice
            // 
            this.Tminprice.Location = new System.Drawing.Point(307, 151);
            this.Tminprice.Name = "Tminprice";
            this.Tminprice.Size = new System.Drawing.Size(132, 20);
            this.Tminprice.TabIndex = 12;
            // 
            // Tnumber
            // 
            this.Tnumber.Location = new System.Drawing.Point(307, 71);
            this.Tnumber.Name = "Tnumber";
            this.Tnumber.Size = new System.Drawing.Size(132, 20);
            this.Tnumber.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Описание";
            // 
            // TcountPeople
            // 
            this.TcountPeople.Location = new System.Drawing.Point(80, 329);
            this.TcountPeople.Name = "TcountPeople";
            this.TcountPeople.Size = new System.Drawing.Size(132, 20);
            this.TcountPeople.TabIndex = 14;
            // 
            // minprice
            // 
            this.minprice.AutoSize = true;
            this.minprice.Location = new System.Drawing.Point(304, 117);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(62, 13);
            this.minprice.TabIndex = 5;
            this.minprice.Text = "Стоимость";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(80, 151);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 20);
            this.name.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер цеха";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество человек";
            // 
            // Tname
            // 
            this.Tname.AutoSize = true;
            this.Tname.Location = new System.Drawing.Point(77, 117);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(83, 13);
            this.Tname.TabIndex = 9;
            this.Tname.Text = "Наименование";
            // 
            // Tarticul
            // 
            this.Tarticul.Location = new System.Drawing.Point(80, 71);
            this.Tarticul.Name = "Tarticul";
            this.Tarticul.Size = new System.Drawing.Size(132, 20);
            this.Tarticul.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Артикул";
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(12, 381);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(142, 30);
            this.Bdelete.TabIndex = 18;
            this.Bdelete.Text = "Удалить";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Изображение";
            // 
            // Tpicture
            // 
            this.Tpicture.Location = new System.Drawing.Point(307, 320);
            this.Tpicture.Name = "Tpicture";
            this.Tpicture.Size = new System.Drawing.Size(132, 20);
            this.Tpicture.TabIndex = 11;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 422);
            this.Controls.Add(this.Bdelete);
            this.Controls.Add(this.Badd);
            this.Controls.Add(this.Ctypes);
            this.Controls.Add(this.Tpicture);
            this.Controls.Add(this.Tmaterial);
            this.Controls.Add(this.Tminprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tnumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TcountPeople);
            this.Controls.Add(this.minprice);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tname);
            this.Controls.Add(this.Tarticul);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Editor";
            this.Text = "Изменение продукции";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Badd;
        private System.Windows.Forms.ComboBox Ctypes;
        private System.Windows.Forms.TextBox Tmaterial;
        private System.Windows.Forms.TextBox Tminprice;
        private System.Windows.Forms.TextBox Tnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TcountPeople;
        private System.Windows.Forms.Label minprice;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tname;
        private System.Windows.Forms.TextBox Tarticul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tpicture;
    }
}