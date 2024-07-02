namespace Practica_paracial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarCandidato = new System.Windows.Forms.Button();
            this.btnVerListado = new System.Windows.Forms.Button();
            this.btnVerPromedio = new System.Windows.Forms.Button();
            this.btnVerAprobados = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.listBoxResumen = new System.Windows.Forms.ListBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCandidato
            // 
            this.btnAgregarCandidato.Location = new System.Drawing.Point(60, 39);
            this.btnAgregarCandidato.Name = "btnAgregarCandidato";
            this.btnAgregarCandidato.Size = new System.Drawing.Size(117, 63);
            this.btnAgregarCandidato.TabIndex = 0;
            this.btnAgregarCandidato.Text = "Agregar Candidato";
            this.btnAgregarCandidato.UseVisualStyleBackColor = true;
            this.btnAgregarCandidato.Click += new System.EventHandler(this.btnAgregarCandidato_Click);
            // 
            // btnVerListado
            // 
            this.btnVerListado.Location = new System.Drawing.Point(218, 39);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(117, 63);
            this.btnVerListado.TabIndex = 1;
            this.btnVerListado.Text = "Ver Listado";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // btnVerPromedio
            // 
            this.btnVerPromedio.Location = new System.Drawing.Point(436, 39);
            this.btnVerPromedio.Name = "btnVerPromedio";
            this.btnVerPromedio.Size = new System.Drawing.Size(117, 63);
            this.btnVerPromedio.TabIndex = 2;
            this.btnVerPromedio.Text = "Ver Promedio";
            this.btnVerPromedio.UseVisualStyleBackColor = true;
            this.btnVerPromedio.Click += new System.EventHandler(this.btnVerPromedio_Click);
            // 
            // btnVerAprobados
            // 
            this.btnVerAprobados.Location = new System.Drawing.Point(436, 234);
            this.btnVerAprobados.Name = "btnVerAprobados";
            this.btnVerAprobados.Size = new System.Drawing.Size(117, 63);
            this.btnVerAprobados.TabIndex = 3;
            this.btnVerAprobados.Text = "Ver Aprobados";
            this.btnVerAprobados.UseVisualStyleBackColor = true;
            this.btnVerAprobados.Click += new System.EventHandler(this.btnVerAprobados_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(221, 30);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(108, 27);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNro);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(59, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero";
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(109, 32);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(84, 22);
            this.txtNro.TabIndex = 8;
            this.txtNro.Text = "txtNro";
            // 
            // listBoxResumen
            // 
            this.listBoxResumen.FormattingEnabled = true;
            this.listBoxResumen.ItemHeight = 16;
            this.listBoxResumen.Location = new System.Drawing.Point(60, 111);
            this.listBoxResumen.Name = "listBoxResumen";
            this.listBoxResumen.Size = new System.Drawing.Size(275, 196);
            this.listBoxResumen.TabIndex = 6;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(446, 192);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(84, 22);
            this.txtNota.TabIndex = 7;
            this.txtNota.Text = "txtNota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nota Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.listBoxResumen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerAprobados);
            this.Controls.Add(this.btnVerPromedio);
            this.Controls.Add(this.btnVerListado);
            this.Controls.Add(this.btnAgregarCandidato);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCandidato;
        private System.Windows.Forms.Button btnVerListado;
        private System.Windows.Forms.Button btnVerPromedio;
        private System.Windows.Forms.Button btnVerAprobados;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.ListBox listBoxResumen;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
    }
}

