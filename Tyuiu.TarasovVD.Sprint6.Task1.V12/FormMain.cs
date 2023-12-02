using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TarasovVD.Sprint6.Task1.V12.Lib;

namespace Tyuiu.TarasovVD.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_TVD.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_TVD.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_TVD.Text = "";
                textBoxResult_TVD.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_TVD.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_TVD.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_TVD.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_TVD.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_TVD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-2 Тарасов Владислав Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
