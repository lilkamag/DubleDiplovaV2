using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Net;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp19
{
    public partial class Form2 : Form
    {
        public class GridText
        {
            public string[,] Text { get; set; }
        }
        public class GridText3
        {
            public string[,] Text1 { get; set; }
        }
        public class GridText4
        {
            public string[,] Text2 { get; set; }
        }
        public class GridText5
        {
            public string[,] Text3 { get; set; }
        }
        public class GridText6
        {
            public string[,] Text4 { get; set; }
        }
        public class GridText7
        {
            public string[,] Text5 { get; set; }
        }
        public class GridText8
        {
            public string[,] Text6 { get; set; }
        }
        public class GridText9
        {
            public string[,] Text7 { get; set; }
        }
        public class GridText10
        {
            public string[,] Text8 { get; set; }
        }

        public class GridText11
        {
            public string[,] Text9 { get; set; }
        }
        public class GridText12
        {
            public string[,] Text12 { get; set; }
        }
        public Form2()
        {
            InitializeComponent();
            Screen currentScreen = Screen.FromRectangle(Bounds);
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.CellClick += dataGridView2_CellContentClick;
            dataGridView2.RowHeadersVisible = false;
            foreach(DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            textBox47.Visible = false;
            pictureBox80.Visible = false;
            
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox79.Visible = false;
            pictureBox77.Visible = false;

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox78.Visible = false;
            pictureBox73.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;

             
            label46.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label43.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
             
            comboBox6.Visible = false;
            comboBox5.Visible = false;
            comboBox9.Visible = false;
            comboBox2.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            panel12.Visible = false;

            pictureBox55.Visible = false;
            pictureBox56.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            panel1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            panel5.Visible = false;
            dateTimePicker1.Visible = false;
             
            comboBox6.Visible = false;
            comboBox18.Visible = false;
            label18.Visible = false;
            
            label16.Visible = false;
            label15.Visible = false;
            pictureBox24.Visible = false;
            pictureBox23.Visible = false;

            panel11.Visible = false;

            comboBox1.Visible = false;
            comboBox12.Visible = false;
            comboBox15.Visible = false;
            textBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
             
            label41.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label38.Visible = false;

            label50.Visible = false;
            textBox48.Visible = false;
            label32.Visible = false;
             
            label31.Visible = false;
            label30.Visible = false;
            label28.Visible = false;
            panel9.Visible = false;
            pictureBox32.Visible = false;
            pictureBox31.Visible = false;
            dateTimePicker2.Visible = false;
             
            comboBox13.Visible = false;
            comboBox16.Visible = false;
            textBox25.Visible = false;

            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

             
            panel8.Visible = false;
             
            textBox24.Visible = false;
            pictureBox30.Visible = false;
            pictureBox29.Visible = false;

             
            label19.Visible = false;
             
            textBox19.Visible = false;
            pictureBox26.Visible = false;
            pictureBox25.Visible = false;

            pictureBox7.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox52.Visible = false;
            pictureBox51.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;

            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;

            panel6.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            textBox10.Visible = false;
            textBox13.Visible = false;
            comboBox3.Visible = false;
            comboBox8.Visible = false;
            pictureBox22.Visible = false;
            pictureBox21.Visible = false;
            panel4.Visible = false;

             
            label22.Visible = false;
            
            textBox22.Visible = false;
            panel7.Visible = false;
            pictureBox28.Visible = false;
            pictureBox27.Visible = false;

             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;

            label37.Visible = false;
            label36.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label33.Visible = false;
            panel10.Visible = false;
            pictureBox31.Visible = false;
            pictureBox33.Visible = false;
            dateTimePicker3.Visible = false;
            comboBox14.Visible = false;
            comboBox4.Visible = false;
            comboBox17.Visible = false;
            textBox30.Visible = false;

            Size = new Size(431, 217);
            panel2.Location = new Point(1, 1);

            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            dataGridView2.Visible = true;
            dataGridView2.ReadOnly = true;
            dataGridView2.MultiSelect = true;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            dataGridView1.Visible = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = true;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 1 & dataGridView2.Rows.Count != 0)
            {
                try
                {
                    int count = 0;
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (dataGridView2[0, i].Value != null)
                        {
                            for (int j = 0; j < dataGridView2.RowCount; j++)
                            {
                                count++;
                                dataGridView2[0, i].Value = $"{count}";
                                i++;
                            }
                        }
                    }

                    int roms = Convert.ToInt32(textBox1.Text);
                    textBox1.Text = Convert.ToString(roms - 1);

                    for (int l = 0; l <= dataGridView2.Rows.Count - 1; l++)
                    {
                        dataGridView2.Rows[l].Selected = false;
                    }
                    for (int m = 0; m <= dataGridView2.Rows.Count - 1; m++)
                    {
                        if (dataGridView2.Rows[m].Cells[0].FormattedValue.ToString().Contains($"{textBox1.Text}"))
                        {
                            dataGridView2.Rows[m].Selected = true;
                        }
                        else if (textBox1.Text == "-1")
                        {
                            timer1.Enabled = true;
                            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                            {
                                dataGridView2.Rows[i].Selected = false;
                            }
                            textBox1.Text = $"{dataGridView2.Rows.Count}";
                            int j = Convert.ToInt32(textBox1.Text);
                            dataGridView2.Rows[j - 1].Selected = true;
                        }
                    }
                    for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                    {
                        string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                        dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                    }
                }
                catch
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    textBox1.Text = $"{dataGridView2.Rows.Count}";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Для начала добавьте несколько записей в таблицу для того чтобы перейти к преведущей записи в таблице!", "Перейти к преведущей записи");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox3, "При нажатии на кнопку будут отсортированы все записи в таблицы от А до Я.");
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox9, "При нажатии на кнопку будет удалена выбранная строка из таблице.");
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox7, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox6, "При нажатии на кнопку будет выделена последняя запись в таблице.");
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox8, "При нажатии на кнопку будет выделена следующая запись в таблице.");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "При нажатии на кнопку будет выделена преведушая запись в таблице.");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox1, "Поля в котором показана какая строка выбрана пользователем из таблицы.");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(label1, "Здесь будет отброжатся общие количество вех строк из таблицы.");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "При нажатии на кнопку будет выделена первая запись в таблице.");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                if (dataGridView2.CurrentRow != null)
                {
                    int ind = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(ind);
                    dataGridView2.ReadOnly = true;
                    dataGridView2.Refresh();
                    textBox1.Refresh();
                    textBox1.Text = Convert.ToString(dataGridView2.Rows.Count);                   
                }
                else
                {
                    MessageBox.Show("Для удаления строки из таблицы для начало выберите строку которую хотите удалить!", "Удалить запись");
                }                    
            }
            else
            {
                MessageBox.Show("Для начала добавьте запись в таблицу для того чтобы удалить выбранную запись из таблицы!", "Удалить запись");
            }            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int kol = dataGridView2.Rows.Count;
            if (kol != 0)
            {
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2.Sort(dataGridView2.Columns[j], ListSortDirection.Ascending);
                }
                dataGridView2.Refresh();
                pictureBox3.Visible = false;
                pictureBox10.Visible = true;
            }
            else
            {
                MessageBox.Show("Для cортировки таблицы для начало заполните таблицу данными!", "Сортировка таблицы от А до Я");
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox59.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            Size = new Size(488, 141);
            panel1.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);

            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            panel1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (dataGridView2.Rows.Count != 1 & dataGridView2.Rows.Count != 0)
            {
                for (int row = 0; row < dataGridView2.RowCount; row++)
                {
                    count++;
                    if (dataGridView2.Rows[row].Cells[0].Value == null)
                    {
                        dataGridView2.Rows[row].Cells[0].Value = Convert.ToString(count);
                    }
                }

                for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                }
                textBox1.Text = $"{dataGridView2.Rows.Count}";
                int j = Convert.ToInt32(textBox1.Text);
                dataGridView2.Rows[j - 1].Selected = true;
                for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                {
                    string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                    dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Для начала добавьте несколько записей в таблицу для того чтобы перейти к последней записи в таблице!", "Перейти к последней записи");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 1 & dataGridView2.Rows.Count != 0)
            {
                try
                {
                    int count = 0;
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        if (dataGridView2[0, i].Value != null)
                        {
                            for (int j = 0; j < dataGridView2.RowCount; j++)
                            {
                                count++;
                                dataGridView2[0, i].Value = $"{count}";
                                i++;
                            }
                        }
                    }

                    int roms = Convert.ToInt32(textBox1.Text);
                    textBox1.Text = Convert.ToString(roms + 1);
                    int g = dataGridView2.Rows.Count;

                    string rows = Convert.ToString(dataGridView2.Rows.Count);

                    for (int l = 0; l <= dataGridView2.Rows.Count - 1; l++)
                    {
                        dataGridView2.Rows[l].Selected = false;
                    }
                    for (int m = 0; m <= dataGridView2.Rows.Count - 1; m++)
                    {
                        if (dataGridView2.Rows[m].Cells[0].FormattedValue.ToString().Contains($"{textBox1.Text}"))
                        {
                            dataGridView2.Rows[m].Selected = true;
                        }
                        else if (textBox1.Text == $"{g + 1}" & textBox1.Text != rows)
                        {

                            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                            {
                                dataGridView2.Rows[i].Selected = false;
                            }
                            dataGridView2.Rows[0].Selected = true;
                            textBox1.Text = "1";
                        }
                    }
                    for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                    {
                        string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                        dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                    }
                }
                catch
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    textBox1.Text = "1";
                }
            }
            else
            {
                MessageBox.Show("Для начала добавьте несколько записей в таблицу для того чтобы перейти к следующей записи в таблице!", "Перейти к следующей записи");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 1 & dataGridView2.Rows.Count != 0)
            {
                int count = 0;
                for (int row = 0; row < dataGridView2.RowCount; row++)
                {
                    count++;
                    if (dataGridView2.Rows[row].Cells[0].Value == null)
                    {
                        dataGridView2.Rows[row].Cells[0].Value = Convert.ToString(count);
                    }
                }

                for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                {
                    dataGridView2.Rows[i].Selected = false;
                }
                dataGridView2.Rows[0].Selected = true;
                textBox1.Text = "1";
                for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                {
                    string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                    dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Для начала добавьте несколько записей в таблицу для того чтобы перейти к первой записи в таблице!", "Перейти к первой записи");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                pictureBox7.Visible = false;
                pictureBox59.Visible = true;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;

                Size = new Size(488, 141);
                panel1.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                panel1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                pictureBox13.Visible = true;


                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    textBox4.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    textBox5.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    textBox6.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    textBox7.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                }

            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox4, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText gridText = new GridText();
            gridText.Text = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText.Text[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Otvetstvennyye_Litsa.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText.Text);

            fs.Close();


            StreamWriter myWritet = new StreamWriter("Column_Unit_Prinel.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    myWritet.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet.Close();
            }
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox5, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int kol = dataGridView2.Rows.Count;
            if (kol != 0)
            {
                for (int j = 1; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2.Sort(dataGridView2.Columns[j], ListSortDirection.Descending);
                }
                dataGridView2.Refresh();
                pictureBox3.Visible = true;
                pictureBox10.Visible = false;
            }
            else
            {
                MessageBox.Show("Для cортировки таблицы для начало заполните таблицу данными!", "Сортировка таблицы от Я до А");
            }
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox10, "При нажатии на кнопку будут отсортированы все записи в таблицы от Я до А.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox11, "При нажатии на кнопку будет осуществлён поиск по таблице.");
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox2, "Поля для поиск по таблице.");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int kol = dataGridView2.Rows.Count;
            if (kol != 0)
            {
                ExcelObj.Application ExcelApp = new ExcelObj.Application();
                ExcelObj.Workbook ExcelWorkBook;
                ExcelObj.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(Missing.Value);
                ExcelWorkSheet = (ExcelObj.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    ExcelWorkSheet.Cells[i + 1] = dataGridView2.Columns[i].HeaderText;
                }
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        ExcelWorkSheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("Для импорта данных из таблицы в Excel для начало заполните таблицу данными!", "Импорт данных из таблицы в Excel");
            }

        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox12, "При нажатии на кнопку будет произведен импорт таблицы в таблицу Excel.");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count != 1 & dataGridView2.Rows.Count != 0)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Поля для поиска должно быть заполнено!", "Поиск");
                }
                else if (textBox2.Text != "")
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                                {
                                    dataGridView2.Rows[i].Selected = true;
                                    for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                                    {
                                        string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                                        dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                                    }
                                }
                            }
                            else if (dataGridView2.Rows[i].Cells[j].Value == null)
                            {
                                MessageBox.Show("Для поиска по таблице для начало заполните таблицу данными!", "Поиск");
                            }
                        }
                    }
                    if (dataGridView2.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Текст который вы искали не был найден!", "Поиск");
                    }
                }
            }
            else
            {
                MessageBox.Show("Для начала добавьте несколько записей в таблицу для того чтобы осуществить поиск по таблице!", "Поиск");
            }
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox13, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox3, "Поля для добавления кода в таблицу.");
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox4, "Поля для добавления фамилии имени отчества в таблицу.");
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox5, "Поля для добавления должности в таблицу.");
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox6, "Поля для добавления адреса в таблицу.");
        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox7, "Поля для добавления телефона в таблицу.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & textBox4.TextLength != 0 & textBox5.TextLength != 0 & textBox6.TextLength != 0 & textBox7.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text, textBox4.Text, textBox5.Text,  textBox6.Text, textBox7.Text);
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText gridText = new GridText();
                gridText.Text = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText.Text[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Otvetstvennyye_Litsa.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText.Text);

                fs.Close();
                StreamWriter myWritet = new StreamWriter("Column_Unit_Prinel.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }
                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox9.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox5.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                panel1.Location = new Point(2, 187);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                panel1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            switch (textBox1.Text)
            {
                case "0":
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    textBox1.Text = $"{dataGridView2.Rows.Count}";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            try
                            {
                                for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                                {
                                    string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                                    dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    break;
                case "1":                  
                    int count = 0;
                    for (int row = 0; row < dataGridView2.RowCount; row++)
                    {
                        count++;
                        if (dataGridView2.Rows[row].Cells[0].Value != null)
                        {
                            dataGridView2.Rows[row].Cells[0].Value = Convert.ToString(count);
                        }
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            try
                            {
                                for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                                {
                                    string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                                    dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox14, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            pictureBox4.Visible = true;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox4.Visible = true;
            pictureBox79.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox5.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            panel1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var value = dataGridView2.Rows[e.RowIndex].Cells[0].Value;
                if (value != null)
                {
                    textBox1.Text = value.ToString();
                }
            }
            catch
            {

            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Form2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.Rows[i].Selected = false;
            }
        }

        private void Form2_MouseEnter(object sender, EventArgs e)
        {                    
            ToolTip t = new ToolTip();
            Form2 otvetc = new Form2();
            t.SetToolTip(otvetc, "При нажатий на форму выбранные вам колонки и строки в таблице будут очищены.");
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = "Выберите файл Excel для загрузки данных(*.xlsx)|*.xlsx";
                ofd.Title = "Выберите документ для загрузки данных";

                ExcelObj.Application app = new ExcelObj.Application();
                ExcelObj.Workbook workbook;
                ExcelObj.Worksheet NwSheet;
                ExcelObj.Range ShtRange;
                DataTable dt = new DataTable();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    workbook = app.Workbooks.Open(ofd.FileName, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value);

                    NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                    ShtRange = NwSheet.UsedRange;
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        dt.Columns.Add(
                        new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                    }
                    dt.AcceptChanges();

                    string[] columnNames = new String[dt.Columns.Count];
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        columnNames[0] = dt.Columns[i].ColumnName;
                    }

                    for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                            {
                                dr[Cnum - 1] =
                                (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                            }
                        }
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                    }

                    dataGridView2.DataSource = dt;
                    app.Quit();
                }

                int count = 0;
                for (int row = 0; row < dataGridView2.RowCount; row++)
                {
                    count++;
                    if (dataGridView2.Rows[row].Cells[0].Value == null)
                    {
                        dataGridView2.Rows[row].Cells[0].Value = Convert.ToString(count);
                    }
                }
            }
            catch
            {
               
            }          
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Не удается освободить объект!" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public int colihectvo = 0;
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            colihectvo++;
            if (dataGridView2.Rows.Count != 0)
            {
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    for (int j = 0; j <= dataGridView1.Rows.Count - 1; j++)
                    {
                        dataGridView1.Rows[j].Selected = false;
                    }
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    colihectvo = 0;
                }
            }
            else
            {
                MessageBox.Show("Для начала добавьте запись в таблицу для того чтобы распечатать выбранные колонки в таблице!", "Печать");
            }
        }

        private void pictureBox16_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox16, "При нажатии на кнопку будет произведен импорт таблицы Excel в таблицу.");            
        }

        private void pictureBox17_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox17, "При нажатии на кнопку будет произведена печать выборочных колонок и строк в таблице.");
        }

        private void pictureBox17_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void dataGridView2_DragOver(object sender, DragEventArgs e)
        {
          
        }

        private void dataGridView1_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView2_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
          
        }

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Enter)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле поиск по номеру строки запрещено, в поле поиск по номеру строки можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView2.Rows.Count != 1 & dataGridView2.Rows.Count != 0)
                {
                    for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    if (textBox1.Text != "")
                    {
                        for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
                        {
                            if (dataGridView2.Rows[i].Cells[0].Value != null)
                            {
                                if (dataGridView2.Rows[i].Cells[0].FormattedValue.ToString().Contains($"{textBox1.Text}"))
                                {
                                    dataGridView2.Rows[i].Selected = true;
                                    for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                                    {
                                        string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                                        dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                                    }
                                }
                            }
                            else if (dataGridView2.Rows[i].Cells[0].Value == null)
                            {
                                MessageBox.Show("Для поиска по номеру строки по таблице для начало заполните таблицу данными!", "Поиск");
                            }
                        }
                        if (dataGridView2.SelectedRows.Count == 0)
                        {
                            MessageBox.Show("Номер строки не был найден!", "Поиск");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Для начала добавьте несколько записей в таблицу для того чтобы осуществить поиск по строке в таблице!", "Поиск по строке");
                }
            }
        }
        string n = "";
        string name1111111 = "";
        string name2211111 = "";
        string name111 = "";
        string name211 = "";
        string name311 = "";
        string name411 = "";
        string name1111 = "";
        string name2111 = "";
        string name3111 = "";
        string name4111 = "";
        string name5111 = "";
        string name11111 = "";
        string name21111 = "";
        string name31111 = "";
        string name41111 = "";
        string name51111 = "";
        string name61111 = "";
        string name71111 = "";
        private void copy_player_notepad1(object sender, EventArgs e)
        {                   
            if (dataGridView2.Columns.Count == 3)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy1 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                    name1111111 = dataGridView2.Rows[rowToCopy1].Cells[1].Value.ToString();
                    name2211111 = dataGridView2.Rows[rowToCopy1].Cells[2].Value.ToString();
                    Clipboard.SetText($"{ name1111111 }  { name2211111 }");
                } 
                else
                {
                    MessageBox.Show("Для того чтобы скопировать запись для начала добавьте запись в таблицу!", "Копировать");
                }
            }
            else if (dataGridView2.Columns.Count == 5)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy2 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                    name111 = dataGridView2.Rows[rowToCopy2].Cells[1].Value.ToString();
                    name211 = dataGridView2.Rows[rowToCopy2].Cells[2].Value.ToString();
                    name311 = dataGridView2.Rows[rowToCopy2].Cells[3].Value.ToString();
                    name411 = dataGridView2.Rows[rowToCopy2].Cells[4].Value.ToString();
                    Clipboard.SetText($"{ name111 }  { name211 } { name311 } { name411 }");
                }
                else
                {
                    MessageBox.Show("Для того чтобы скопировать запись для начала добавьте запись в таблицу!", "Копировать");
                }
            }
            else if (dataGridView2.Columns.Count == 6)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy3 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));                
                    name1111 = dataGridView2.Rows[rowToCopy3].Cells[1].Value.ToString();
                    name2111 = dataGridView2.Rows[rowToCopy3].Cells[2].Value.ToString();
                    name3111 = dataGridView2.Rows[rowToCopy3].Cells[3].Value.ToString();
                    name4111 = dataGridView2.Rows[rowToCopy3].Cells[4].Value.ToString();
                    name5111 = dataGridView2.Rows[rowToCopy3].Cells[5].Value.ToString();
                    Clipboard.SetText($"{ name1111 }  { name2111 } { name3111 } { name4111 } { name5111 }");
                }
                else
                {
                    MessageBox.Show("Для того чтобы скопировать запись для начала добавьте запись в таблицу!", "Копировать");
                }
            }
            else if (dataGridView2.Columns.Count == 8)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy4 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));                
                    name11111 = dataGridView2.Rows[rowToCopy4].Cells[1].Value.ToString();
                    name21111 = dataGridView2.Rows[rowToCopy4].Cells[2].Value.ToString();
                    name31111 = dataGridView2.Rows[rowToCopy4].Cells[3].Value.ToString();
                    name41111 = dataGridView2.Rows[rowToCopy4].Cells[4].Value.ToString();
                    name51111 = dataGridView2.Rows[rowToCopy4].Cells[5].Value.ToString();
                    name61111 = dataGridView2.Rows[rowToCopy4].Cells[6].Value.ToString();
                    name71111 = dataGridView2.Rows[rowToCopy4].Cells[7].Value.ToString();
                    Clipboard.SetText($"{ name11111 }  { name21111 } { name31111 } { name41111 } { name51111 } { name61111 } { name71111 }");
                }
                else
                {
                    MessageBox.Show("Для того чтобы скопировать запись для начала добавьте запись в таблицу!", "Копировать");
                }
            }
        }
        private void copy_player_notepad2(object sender, EventArgs e)
        {
            if (dataGridView2.Columns.Count == 3)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy1 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                    name1111111 = dataGridView2.Rows[rowToCopy1].Cells[1].Value.ToString();
                    name2211111 = dataGridView2.Rows[rowToCopy1].Cells[2].Value.ToString();
                    int ind = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(ind);
                    Clipboard.SetText($"{ name1111111 }  { name2211111 }");
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вырезать запись для начала добавьте запись в таблицу!", "Вырезать");
                }
            }
            else if (dataGridView2.Columns.Count == 5)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy2 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected)); ;
                    name111 = dataGridView2.Rows[rowToCopy2].Cells[1].Value.ToString();
                    name211 = dataGridView2.Rows[rowToCopy2].Cells[2].Value.ToString();
                    name311 = dataGridView2.Rows[rowToCopy2].Cells[3].Value.ToString();
                    name411 = dataGridView2.Rows[rowToCopy2].Cells[4].Value.ToString();
                    int ind = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(ind);
                    Clipboard.SetText($"{ name111 }  { name211 } { name311 } { name411 }");
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вырезать запись для начала добавьте запись в таблицу!", "Вырезать");
                }
            }
            else if (dataGridView2.Columns.Count == 6)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy3 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                    name1111 = dataGridView2.Rows[rowToCopy3].Cells[1].Value.ToString();
                    name2111 = dataGridView2.Rows[rowToCopy3].Cells[2].Value.ToString();
                    name3111 = dataGridView2.Rows[rowToCopy3].Cells[3].Value.ToString();
                    name4111 = dataGridView2.Rows[rowToCopy3].Cells[4].Value.ToString();
                    name5111 = dataGridView2.Rows[rowToCopy3].Cells[5].Value.ToString();
                    int ind = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(ind);
                    Clipboard.SetText($"{ name1111 }  { name2111 } { name3111 } { name4111 } { name5111 }");
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вырезать запись для начала добавьте запись в таблицу!", "Вырезать");
                }
            }
            else if (dataGridView2.Columns.Count == 8)
            {
                if (dataGridView2.Rows != null)
                {
                    Clipboard.Clear();
                    int rowToCopy4 = Convert.ToInt16(dataGridView2.Rows.GetFirstRow(DataGridViewElementStates.Selected));
                    name11111 = dataGridView2.Rows[rowToCopy4].Cells[1].Value.ToString();
                    name21111 = dataGridView2.Rows[rowToCopy4].Cells[2].Value.ToString();
                    name31111 = dataGridView2.Rows[rowToCopy4].Cells[3].Value.ToString();
                    name41111 = dataGridView2.Rows[rowToCopy4].Cells[4].Value.ToString();
                    name51111 = dataGridView2.Rows[rowToCopy4].Cells[5].Value.ToString();
                    name61111 = dataGridView2.Rows[rowToCopy4].Cells[6].Value.ToString();
                    name71111 = dataGridView2.Rows[rowToCopy4].Cells[7].Value.ToString();
                    int ind = dataGridView2.SelectedCells[0].RowIndex;
                    dataGridView2.Rows.RemoveAt(ind);
                    Clipboard.SetText($"{ name11111 }  { name21111 } { name31111 } { name41111 } { name51111 } { name61111 } { name71111 }");
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вырезать запись для начала добавьте запись в таблицу!", "Вырезать");
                }
            }
        }
        private void copy_player_notepad3(object sender, EventArgs e)
        {
            if (dataGridView2.Columns.Count == 3)
            {
                if (name1111111 != "" & name2211111 != "")
                {
                    dataGridView2.Rows.Add(n, name1111111, name2211111);
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вставить строку в таблицу для начала для начало скопируйте строку из таблицы или же вырежите!", "Вставить строку");
                }
            }
            else if (dataGridView2.Columns.Count == 5)
            {
                if (name111 != "" & name211 != "" & name311 != "" & name411 != "")
                {
                    dataGridView2.Rows.Add(n, name111, name211, name311, name411);
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вставить строку в таблицу для начала для начало скопируйте строку из таблицы или же вырежите!", "Вставить строку");
                }
            }
            else if (dataGridView2.Columns.Count == 6)
            {
                if (name1111 != "" & name2111 != "" & name3111 != "" & name4111 != "" & name5111 != "")
                {
                    dataGridView2.Rows.Add(n, name1111, name2111, name3111, name4111, name5111);
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вставить строку в таблицу для начала для начало скопируйте строку из таблицы или же вырежите!", "Вставить строку");
                }
            }
            else if (dataGridView2.Columns.Count == 8)
            {
                if (name11111 != "" & name21111 != "" & name31111 != "" & name41111 != "" & name51111 != "" & name61111 != "" & name71111 != "")
                {
                    dataGridView2.Rows.Add(n, name11111, name21111, name31111, name41111, name51111, name61111, name71111);
                    dataGridView2.Refresh();
                }
                else
                {
                    MessageBox.Show("Для того чтобы вставить строку в таблицу для начала для начало скопируйте строку из таблицы или же вырежите!", "Вставить строку");
                }
            }
        }
        private void copy_player_notepad4(object sender, EventArgs e)
        {
            if (dataGridView2.Rows != null)
            {
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("Нельзя обновить таблицу в таблице нету не одной записи!", "Обновления таблицы");
            }
        }
        private void copy_player_notepad5(object sender, EventArgs e)
        {
            if (dataGridView2.Rows != null)
            {
                textBox2.Visible = false;
                pictureBox11.Visible = false;
                textBox47.Visible = true;
                pictureBox80.Visible = true;
                textBox2.Clear();
                textBox47.Clear();
            }
            else
            {
                MessageBox.Show("Нельзя отфильтровать таблицу по поиску в таблице нету не одной записи!", "Включить фильтр по поиску в таблице");
            }
        }
        private void copy_player_notepad6(object sender, EventArgs e)
        {
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            textBox2.Visible = true;
            pictureBox11.Visible = true;
            textBox2.Clear();
            textBox47.Clear();
        }
        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               dataGridView1.Rows.Clear();
               int currentMouseOverRow = dataGridView2.HitTest(e.X, e.Y).RowIndex;

               if ((currentMouseOverRow >= 0) && (currentMouseOverRow != dataGridView2.Rows.Count))
               {
                  ContextMenu m = new ContextMenu();                 
                  m.MenuItems.Add("Копировать выбраную строку из таблицы", copy_player_notepad1);
                  m.MenuItems.Add("Вырезать выбраную строку из таблицы", copy_player_notepad2);
                  m.MenuItems.Add("Вставить строку в таблицу", copy_player_notepad3);
                  m.MenuItems.Add("Обновить таблицу", copy_player_notepad4);
                  m.MenuItems.Add("Включить фильтр по поиску в таблице", copy_player_notepad5);
                  m.MenuItems.Add("Отключить фильтр по поиску в таблице", copy_player_notepad6);
                  for (int i = 0; i < dataGridView2.Rows.Count; i++)
                  {
                     dataGridView2.Rows[i].Selected = false;
                  }

                  dataGridView2.Rows[currentMouseOverRow].Selected = true;
                  m.Show(dataGridView2, new Point(e.X, e.Y));
               }
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            dataGridView2.AllowUserToAddRows = false;
            e.Graphics.DrawImage(objBmp, 0, 0);
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox12_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 &  textBox9.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text,  textBox9.Text);
                textBox3.Clear();                 
                textBox9.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText4 gridText4 = new GridText4();
                gridText4.Text2 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText4.Text2[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Postavshchiki.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText4.Text2);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Provider.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox52.Visible = true;
                pictureBox9.Visible = true;
                pictureBox70.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox38.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                 
                textBox9.Visible = false;
                panel3.Visible = false;
                 
                label7.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = true;
            pictureBox71.Visible = false;
            pictureBox4.Visible = false;
            pictureBox79.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = true;
            pictureBox71.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox52.Visible = true;
            pictureBox9.Visible = true;
            pictureBox70.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox38.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            textBox3.Visible = false;
             
            textBox9.Visible = false;
            panel3.Visible = false;
             
            label7.Visible = false;
        }

        private void textBox8_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Ответственные Лица";
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Табельный номер");
            dataGridView2.Columns.Add("1", "ФИО");
            dataGridView2.Columns.Add("2", "Должность");
            dataGridView2.Columns.Add("3", "Адрес");
            dataGridView2.Columns.Add("4", "Телефон");

            dataGridView1.Columns.Add("0", "Табельный номер");
            dataGridView1.Columns.Add("1", "ФИО");
            dataGridView1.Columns.Add("2", "Должность");
            dataGridView1.Columns.Add("3", "Адрес");
            dataGridView1.Columns.Add("4", "Телефон");

            pictureBox5.Visible = true;
            pictureBox7.Visible = true;

            try
            {
                GridText gridText2 = new GridText();
                FileStream fs2 = new FileStream("Otvetstvennyye_Litsa.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText2.Text = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText2.Text.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText2.Text.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText2.Text[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox7.Visible = false;
                pictureBox5.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Ответственные Лица");
                pictureBox7.Visible = true;
                pictureBox5.Visible = true;
            }
            
            pictureBox4.Visible = true;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox73.Visible = false;
            pictureBox78.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            pictureBox77.Visible = false;

            textBox47.Visible = false;
            pictureBox80.Visible = false;

            button11.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
           
            panel2.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox5.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Text = "Потребитель";
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Табельный номер");
            dataGridView2.Columns.Add("1", "Потребитель");

            dataGridView1.Columns.Add("0", "Код");
            dataGridView1.Columns.Add("1", "Потребитель");

            pictureBox37.Visible = true;
            pictureBox46.Visible = true;

            pictureBox4.Visible = false;

            try
            {
                GridText3 gridText3 = new GridText3();
                FileStream fs2 = new FileStream("Potrebiteli.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText3.Text1 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText3.Text1.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText3.Text1.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText3.Text1[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                
                pictureBox46.Visible = false;
                pictureBox37.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Потребитель");
                pictureBox46.Visible = true;
                pictureBox37.Visible = true;
            }
            
            textBox47.Visible = false;
            pictureBox80.Visible = false;

            button11.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            
            panel2.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox4.Visible = false;
            pictureBox69.Visible = true;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox73.Visible = false;
            pictureBox78.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            pictureBox77.Visible = false;

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox69.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Text = "Поставщик";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Табельный номер");
            dataGridView2.Columns.Add("1", "Поставщик");

            dataGridView1.Columns.Add("0", "Табельный номер");
            dataGridView1.Columns.Add("1", "Поставщик");

            pictureBox38.Visible = true;
            pictureBox52.Visible = true;

            try
            {
                GridText4 gridText4 = new GridText4();
                FileStream fs2 = new FileStream("Postavshchiki.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText4.Text2 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText4.Text2.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText4.Text2.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText4.Text2[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox52.Visible = false;
                pictureBox38.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Поставщик");
                pictureBox52.Visible = true;
                pictureBox38.Visible = true;
            }
            
            textBox47.Visible = false;
            pictureBox80.Visible = false;

            button11.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            
            panel2.Visible = false;
            pictureBox70.Visible = true;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = true;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox73.Visible = false;
            pictureBox78.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            pictureBox77.Visible = false;

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox70.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "Категории";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Категорий");

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Категорий");

            pictureBox39.Visible = true;
            pictureBox49.Visible = true;

            try
            {
                GridText5 gridText5 = new GridText5();
                FileStream fs2 = new FileStream("Kaitegoriy.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText5.Text3 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText5.Text3.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText5.Text3.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText5.Text3[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox49.Visible = false;
                pictureBox39.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Категории");
                pictureBox49.Visible = true;
                pictureBox39.Visible = true;
            }
            
            textBox47.Visible = false;
            pictureBox80.Visible = false;

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = true;
            pictureBox74.Visible = false;
            pictureBox73.Visible = false;
            pictureBox78.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            pictureBox77.Visible = false;

            button11.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
           
            panel2.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox71.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Text = "Единицы Измерений";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Единица Измерения");            

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Единица Измерения");

            pictureBox40.Visible = true;
            pictureBox48.Visible = true;

            try
            {
                GridText6 gridText6 = new GridText6();
                FileStream fs2 = new FileStream("Yedinitsy_Izmereni.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText6.Text4 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText6.Text4.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText6.Text4.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText6.Text4[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox48.Visible = false;
                pictureBox40.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Единицы Измерений");
                pictureBox48.Visible = true;
                pictureBox40.Visible = true;
            }
            
            textBox47.Visible = false;
            pictureBox80.Visible = false;

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = true;
            pictureBox73.Visible = false;
            pictureBox78.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            pictureBox77.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
           
            panel2.Visible = false;
            button11.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Text = "Остаток МТ на складе";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Дата");
            dataGridView2.Columns.Add("2", "Наименования Товара");
            dataGridView2.Columns.Add("3", "Единица Измерения");
            dataGridView2.Columns.Add("4", "Количество");
            dataGridView2.Columns.Add("5", "Цена");

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Дата");
            dataGridView1.Columns.Add("2", "Наименования Товара");
            dataGridView1.Columns.Add("3", "Единица Измерения");
            dataGridView1.Columns.Add("4", "Количество");
            dataGridView1.Columns.Add("5", "Цена");

            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox45.Visible = true;
            pictureBox53.Visible = true;

            try
            {
                GridText11 gridText11 = new GridText11();
                FileStream fs2 = new FileStream("Ostatok_Na_Sklade.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText11.Text9 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText11.Text9.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText11.Text9.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText11.Text9[i, j];
                    }
                }

                fs2.Close();

            }
            catch
            {
                pictureBox53.Visible = false;
                pictureBox45.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Остаток МТ на складе");
                pictureBox53.Visible = true;
                pictureBox45.Visible = true;
            }
            try
            {
                string[] text = File.ReadAllLines(@"Column_Unit_Measurements.sql");
                comboBox4.Items.AddRange(text);

                string[] text1 = File.ReadAllLines(@"Column_Unit_Naimenovaine.sql");
                comboBox14.Items.AddRange(text1);

                string[] text2 = File.ReadAllLines(@"Column_Unit_Col.sql");
                comboBox17.Items.AddRange(text2);
            }
            catch
            {

            }

            
            textBox47.Visible = false;
            pictureBox80.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        
            panel2.Visible = false;
            button11.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox79.Visible = false;
            pictureBox77.Visible = true;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Text = "Товары";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Артикул");
            dataGridView2.Columns.Add("2", "Наименования Товара");
            dataGridView2.Columns.Add("3", "Категорий");
            dataGridView2.Columns.Add("4", "Единица Измерения");
            dataGridView2.Columns.Add("5", "Количество");

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Артикул");
            dataGridView1.Columns.Add("2", "Наименования Товара");
            dataGridView1.Columns.Add("3", "Категорий");
            dataGridView1.Columns.Add("4", "Единица Измерения");
            dataGridView1.Columns.Add("5", "Количество");

            pictureBox41.Visible = true;
            pictureBox47.Visible = true;

            try
            {
                GridText7 gridText7 = new GridText7();
                FileStream fs2 = new FileStream("Tovary.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText7.Text5 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText7.Text5.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText7.Text5.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText7.Text5[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox47.Visible = false;
                pictureBox41.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Товары");
                pictureBox47.Visible = true;
                pictureBox41.Visible = true;
            }
            try
            {
                string[] text = File.ReadAllLines(@"Column_Unit_Measurements.sql");
                comboBox3.Items.AddRange(text);

                string[] text1 = File.ReadAllLines(@"Column_Unit_Kaitegoriy.sql");
                comboBox8.Items.AddRange(text1);
            }
            catch
            {

            }
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            
            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox73.Visible = false;
            pictureBox78.Visible = true;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;

            button11.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            
            panel2.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Text = "Приходный Ордер";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Табельный номер");
            dataGridView2.Columns.Add("1", "Дата");
            dataGridView2.Columns.Add("2", "Поставщик");
            dataGridView2.Columns.Add("3", "Принял");

            dataGridView1.Columns.Add("0", "Табельный номер");
            dataGridView1.Columns.Add("1", "Дата");
            dataGridView1.Columns.Add("2", "Поставщик");
            dataGridView1.Columns.Add("3", "Принял");

            pictureBox42.Visible = true;
            pictureBox54.Visible = true;

            try
            {
                GridText8 gridText8 = new GridText8();
                FileStream fs2 = new FileStream("Prikhodnyye_Ordery.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText8.Text6 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText8.Text6.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText8.Text6.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText8.Text6[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox54.Visible = false;
                pictureBox42.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Приходный Ордер");
                pictureBox54.Visible = true;
                pictureBox42.Visible = true;
            }

            try
            {
                string[] text1 = File.ReadAllLines(@"Column_Unit_Provider.sql");
                comboBox6.Items.AddRange(text1);

                string[] text2 = File.ReadAllLines(@"Column_Unit_Prinel.sql");
                comboBox18.Items.AddRange(text2);               
            }
            catch
            {

            }

            textBox47.Visible = false;
            pictureBox80.Visible = false;
            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
       
            panel2.Visible = false;
            button11.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox73.Visible = true;
            pictureBox78.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Text = "Накладные";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Наименования товара");
            dataGridView2.Columns.Add("2", "Единица Измерения");
            dataGridView2.Columns.Add("3", "Количество");
            dataGridView2.Columns.Add("4", "Сумма");

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Наименования товара");
            dataGridView1.Columns.Add("2", "Единица Измерения");
            dataGridView1.Columns.Add("3", "Количество");
            dataGridView1.Columns.Add("4", "Сумма");
            try
            {
                GridText9 gridText9 = new GridText9();
                FileStream fs2 = new FileStream("Nakladnyye.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText9.Text7 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText9.Text7.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText9.Text7.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText9.Text7[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox50.Visible = false;
                pictureBox43.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Накладные");
                pictureBox50.Visible = true;
                pictureBox43.Visible = true;
            }

            try
            {
               string[] text = File.ReadAllLines(@"Column_Unit_Naimenovaine.sql");
               comboBox12.Items.AddRange(text);

               string[] text1 = File.ReadAllLines(@"Column_Unit_Col.sql");
               comboBox15.Items.AddRange(text1);

               string[] text2 = File.ReadAllLines(@"Column_Unit_Measurements.sql");
               comboBox1.Items.AddRange(text2);
            }
            catch
            {

            }
            pictureBox50.Visible = true;
            pictureBox43.Visible = true;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            panel2.Visible = false;
            button11.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox78.Visible = false;
            pictureBox73.Visible = false;
            pictureBox76.Visible = true;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            pictureBox50.Visible = true;
            pictureBox43.Visible = true;
            Size = new Size(790, 225);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Text = "Акты о списаний";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Дата");
            dataGridView2.Columns.Add("2", "Наименования Товара");
            dataGridView2.Columns.Add("3", "Количество");
            dataGridView2.Columns.Add("4", "Разница");

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Дата");
            dataGridView1.Columns.Add("2", "Наименования Товара");
            dataGridView1.Columns.Add("3", "Количество");
            dataGridView1.Columns.Add("4", "Разница");

            pictureBox44.Visible = true;
            pictureBox51.Visible = true;

            try
            {
                GridText10 gridText10 = new GridText10();
                FileStream fs2 = new FileStream("Aktiye_Spisaniya.sql", FileMode.Open);
                BinaryFormatter formatter2 = new BinaryFormatter();

                gridText10.Text8 = (string[,])formatter2.Deserialize(fs2);

                for (int i = 0; i < gridText10.Text8.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText10.Text8.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText10.Text8[i, j];
                    }
                }

                fs2.Close();
            }
            catch
            {
                pictureBox51.Visible = false;
                pictureBox44.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Акты о списаний");
                pictureBox51.Visible = true;
                pictureBox44.Visible = true;
            }

            try
            {
                string[] text = File.ReadAllLines(@"Column_Unit_Naimenovaine.sql");
                comboBox13.Items.AddRange(text);

                string[] text1 = File.ReadAllLines(@"Column_Unit_Col.sql");
                comboBox16.Items.AddRange(text1);
            }
            catch
            {

            }
            
            textBox47.Visible = false;
            pictureBox80.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
      
            panel2.Visible = false;
            button11.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox78.Visible = false;
            pictureBox73.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = true;
            pictureBox75.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox20_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox20, "При нажатии на кнопку вы попадете в главное меню.");
        }

        private void pictureBox20_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox20_Click_2(object sender, EventArgs e)
        {
            this.Text = "Учет малоценных товаров на складе ОАО «Гродно Азот».";

            textBox47.Visible = false;
            pictureBox80.Visible = false;
            
            pictureBox59.Visible = false;
            pictureBox60.Visible = false;
            pictureBox61.Visible = false;
            pictureBox62.Visible = false;
            pictureBox63.Visible = false;
            pictureBox64.Visible = false;
            pictureBox65.Visible = false;
            pictureBox66.Visible = false;
            pictureBox67.Visible = false;
            pictureBox68.Visible = false;
            pictureBox79.Visible = false;
            pictureBox77.Visible = false;

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox78.Visible = false;
            pictureBox73.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = false;

            pictureBox7.Visible = false;
            pictureBox46.Visible = false;
            pictureBox47.Visible = false;
            pictureBox48.Visible = false;
            pictureBox49.Visible = false;
            pictureBox50.Visible = false;
            pictureBox52.Visible = false;
            pictureBox51.Visible = false;
            pictureBox53.Visible = false;
            pictureBox54.Visible = false;
            pictureBox55.Visible = false;
            pictureBox56.Visible = false;

            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            
            panel2.Visible = true;
            button11.Visible = true;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            panel1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;

             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;

            Size = new Size(431, 217);
            panel2.Location = new Point(1, 1);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            Application.Restart();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (textBox48.TextLength != 0 & textBox3.TextLength != 0 & textBox10.TextLength != 0 & textBox13.TextLength != 0 & comboBox8.Text != "" & comboBox3.Text != "")
            {
                dataGridView2.Rows.Add(textBox3.Text, textBox10.Text, textBox13.Text, comboBox8.Text, comboBox3.Text, textBox48.Text);
                textBox3.Clear();
                textBox48.Clear();
                textBox10.Clear();
                textBox13.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText7 gridText7 = new GridText7();
                gridText7.Text5 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText7.Text5[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Tovary.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText7.Text5);

                fs.Close();
                StreamWriter myWritet = new StreamWriter("Column_Unit_Col.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[5].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                StreamWriter myWritet2 = new StreamWriter("Column_Unit_Naimenovaine.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet2.Write(dataGridView2.Rows[i].Cells[2].Value.ToString());
                        myWritet2.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet2.Close();
                }
                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox47.Visible = true;
                pictureBox9.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox41.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                textBox13.Visible = false;
                comboBox3.Visible = false;
                comboBox8.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                label50.Visible = false;
                textBox48.Visible = false;
                panel4.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox10.Clear();
            textBox13.Clear();
            textBox48.Clear();
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox78.Visible = true;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox47.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox41.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            textBox10.Visible = false;
            textBox13.Visible = false;    
            comboBox3.Visible = false;
            comboBox8.Visible = false;
            pictureBox22.Visible = false;
            pictureBox21.Visible = false;
            panel4.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox9_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox9, "Поля для добавления поставщика в таблицу.");
        }

        private void textBox10_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox10, "Поля для добавления артикула в таблицу.");
        }

        private void textBox13_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox13, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox8_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox8, "Поля для добавления категорий в таблицу.");
        }

        private void comboBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox3, "Поля для добавления единицы измерения в таблицу.");
        }

        private void pictureBox19_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox19, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox22_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox22, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox18_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox18, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void pictureBox21_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox21, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void dateTimePicker1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & comboBox6.Text != "" & comboBox18.Text != "")
            {
                dataGridView2.Rows.Add(textBox3.Text, dateTimePicker1.Text, comboBox6.Text, comboBox18.Text);
                textBox3.Clear();                 

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText8 gridText8 = new GridText8();
                gridText8.Text6 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText8.Text6[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Prikhodnyye_Ordery.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText8.Text6);

                fs.Close();

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox54.Visible = true;
                pictureBox9.Visible = true;
                pictureBox73.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox42.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                dateTimePicker1.Visible = false;
                 
                panel5.Visible = false;
                comboBox6.Visible = false;
                comboBox18.Visible = false;
                label18.Visible = false;
                
                label16.Visible = false;
                label15.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox54.Visible = true;
            pictureBox9.Visible = true;
            pictureBox73.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox42.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            dateTimePicker1.Visible = false;
             
            panel5.Visible = false;
            comboBox6.Visible = false;
            comboBox18.Visible = false;
            label18.Visible = false;
            
            label16.Visible = false;
            label15.Visible = false;
            pictureBox65.Visible = false;
            pictureBox24.Visible = false;
            pictureBox23.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker1, "Поля для добавления даты в таблицу.");
        }

        private void textBox17_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void comboBox6_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox6, "Поля для добавления поставщика в таблицу.");
        }

        private void comboBox18_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureBox24_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox24, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox23_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox23, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0  & textBox19.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text,  textBox19.Text);
                textBox3.Clear();
                 
                textBox19.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText3 gridText3 = new GridText3();
                gridText3.Text1 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText3.Text1[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Potrebiteli.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText3.Text1);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Potrebiteli.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox46.Visible = true;
                pictureBox9.Visible = true;
                pictureBox69.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox37.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                 
                textBox9.Visible = false;
                panel3.Visible = false;
                 
                panel6.Visible = false;
                label7.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
             
            textBox19.Clear();
            pictureBox4.Visible = false;
            pictureBox79.Visible = false;
            pictureBox69.Visible = true;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox46.Visible = true;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox69.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox37.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
             
            panel6.Visible = false;
            label19.Visible = false;
             
            textBox19.Visible = false;
            pictureBox26.Visible = false;
            pictureBox25.Visible = false;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox19_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox19, "Поля для добавления потребителя в таблицу.");
        }

        private void pictureBox26_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox26, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox25_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox25, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0   & textBox22.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text,   textBox22.Text);
                textBox3.Clear();
                
                textBox22.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText5 gridText5 = new GridText5();
                gridText5.Text3 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText5.Text3[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Kaitegoriy.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText5.Text3);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Kaitegoriy.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox49.Visible = true;
                pictureBox9.Visible = true;
                pictureBox71.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox39.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                 
                label22.Visible = false;
                
                textBox22.Visible = false;
                panel7.Visible = false;
                pictureBox28.Visible = false;
                pictureBox27.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            
            textBox22.Clear();
            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = true;
            pictureBox4.Visible = false;
            pictureBox79.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = true;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox49.Visible = true;
            pictureBox9.Visible = true;
            pictureBox71.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox39.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
             
            label22.Visible = false;
            
            textBox22.Visible = false;
            panel7.Visible = false;
            pictureBox28.Visible = false;
            pictureBox62.Visible = false;
            pictureBox27.Visible = false;
        }

        private void textBox21_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textBox22_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox22, "Поля для добавления категорий в таблицу.");
        }

        private void pictureBox28_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox28, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox27, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0   & textBox24.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text,  textBox24.Text);
                textBox3.Clear();
                
                textBox24.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText6 gridText6 = new GridText6();
                gridText6.Text4 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText6.Text4[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Yedinitsy_Izmereni.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText6.Text4);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Measurements.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox48.Visible = true;
                pictureBox9.Visible = true;
                pictureBox74.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox40.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                 
                panel8.Visible = false;
                 
                textBox24.Visible = false;
                pictureBox30.Visible = false;
                pictureBox29.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            
            textBox24.Clear();
            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = true;

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox48.Visible = true;
            pictureBox9.Visible = true;
            pictureBox74.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox40.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
             
            panel8.Visible = false;
             
            textBox24.Visible = false;
            pictureBox30.Visible = false;
            pictureBox29.Visible = false;
        }

        private void textBox23_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void textBox24_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox24, "Поля для добавления единицы измерения в таблицу.");
        }

        private void pictureBox30_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox30, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox29_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox29, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {           
             if (textBox3.TextLength != 0   & comboBox13.Text != "" & comboBox16.Text != "" & textBox25.TextLength != 0)
             {
                int a = int.Parse(textBox25.Text);
                int b = int.Parse(comboBox16.Text);
                if (a > b)
                {
                    MessageBox.Show("Разница не может быть больше чем количества!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                }
                else
                {
                    int result = b - a;
                    comboBox16.Text = Convert.ToString(result);
                    dataGridView2.Rows.Add(textBox3.Text, dateTimePicker2.Text, comboBox13.Text, comboBox16.Text, textBox25.Text);
                    textBox3.Clear();                    
                    textBox25.Clear();
                    textBox47.Visible = false;
                    pictureBox80.Visible = false;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView2.AutoResizeColumns();
                    dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                    GridText10 gridText10 = new GridText10();
                    gridText10.Text8 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                gridText10.Text8[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                            }
                        }
                    }

                    FileStream fs = new FileStream("Aktiye_Spisaniya.sql", FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, gridText10.Text8);

                    fs.Close();
                    textBox47.Visible = false;
                    pictureBox80.Visible = false;
                    pictureBox20.Visible = true;
                    pictureBox17.Visible = true;
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox51.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox72.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox44.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    dataGridView2.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox16.Visible = true;
                    Size = new Size(790, 225);
                    dataGridView2.Size = new Size(772, 150);
                    dataGridView1.Size = new Size(772, 150);
                    dataGridView2.Location = new Point(1, 35);
                    dataGridView1.Location = new Point(1, 35);
                    label32.Visible = false;
                     
                    label31.Visible = false;
                    label30.Visible = false;
                    label28.Visible = false;
                    panel9.Visible = false;
                    pictureBox32.Visible = false;
                    pictureBox31.Visible = false;
                    dateTimePicker2.Visible = false;
                     
                    comboBox13.Visible = false;
                    comboBox16.Visible = false;
                    textBox25.Visible = false;
                }
             }
             else
             {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
             }            
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {                 
                textBox25.Clear();

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox51.Visible = true;
                pictureBox9.Visible = true;
                pictureBox72.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox44.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                label32.Visible = false;
                 
                label31.Visible = false;
                label30.Visible = false;
                label28.Visible = false;
                panel9.Visible = false;
                pictureBox32.Visible = false;
                pictureBox31.Visible = false;
                dateTimePicker2.Visible = false;
                 
                comboBox13.Visible = false;
                comboBox16.Visible = false;
                textBox25.Visible = false;
        }

        private void dateTimePicker2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker2, "Поля для добавления даты в таблицу.");
        }

        private void textBox26_MouseEnter(object sender, EventArgs e)
        {

        }

        private void comboBox13_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox13, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox16_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox16, "Поля для добавления количества в таблицу.");
        }

        private void textBox25_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox25, "Поля для добавления разницы в таблицу.");
        }

        private void pictureBox32_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox32, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox31_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox31, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker3, "Поля для добавления даты в таблицу.");
        }

        private void comboBox14_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox14, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox4, "Поля для добавления единицы измерения в таблицу.");
        }

        private void comboBox17_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox17, "Поля для добавления количества в таблицу.");
        }

        private void textBox30_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox30, "Поля для добавления цены в таблицу.");
        }

        private void pictureBox34_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox34, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox33_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox33, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void pictureBox34_Click_1(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & comboBox14.Text != "" & comboBox4.Text != "" & comboBox17.Text != "" & textBox30.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text, dateTimePicker3.Text, comboBox14.Text, comboBox4.Text, comboBox17.Text, textBox30.Text);
                textBox3.Clear();                    
                textBox30.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText11 gridText11 = new GridText11();
                gridText11.Text9 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText11.Text9[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Ostatok_Na_Sklade.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText11.Text9);

                fs.Close();

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox53.Visible = true;
                pictureBox9.Visible = true;
                pictureBox77.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox45.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                label37.Visible = false;
                label36.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label33.Visible = false;
                panel10.Visible = false;
                pictureBox31.Visible = false;
                pictureBox33.Visible = false;
                dateTimePicker3.Visible = false;
                comboBox14.Visible = false;
                comboBox4.Visible = false;
                comboBox17.Visible = false;
                textBox30.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox33_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox30.Clear();

            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox53.Visible = true;
            pictureBox9.Visible = true;
            pictureBox77.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox45.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            label37.Visible = false;
            label36.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label33.Visible = false;
            panel10.Visible = false;
            pictureBox31.Visible = false;
            pictureBox33.Visible = false;
            dateTimePicker3.Visible = false;
            comboBox14.Visible = false;
            comboBox4.Visible = false;
            comboBox17.Visible = false;
            textBox30.Visible = false;
        }

        private void dateTimePicker3_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker3, "Поля для добавления даты в таблицу.");
        }

        private void comboBox14_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox14, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox4_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox4, "Поля для добавления единицы измерения в таблицу.");
        }

        private void comboBox17_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox17, "Поля для добавления количества в таблицу.");
        }

        private void textBox30_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox30, "Поля для добавления цены в таблицу.");
        }

        private void pictureBox34_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox34, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox33_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox33, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & comboBox1.Text != "" & comboBox12.Text != "" & comboBox15.Text != "" & textBox35.TextLength != 0)
            {
                dataGridView2.Rows.Add(textBox3.Text,   comboBox12.Text, comboBox1.Text, comboBox15.Text, textBox35.Text);
                textBox3.Clear();
                textBox35.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText9 gridText9 = new GridText9();
                gridText9.Text7 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText9.Text7[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Nakladnyye.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText9.Text7);

                fs.Close();

                StreamWriter myWritet1 = new StreamWriter("Column_Unit_Sum.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet1.Write(dataGridView2.Rows[i].Cells[4].Value.ToString());
                        myWritet1.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet1.Close();
                }

               

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox50.Visible = true;
                pictureBox9.Visible = true;
                pictureBox76.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox43.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                panel11.Visible = false;
                
                comboBox1.Visible = false;
                comboBox12.Visible = false;
                comboBox15.Visible = false;
                textBox35.Visible = false;
                pictureBox36.Visible = false;
                pictureBox35.Visible = false;
                 
                label41.Visible = false;
                label39.Visible = false;
                label40.Visible = false;
                label38.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {                        
            textBox35.Clear();

            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox50.Visible = true;
            pictureBox9.Visible = true;
            pictureBox76.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox43.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
            panel11.Visible = false;
            
            comboBox1.Visible = false;
            comboBox12.Visible = false;
            comboBox15.Visible = false;
            textBox35.Visible = false;
            pictureBox36.Visible = false;
            pictureBox35.Visible = false;
             
            label41.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label38.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Text = "Расходные накладные";

            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView2.Columns.Add("0", "Номенклатурный номер");
            dataGridView2.Columns.Add("1", "Потребитель");
            dataGridView2.Columns.Add("2", "Поставщик");
            dataGridView2.Columns.Add("3", "Категорий");
            dataGridView2.Columns.Add("4", "Единица Измерения");
            dataGridView2.Columns.Add("5", "Количество");
            dataGridView2.Columns.Add("6", "Сумма");

            dataGridView1.Columns.Add("0", "Номенклатурный номер");
            dataGridView1.Columns.Add("1", "Потребитель");
            dataGridView1.Columns.Add("2", "Поставщик");
            dataGridView1.Columns.Add("3", "Категорий");
            dataGridView1.Columns.Add("4", "Единица Измерения");
            dataGridView1.Columns.Add("5", "Количество");
            dataGridView1.Columns.Add("6", "Сумма");

            pictureBox55.Visible = true;
            pictureBox56.Visible = true;

            try
            {
                GridText12 gridText12 = new GridText12();
                FileStream fs12 = new FileStream("Overhead_Expenditure.sql", FileMode.Open);
                BinaryFormatter formatter12 = new BinaryFormatter();

                gridText12.Text12 = (string[,])formatter12.Deserialize(fs12);

                for (int i = 0; i < gridText12.Text12.GetLength(0); i++)
                {
                    dataGridView2.Rows.Add();

                    for (int j = 0; j < gridText12.Text12.GetLength(1); j++)
                    {
                        dataGridView2.Rows[i].Cells[j].Value = gridText12.Text12[i, j];
                    }
                }

                fs12.Close();
            }
            catch
            {
                pictureBox55.Visible = false;
                pictureBox56.Visible = false;
                MessageBox.Show("Для загрузки таблицы для начало заполните её данными!", "Расходные накладные");
                pictureBox55.Visible = true;
                pictureBox56.Visible = true;
            }
            try
            {
                string[] text = File.ReadAllLines(@"Column_Unit_Measurements.sql");
                comboBox2.Items.AddRange(text);

                string[] text1 = File.ReadAllLines(@"Column_Unit_Provider.sql");
                comboBox5.Items.AddRange(text1);

                string[] text2 = File.ReadAllLines(@"Column_Unit_Potrebiteli.sql");
                comboBox7.Items.AddRange(text2);

                string[] text3 = File.ReadAllLines(@"Column_Unit_Kaitegoriy.sql");
                comboBox9.Items.AddRange(text3);

                string[] text4 = File.ReadAllLines(@"Column_Unit_Col.sql");
                comboBox10.Items.AddRange(text4);

                string[] text5 = File.ReadAllLines(@"Column_Unit_Sum.sql");
                comboBox11.Items.AddRange(text5);
            }
            catch
            {

            }

            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
        
            panel2.Visible = false;
            button11.Visible = false;

            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);

            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);

            pictureBox4.Visible = false;
            pictureBox69.Visible = false;
            pictureBox70.Visible = false;
            pictureBox71.Visible = false;
            pictureBox74.Visible = false;
            pictureBox78.Visible = false;
            pictureBox73.Visible = false;
            pictureBox76.Visible = false;
            pictureBox72.Visible = false;
            pictureBox75.Visible = true;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox4.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText3 gridText3 = new GridText3();
            gridText3.Text1 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText3.Text1[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Potrebiteli.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText3.Text1);

            fs.Close();

            StreamWriter myWritet = new StreamWriter("Column_Unit_Potrebiteli.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    myWritet.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet.Close();
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText4 gridText4 = new GridText4();
            gridText4.Text2 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText4.Text2[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Postavshchiki.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText4.Text2);

            fs.Close();

            StreamWriter myWritet = new StreamWriter("Column_Unit_Provider.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    myWritet.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet.Close();
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText5 gridText5 = new GridText5();
            gridText5.Text3 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText5.Text3[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Kaitegoriy.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText5.Text3);

            fs.Close();

             StreamWriter myWritet = new StreamWriter("Column_Unit_Kaitegoriy.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    myWritet.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet.Close();
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText6 gridText6 = new GridText6();
            gridText6.Text4 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText6.Text4[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Yedinitsy_Izmereni.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText6.Text4);

            fs.Close();

            StreamWriter myWritet = new StreamWriter("Column_Unit_Measurements.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    myWritet.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet.Close();
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText7 gridText7 = new GridText7();
            gridText7.Text5 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText7.Text5[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Tovary.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText7.Text5);

            fs.Close();

            StreamWriter myWritet = new StreamWriter("Column_Unit_Col.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet.Write(dataGridView2.Rows[i].Cells[5].Value.ToString());
                    myWritet.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet.Close();
            }

            StreamWriter myWritet2 = new StreamWriter("Column_Unit_Naimenovaine.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet2.Write(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    myWritet2.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet2.Close();
            }

        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText8 gridText8 = new GridText8();
            gridText8.Text6 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText8.Text6[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Prikhodnyye_Ordery.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText8.Text6);

            fs.Close();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText9 gridText9 = new GridText9();
            gridText9.Text7 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText9.Text7[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Nakladnyye.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText9.Text7);

            fs.Close();

            StreamWriter myWritet1 = new StreamWriter("Column_Unit_Sum.sql");
            try
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    myWritet1.Write(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    myWritet1.WriteLine();
                }
            }
            catch
            {

            }
            finally
            {
                myWritet1.Close();
            }
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText10 gridText10 = new GridText10();
            gridText10.Text8 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText10.Text8[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Aktiye_Spisaniya.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText10.Text8);

            fs.Close();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText11 gridText11 = new GridText11();
            gridText11.Text9 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText11.Text9[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs = new FileStream("Ostatok_Na_Sklade.sql", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, gridText11.Text9);

            fs.Close();
        }

        private void pictureBox45_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox45, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox38_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox38, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox40_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox40, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox41_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox41, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox39_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox39, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox37_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox37, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox42_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox42, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox43_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox43, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void pictureBox44_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox44, "При нажатии на кнопку будет сохранена таблица.");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            pictureBox46.Visible = false;

            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            textBox3.Visible = false;

            Size = new Size(488, 89);
            panel6.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox60.Visible = false;
             
            panel6.Visible = true;
            label19.Visible = true;
             
            textBox19.Visible = true;
            pictureBox26.Visible = true;
            pictureBox25.Visible = true;
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            pictureBox47.Visible = false;
            pictureBox78.Visible = false;
            pictureBox64.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            textBox3.Visible = false;

            Size = new Size(432, 160);
            panel4.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            label10.Visible = true;
            textBox10.Visible = true;
            textBox13.Visible = true;
            comboBox3.Visible = true;
            comboBox8.Visible = true;
            pictureBox22.Visible = true;
            pictureBox21.Visible = true;
            textBox48.Visible = true;
            label50.Visible = true;
            panel4.Visible = true;
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            pictureBox74.Visible = false;
            pictureBox48.Visible = false;
            pictureBox63.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            textBox3.Visible = false;

            Size = new Size(488, 89);
            panel8.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
             
            panel8.Visible = true;
           
            textBox24.Visible = true;
            pictureBox30.Visible = true;

            pictureBox29.Visible = true;
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            pictureBox49.Visible = false;

            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            textBox3.Visible = false;
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            Size = new Size(488, 89);
            panel7.Location = new Point(1, 1);

            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            
            label22.Visible = true;
             
            textBox22.Visible = true;
            panel7.Visible = true;
            pictureBox28.Visible = true;
            pictureBox27.Visible = true;
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {          
            pictureBox50.Visible = false;
            pictureBox76.Visible = false;
            pictureBox66.Visible = false;

            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            Size = new Size(477, 141);
            panel11.Location = new Point(1, 1);

            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            panel11.Visible = true;
            
            comboBox1.Visible = true;
            comboBox12.Visible = true;
            comboBox15.Visible = true;
            textBox35.Visible = true;
            pictureBox36.Visible = true;
            pictureBox35.Visible = true;
             
            label41.Visible = true;
            label39.Visible = true;
            label40.Visible = true;
            label38.Visible = true;
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            pictureBox52.Visible = false;
            pictureBox61.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;
            textBox3.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            Size = new Size(488, 89);
            panel3.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
             
            textBox9.Clear();
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            
            textBox9.Visible = true;
            panel3.Visible = true;
            
            label7.Visible = true;
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            pictureBox51.Visible = false;
            pictureBox67.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox72.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;

            Size = new Size(430, 150);
            panel9.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);

            label32.Visible = true;
            
            label31.Visible = true;
            label30.Visible = true;
            label28.Visible = true;
            panel9.Visible = true;
            pictureBox32.Visible = true;
            pictureBox31.Visible = true;
            dateTimePicker2.Visible = true;
             
            comboBox13.Visible = true;
            comboBox16.Visible = true;
            textBox25.Visible = true;
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            pictureBox53.Visible = false;
            pictureBox77.Visible = false;
            pictureBox79.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;

            Size = new Size(430, 160);
            panel10.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            label37.Visible = true;
            label36.Visible = true;
            label34.Visible = true;
            label35.Visible = true;
            label33.Visible = true;
            panel10.Visible = true;
            pictureBox31.Visible = true;
            pictureBox34.Visible = true;
            dateTimePicker3.Visible = true;
            pictureBox33.Visible = true;
            comboBox14.Visible = true;
            comboBox4.Visible = true;
            comboBox17.Visible = true;
            textBox30.Visible = true;
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            pictureBox54.Visible = false;
            pictureBox73.Visible = false;
            pictureBox65.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;

            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;

            Size = new Size(442, 112);
            panel5.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            dateTimePicker1.Visible = true;
             
            panel5.Visible = true;
            comboBox6.Visible = true;
            comboBox18.Visible = true;
            label18.Visible = true;
             
            label16.Visible = true;
            label15.Visible = true;
            pictureBox24.Visible = true;
            pictureBox23.Visible = true;
        }

        private void pictureBox46_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox46, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox47_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox47, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox48_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox48, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox49_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox49, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox50_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox50, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox52_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox52, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox51_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox51, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox53_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox53, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void pictureBox54_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox54, "При нажатии на кнопку будет открыта новая форма для добовления новой записи в таблицу.");
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            pictureBox55.Visible = false;
            pictureBox75.Visible = false;
            pictureBox5.Visible = false;
            pictureBox37.Visible = false;
            pictureBox38.Visible = false;
            pictureBox39.Visible = false;
            pictureBox40.Visible = false;
            pictureBox41.Visible = false;
            pictureBox42.Visible = false;
            pictureBox43.Visible = false;
            pictureBox44.Visible = false;
            pictureBox45.Visible = false;
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox56.Visible = false;
            dataGridView1.Visible = false;
            textBox3.Visible = false;
            label2.Visible = false;
            pictureBox20.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox8.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox9.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox10.Visible = false;
            pictureBox5.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            dataGridView2.Visible = false;
            pictureBox16.Visible = false;
            pictureBox16.Visible = false;
             
            label7.Visible = false;
             
            textBox9.Visible = false;
            pictureBox19.Visible = false;
            pictureBox18.Visible = false;
            panel3.Visible = false;
            panel1.Visible = false;
            pictureBox17.Visible = false;

            Size = new Size(435, 183);
            panel12.Location = new Point(1, 1);
            dataGridView2.Size = new Size(10, 10);
            dataGridView1.Size = new Size(10, 10);
            int h = dataGridView2.Rows.Count;
            int l = h + 1;
            textBox3.Text = Convert.ToString(l);

             
            label46.Visible = true;
            label44.Visible = true;
            label45.Visible = true;
            label43.Visible = true;
            label48.Visible = true;
            label49.Visible = true;
            pictureBox58.Visible = true;
            pictureBox57.Visible = true;
             
            comboBox6.Visible = true;
            comboBox5.Visible = true;
            comboBox9.Visible = true;
            comboBox2.Visible = true;
            comboBox10.Visible = true;
            comboBox11.Visible = true;
            panel12.Visible = true;
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            dataGridView2.ReadOnly = true;
            GridText12 gridText12 = new GridText12();
            gridText12.Text12 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                    {
                        gridText12.Text12[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
            }

            FileStream fs12 = new FileStream("Overhead_Expenditure.sql", FileMode.Create);
            BinaryFormatter formatter12 = new BinaryFormatter();
            formatter12.Serialize(fs12, gridText12.Text12);

            fs12.Close();
        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_TextChanged_0(object sender, EventArgs e)
        {

        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & comboBox7.Text != "" & comboBox5.Text != "" & comboBox9.Text != "" & comboBox2.Text != "" & comboBox10.Text != "" & comboBox11.Text != "")
            {
                dataGridView2.Rows.Add(textBox3.Text,  comboBox7.Text, comboBox5.Text, comboBox9.Text, comboBox2.Text, comboBox10.Text, comboBox11.Text);
                textBox3.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText12 gridText12 = new GridText12();
                gridText12.Text12 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText12.Text12[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs12 = new FileStream("Overhead_Expenditure.sql", FileMode.Create);
                BinaryFormatter formatter12 = new BinaryFormatter();
                formatter12.Serialize(fs12, gridText12.Text12);

                fs12.Close();

                pictureBox55.Visible = true;
                pictureBox56.Visible = true;
                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox9.Visible = true;
                pictureBox75.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                 
                label46.Visible = false;
                label44.Visible = false;
                label45.Visible = false;
                label43.Visible = false;
                label48.Visible = false;
                label49.Visible = false;
                 
                comboBox6.Visible = false;
                comboBox5.Visible = false;
                comboBox9.Visible = false;
                comboBox2.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                panel12.Visible = false;
            }
            else
            {
                MessageBox.Show("Для добавления новой записи заполните пожалуйста все поля!", "Добавления");
            }
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            textBox3.Clear();            
            textBox47.Visible = false;
            pictureBox80.Visible = false;
            pictureBox55.Visible = true;
            pictureBox56.Visible = true;
            pictureBox20.Visible = true;
            pictureBox17.Visible = true;
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox8.Visible = true;
            pictureBox6.Visible = true;
            pictureBox9.Visible = true;
            pictureBox75.Visible = true;
            pictureBox3.Visible = true;
            pictureBox10.Visible = true;
            pictureBox12.Visible = true;
            pictureBox11.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            dataGridView2.Visible = true;
            pictureBox16.Visible = true;
            pictureBox16.Visible = true;
            Size = new Size(790, 225);
            dataGridView2.Size = new Size(772, 150);
            dataGridView1.Size = new Size(772, 150);
            dataGridView2.Location = new Point(1, 35);
            dataGridView1.Location = new Point(1, 35);
             
            label46.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label43.Visible = false;
            label48.Visible = false;
            label49.Visible = false;
            pictureBox68.Visible = false;
             
            comboBox6.Visible = false;
            comboBox5.Visible = false;
            comboBox9.Visible = false;
            comboBox2.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            panel12.Visible = false;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox36_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox36, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox58_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox58, "При нажатии на кнопку будет добавлена новая запись в таблицу.");
        }

        private void pictureBox35_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox35, "При нажатии на кнопку назад вы вернетесь к таблице.");
        }

        private void textBox36_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox1, "Поля для добавления номера накладной в таблицу.");
        }

        private void comboBox12_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox12, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox15_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox15, "Поля для добавления количества в таблицу.");
        }

        private void textBox35_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox35, "Поля для добавления суммы в таблицу.");
        }

        private void textBox44_MouseEnter(object sender, EventArgs e)
        { 

        }

        private void comboBox6_MouseEnter_8(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox6, "Поля для добавления потребителя в таблицу.");
        }

        private void comboBox5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox5, "Поля для добавления поставщика в таблицу.");
        }

        private void comboBox9_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox9, "Поля для добавления категорий в таблицу.");
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox2, "Поля для добавления единицы измерения в таблицу.");
        }

        private void comboBox10_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox10, "Поля для добавления количества в таблицу.");
        }

        private void comboBox11_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox11, "Поля для добавления суммы в таблицу.");
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & textBox4.TextLength != 0 & textBox5.TextLength != 0 & textBox6.TextLength != 0 & textBox7.TextLength != 0)
            {
                dataGridView2.SelectedCells[1].Value = textBox4.Text;
                dataGridView2.SelectedCells[2].Value = textBox5.Text;
                dataGridView2.SelectedCells[3].Value = textBox6.Text;
                dataGridView2.SelectedCells[4].Value = textBox7.Text;
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText gridText = new GridText();
                gridText.Text = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText.Text[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Otvetstvennyye_Litsa.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText.Text);

                fs.Close();
                StreamWriter myWritet = new StreamWriter("Column_Unit_Prinel.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }
                

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox9.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox5.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                panel1.Location = new Point(2, 187);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                panel1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox59_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox59, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0   & textBox19.TextLength != 0)
            {
                dataGridView2.SelectedCells[1].Value = textBox19.Text;
                textBox3.Clear();
                 
                textBox19.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText3 gridText3 = new GridText3();
                gridText3.Text1 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText3.Text1[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Potrebiteli.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText3.Text1);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Potrebiteli.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox46.Visible = true;
                pictureBox9.Visible = true;
                pictureBox69.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox37.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                 
                textBox9.Visible = false;
                panel3.Visible = false;
                 
                panel6.Visible = false;
                label7.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 &   textBox9.TextLength != 0)
            { 
                dataGridView2.SelectedCells[1].Value = textBox9.Text;
                textBox3.Clear();
                 
                textBox9.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText4 gridText4 = new GridText4();
                gridText4.Text2 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText4.Text2[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Postavshchiki.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText4.Text2);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Provider.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox52.Visible = true;
                pictureBox9.Visible = true;
                pictureBox70.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox38.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                textBox3.Visible = false;
                 
                textBox9.Visible = false;
                panel3.Visible = false;
                 
                label7.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0  & textBox22.TextLength != 0)
            {
                dataGridView2.SelectedCells[1].Value = textBox22.Text;
                textBox3.Clear();
                
                textBox22.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText5 gridText5 = new GridText5();
                gridText5.Text3 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText5.Text3[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Kaitegoriy.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText5.Text3);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Kaitegoriy.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox49.Visible = true;
                pictureBox9.Visible = true;
                pictureBox71.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox39.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                pictureBox71.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                 
                label22.Visible = false;
                
                textBox22.Visible = false;
                panel7.Visible = false;
                pictureBox62.Visible = false;
                pictureBox27.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0   & textBox24.TextLength != 0)
            {
                dataGridView2.SelectedCells[1].Value = textBox24.Text;
                textBox3.Clear();
                
                textBox24.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText6 gridText6 = new GridText6();
                gridText6.Text4 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText6.Text4[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Yedinitsy_Izmereni.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText6.Text4);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Measurements.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[1].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                pictureBox4.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox74.Visible = true;

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox48.Visible = true;
                pictureBox9.Visible = true;
                pictureBox74.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox40.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                 
                panel8.Visible = false;
                 
                textBox24.Visible = false;
                pictureBox62.Visible = false;
                pictureBox29.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            if (textBox48.TextLength != 0 & textBox3.TextLength != 0 & textBox10.TextLength != 0 & textBox13.TextLength != 0 & comboBox8.Text != "" & comboBox3.Text != "")
            {
                dataGridView2.SelectedCells[1].Value = textBox10.Text;
                dataGridView2.SelectedCells[2].Value = textBox13.Text;
                dataGridView2.SelectedCells[3].Value = comboBox8.Text;
                dataGridView2.SelectedCells[4].Value = comboBox3.Text;
                dataGridView2.SelectedCells[5].Value = textBox48.Text;
                textBox3.Clear();
                textBox10.Clear();
                textBox13.Clear();
                textBox48.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText7 gridText7 = new GridText7();
                gridText7.Text5 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText7.Text5[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Tovary.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText7.Text5);

                fs.Close();
                StreamWriter myWritet = new StreamWriter("Column_Unit_Col.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[5].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }

                StreamWriter myWritet2 = new StreamWriter("Column_Unit_Naimenovaine.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet2.Write(dataGridView2.Rows[i].Cells[2].Value.ToString());
                        myWritet2.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet2.Close();
                }
                pictureBox4.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;

                pictureBox78.Visible = true;
                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox47.Visible = true;
                pictureBox9.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox41.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 230);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                textBox10.Visible = false;
                textBox13.Visible = false;
                comboBox3.Visible = false;
                comboBox8.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                textBox48.Visible = false;
                label50.Visible = false;
                panel4.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0  & comboBox6.Text != "" & comboBox18.Text != "")
            {
                dataGridView2.SelectedCells[1].Value = dateTimePicker1.Text;
                dataGridView2.SelectedCells[2].Value = comboBox6.Text;
                dataGridView2.SelectedCells[3].Value = comboBox18.Text;
                textBox3.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText8 gridText8 = new GridText8();
                gridText8.Text6 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText8.Text6[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Prikhodnyye_Ordery.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText8.Text6);

                fs.Close();

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox54.Visible = true;
                pictureBox9.Visible = true;
                pictureBox73.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox42.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                dateTimePicker1.Visible = false;
                 
                panel5.Visible = false;
                comboBox6.Visible = false;
                comboBox18.Visible = false;
                label18.Visible = false;
                
                label16.Visible = false;
                label15.Visible = false;
                pictureBox65.Visible = false;
                pictureBox23.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0  & comboBox1.Text != "" & comboBox12.Text != "" & comboBox15.Text != "" & textBox35.TextLength != 0)
            {
                dataGridView2.SelectedCells[1].Value = comboBox12.Text;
                dataGridView2.SelectedCells[2].Value = comboBox1.Text;
                dataGridView2.SelectedCells[3].Value = comboBox15.Text;
                dataGridView2.SelectedCells[4].Value = textBox35.Text;
                textBox3.Clear();                
                textBox35.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText9 gridText9 = new GridText9();
                gridText9.Text7 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText9.Text7[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Nakladnyye.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText9.Text7);

                fs.Close();

                StreamWriter myWritet = new StreamWriter("Column_Unit_Sum.sql");
                try
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        myWritet.Write(dataGridView2.Rows[i].Cells[3].Value.ToString());
                        myWritet.WriteLine();
                    }
                }
                catch
                {

                }
                finally
                {
                    myWritet.Close();
                }             

                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox50.Visible = true;
                pictureBox9.Visible = true;
                pictureBox76.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox43.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                panel11.Visible = false;
                
                comboBox1.Visible = false;
                comboBox12.Visible = false;
                comboBox15.Visible = false;
                textBox35.Visible = false;
                pictureBox66.Visible = false;
                pictureBox35.Visible = false;
                 
                label41.Visible = false;
                label39.Visible = false;
                label40.Visible = false;
                label38.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0   & comboBox13.Text != "" & comboBox16.Text != "" & textBox25.TextLength != 0)
            {
                int a = int.Parse(textBox25.Text);
                int b = int.Parse(comboBox16.Text);
                if (a > b)
                {                    
                    MessageBox.Show("Разница не может быть больше чем количества!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                }
                else
                {
                    int result = b - a;
                    comboBox16.Text = Convert.ToString(result);
                    dataGridView2.SelectedCells[1].Value = dateTimePicker2.Text;
                    dataGridView2.SelectedCells[2].Value = comboBox13.Text;
                    dataGridView2.SelectedCells[3].Value = comboBox16.Text;
                    dataGridView2.SelectedCells[4].Value = textBox25.Text;
                    textBox3.Clear();                   
                    textBox25.Clear();

                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView2.AutoResizeColumns();
                    dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                    GridText10 gridText10 = new GridText10();
                    gridText10.Text8 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                gridText10.Text8[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                            }
                        }
                    }

                    FileStream fs = new FileStream("Aktiye_Spisaniya.sql", FileMode.Create);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, gridText10.Text8);

                    fs.Close();
                    textBox47.Visible = false;
                    pictureBox80.Visible = false;
                    pictureBox20.Visible = true;
                    pictureBox17.Visible = true;
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = true;
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox8.Visible = true;
                    pictureBox6.Visible = true;
                    pictureBox51.Visible = true;
                    pictureBox9.Visible = true;
                    pictureBox72.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox10.Visible = true;
                    pictureBox44.Visible = true;
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    label1.Visible = true;
                    dataGridView2.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox16.Visible = true;
                    Size = new Size(790, 225);
                    dataGridView2.Size = new Size(772, 150);
                    dataGridView1.Size = new Size(772, 150);
                    dataGridView2.Location = new Point(1, 35);
                    dataGridView1.Location = new Point(1, 35);
                    label32.Visible = false;
                     
                    label31.Visible = false;
                    label30.Visible = false;
                    label28.Visible = false;
                    panel9.Visible = false;
                    pictureBox32.Visible = false;
                    pictureBox31.Visible = false;
                    dateTimePicker2.Visible = false;
                     
                    comboBox13.Visible = false;
                    comboBox16.Visible = false;
                    textBox25.Visible = false;
                }
            }
            else
            {
               MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }            
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0  & comboBox7.Text != "" & comboBox5.Text != "" & comboBox9.Text != "" & comboBox2.Text != "" & comboBox10.Text != "" & comboBox11.Text != "")
            { 
                dataGridView2.SelectedCells[1].Value = comboBox7.Text;
                dataGridView2.SelectedCells[2].Value = comboBox5.Text;
                dataGridView2.SelectedCells[3].Value = comboBox9.Text;
                dataGridView2.SelectedCells[4].Value = comboBox2.Text;
                dataGridView2.SelectedCells[5].Value = comboBox10.Text;
                dataGridView2.SelectedCells[6].Value = comboBox11.Text;
                textBox3.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText12 gridText12 = new GridText12();
                gridText12.Text12 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText12.Text12[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs12 = new FileStream("Overhead_Expenditure.sql", FileMode.Create);
                BinaryFormatter formatter12 = new BinaryFormatter();
                formatter12.Serialize(fs12, gridText12.Text12);

                fs12.Close();
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox55.Visible = true;
                pictureBox56.Visible = true;
                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox9.Visible = true;
                pictureBox75.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                 
                label46.Visible = false;
                label44.Visible = false;
                label45.Visible = false;
                label43.Visible = false;
                label48.Visible = false;
                label49.Visible = false;
                 
                comboBox6.Visible = false;
                comboBox5.Visible = false;
                comboBox9.Visible = false;
                comboBox2.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                panel12.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox69.Visible = false;
                pictureBox46.Visible = false;
                pictureBox26.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;
                textBox3.Visible = false;

                Size = new Size(488, 89);
                panel6.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                 
                panel6.Visible = true;
                label19.Visible = true;
                 
                textBox19.Visible = true;

                pictureBox25.Visible = true;
                pictureBox60.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    textBox19.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                }
            }            
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            if (textBox3.TextLength != 0 & comboBox14.Text != "" & comboBox4.Text != "" & comboBox17.Text != "" & textBox30.TextLength != 0)
            {
                dataGridView2.SelectedCells[1].Value = dateTimePicker3.Text;
                dataGridView2.SelectedCells[2].Value = comboBox14.Text;
                dataGridView2.SelectedCells[3].Value = comboBox4.Text;
                dataGridView2.SelectedCells[4].Value = comboBox17.Text;
                dataGridView2.SelectedCells[5].Value = textBox30.Text;
                textBox3.Clear();
                textBox30.Clear();

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView2.AutoResizeColumns();
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

                GridText11 gridText11 = new GridText11();
                gridText11.Text9 = new string[dataGridView2.RowCount, dataGridView2.ColumnCount];

                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            gridText11.Text9[i, j] = (string)dataGridView2.Rows[i].Cells[j].Value;
                        }
                    }
                }

                FileStream fs = new FileStream("Ostatok_Na_Sklade.sql", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, gridText11.Text9);

                fs.Close();
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox20.Visible = true;
                pictureBox17.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = true;
                pictureBox53.Visible = true;
                pictureBox9.Visible = true;
                pictureBox77.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox45.Visible = true;
                pictureBox12.Visible = true;
                pictureBox11.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                label1.Visible = true;
                dataGridView2.Visible = true;
                pictureBox16.Visible = true;
                pictureBox16.Visible = true;
                Size = new Size(790, 225);
                dataGridView2.Size = new Size(772, 150);
                dataGridView1.Size = new Size(772, 150);
                dataGridView2.Location = new Point(1, 35);
                dataGridView1.Location = new Point(1, 35);
                pictureBox4.Visible = false;
                label37.Visible = false;
                label36.Visible = false;
                label34.Visible = false;
                label35.Visible = false;
                label33.Visible = false;
                panel10.Visible = false;
                pictureBox31.Visible = false;
                pictureBox33.Visible = false;
                dateTimePicker3.Visible = false;
                comboBox14.Visible = false;
                comboBox4.Visible = false;
                comboBox17.Visible = false;
                textBox30.Visible = false;
            }
            else
            {
                MessageBox.Show("Для редактирования записи заполните пожалуйста все поля!", "Редактирования");
            }
        }

        private void pictureBox60_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox60, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox69_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox69, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox52.Visible = false;
                pictureBox70.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;
                textBox3.Visible = false;
                pictureBox69.Visible = false;
                Size = new Size(488, 89);
                panel3.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                pictureBox18.Visible = true;
                pictureBox61.Visible = true;
                
                textBox9.Visible = true;
                panel3.Visible = true;
                
                label7.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    textBox9.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                }
            }           
        }

        private void pictureBox70_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox70, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox61_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox61, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox62_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox62, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox49.Visible = false;
                pictureBox71.Visible = false;
                pictureBox28.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;
                textBox3.Visible = false;

                Size = new Size(488, 89);
                panel7.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                
                label22.Visible = true;
                 
                textBox22.Visible = true;
                panel7.Visible = true;
                pictureBox62.Visible = true;
                pictureBox27.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    textBox22.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                }
            }           
        }

        private void pictureBox71_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox71, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox54.Visible = false;
                pictureBox73.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;

                Size = new Size(442, 112);
                panel5.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                dateTimePicker1.Visible = true;
                 
                panel5.Visible = true;
                comboBox6.Visible = true;
                comboBox18.Visible = true;
                label18.Visible = true;
                 
                label16.Visible = true;
                label15.Visible = true;
                pictureBox65.Visible = true;
                pictureBox23.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dateTimePicker1.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    comboBox6.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    comboBox18.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                }
            }            
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox48.Visible = false;
                pictureBox74.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;
                textBox3.Visible = false;

                Size = new Size(488, 89);
                panel8.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                 
                panel8.Visible = true;
               
                textBox24.Visible = true;
                pictureBox63.Visible = true;
                pictureBox29.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    textBox24.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                }
            }          
        }

        private void pictureBox63_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox63, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox74_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox74, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox4.Visible = false;
                pictureBox69.Visible = false;
                pictureBox70.Visible = false;
                pictureBox71.Visible = false;
                pictureBox74.Visible = false;
                pictureBox78.Visible = true;

                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                panel1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;

                pictureBox47.Visible = false;
                pictureBox78.Visible = false;
                pictureBox64.Visible = true;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;
                textBox3.Visible = false;

                Size = new Size(432, 160);
                panel4.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                textBox10.Visible = true;
                textBox13.Visible = true;
                comboBox3.Visible = true;
                comboBox8.Visible = true;
                pictureBox22.Visible = true;
                pictureBox21.Visible = true;
                textBox48.Visible = true;
                label50.Visible = true;
                panel4.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    textBox10.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    comboBox8.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    textBox13.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    comboBox3.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                    textBox48.Text = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                }
            }            
        }

        private void pictureBox78_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox78, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox65_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox65, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox73_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox73, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                pictureBox50.Visible = false;
                pictureBox76.Visible = false;
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;

                Size = new Size(477, 141);
                panel11.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                panel11.Visible = true;
                
                comboBox1.Visible = true;
                comboBox12.Visible = true;
                comboBox15.Visible = true;
                textBox35.Visible = true;
                pictureBox66.Visible = true;
                pictureBox35.Visible = true;
                 
                label41.Visible = true;
                label39.Visible = true;
                label40.Visible = true;
                label38.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    comboBox12.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    comboBox1.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);                    
                    comboBox15.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    textBox35.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                }
            }           
        }

        private void pictureBox66_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox66, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox76_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox76, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox67_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox67, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox51.Visible = false;
                pictureBox72.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox72.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;

                Size = new Size(430, 150);
                panel9.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                label32.Visible = true;
                
                label31.Visible = true;
                label30.Visible = true;
                label28.Visible = true;
                panel9.Visible = true;
                pictureBox67.Visible = true;
                pictureBox31.Visible = true;
                dateTimePicker2.Visible = true;
                 
                comboBox13.Visible = true;
                comboBox16.Visible = true;
                textBox25.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dateTimePicker2.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    comboBox13.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    comboBox16.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    textBox25.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                }
            }           
        }

        private void pictureBox72_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox72, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox55.Visible = false;
                pictureBox75.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                pictureBox56.Visible = false;
                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox75.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;

                Size = new Size(435, 183);
                panel12.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                 
                label46.Visible = true;
                label44.Visible = true;
                label45.Visible = true;
                label43.Visible = true;
                label48.Visible = true;
                label49.Visible = true;
                pictureBox57.Visible = true;
                pictureBox68.Visible = true;
                 
                comboBox6.Visible = true;
                comboBox5.Visible = true;
                comboBox9.Visible = true;
                comboBox2.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                panel12.Visible = true;

                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    comboBox6.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    comboBox5.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    comboBox9.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    comboBox2.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                    comboBox10.Text = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                    comboBox11.Text = Convert.ToString(dataGridView1.Rows[i].Cells[6].Value);
                }
            }               
        }

        private void pictureBox68_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox68, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox75_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox75, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Для редактирования таблицы для начало выберите строку которую хотите отредактировать!", "Редактировать");
            }
            else
            {
                textBox47.Visible = false;
                pictureBox80.Visible = false;
                pictureBox53.Visible = false;
                pictureBox77.Visible = false;
                pictureBox5.Visible = false;
                pictureBox37.Visible = false;
                pictureBox38.Visible = false;
                pictureBox39.Visible = false;
                pictureBox40.Visible = false;
                pictureBox41.Visible = false;
                pictureBox42.Visible = false;
                pictureBox43.Visible = false;
                pictureBox44.Visible = false;
                pictureBox45.Visible = false;

                dataGridView1.Visible = false;
                textBox3.Visible = false;
                label2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox8.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox77.Visible = false;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                dataGridView2.Visible = false;
                pictureBox16.Visible = false;
                pictureBox16.Visible = false;
                 
                label7.Visible = false;
                 
                textBox9.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                panel3.Visible = false;
                panel1.Visible = false;
                pictureBox17.Visible = false;

                Size = new Size(430, 160);
                panel10.Location = new Point(1, 1);
                dataGridView2.Size = new Size(10, 10);
                dataGridView1.Size = new Size(10, 10);
                int h = dataGridView2.Rows.Count;
                int l = h + 1;
                textBox3.Text = Convert.ToString(l);

                label37.Visible = true;
                label36.Visible = true;
                label34.Visible = true;
                label35.Visible = true;
                label33.Visible = true;
                panel10.Visible = true;
                pictureBox31.Visible = true;
                pictureBox33.Visible = true;
                pictureBox79.Visible = true;
                dateTimePicker3.Visible = true;
                comboBox14.Visible = true;
                comboBox4.Visible = true;
                comboBox17.Visible = true;
                textBox30.Visible = true;
                dataGridView1.Rows.Clear();
                colihectvo++;
                if (colihectvo == 1)
                {
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {
                        object[] items = new object[row.Cells.Count];
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            items[i] = row.Cells[i].Value;
                        }
                        dataGridView1.Rows.Add(items);
                    }
                    colihectvo = 0;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dateTimePicker3.Text = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    comboBox14.Text = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);
                    comboBox4.Text = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                    comboBox17.Text = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                    textBox30.Text = Convert.ToString(dataGridView1.Rows[i].Cells[5].Value);
                }
            }            
        }

        private void pictureBox79_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox79, "При нажатии на кнопку будет сохранены отредактированные данные в таблицу.");
        }

        private void pictureBox77_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox77, "При нажатии на кнопку вы сможете редактировать записи в таблице.");
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox6_KeyPress_9(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
           
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле адрес должен текст быть такого формата (Улица, дом, квартира.)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == '-' || e.KeyChar == '+' || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле телефон текст должен быть такого формата (55-09-00 или +375298763456)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле артикуль текст должен быть такого формата (5532-093-0110)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '$' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле цена должен текст быть такого формата (34$ или 34 руб.)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '$' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле сумма должен текст быть такого формата (34$ или 34 руб.)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox47_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox47, "Поля для автофильтрацией по поиску в таблице.");
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            if (textBox47.Text == "")
            {
                MessageBox.Show("Поля для автофильтрацией по поиску в таблице должно быть заполнено!", "Автофильтр по таблице");
            }
            else if (textBox47.Text != "")
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Selected = true;
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox47.Text))
                            {
                                dataGridView2.Rows[i].Selected = false;                   
                                textBox47.Visible = false;
                                pictureBox80.Visible = false;
                                textBox2.Visible = true;
                                pictureBox11.Visible = true;
                            }
                        }
                        else if (dataGridView2.Rows[i].Cells[j].Value == null)
                        {
                            MessageBox.Show("Нельзя отфильтровать таблицу по поиску в таблице нету не одной записи!", "Автофильтр по таблице");
                        }
                    }
                }                                         
            }
            int vse = dataGridView2.RowCount;
            if (dataGridView2.SelectedRows.Count == vse)
            {
                MessageBox.Show("Значения которое хотели отфильтровать по таблице не было найдено!", "Автофильтр по таблице");
            }
            else
            {
                int selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int k = 0; k < selectedRowCount; k++)
                    {
                        dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                    }
                }
            }
        }

        private void pictureBox80_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox80, "Автофильтрация по поиску в таблице.");
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, поля дата должно быть такого формата (год.месяц.число)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void dateTimePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, поля дата должно быть такого формата (год.месяц.число)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void dateTimePicker3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, поля дата должно быть такого формата (год.месяц.число)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, поля дата должно быть такого формата (год.месяц.число)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '$' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле сумма должен текст быть такого формата (34$ или 34 руб.)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox48_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox48, "Поля для добавления количества в таблицу.");
        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox3, "Поля для добавления единицы измерения в таблицу.");
        }

        private void comboBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox17_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox48_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox48, "Поля для добавления количества в таблицу.");
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == '+' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод данного символа в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox1_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox1, "Поля для добавления единицы измерения в таблицу.");
        }

        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox11_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox48_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker1, "Поля для добавления даты в таблицу.");
        }

        private void dateTimePicker2_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker2, "Поля для добавления даты в таблицу.");
        }

        private void dateTimePicker3_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(dateTimePicker3, "Поля для добавления даты в таблицу.");
        }

        private void comboBox1_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox1, "Поля для добавления единицы измерения в таблицу.");
        }

        private void comboBox1_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox2, "Поля для добавления номера накладной в таблицу.");
        }

        private void comboBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox3, "Поля для добавления номера накладной в таблицу.");
        }

        private void comboBox3_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox4, "Поля для добавления номера накладной в таблицу.");
        }

        private void comboBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox6, "Поля для добавления поставщика в таблицу.");
        }

        private void comboBox5_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox5, "Поля для добавления поставщика в таблицу.");
        }

        private void comboBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {            
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox7, "Поля для добавления потребителя в таблицу.");
        }

        private void comboBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox8, "Поля для добавления категорий в таблицу.");
        }

        private void comboBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox9, "Поля для добавления категорий в таблицу.");
        }

        private void comboBox9_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
           
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox10, "Поля для добавления количества в таблицу.");
        }

        private void comboBox10_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox11_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox11, "Поля для добавления суммы в таблицу.");
        }

        private void comboBox11_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '$' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("В поле сумма должен текст быть такого формата (34$ или 34 руб.)!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox12, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox12_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
                        ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox13_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox13_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox13, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox14, "Поля для добавления наименования товара в таблицу.");
        }

        private void comboBox14_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
           
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox15, "Поля для добавления количества в таблицу.");
        }

        private void comboBox15_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox16_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox16, "Поля для добавления количества в таблицу.");
        }

        private void comboBox16_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }            
        }

        private void comboBox16_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox17, "Поля для добавления количества в таблицу.");
        }

        private void comboBox17_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле запрещено, в поле можно писать только цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox18, "Поля для добавления кто принял товар в таблицу.");
        }

        private void comboBox18_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox4_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox12_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод символов в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void comboBox2_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            ((ComboBox)(sender)).DroppedDown = true;
            if ((char.IsControl(e.KeyChar)))
                return;
            string Str = ((ComboBox)(sender)).Text.Substring(0, ((ComboBox)(sender)).SelectionStart) + e.KeyChar;
            int Index = ((ComboBox)(sender)).FindStringExact(Str);
            if (Index == -1)
                Index = ((ComboBox)(sender)).FindString(Str);
            ((ComboBox)sender).SelectedIndex = Index;
            ((ComboBox)(sender)).SelectionStart = Str.Length;
            ((ComboBox)(sender)).SelectionLength = ((ComboBox)(sender)).Text.Length - ((ComboBox)(sender)).SelectionStart;
            e.Handled = true;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)Keys.Enter || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поле запрещено, в поле можно писать только буквами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Enter || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == '+' || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод данного символа в поле запрещено, в поле можно писать только буквами или цыфрами!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void comboBox12_MouseEnter_2(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(comboBox12, "Поля для добавления наименования товара в таблицу.");
        }

        private void dateTimePicker1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
            {
                return;
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите дату из календаря!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void dateTimePicker3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите дату из календаря!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void dateTimePicker2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Пожалуйста выберите дату из календаря!", "Учет малоценных товаров на складе ОАО «Гродно Азот»");
                e.Handled = true;
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Поля для поиска должно быть заполнено!", "Поиск");
                }
                else if (textBox2.Text != "")
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        dataGridView2.Rows[i].Selected = false;
                    }
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                                {
                                    dataGridView2.Rows[i].Selected = true;
                                    for (int l = 0; l < dataGridView2.SelectedRows.Count; l++)
                                    {
                                        string rowIndex = dataGridView2.SelectedRows[l].Index.ToString();
                                        dataGridView2.FirstDisplayedScrollingRowIndex = Convert.ToInt32(rowIndex);
                                    }
                                }
                            }
                            else if (dataGridView2.Rows[i].Cells[j].Value == null)
                            {
                                MessageBox.Show("Для поиска по таблице для начало заполните таблицу данными!", "Поиск");
                            }
                        }
                    }
                    if (dataGridView2.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Текст который вы искали не был найден!", "Поиск");
                    }
                }
            }
        }

        private void textBox47_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox47.Text == "")
                {
                    MessageBox.Show("Поля для автофильтрацией по поиску в таблице должно быть заполнено!", "Автофильтр по таблице");
                }
                else if (textBox47.Text != "")
                {
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        dataGridView2.Rows[i].Selected = true;
                    }
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView2.ColumnCount; j++)
                        {
                            if (dataGridView2.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox47.Text))
                                {
                                    dataGridView2.Rows[i].Selected = false;
                                    textBox47.Visible = false;
                                    pictureBox80.Visible = false;
                                    textBox2.Visible = true;
                                    pictureBox11.Visible = true;
                                }
                            }
                            else if (dataGridView2.Rows[i].Cells[j].Value == null)
                            {
                                MessageBox.Show("Нельзя отфильтровать таблицу по поиску в таблице нету не одной записи!", "Автофильтр по таблице");
                            }
                        }
                    }
                }
                int vse = dataGridView2.RowCount;
                if (dataGridView2.SelectedRows.Count == vse)
                {
                    MessageBox.Show("Значения которое хотели отфильтровать по таблице не было найдено!", "Автофильтр по таблице");
                }
                else
                {
                    int selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        for (int k = 0; k < selectedRowCount; k++)
                        {
                            dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                        }
                    }
                }
            }
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer2_Tick_2(object sender, EventArgs e)
        {
            label1.Text = "из " + $"{dataGridView2.Rows.Count}";
            if (textBox1.Text == "1")
            {
                timer1.Enabled = false;
            }
            else if (textBox1.Text == "0")
            {
                timer1.Enabled = true;
            }
            else if (textBox1.Text != "1")
            {
                timer1.Enabled = true;
            }
            else if (textBox1.Text != "0")
            {
                timer1.Enabled = false;
            }
        }
    }
}
