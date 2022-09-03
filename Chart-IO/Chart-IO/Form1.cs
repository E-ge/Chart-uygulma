using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Chart_IO
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var kategori in chart1.Series)
            {
                kategori.Points.Clear();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double mevcutdeger = this.chart1.Series[comboBox1.Text].Points[0].YValues[0];
            
            if(mevcutdeger==0)
            {
                chart1.Series[comboBox1.Text].Points.Clear();
                this.chart1.Series[comboBox1.Text].Points.AddXY("Öğrenci Sayısı", Convert.ToDouble(numericUpDown1.Value));
            }
            else
            {
                DialogResult tus = MessageBox.Show("Üzerine ekleme yapılsın mı?", "Grafik Çiz", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(tus==DialogResult.Yes)
                {
                    this.chart1.Series[comboBox1.Text].Points[0].YValues[0] += Convert.ToDouble(numericUpDown1.Value);
                    double deger = this.chart1.Series[comboBox1.Text].Points[0].YValues[0];
                    chart1.Series[comboBox1.Text].Points.Clear();
                    this.chart1.Series[comboBox1.Text].Points.AddXY("Öğrenci Sayısı", deger);
                }
            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var kategori in chart1.Series)
            {
                kategori.Points.AddXY("Öğrenci Sayısı", 0);

            }
        }
    }
}
