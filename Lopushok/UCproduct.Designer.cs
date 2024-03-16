namespace Lopushok
{
    partial class UCproduct
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.articul = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.minprice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.type.Location = new System.Drawing.Point(190, 18);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(36, 20);
            this.type.TabIndex = 1;
            this.type.Text = "Тип";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(325, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "|";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(366, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(122, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Наименование";
            // 
            // articul
            // 
            this.articul.AutoSize = true;
            this.articul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.articul.Location = new System.Drawing.Point(190, 48);
            this.articul.Name = "articul";
            this.articul.Size = new System.Drawing.Size(72, 20);
            this.articul.TabIndex = 1;
            this.articul.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(190, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Материалы:";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.material.Location = new System.Drawing.Point(311, 81);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(93, 20);
            this.material.TabIndex = 1;
            this.material.Text = "материал1";
            // 
            // minprice
            // 
            this.minprice.AutoSize = true;
            this.minprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.minprice.Location = new System.Drawing.Point(534, 18);
            this.minprice.Name = "minprice";
            this.minprice.Size = new System.Drawing.Size(95, 22);
            this.minprice.TabIndex = 1;
            this.minprice.Text = "Стоимость";
            // 
            // UCproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.name);
            this.Controls.Add(this.minprice);
            this.Controls.Add(this.material);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCproduct";
            this.Size = new System.Drawing.Size(662, 124);
            this.Click += new System.EventHandler(this.UCproduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label articul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label minprice;
    }
}
