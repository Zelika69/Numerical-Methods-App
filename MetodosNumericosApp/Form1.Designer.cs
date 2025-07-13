namespace MetodosNumericosApp
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.cmbTolerancia = new System.Windows.Forms.ComboBox();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.picGrafico = new System.Windows.Forms.PictureBox();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(83, 71);
            this.txtA.MaxLength = 100;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(83, 108);
            this.txtB.MaxLength = 100;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 78);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Valor A:";
            this.lblA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 115);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Valor B:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(63, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(83, 26);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tolerancia:";
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(6, 29);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(51, 13);
            this.lblFuncion.TabIndex = 9;
            this.lblFuncion.Text = "Función: ";
            // 
            // rtbResultados
            // 
            this.rtbResultados.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbResultados.Location = new System.Drawing.Point(687, 0);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(320, 473);
            this.rtbResultados.TabIndex = 10;
            this.rtbResultados.Text = "";
            // 
            // cmbTolerancia
            // 
            this.cmbTolerancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTolerancia.FormattingEnabled = true;
            this.cmbTolerancia.Items.AddRange(new object[] {
            "0.1",
            "0.01",
            "0.001",
            "0.0001"});
            this.cmbTolerancia.Location = new System.Drawing.Point(83, 150);
            this.cmbTolerancia.Name = "cmbTolerancia";
            this.cmbTolerancia.Size = new System.Drawing.Size(100, 21);
            this.cmbTolerancia.TabIndex = 11;
            this.cmbTolerancia.SelectedIndexChanged += new System.EventHandler(this.cmbTolerancia_SelectedIndexChanged);
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.lblFuncion);
            this.gbParametros.Controls.Add(this.cmbTolerancia);
            this.gbParametros.Controls.Add(this.btnCalcular);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.txtFuncion);
            this.gbParametros.Controls.Add(this.txtA);
            this.gbParametros.Controls.Add(this.lblA);
            this.gbParametros.Controls.Add(this.lblB);
            this.gbParametros.Controls.Add(this.txtB);
            this.gbParametros.Location = new System.Drawing.Point(37, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(201, 281);
            this.gbParametros.TabIndex = 12;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // picGrafico
            // 
            this.picGrafico.Location = new System.Drawing.Point(268, 21);
            this.picGrafico.Name = "picGrafico";
            this.picGrafico.Size = new System.Drawing.Size(400, 300);
            this.picGrafico.TabIndex = 13;
            this.picGrafico.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 473);
            this.Controls.Add(this.picGrafico);
            this.Controls.Add(this.gbParametros);
            this.Controls.Add(this.rtbResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.ComboBox cmbTolerancia;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.PictureBox picGrafico;
    }
}

