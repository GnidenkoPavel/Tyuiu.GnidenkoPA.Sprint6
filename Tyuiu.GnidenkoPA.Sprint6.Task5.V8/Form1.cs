using System;
using System.Windows.Forms;
using Tyuiu.GnidenkoPA.Sprint6.Task5.V8.Lib;

namespace Tyuiu.GnidenkoPA.Sprint6.Task5.V8
{
    public partial class Form1 : Form
    {
        private DataService ds = new DataService();
        private DataGridView dataGridView1;
        private Button buttonDone;
        private Button buttonOpenFile;
        private TextBox textBoxPath;
        
        private dynamic chart1; 

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Спринт 6 | Таск 5 | Вариант 8 | Гниденко П.А.";
            this.Size = new System.Drawing.Size(1000, 600);

            textBoxPath = new TextBox
            {
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(500, 23),
                Text = @"C:\DataSprint5\InputFileTask5V8.txt"
            };
            this.Controls.Add(textBoxPath);

            buttonOpenFile = new Button
            {
                Location = new System.Drawing.Point(520, 10),
                Size = new System.Drawing.Size(100, 27),
                Text = "Открыть файл"
            };
            buttonOpenFile.Click += ButtonOpenFile_Click;
            this.Controls.Add(buttonOpenFile);

            buttonDone = new Button
            {
                Location = new System.Drawing.Point(630, 10),
                Size = new System.Drawing.Size(100, 27),
                Text = "Выполнить"
            };
            buttonDone.Click += ButtonDone_Click;
            this.Controls.Add(buttonDone);

            dataGridView1 = new DataGridView
            {
                Location = new System.Drawing.Point(12, 50),
                Size = new System.Drawing.Size(960, 250),
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                ColumnCount = 1
            };
            dataGridView1.Columns[0].HeaderText = "Числа < 0";
            dataGridView1.Columns[0].Width = 200;
            this.Controls.Add(dataGridView1);

            
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = openFileDialog.FileName;
            }
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                double[] numbers = ds.LoadFromDataFile(textBoxPath.Text);

                foreach (double num in numbers)
                {
                    dataGridView1.Rows.Add(num.ToString("F3"));
                }

                MessageBox.Show($"Обработано чисел: {numbers.Length}", "Готово");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }
    }
}