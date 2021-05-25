using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        StringBuilder str = new StringBuilder(8);
        List<int> Symbols = new List<int> { 35, 36, 37, 38, 42, 64 };
        public Form1()
        {
            InitializeComponent();
            Screen currentScreen = Screen.FromRectangle(Bounds);
            Random hf1 = new Random();
            label7.Text = hf1.Next(10000, 999999).ToString();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация f = new Авторизация();
            f.ShowDialog();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            str.Clear();
            for (int i = 0; i < 2; i++)
            {
                {
                    str.Append(((char)rnd.Next(48, 59)).ToString() +
                    (char)rnd.Next(65, 92) +
                    (char)rnd.Next(97, 124) +
                    (char)Symbols[rnd.Next(0, 6)]);
                }
                textBox4.Text = str.ToString();
                textBox3.Text = str.ToString();

                textBox7.Text = textBox3.Text;
                textBox6.Text = textBox4.Text;
            }
            Clipboard.SetText(textBox3.Text);
            MessageBox.Show("Пароль скопирован в буфер обмена!", "Регистрация");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox7.Text = textBox3.Text;
            textBox6.Text = textBox4.Text;
            textBox3.Visible = false;
            textBox6.Visible = true;
            pictureBox2.Visible = false;
            textBox4.Visible = false;
            textBox7.Visible = true;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox7.Text;
            textBox4.Text = textBox6.Text;
            textBox3.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
        }

        private void textBox14_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox14, "Поля для ввода логина.");
        }

        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox27, "Вернуться обратно на форму Авторизации.");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox1, "Поля для ввода имени.");
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox2, "Поля для ввода фамилий.");
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox3, "Поля для ввода придуманного пользователем пароля.");
        }

        private void textBox3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox7, "Поля для ввода придуманного пользователем пароля.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox4, "Поля для ввода подтвердить пароля.");
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox6, "Поля для ввода подтвердить пароля.");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox23_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox23, "Нажмите на кнопку для того чтобы восстановить доступ к вашей учётной записи.");            
        }
       
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            string str = "";
            str = textBox14.Text.ToUpper();

            for (int i = 0; i < str.Length; ++i)
            {
                char[] hifrovka = str.ToCharArray();

                if (hifrovka[i] == 'A')
                {
                    str = str.Replace("A", "!");
                }
                else if (hifrovka[i] == 'B')
                {
                    str = str.Replace("B", "@");
                }
                else if (hifrovka[i] == 'C')
                {
                    str = str.Replace("C", "#");
                }
                else if (hifrovka[i] == 'D')
                {
                    str = str.Replace("D", "$");
                }
                else if (hifrovka[i] == 'E')
                {
                    str = str.Replace("E", "%");
                }
                else if (hifrovka[i] == 'F')
                {
                    str = str.Replace("F", "^");
                }
                else if (hifrovka[i] == 'G')
                {
                    str = str.Replace("G", "&");
                }
                else if (hifrovka[i] == 'H')
                {
                    str = str.Replace("H", "?");
                }
                else if (hifrovka[i] == 'I')
                {
                    str = str.Replace("I", "*");
                }
                else if (hifrovka[i] == 'J')
                {
                    str = str.Replace("J", "(");
                }
                else if (hifrovka[i] == 'K')
                {
                    str = str.Replace("K", ")");
                }
                else if (hifrovka[i] == 'L')
                {
                    str = str.Replace("L", "_");
                }
                else if (hifrovka[i] == 'M')
                {
                    str = str.Replace("M", "-");
                }
                else if (hifrovka[i] == 'N')
                {
                    str = str.Replace("N", "=");
                }
                else if (hifrovka[i] == 'O')
                {
                    str = str.Replace("O", "+");
                }
                else if (hifrovka[i] == 'P')
                {
                    str = str.Replace("P", "Ж");
                }
                else if (hifrovka[i] == 'Q')
                {
                    str = str.Replace("Q", ",");
                }
                else if (hifrovka[i] == 'R')
                {
                    str = str.Replace("R", ".");
                }
                else if (hifrovka[i] == 'S')
                {
                    str = str.Replace("S", ":");
                }
                else if (hifrovka[i] == 'T')
                {
                    str = str.Replace("T", ";");
                }
                else if (hifrovka[i] == 'U')
                {
                    str = str.Replace("U", "[");
                }
                else if (hifrovka[i] == 'V')
                {
                    str = str.Replace("V", "]");
                }
                else if (hifrovka[i] == 'W')
                {
                    str = str.Replace("W", "{");
                }
                else if (hifrovka[i] == 'X')
                {
                    str = str.Replace("X", "}");
                }
                else if (hifrovka[i] == 'Z')
                {
                    str = str.Replace("Z", "|");
                }
                else if (hifrovka[i] == '1')
                {
                    str = str.Replace("1", "Й");
                }
                else if (hifrovka[i] == '2')
                {
                    str = str.Replace("2", "Ц");
                }
                else if (hifrovka[i] == '3')
                {
                    str = str.Replace("3", "У");
                }
                else if (hifrovka[i] == '4')
                {
                    str = str.Replace("4", "К");
                }
                else if (hifrovka[i] == '5')
                {
                    str = str.Replace("5", "Е");
                }
                else if (hifrovka[i] == '6')
                {
                    str = str.Replace("6", "Н");
                }
                else if (hifrovka[i] == '7')
                {
                    str = str.Replace("7", "Г");
                }
                else if (hifrovka[i] == '8')
                {
                    str = str.Replace("8", "Ш");
                }
                else if (hifrovka[i] == '9')
                {
                    str = str.Replace("9", "Щ");
                }
                else if (hifrovka[i] == '0')
                {
                    str = str.Replace("0", "З");
                }
                else if (hifrovka[i] == 'А')
                {
                    str = str.Replace("А", "!");
                }
                else if (hifrovka[i] == 'Б')
                {
                    str = str.Replace("Б", "@");
                }
                else if (hifrovka[i] == 'В')
                {
                    str = str.Replace("В", "#");
                }
                else if (hifrovka[i] == 'Г')
                {
                    str = str.Replace("Г", "$");
                }
                else if (hifrovka[i] == 'Д')
                {
                    str = str.Replace("Д", "%");
                }
                else if (hifrovka[i] == 'Е')
                {
                    str = str.Replace("Е", "^");
                }
                else if (hifrovka[i] == 'Ё')
                {
                    str = str.Replace("Ё", "&");
                }
                else if (hifrovka[i] == 'Ж')
                {
                    str = str.Replace("Ж", "?");
                }
                else if (hifrovka[i] == 'З')
                {
                    str = str.Replace("З", "*");
                }
                else if (hifrovka[i] == 'И')
                {
                    str = str.Replace("И", "(");
                }
                else if (hifrovka[i] == 'Й')
                {
                    str = str.Replace("Й", ")");
                }
                else if (hifrovka[i] == 'К')
                {
                    str = str.Replace("К", "_");
                }
                else if (hifrovka[i] == 'Л')
                {
                    str = str.Replace("Л", "-");
                }
                else if (hifrovka[i] == 'М')
                {
                    str = str.Replace("М", "=");
                }
                else if (hifrovka[i] == 'Н')
                {
                    str = str.Replace("Н", "+");
                }
                else if (hifrovka[i] == 'О')
                {
                    str = str.Replace("О", "L");
                }
                else if (hifrovka[i] == 'П')
                {
                    str = str.Replace("П", ",");
                }
                else if (hifrovka[i] == 'Р')
                {
                    str = str.Replace("Р", ".");
                }
                else if (hifrovka[i] == 'С')
                {
                    str = str.Replace("С", ":");
                }
                else if (hifrovka[i] == 'Т')
                {
                    str = str.Replace("Т", ";");
                }
                else if (hifrovka[i] == 'У')
                {
                    str = str.Replace("У", "[");
                }
                else if (hifrovka[i] == 'Ф')
                {
                    str = str.Replace("Ф", "]");
                }
                else if (hifrovka[i] == 'Х')
                {
                    str = str.Replace("Х", "{");
                }
                else if (hifrovka[i] == 'Ц')
                {
                    str = str.Replace("Ц", "}");
                }
                else if (hifrovka[i] == 'Ч')
                {
                    str = str.Replace("Ч", "|");
                }
                else if (hifrovka[i] == 'Ш')
                {
                    str = str.Replace("Ш", "V");
                }
                else if (hifrovka[i] == 'Щ')
                {
                    str = str.Replace("Щ", "~");
                }
                else if (hifrovka[i] == 'Ъ')
                {
                    str = str.Replace("Ъ", "`");
                }
                else if (hifrovka[i] == 'Ы')
                {
                    str = str.Replace("Ы", "K");
                }
                else if (hifrovka[i] == 'Ь')
                {
                    str = str.Replace("Ь", "№");
                }
                else if (hifrovka[i] == 'Э')
                {
                    str = str.Replace("Э", "Z");
                }
                else if (hifrovka[i] == 'Ю')
                {
                    str = str.Replace("Ю", "M");
                }
                else if (hifrovka[i] == 'Я')
                {
                    str = str.Replace("Я", "N");
                }
            }

            string str11 = "";
            str11 = textBox3.Text.ToUpper();

            for (int i1 = 0; i1 < str11.Length; ++i1)
            {
                char[] hifrovka1 = str11.ToCharArray();

                if (hifrovka1[i1] == 'A')
                {
                    str11 = str11.Replace("A", "!");
                }
                else if (hifrovka1[i1] == 'B')
                {
                    str11 = str11.Replace("B", "@");
                }
                else if (hifrovka1[i1] == 'C')
                {
                    str11 = str11.Replace("C", "#");
                }
                else if (hifrovka1[i1] == 'D')
                {
                    str11 = str11.Replace("D", "$");
                }
                else if (hifrovka1[i1] == 'E')
                {
                    str11 = str11.Replace("E", "%");
                }
                else if (hifrovka1[i1] == 'F')
                {
                    str11 = str11.Replace("F", "^");
                }
                else if (hifrovka1[i1] == 'G')
                {
                    str11 = str11.Replace("G", "&");
                }
                else if (hifrovka1[i1] == 'H')
                {
                    str11 = str11.Replace("H", "?");
                }
                else if (hifrovka1[i1] == 'I')
                {
                    str11 = str11.Replace("I", "*");
                }
                else if (hifrovka1[i1] == 'J')
                {
                    str11 = str11.Replace("J", "(");
                }
                else if (hifrovka1[i1] == 'K')
                {
                    str11 = str11.Replace("K", ")");
                }
                else if (hifrovka1[i1] == 'L')
                {
                    str11 = str11.Replace("L", "_");
                }
                else if (hifrovka1[i1] == 'M')
                {
                    str11 = str11.Replace("M", "-");
                }
                else if (hifrovka1[i1] == 'N')
                {
                    str11 = str11.Replace("N", "=");
                }
                else if (hifrovka1[i1] == 'O')
                {
                    str11 = str11.Replace("O", "+");
                }
                else if (hifrovka1[i1] == 'P')
                {
                    str11 = str11.Replace("P", "Ж");
                }
                else if (hifrovka1[i1] == 'Q')
                {
                    str11 = str11.Replace("Q", ",");
                }
                else if (hifrovka1[i1] == 'R')
                {
                    str11 = str11.Replace("R", ".");
                }
                else if (hifrovka1[i1] == 'S')
                {
                    str11 = str11.Replace("S", ":");
                }
                else if (hifrovka1[i1] == 'T')
                {
                    str11 = str11.Replace("T", ";");
                }
                else if (hifrovka1[i1] == 'U')
                {
                    str11 = str11.Replace("U", "[");
                }
                else if (hifrovka1[i1] == 'V')
                {
                    str11 = str11.Replace("V", "]");
                }
                else if (hifrovka1[i1] == 'W')
                {
                    str11 = str11.Replace("W", "{");
                }
                else if (hifrovka1[i1] == 'X')
                {
                    str11 = str11.Replace("X", "}");
                }
                else if (hifrovka1[i1] == 'Z')
                {
                    str11 = str11.Replace("Z", "|");
                }
                else if (hifrovka1[i1] == '1')
                {
                    str11 = str11.Replace("1", "Й");
                }
                else if (hifrovka1[i1] == '2')
                {
                    str11 = str11.Replace("2", "Ц");
                }
                else if (hifrovka1[i1] == '3')
                {
                    str11 = str11.Replace("3", "У");
                }
                else if (hifrovka1[i1] == '4')
                {
                    str11 = str11.Replace("4", "К");
                }
                else if (hifrovka1[i1] == '5')
                {
                    str11 = str11.Replace("5", "Е");
                }
                else if (hifrovka1[i1] == '6')
                {
                    str11 = str11.Replace("6", "Н");
                }
                else if (hifrovka1[i1] == '7')
                {
                    str11 = str11.Replace("7", "Г");
                }
                else if (hifrovka1[i1] == '8')
                {
                    str11 = str11.Replace("8", "Ш");
                }
                else if (hifrovka1[i1] == '9')
                {
                    str11 = str11.Replace("9", "Щ");
                }
                else if (hifrovka1[i1] == '0')
                {
                    str11 = str11.Replace("0", "З");
                }
                else if (hifrovka1[i1] == 'А')
                {
                    str11 = str11.Replace("А", "!");
                }
                else if (hifrovka1[i1] == 'Б')
                {
                    str11 = str11.Replace("Б", "@");
                }
                else if (hifrovka1[i1] == 'В')
                {
                    str11 = str11.Replace("В", "#");
                }
                else if (hifrovka1[i1] == 'Г')
                {
                    str11 = str11.Replace("Г", "$");
                }
                else if (hifrovka1[i1] == 'Д')
                {
                    str11 = str11.Replace("Д", "%");
                }
                else if (hifrovka1[i1] == 'Е')
                {
                    str11 = str11.Replace("Е", "^");
                }
                else if (hifrovka1[i1] == 'Ё')
                {
                    str11 = str11.Replace("Ё", "&");
                }
                else if (hifrovka1[i1] == 'Ж')
                {
                    str11 = str11.Replace("Ж", "?");
                }
                else if (hifrovka1[i1] == 'З')
                {
                    str11 = str11.Replace("З", "*");
                }
                else if (hifrovka1[i1] == 'И')
                {
                    str11 = str11.Replace("И", "(");
                }
                else if (hifrovka1[i1] == 'Й')
                {
                    str11 = str11.Replace("Й", ")");
                }
                else if (hifrovka1[i1] == 'К')
                {
                    str11 = str11.Replace("К", "_");
                }
                else if (hifrovka1[i1] == 'Л')
                {
                    str11 = str11.Replace("Л", "-");
                }
                else if (hifrovka1[i1] == 'М')
                {
                    str11 = str11.Replace("М", "=");
                }
                else if (hifrovka1[i1] == 'Н')
                {
                    str11 = str11.Replace("Н", "+");
                }
                else if (hifrovka1[i1] == 'О')
                {
                    str11 = str11.Replace("О", "L");
                }
                else if (hifrovka1[i1] == 'П')
                {
                    str11 = str11.Replace("П", ",");
                }
                else if (hifrovka1[i1] == 'Р')
                {
                    str11 = str11.Replace("Р", ".");
                }
                else if (hifrovka1[i1] == 'С')
                {
                    str11 = str11.Replace("С", ":");
                }
                else if (hifrovka1[i1] == 'Т')
                {
                    str11 = str11.Replace("Т", ";");
                }
                else if (hifrovka1[i1] == 'У')
                {
                    str11 = str11.Replace("У", "[");
                }
                else if (hifrovka1[i1] == 'Ф')
                {
                    str11 = str11.Replace("Ф", "]");
                }
                else if (hifrovka1[i1] == 'Х')
                {
                    str11 = str11.Replace("Х", "{");
                }
                else if (hifrovka1[i1] == 'Ц')
                {
                    str11 = str11.Replace("Ц", "}");
                }
                else if (hifrovka1[i1] == 'Ч')
                {
                    str11 = str11.Replace("Ч", "|");
                }
                else if (hifrovka1[i1] == 'Ш')
                {
                    str11 = str11.Replace("Ш", "V");
                }
                else if (hifrovka1[i1] == 'Щ')
                {
                    str11 = str11.Replace("Щ", "~");
                }
                else if (hifrovka1[i1] == 'Ъ')
                {
                    str11 = str11.Replace("Ъ", "`");
                }
                else if (hifrovka1[i1] == 'Ы')
                {
                    str11 = str11.Replace("Ы", "K");
                }
                else if (hifrovka1[i1] == 'Ь')
                {
                    str11 = str11.Replace("Ь", "№");
                }
                else if (hifrovka1[i1] == 'Э')
                {
                    str11 = str11.Replace("Э", "Z");
                }
                else if (hifrovka1[i1] == 'Ю')
                {
                    str11 = str11.Replace("Ю", "M");
                }
                else if (hifrovka1[i1] == 'Я')
                {
                    str11 = str11.Replace("Я", "N");
                }
            }
            textBox14.Text = str;
            textBox3.Text = str11;

            string[] Line = File.ReadAllLines("login.sql");
            string Lin111 = File.ReadAllText("password.sql");
            richTextBox1.Text = Lin111;

            if (Line.Contains(textBox14.Text)) 
            {
                for (int i = 0; i < Line.Length; i++)
                {
                    if (textBox14.Text == Line[i])
                    {
                        string kill = File.ReadLines("password.sql").Skip(i).FirstOrDefault().ToString();
                        string a = kill;
                        int index = richTextBox1.Text.IndexOf(a);
                        richTextBox1.SelectionStart = index;
                        richTextBox1.SelectionLength = a.Length;
                        richTextBox1.SelectedText = textBox3.Text;
                        richTextBox2.Text = richTextBox1.Text;
                        richTextBox2.SaveFile(@"password.sql", RichTextBoxStreamType.PlainText);
                    }
                }
               
                try
                {
                   File.Delete(@"Indicator.sql");
                   File.Create(@"Indicator.sql");
                }
                catch
                {

                }
                textBox14.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox5.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
                MessageBox.Show("Пароль успешно восстановлен!", "Восстановление доступа");
                Hide();
                Form2 f = new Form2();
                f.ShowDialog();
                Close();
            }
            else 
            {
                textBox14.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox2.Clear();
                textBox5.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
                MessageBox.Show("Пользователь с таким логином не был найден!", "Восстановление доступа");
            }     

            if (textBox14.TextLength == 0 || textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || textBox4.TextLength == 0 || textBox5.TextLength == 0)
            {
                textBox14.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox5.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
                MessageBox.Show("Заполните все поля!", "Восстановление доступа");
            }
            else if (textBox5.Text != label7.Text)
            {
                textBox14.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox5.Clear();
                textBox2.Clear();
                MessageBox.Show("Не верно введён код с картинки по пробуйте ещё раз!", "Восстановление доступа");
                Random hf1 = new Random();
                label7.Text = hf1.Next(10000, 999999).ToString();
            }
            else if (textBox3.Text != textBox4.Text)
            {
                textBox14.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox7.Clear();
                textBox4.Clear();
                textBox6.Clear();
                textBox5.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                richTextBox2.Clear();
                MessageBox.Show("Пароли не совпадают!", "Восстановление доступа");
            }
            else if (textBox3.TextLength == 1 || textBox3.TextLength == 2 || textBox3.TextLength == 3 || textBox3.TextLength == 4)
            {
                MessageBox.Show("пароль должен быть не меньше чем 4 символа!", "Восстановление доступа");
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox4, "Нажмите кнопку для того чтобы сгенерировать пароль.");
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "При нажатии на кнопку будет показан пароль.");
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox3, "При нажатии на кнопку будет скрыт пароль.");
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox5, "Поля для ввода кода с картинки.");
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(label7, "Картинка с кодам.");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control))
           {
                return;
           }
           else
           {
                MessageBox.Show("Ввод цифр в поля имя запрещено, имя должно быть написано только буквами!", "Восстановление доступа");
                e.Handled = true;
           }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр в поля фамилия запрещено, имя должно быть написано только буквами!", "Восстановление доступа");
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле капча запрещено, в поле капча можно писать только цыфрами!", "Восстановление доступа");
                e.Handled = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
