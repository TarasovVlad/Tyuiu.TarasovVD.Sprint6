using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TarasovVD.Sprint6.Task2.V8.Lib;

namespace Tyuiu.TarasovVD.Sprint6.Task2.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-2 Тарасов Владислав Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_TVD.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_TVD.Text);

                

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_TVD.Titles.Add("График функции");
                this.chartFunction_TVD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_TVD.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_TVD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_TVD.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_TVD_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_TVD.BackColor = Color.Red;
        }

        private void buttonDone_TVD_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_TVD.BackColor = Color.Green;
        }

        private void buttonDone_TVD_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_TVD.BackColor = Color.Blue;
        }
    }
}
