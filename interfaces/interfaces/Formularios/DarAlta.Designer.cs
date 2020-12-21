namespace interfaces
{
    partial class Dar_Alta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dar_Alta));
            this.btn_DarAlta = new System.Windows.Forms.Button();
            this.tb_Tema3 = new System.Windows.Forms.TextBox();
            this.tb_Tema1 = new System.Windows.Forms.TextBox();
            this.tb_Tema2 = new System.Windows.Forms.TextBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.tb_Contenido = new System.Windows.Forms.TextBox();
            this.tb_Orden = new System.Windows.Forms.TextBox();
            this.tb_Carpeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gb_Alta = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb_Alta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DarAlta
            // 
            this.btn_DarAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_DarAlta.Location = new System.Drawing.Point(424, 421);
            this.btn_DarAlta.Name = "btn_DarAlta";
            this.btn_DarAlta.Size = new System.Drawing.Size(149, 42);
            this.btn_DarAlta.TabIndex = 6;
            this.btn_DarAlta.Text = "Alta";
            this.btn_DarAlta.UseVisualStyleBackColor = true;
            this.btn_DarAlta.Click += new System.EventHandler(this.btn_DarAlta_Click);
            // 
            // tb_Tema3
            // 
            this.tb_Tema3.Enabled = false;
            this.tb_Tema3.Location = new System.Drawing.Point(191, 344);
            this.tb_Tema3.Name = "tb_Tema3";
            this.tb_Tema3.Size = new System.Drawing.Size(346, 20);
            this.tb_Tema3.TabIndex = 5;
            // 
            // tb_Tema1
            // 
            this.tb_Tema1.Enabled = false;
            this.tb_Tema1.Location = new System.Drawing.Point(191, 244);
            this.tb_Tema1.Name = "tb_Tema1";
            this.tb_Tema1.Size = new System.Drawing.Size(346, 20);
            this.tb_Tema1.TabIndex = 3;
            this.tb_Tema1.TextChanged += new System.EventHandler(this.tb_Tema1_TextChanged);
            // 
            // tb_Tema2
            // 
            this.tb_Tema2.Enabled = false;
            this.tb_Tema2.Location = new System.Drawing.Point(191, 294);
            this.tb_Tema2.Name = "tb_Tema2";
            this.tb_Tema2.Size = new System.Drawing.Size(346, 20);
            this.tb_Tema2.TabIndex = 4;
            this.tb_Tema2.TextChanged += new System.EventHandler(this.tb_Tema2_TextChanged);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.CustomFormat = "dd/MM/yyyy";
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha.Location = new System.Drawing.Point(191, 115);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(346, 20);
            this.dtp_Fecha.TabIndex = 1;
            this.dtp_Fecha.ValueChanged += new System.EventHandler(this.dtp_Fecha_ValueChanged);
            this.dtp_Fecha.Leave += new System.EventHandler(this.dtp_Fecha_Leave);
            // 
            // tb_Contenido
            // 
            this.tb_Contenido.Enabled = false;
            this.tb_Contenido.Location = new System.Drawing.Point(191, 163);
            this.tb_Contenido.Multiline = true;
            this.tb_Contenido.Name = "tb_Contenido";
            this.tb_Contenido.Size = new System.Drawing.Size(346, 62);
            this.tb_Contenido.TabIndex = 2;
            this.tb_Contenido.TextChanged += new System.EventHandler(this.tb_Contenido_TextChanged);
            // 
            // tb_Orden
            // 
            this.tb_Orden.Location = new System.Drawing.Point(191, 71);
            this.tb_Orden.Name = "tb_Orden";
            this.tb_Orden.ReadOnly = true;
            this.tb_Orden.Size = new System.Drawing.Size(346, 20);
            this.tb_Orden.TabIndex = 13;
            // 
            // tb_Carpeta
            // 
            this.tb_Carpeta.Location = new System.Drawing.Point(191, 29);
            this.tb_Carpeta.Name = "tb_Carpeta";
            this.tb_Carpeta.ReadOnly = true;
            this.tb_Carpeta.Size = new System.Drawing.Size(346, 20);
            this.tb_Carpeta.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Carpeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Orden Carpeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contenido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Clave 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Clave 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Clave 3";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Aceptar.Location = new System.Drawing.Point(424, 421);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(149, 42);
            this.btn_Aceptar.TabIndex = 26;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalir.Location = new System.Drawing.Point(12, 421);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 42);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gb_Alta
            // 
            this.gb_Alta.Controls.Add(this.tb_Carpeta);
            this.gb_Alta.Controls.Add(this.label1);
            this.gb_Alta.Controls.Add(this.tb_Orden);
            this.gb_Alta.Controls.Add(this.label7);
            this.gb_Alta.Controls.Add(this.tb_Contenido);
            this.gb_Alta.Controls.Add(this.label6);
            this.gb_Alta.Controls.Add(this.dtp_Fecha);
            this.gb_Alta.Controls.Add(this.label5);
            this.gb_Alta.Controls.Add(this.tb_Tema2);
            this.gb_Alta.Controls.Add(this.label4);
            this.gb_Alta.Controls.Add(this.tb_Tema1);
            this.gb_Alta.Controls.Add(this.label3);
            this.gb_Alta.Controls.Add(this.tb_Tema3);
            this.gb_Alta.Controls.Add(this.label2);
            this.gb_Alta.Location = new System.Drawing.Point(12, 12);
            this.gb_Alta.Name = "gb_Alta";
            this.gb_Alta.Size = new System.Drawing.Size(561, 387);
            this.gb_Alta.TabIndex = 28;
            this.gb_Alta.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(167, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Dar_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gb_Alta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_DarAlta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dar_Alta";
            this.Text = "Alta";
            this.gb_Alta.ResumeLayout(false);
            this.gb_Alta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DarAlta;
        private System.Windows.Forms.TextBox tb_Tema3;
        private System.Windows.Forms.TextBox tb_Tema1;
        private System.Windows.Forms.TextBox tb_Tema2;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.TextBox tb_Contenido;
        private System.Windows.Forms.TextBox tb_Orden;
        private System.Windows.Forms.TextBox tb_Carpeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gb_Alta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}