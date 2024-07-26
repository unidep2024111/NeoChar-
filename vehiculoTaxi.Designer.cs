namespace taxis
{
    partial class vehiculoTaxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vehiculoTaxi));
            textGremio = new TextBox();
            textMatricula = new TextBox();
            textNombre = new TextBox();
            textLicencia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textGremio
            // 
            textGremio.Location = new Point(124, 96);
            textGremio.Name = "textGremio";
            textGremio.Size = new Size(100, 23);
            textGremio.TabIndex = 0;
            // 
            // textMatricula
            // 
            textMatricula.Location = new Point(124, 137);
            textMatricula.Name = "textMatricula";
            textMatricula.Size = new Size(100, 23);
            textMatricula.TabIndex = 1;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(124, 182);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 2;
            // 
            // textLicencia
            // 
            textLicencia.Location = new Point(124, 228);
            textLicencia.Name = "textLicencia";
            textLicencia.Size = new Size(100, 23);
            textLicencia.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 99);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Gremio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 145);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 190);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 236);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 7;
            label4.Text = "Num.de licencia";
            // 
            // button1
            // 
            button1.Location = new Point(244, 342);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(386, 343);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(642, 433);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(230, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 81);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(226, 231);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(230, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(399, 255);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // vehiculoTaxi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 426);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textLicencia);
            Controls.Add(textNombre);
            Controls.Add(textMatricula);
            Controls.Add(textGremio);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            MaximizeBox = false;
            Name = "vehiculoTaxi";
            Text = "vehiculoTaxi";
            Load += vehiculoTaxi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textGremio;
        private TextBox textMatricula;
        private TextBox textNombre;
        private TextBox textLicencia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private DataGridView dataGridView1;
    }
}