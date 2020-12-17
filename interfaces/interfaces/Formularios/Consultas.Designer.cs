namespace interfaces
{
    partial class Consultas
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
            this.txtTema1 = new System.Windows.Forms.TextBox();
            this.gb_Consulta = new System.Windows.Forms.GroupBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtTema3 = new System.Windows.Forms.TextBox();
            this.txtTema2 = new System.Windows.Forms.TextBox();
            this.cbContenido = new System.Windows.Forms.CheckBox();
            this.cbTema3 = new System.Windows.Forms.CheckBox();
            this.cbTema2 = new System.Windows.Forms.CheckBox();
            this.cbTema1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gb_Consulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTema1
            // 
            this.txtTema1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTema1.Location = new System.Drawing.Point(115, 53);
            this.txtTema1.Name = "txtTema1";
            this.txtTema1.Size = new System.Drawing.Size(389, 23);
            this.txtTema1.TabIndex = 0;
            // 
            // gb_Consulta
            // 
            this.gb_Consulta.Controls.Add(this.txtContenido);
            this.gb_Consulta.Controls.Add(this.txtTema3);
            this.gb_Consulta.Controls.Add(this.txtTema2);
            this.gb_Consulta.Controls.Add(this.cbContenido);
            this.gb_Consulta.Controls.Add(this.cbTema3);
            this.gb_Consulta.Controls.Add(this.cbTema2);
            this.gb_Consulta.Controls.Add(this.cbTema1);
            this.gb_Consulta.Controls.Add(this.label1);
            this.gb_Consulta.Controls.Add(this.btnBuscar);
            this.gb_Consulta.Controls.Add(this.txtTema1);
            this.gb_Consulta.Location = new System.Drawing.Point(12, 3);
            this.gb_Consulta.Name = "gb_Consulta";
            this.gb_Consulta.Size = new System.Drawing.Size(692, 345);
            this.gb_Consulta.TabIndex = 3;
            this.gb_Consulta.TabStop = false;
            // 
            // txtContenido
            // 
            this.txtContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtContenido.Location = new System.Drawing.Point(115, 183);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContenido.Size = new System.Drawing.Size(549, 135);
            this.txtContenido.TabIndex = 14;
            // 
            // txtTema3
            // 
            this.txtTema3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTema3.Location = new System.Drawing.Point(115, 138);
            this.txtTema3.Name = "txtTema3";
            this.txtTema3.Size = new System.Drawing.Size(389, 23);
            this.txtTema3.TabIndex = 13;
            // 
            // txtTema2
            // 
            this.txtTema2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTema2.Location = new System.Drawing.Point(115, 93);
            this.txtTema2.Name = "txtTema2";
            this.txtTema2.Size = new System.Drawing.Size(389, 23);
            this.txtTema2.TabIndex = 12;
            // 
            // cbContenido
            // 
            this.cbContenido.AutoSize = true;
            this.cbContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbContenido.Location = new System.Drawing.Point(18, 185);
            this.cbContenido.Name = "cbContenido";
            this.cbContenido.Size = new System.Drawing.Size(91, 21);
            this.cbContenido.TabIndex = 11;
            this.cbContenido.Text = "Contenido";
            this.cbContenido.UseVisualStyleBackColor = true;
            this.cbContenido.CheckedChanged += new System.EventHandler(this.cbContenido_CheckedChanged);
            // 
            // cbTema3
            // 
            this.cbTema3.AutoSize = true;
            this.cbTema3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTema3.Location = new System.Drawing.Point(18, 140);
            this.cbTema3.Name = "cbTema3";
            this.cbTema3.Size = new System.Drawing.Size(75, 21);
            this.cbTema3.TabIndex = 10;
            this.cbTema3.Text = "Tema 3";
            this.cbTema3.UseVisualStyleBackColor = true;
            this.cbTema3.CheckedChanged += new System.EventHandler(this.cbTema3_CheckedChanged);
            // 
            // cbTema2
            // 
            this.cbTema2.AutoSize = true;
            this.cbTema2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTema2.Location = new System.Drawing.Point(18, 95);
            this.cbTema2.Name = "cbTema2";
            this.cbTema2.Size = new System.Drawing.Size(75, 21);
            this.cbTema2.TabIndex = 9;
            this.cbTema2.Text = "Tema 2";
            this.cbTema2.UseVisualStyleBackColor = true;
            this.cbTema2.CheckedChanged += new System.EventHandler(this.cbTema2_CheckedChanged);
            // 
            // cbTema1
            // 
            this.cbTema1.AutoSize = true;
            this.cbTema1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbTema1.Location = new System.Drawing.Point(18, 55);
            this.cbTema1.Name = "cbTema1";
            this.cbTema1.Size = new System.Drawing.Size(75, 21);
            this.cbTema1.TabIndex = 8;
            this.cbTema1.Text = "Tema 1";
            this.cbTema1.UseVisualStyleBackColor = true;
            this.cbTema1.CheckedChanged += new System.EventHandler(this.cbTema1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Criterio de búsqueda:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBuscar.Location = new System.Drawing.Point(554, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 40);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVolver.Location = new System.Drawing.Point(12, 363);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(139, 43);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 422);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gb_Consulta);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.gb_Consulta.ResumeLayout(false);
            this.gb_Consulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTema1;
        private System.Windows.Forms.GroupBox gb_Consulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtTema3;
        private System.Windows.Forms.TextBox txtTema2;
        private System.Windows.Forms.CheckBox cbContenido;
        private System.Windows.Forms.CheckBox cbTema3;
        private System.Windows.Forms.CheckBox cbTema2;
        private System.Windows.Forms.CheckBox cbTema1;
    }
}