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
            this.textA = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.cmbTolerancia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Location = new System.Drawing.Point(114, 83);
            this.textA.MaxLength = 100;
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(100, 20);
            this.textA.TabIndex = 0;
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(114, 152);
            this.textB.MaxLength = 100;
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 20);
            this.textB.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(41, 90);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Valor A:";
            this.lblA.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(41, 159);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Valor B:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(72, 255);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(34, 205);
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
            this.rtbResultados.Location = new System.Drawing.Point(288, 0);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.Size = new System.Drawing.Size(332, 305);
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
            this.cmbTolerancia.Location = new System.Drawing.Point(114, 202);
            this.cmbTolerancia.Name = "cmbTolerancia";
            this.cmbTolerancia.Size = new System.Drawing.Size(100, 21);
            this.cmbTolerancia.TabIndex = 11;
            this.cmbTolerancia.SelectedIndexChanged += new System.EventHandler(this.cmbTolerancia_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFuncion);
            this.groupBox1.Controls.Add(this.txtFuncion);
            this.groupBox1.Location = new System.Drawing.Point(257, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 281);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTolerancia);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.textA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.ComboBox cmbTolerancia;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

