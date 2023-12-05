using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TarasovVD.Sprint6.Task7.V5.Lib;
using System.IO;

namespace Tyuiu.TarasovVD.Sprint6.Task7.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_TVD.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_TVD.Filter = "Значения, разделённые запятыми (*.csv)|*.csv|Все файлы(*.*)|(*.*)";
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }
        private void buttonOpenFile_TVD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_TVD.ShowDialog();
            openFilePath = openFileDialogTask_TVD.FileName;
            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInPutData_TVD.ColumnCount = colums;
            dataGridViewInPutData_TVD.RowCount = rows;
            dataGridViewOutPutData_TVD.ColumnCount = colums;
            dataGridViewOutPutData_TVD.RowCount = rows;
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPutData_TVD.Columns[i].Width = 25;
                dataGridViewOutPutData_TVD.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPutData_TVD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_TVD.Enabled = true;
                
                
        }

        private void buttonDone_TVD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutPutData_TVD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_TVD.Enabled = true;
        }

        private void buttonSaveFile_TVD_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_TVD.FileName = "OutPutFileTask7V5.csv";
            saveFileDialogMatrix_TVD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_TVD.ShowDialog();
            string path = saveFileDialogMatrix_TVD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPutData_TVD.RowCount;
            int columns = dataGridViewOutPutData_TVD.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if ( j != columns - 1)
                    {
                        str = str + dataGridViewOutPutData_TVD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutData_TVD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }    
        }

        private void buttonHelp_TVD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TVD.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TVD.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TVD.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_TVD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TVD.ToolTipTitle = "Справка";
        }
    }
}
