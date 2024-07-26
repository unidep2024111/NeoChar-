namespace taxis
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            lblmensaje = new Label();
            lbltipoUsuario = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.BackColor = SystemColors.AppWorkspace;
            lblmensaje.Location = new Point(347, 111);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 15);
            lblmensaje.TabIndex = 0;
            lblmensaje.Click += label1_Click;
            // 
            // lbltipoUsuario
            // 
            lbltipoUsuario.AutoSize = true;
            lbltipoUsuario.BorderStyle = BorderStyle.FixedSingle;
            lbltipoUsuario.Location = new Point(380, 87);
            lbltipoUsuario.Name = "lbltipoUsuario";
            lbltipoUsuario.Size = new Size(49, 17);
            lbltipoUsuario.TabIndex = 1;
            lbltipoUsuario.Text = "Usuario";
            lbltipoUsuario.Click += lbltipoUsuario_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Sans Serif Collection", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(71, 126);
            button1.Name = "button1";
            button1.Size = new Size(154, 139);
            button1.TabIndex = 2;
            button1.Text = "Registro de Taxi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 255, 255);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(35, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 267);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(287, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(246, 267);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(297, 148);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(224, 194);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(44, -1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(457, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 394);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(lbltipoUsuario);
            Controls.Add(lblmensaje);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "Usuario";
            Text = "Usuario";
            Load += Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmensaje;
        private Label lbltipoUsuario;
        private Button button1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}