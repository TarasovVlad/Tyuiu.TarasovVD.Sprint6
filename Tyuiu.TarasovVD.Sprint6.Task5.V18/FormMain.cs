using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TarasovVD.Sprint6.Task5.V18.Lib;

namespace Tyuiu.TarasovVD.Sprint6.Task5.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\User\source\repos\Tyuiu.TarasovVD.Sprint6\Tyuiu.TarasovVD.Sprint6.Task5.V18\bin\Debug\InPutFileTask5V18.txt";
        private void buttonHelp_TVD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-2 Тарасов Владислав Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_TVD_Click(object sender, EventArgs e)
        {
            dataGridViewResult_TVD.ColumnCount = 2;
            dataGridViewResult_TVD.Columns[0].Width = 20;
            dataGridViewResult_TVD.Columns[1].Width = 50;
            this.chartDiag_TVD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_TVD.ChartAreas[0].AxisY.Title = "Ось Y";
            chartDiag_TVD.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_TVD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_TVD.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_TVD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
