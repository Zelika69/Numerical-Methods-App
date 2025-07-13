using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosNumericosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTolerancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void GraficarFuncion(Func<double, double> f, double xMin, double xMax, double raiz)
        {
            // Configuración del gráfico
            Bitmap bmp = new Bitmap(picGrafico.Width, picGrafico.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Escalas (ajustar según tus datos)
                float scaleX = picGrafico.Width / (float)(xMax - xMin);
                float scaleY = picGrafico.Height / 2f;
                float centerY = picGrafico.Height / 2f;

                // Ejes X e Y
                g.DrawLine(Pens.Black, 0, centerY, picGrafico.Width, centerY); // Eje X
                g.DrawLine(Pens.Black, (float)(-xMin * scaleX), 0, (float)(-xMin * scaleX), picGrafico.Height); // Eje Y

                // Graficar función
                List<PointF> puntos = new List<PointF>();
                for (double x = xMin; x <= xMax; x += 0.01)
                {
                    float pixelX = (float)((x - xMin) * scaleX);
                    float pixelY = centerY - (float)(f(x) * scaleY / 10); // Ajustar escala Y
                    puntos.Add(new PointF(pixelX, pixelY));
                }
                g.DrawLines(Pens.Blue, puntos.ToArray());

                // Marcar raíz encontrada
                if (!double.IsNaN(raiz))
                {
                    float rootX = (float)((raiz - xMin) * scaleX);
                    g.FillEllipse(Brushes.Red, rootX - 3, centerY - 3, 6, 6);
                }

                picGrafico.Image = bmp;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores de los controles
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double tolerancia = double.Parse(cmbTolerancia.SelectedItem.ToString());

                // Definir la función (ejemplo: x^2 - 2)
                Func<double, double> f = x => Math.Pow(x, 2) - 2;

                // Llamar al método de bisección
                double raiz = Biseccion(f, a, b, tolerancia, 100);

                // Mostrar resultados
                rtbResultados.Text = $"Raíz encontrada: {raiz.ToString("F6")}\n";
                rtbResultados.AppendText($"Tolerancia usada: {tolerancia}\n");
                GraficarFuncion(f, a, b, raiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método de Bisección (implementación)
        private double Biseccion(Func<double, double> f, double a, double b, double tolerancia, int maxIteraciones)
        {
            for (int i = 0; i < maxIteraciones; i++)
            {
                double c = (a + b) / 2;
                if (Math.Abs(f(c)) < tolerancia) return c;
                if (f(a) * f(c) < 0) b = c;
                else a = c;
            }
            return (a + b) / 2;
        }
    }
}
