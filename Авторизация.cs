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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            label5.Text = Environment.MachineName;
            Screen currentScreen = Screen.FromRectangle(Bounds);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            textBox19.Visible = true;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;

            string str = "";
            str = textBox18.Text.ToUpper();

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

            string str1 = "";
            str1 = textBox19.Text.ToUpper();         

            for (int i1 = 0; i1 < str1.Length; ++i1)
            {
                char[] hifrovka1 = str1.ToCharArray();

                if (hifrovka1[i1] == 'A')
                {
                    str1 = str1.Replace("A", "!");
                }
                else if (hifrovka1[i1] == 'B')
                {
                    str1 = str1.Replace("B", "@");
                }
                else if (hifrovka1[i1] == 'C')
                {
                    str1 = str1.Replace("C", "#");
                }
                else if (hifrovka1[i1] == 'D')
                {
                    str1 = str1.Replace("D", "$");
                }
                else if (hifrovka1[i1] == 'E')
                {
                    str1 = str1.Replace("E", "%");
                }
                else if (hifrovka1[i1] == 'F')
                {
                    str1 = str1.Replace("F", "^");
                }
                else if (hifrovka1[i1] == 'G')
                {
                    str1 = str1.Replace("G", "&");
                }
                else if (hifrovka1[i1] == 'H')
                {
                    str1 = str1.Replace("H", "?");
                }
                else if (hifrovka1[i1] == 'I')
                {
                    str1 = str1.Replace("I", "*");
                }
                else if (hifrovka1[i1] == 'J')
                {
                    str1 = str1.Replace("J", "(");
                }
                else if (hifrovka1[i1] == 'K')
                {
                    str1 = str1.Replace("K", ")");
                }
                else if (hifrovka1[i1] == 'L')
                {
                    str1 = str1.Replace("L", "_");
                }
                else if (hifrovka1[i1] == 'M')
                {
                    str1 = str1.Replace("M", "-");
                }
                else if (hifrovka1[i1] == 'N')
                {
                    str1 = str1.Replace("N", "=");
                }
                else if (hifrovka1[i1] == 'O')
                {
                    str1 = str1.Replace("O", "+");
                }
                else if (hifrovka1[i1] == 'P')
                {
                    str1 = str1.Replace("P", "Ж");
                }
                else if (hifrovka1[i1] == 'Q')
                {
                    str1 = str1.Replace("Q", ",");
                }
                else if (hifrovka1[i1] == 'R')
                {
                    str1 = str1.Replace("R", ".");
                }
                else if (hifrovka1[i1] == 'S')
                {
                    str1 = str1.Replace("S", ":");
                }
                else if (hifrovka1[i1] == 'T')
                {
                    str1 = str1.Replace("T", ";");
                }
                else if (hifrovka1[i1] == 'U')
                {
                    str1 = str1.Replace("U", "[");
                }
                else if (hifrovka1[i1] == 'V')
                {
                    str1 = str1.Replace("V", "]");
                }
                else if (hifrovka1[i1] == 'W')
                {
                    str1 = str1.Replace("W", "{");
                }
                else if (hifrovka1[i1] == 'X')
                {
                    str1 = str1.Replace("X", "}");
                }
                else if (hifrovka1[i1] == 'Z')
                {
                    str1 = str1.Replace("Z", "|");
                }
                else if (hifrovka1[i1] == '1')
                {
                    str1 = str1.Replace("1", "Й");
                }
                else if (hifrovka1[i1] == '2')
                {
                    str1 = str1.Replace("2", "Ц");
                }
                else if (hifrovka1[i1] == '3')
                {
                    str1 = str1.Replace("3", "У");
                }
                else if (hifrovka1[i1] == '4')
                {
                    str1 = str1.Replace("4", "К");
                }
                else if (hifrovka1[i1] == '5')
                {
                    str1 = str1.Replace("5", "Е");
                }
                else if (hifrovka1[i1] == '6')
                {
                    str1 = str1.Replace("6", "Н");
                }
                else if (hifrovka1[i1] == '7')
                {
                    str1 = str1.Replace("7", "Г");
                }
                else if (hifrovka1[i1] == '8')
                {
                    str1 = str1.Replace("8", "Ш");
                }
                else if (hifrovka1[i1] == '9')
                {
                    str1 = str1.Replace("9", "Щ");
                }
                else if (hifrovka1[i1] == '0')
                {
                    str1 = str1.Replace("0", "З");
                }
                else if (hifrovka1[i1] == 'А')
                {
                    str1 = str1.Replace("А", "!");
                }
                else if (hifrovka1[i1] == 'Б')
                {
                    str1 = str1.Replace("Б", "@");
                }
                else if (hifrovka1[i1] == 'В')
                {
                    str1 = str1.Replace("В", "#");
                }
                else if (hifrovka1[i1] == 'Г')
                {
                    str1 = str1.Replace("Г", "$");
                }
                else if (hifrovka1[i1] == 'Д')
                {
                    str1 = str1.Replace("Д", "%");
                }
                else if (hifrovka1[i1] == 'Е')
                {
                    str1 = str1.Replace("Е", "^");
                }
                else if (hifrovka1[i1] == 'Ё')
                {
                    str1 = str1.Replace("Ё", "&");
                }
                else if (hifrovka1[i1] == 'Ж')
                {
                    str1 = str1.Replace("Ж", "?");
                }
                else if (hifrovka1[i1] == 'З')
                {
                    str1 = str1.Replace("З", "*");
                }
                else if (hifrovka1[i1] == 'И')
                {
                    str1 = str1.Replace("И", "(");
                }
                else if (hifrovka1[i1] == 'Й')
                {
                    str1 = str1.Replace("Й", ")");
                }
                else if (hifrovka1[i1] == 'К')
                {
                    str1 = str1.Replace("К", "_");
                }
                else if (hifrovka1[i1] == 'Л')
                {
                    str1 = str1.Replace("Л", "-");
                }
                else if (hifrovka1[i1] == 'М')
                {
                    str1 = str1.Replace("М", "=");
                }
                else if (hifrovka1[i1] == 'Н')
                {
                    str1 = str1.Replace("Н", "+");
                }
                else if (hifrovka1[i1] == 'О')
                {
                    str1 = str1.Replace("О", "L");
                }
                else if (hifrovka1[i1] == 'П')
                {
                    str1 = str1.Replace("П", ",");
                }
                else if (hifrovka1[i1] == 'Р')
                {
                    str1 = str1.Replace("Р", ".");
                }
                else if (hifrovka1[i1] == 'С')
                {
                    str1 = str1.Replace("С", ":");
                }
                else if (hifrovka1[i1] == 'Т')
                {
                    str1 = str1.Replace("Т", ";");
                }
                else if (hifrovka1[i1] == 'У')
                {
                    str1 = str1.Replace("У", "[");
                }
                else if (hifrovka1[i1] == 'Ф')
                {
                    str1 = str1.Replace("Ф", "]");
                }
                else if (hifrovka1[i1] == 'Х')
                {
                    str1 = str1.Replace("Х", "{");
                }
                else if (hifrovka1[i1] == 'Ц')
                {
                    str1 = str1.Replace("Ц", "}");
                }
                else if (hifrovka1[i1] == 'Ч')
                {
                    str1 = str1.Replace("Ч", "|");
                }
                else if (hifrovka1[i1] == 'Ш')
                {
                    str1 = str1.Replace("Ш", "V");
                }
                else if (hifrovka1[i1] == 'Щ')
                {
                    str1 = str1.Replace("Щ", "~");
                }
                else if (hifrovka1[i1] == 'Ъ')
                {
                    str1 = str1.Replace("Ъ", "`");
                }
                else if (hifrovka1[i1] == 'Ы')
                {
                    str1 = str1.Replace("Ы", "K");
                }
                else if (hifrovka1[i1] == 'Ь')
                {
                    str1 = str1.Replace("Ь", "№");
                }
                else if (hifrovka1[i1] == 'Э')
                {
                    str1 = str1.Replace("Э", "Z");
                }
                else if (hifrovka1[i1] == 'Ю')
                {
                    str1 = str1.Replace("Ю", "M");
                }
                else if (hifrovka1[i1] == 'Я')
                {
                    str1 = str1.Replace("Я", "N");
                }
            }
            textBox18.Text = str;
            textBox19.Text = str1;

            string login;
            string password;
            textBox2.Text = textBox19.Text;
            StreamReader f = new StreamReader(@"login.sql", true);
            StreamReader f1 = new StreamReader(@"password.sql", true);

            while ((login = f.ReadLine()) != null & (password = f1.ReadLine()) != null)
            {
                if (textBox18.Text == login & textBox19.Text == password & textBox1.Text == label4.Text)
                {
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox2.Clear();
                    textBox1.Clear();
                    Hide();
                    Form2 fr = new Form2();
                    fr.ShowDialog();
                    break;
                }
            }
            f.Close();
            f1.Close();

            if (textBox18.TextLength == 0 || textBox19.TextLength == 0 || textBox1.TextLength == 0)
            {
                textBox18.Clear();
                textBox19.Clear();
                textBox2.Clear();
                textBox1.Clear();
                MessageBox.Show("Для авторизаций заполните все поля!", "Авторизация");
            }
            else if (textBox18.TextLength != 0 & textBox19.TextLength != 0 & textBox1.TextLength != 0)
            {
                if (textBox1.Text != label4.Text)
                {
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox2.Clear();
                    textBox1.Clear();
                    MessageBox.Show("Вы указали неправильный код с картинки, попробуйте ввести его заново!", "Авторизация");
                    Random hf1 = new Random();
                    label4.Text = hf1.Next(10000, 999999).ToString();
                }
                else if (textBox18.Text != login || textBox19.Text != password)
                {
                    textBox18.Clear();
                    textBox19.Clear();
                    textBox2.Clear();
                    textBox1.Clear();
                    MessageBox.Show("Введен неверный логин или пароль!", "Авторизация");
                }
                else if (textBox19.TextLength == 1 || textBox19.TextLength == 2 || textBox19.TextLength == 3 || textBox19.TextLength == 4)
                {
                    MessageBox.Show("пароль должен быть не меньше чем 4 символа!", "Восстановление доступа");
                }
            }
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox18, "Поля для ввода логина.");
        }

        private void textBox19_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox19, "Поля для ввода пароля.");
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox1, "Поля для ввода кода с картинки.");
        }

        private void pictureBox26_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox26, "Кнопка для входа.");
        }

        private void checkBox1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(checkBox1, "Поставьте галочку для того чтобы не вводить логин и пароль каждый раз при входе в программу.");
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(linkLabel1, " Нажмите сюда если вы забыли свой пароль от входа.");         
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(label4, "Картинка с кодам.");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox19.Text;
            textBox19.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox3, "При нажатии на кнопку будет показан пароль.");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox19.Text = textBox2.Text;
            textBox19.Visible = true;
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox4, "При нажатии на кнопку будет скрыт пароль.");
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox2, "Поля для ввода пароля.");
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            Random hf1 = new Random();
            label4.Text = hf1.Next(10000, 999999).ToString();
            try
            {
                string Indicator = File.ReadAllText(@"Indicator.sql");                
                string str = "";
                string proverka = Environment.MachineName;
                str = proverka.ToUpper();               
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
                proverka = str;
                if (Indicator != proverka)
                {
                    File.Delete(@"Indicator.sql");
                }
                StreamReader f2 = new StreamReader(@"Indicator.sql", true);
                while ((Indicator = f2.ReadLine()) != null)
                {
                    if (Indicator == proverka)
                    {
                        this.Hide();
                        Form2 fr = new Form2();
                        fr.ShowDialog();
                        this.Close();
                        break;
                    }
                }
                f2.Close();
            }
            catch
            {
                
            }
        }

        private void textBox18_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string str = "";
            str = textBox18.Text.ToUpper();

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

            string str1 = "";
            str1 = textBox19.Text.ToUpper();

            for (int i1 = 0; i1 < str1.Length; ++i1)
            {
                char[] hifrovka1 = str1.ToCharArray();

                if (hifrovka1[i1] == 'A')
                {
                    str1 = str1.Replace("A", "!");
                }
                else if (hifrovka1[i1] == 'B')
                {
                    str1 = str1.Replace("B", "@");
                }
                else if (hifrovka1[i1] == 'C')
                {
                    str1 = str1.Replace("C", "#");
                }
                else if (hifrovka1[i1] == 'D')
                {
                    str1 = str1.Replace("D", "$");
                }
                else if (hifrovka1[i1] == 'E')
                {
                    str1 = str1.Replace("E", "%");
                }
                else if (hifrovka1[i1] == 'F')
                {
                    str1 = str1.Replace("F", "^");
                }
                else if (hifrovka1[i1] == 'G')
                {
                    str1 = str1.Replace("G", "&");
                }
                else if (hifrovka1[i1] == 'H')
                {
                    str1 = str1.Replace("H", "?");
                }
                else if (hifrovka1[i1] == 'I')
                {
                    str1 = str1.Replace("I", "*");
                }
                else if (hifrovka1[i1] == 'J')
                {
                    str1 = str1.Replace("J", "(");
                }
                else if (hifrovka1[i1] == 'K')
                {
                    str1 = str1.Replace("K", ")");
                }
                else if (hifrovka1[i1] == 'L')
                {
                    str1 = str1.Replace("L", "_");
                }
                else if (hifrovka1[i1] == 'M')
                {
                    str1 = str1.Replace("M", "-");
                }
                else if (hifrovka1[i1] == 'N')
                {
                    str1 = str1.Replace("N", "=");
                }
                else if (hifrovka1[i1] == 'O')
                {
                    str1 = str1.Replace("O", "+");
                }
                else if (hifrovka1[i1] == 'P')
                {
                    str1 = str1.Replace("P", "Ж");
                }
                else if (hifrovka1[i1] == 'Q')
                {
                    str1 = str1.Replace("Q", ",");
                }
                else if (hifrovka1[i1] == 'R')
                {
                    str1 = str1.Replace("R", ".");
                }
                else if (hifrovka1[i1] == 'S')
                {
                    str1 = str1.Replace("S", ":");
                }
                else if (hifrovka1[i1] == 'T')
                {
                    str1 = str1.Replace("T", ";");
                }
                else if (hifrovka1[i1] == 'U')
                {
                    str1 = str1.Replace("U", "[");
                }
                else if (hifrovka1[i1] == 'V')
                {
                    str1 = str1.Replace("V", "]");
                }
                else if (hifrovka1[i1] == 'W')
                {
                    str1 = str1.Replace("W", "{");
                }
                else if (hifrovka1[i1] == 'X')
                {
                    str1 = str1.Replace("X", "}");
                }
                else if (hifrovka1[i1] == 'Z')
                {
                    str1 = str1.Replace("Z", "|");
                }
                else if (hifrovka1[i1] == '1')
                {
                    str1 = str1.Replace("1", "Й");
                }
                else if (hifrovka1[i1] == '2')
                {
                    str1 = str1.Replace("2", "Ц");
                }
                else if (hifrovka1[i1] == '3')
                {
                    str1 = str1.Replace("3", "У");
                }
                else if (hifrovka1[i1] == '4')
                {
                    str1 = str1.Replace("4", "К");
                }
                else if (hifrovka1[i1] == '5')
                {
                    str1 = str1.Replace("5", "Е");
                }
                else if (hifrovka1[i1] == '6')
                {
                    str1 = str1.Replace("6", "Н");
                }
                else if (hifrovka1[i1] == '7')
                {
                    str1 = str1.Replace("7", "Г");
                }
                else if (hifrovka1[i1] == '8')
                {
                    str1 = str1.Replace("8", "Ш");
                }
                else if (hifrovka1[i1] == '9')
                {
                    str1 = str1.Replace("9", "Щ");
                }
                else if (hifrovka1[i1] == '0')
                {
                    str1 = str1.Replace("0", "З");
                }
                else if (hifrovka1[i1] == 'А')
                {
                    str = str.Replace("А", "!");
                }
                else if (hifrovka1[i1] == 'Б')
                {
                    str = str.Replace("Б", "@");
                }
                else if (hifrovka1[i1] == 'В')
                {
                    str = str.Replace("В", "#");
                }
                else if (hifrovka1[i1] == 'Г')
                {
                    str = str.Replace("Г", "$");
                }
                else if (hifrovka1[i1] == 'Д')
                {
                    str = str.Replace("Д", "%");
                }
                else if (hifrovka1[i1] == 'Е')
                {
                    str = str.Replace("Е", "^");
                }
                else if (hifrovka1[i1] == 'Ё')
                {
                    str = str.Replace("Ё", "&");
                }
                else if (hifrovka1[i1] == 'Ж')
                {
                    str = str.Replace("Ж", "?");
                }
                else if (hifrovka1[i1] == 'З')
                {
                    str = str.Replace("З", "*");
                }
                else if (hifrovka1[i1] == 'И')
                {
                    str = str.Replace("И", "(");
                }
                else if (hifrovka1[i1] == 'Й')
                {
                    str = str.Replace("Й", ")");
                }
                else if (hifrovka1[i1] == 'К')
                {
                    str = str.Replace("К", "_");
                }
                else if (hifrovka1[i1] == 'Л')
                {
                    str = str.Replace("Л", "-");
                }
                else if (hifrovka1[i1] == 'М')
                {
                    str = str.Replace("М", "=");
                }
                else if (hifrovka1[i1] == 'Н')
                {
                    str = str.Replace("Н", "+");
                }
                else if (hifrovka1[i1] == 'О')
                {
                    str = str.Replace("О", "L");
                }
                else if (hifrovka1[i1] == 'П')
                {
                    str = str.Replace("П", ",");
                }
                else if (hifrovka1[i1] == 'Р')
                {
                    str = str.Replace("Р", ".");
                }
                else if (hifrovka1[i1] == 'С')
                {
                    str = str.Replace("С", ":");
                }
                else if (hifrovka1[i1] == 'Т')
                {
                    str = str.Replace("Т", ";");
                }
                else if (hifrovka1[i1] == 'У')
                {
                    str = str.Replace("У", "[");
                }
                else if (hifrovka1[i1] == 'Ф')
                {
                    str = str.Replace("Ф", "]");
                }
                else if (hifrovka1[i1] == 'Х')
                {
                    str = str.Replace("Х", "{");
                }
                else if (hifrovka1[i1] == 'Ц')
                {
                    str = str.Replace("Ц", "}");
                }
                else if (hifrovka1[i1] == 'Ч')
                {
                    str = str.Replace("Ч", "|");
                }
                else if (hifrovka1[i1] == 'Ш')
                {
                    str = str.Replace("Ш", "V");
                }
                else if (hifrovka1[i1] == 'Щ')
                {
                    str = str.Replace("Щ", "~");
                }
                else if (hifrovka1[i1] == 'Ъ')
                {
                    str = str.Replace("Ъ", "`");
                }
                else if (hifrovka1[i1] == 'Ы')
                {
                    str = str.Replace("Ы", "K");
                }
                else if (hifrovka1[i1] == 'Ь')
                {
                    str = str.Replace("Ь", "№");
                }
                else if (hifrovka1[i1] == 'Э')
                {
                    str = str.Replace("Э", "Z");
                }
                else if (hifrovka1[i1] == 'Ю')
                {
                    str = str.Replace("Ю", "M");
                }
                else if (hifrovka1[i1] == 'Я')
                {
                    str = str.Replace("Я", "N");
                }
            }
            textBox18.Text = str;
            textBox19.Text = str1;

            if (checkBox1.Checked == true)
            {
                try
                {
                    string login;
                    string password;
                    textBox2.Text = textBox19.Text;
                    StreamReader f = new StreamReader(@"login.sql", true);
                    StreamReader f1 = new StreamReader(@"password.sql", true);

                    while ((login = f.ReadLine()) != null & (password = f1.ReadLine()) != null)
                    {
                        if (textBox18.Text == login & textBox19.Text == password & textBox1.Text == label4.Text)
                        {
                            for (int i = 0; i < label5.Text.Length; ++i)
                            {
                                char[] hifrovka = label5.Text.ToCharArray();

                                if (hifrovka[i] == 'A')
                                {
                                    label5.Text = label5.Text.Replace("A", "!");
                                }
                                else if (hifrovka[i] == 'B')
                                {
                                    label5.Text = label5.Text.Replace("B", "@");
                                }
                                else if (hifrovka[i] == 'C')
                                {
                                    label5.Text = label5.Text.Replace("C", "#");
                                }
                                else if (hifrovka[i] == 'D')
                                {
                                    label5.Text = label5.Text.Replace("D", "$");
                                }
                                else if (hifrovka[i] == 'E')
                                {
                                    label5.Text = label5.Text.Replace("E", "%");
                                }
                                else if (hifrovka[i] == 'F')
                                {
                                    label5.Text = label5.Text.Replace("F", "^");
                                }
                                else if (hifrovka[i] == 'G')
                                {
                                    label5.Text = label5.Text.Replace("G", "&");
                                }
                                else if (hifrovka[i] == 'H')
                                {
                                    label5.Text = label5.Text.Replace("H", "?");
                                }
                                else if (hifrovka[i] == 'I')
                                {
                                    label5.Text = label5.Text.Replace("I", "*");
                                }
                                else if (hifrovka[i] == 'J')
                                {
                                    label5.Text = label5.Text.Replace("J", "(");
                                }
                                else if (hifrovka[i] == 'K')
                                {
                                    label5.Text = label5.Text.Replace("K", ")");
                                }
                                else if (hifrovka[i] == 'L')
                                {
                                    label5.Text = label5.Text.Replace("L", "_");
                                }
                                else if (hifrovka[i] == 'M')
                                {
                                    label5.Text = label5.Text.Replace("M", "-");
                                }
                                else if (hifrovka[i] == 'N')
                                {
                                    label5.Text = label5.Text.Replace("N", "=");
                                }
                                else if (hifrovka[i] == 'O')
                                {
                                    label5.Text = label5.Text.Replace("O", "+");
                                }
                                else if (hifrovka[i] == 'P')
                                {
                                    label5.Text = label5.Text.Replace("P", "Ж");
                                }
                                else if (hifrovka[i] == 'Q')
                                {
                                    label5.Text = label5.Text.Replace("Q", ",");
                                }
                                else if (hifrovka[i] == 'R')
                                {
                                    label5.Text = label5.Text.Replace("R", ".");
                                }
                                else if (hifrovka[i] == 'S')
                                {
                                    label5.Text = label5.Text.Replace("S", ":");
                                }
                                else if (hifrovka[i] == 'T')
                                {
                                    label5.Text = label5.Text.Replace("T", ";");
                                }
                                else if (hifrovka[i] == 'U')
                                {
                                    label5.Text = label5.Text.Replace("U", "[");
                                }
                                else if (hifrovka[i] == 'V')
                                {
                                    label5.Text = label5.Text.Replace("V", "]");
                                }
                                else if (hifrovka[i] == 'W')
                                {
                                    label5.Text = label5.Text.Replace("W", "{");
                                }
                                else if (hifrovka[i] == 'X')
                                {
                                    label5.Text = label5.Text.Replace("X", "}");
                                }
                                else if (hifrovka[i] == 'Z')
                                {
                                    label5.Text = label5.Text.Replace("Z", "|");
                                }
                                else if (hifrovka[i] == '1')
                                {
                                    label5.Text = label5.Text.Replace("1", "Й");
                                }
                                else if (hifrovka[i] == '2')
                                {
                                    label5.Text = label5.Text.Replace("2", "Ц");
                                }
                                else if (hifrovka[i] == '3')
                                {
                                    label5.Text = label5.Text.Replace("3", "У");
                                }
                                else if (hifrovka[i] == '4')
                                {
                                    label5.Text = label5.Text.Replace("4", "К");
                                }
                                else if (hifrovka[i] == '5')
                                {
                                    label5.Text = label5.Text.Replace("5", "Е");
                                }
                                else if (hifrovka[i] == '6')
                                {
                                    label5.Text = label5.Text.Replace("6", "Н");
                                }
                                else if (hifrovka[i] == '7')
                                {
                                    label5.Text = label5.Text.Replace("7", "Г");
                                }
                                else if (hifrovka[i] == '8')
                                {
                                    label5.Text = label5.Text.Replace("8", "Ш");
                                }
                                else if (hifrovka[i] == '9')
                                {
                                    label5.Text = label5.Text.Replace("9", "Щ");
                                }
                                else if (hifrovka[i] == '0')
                                {
                                    label5.Text = label5.Text.Replace("0", "З");
                                }
                                else if (hifrovka[i] == 'А')
                                {
                                    label5.Text = label5.Text.Replace("А", "!");
                                }
                                else if (hifrovka[i] == 'Б')
                                {
                                    label5.Text = label5.Text.Replace("Б", "@");
                                }
                                else if (hifrovka[i] == 'В')
                                {
                                    label5.Text = label5.Text.Replace("В", "#");
                                }
                                else if (hifrovka[i] == 'Г')
                                {
                                    label5.Text = label5.Text.Replace("Г", "$");
                                }
                                else if (hifrovka[i] == 'Д')
                                {
                                    label5.Text = label5.Text.Replace("Д", "%");
                                }
                                else if (hifrovka[i] == 'Е')
                                {
                                    label5.Text = label5.Text.Replace("Е", "^");
                                }
                                else if (hifrovka[i] == 'Ё')
                                {
                                    label5.Text = label5.Text.Replace("Ё", "&");
                                }
                                else if (hifrovka[i] == 'Ж')
                                {
                                    label5.Text = label5.Text.Replace("Ж", "?");
                                }
                                else if (hifrovka[i] == 'З')
                                {
                                    label5.Text = label5.Text.Replace("З", "*");
                                }
                                else if (hifrovka[i] == 'И')
                                {
                                    label5.Text = label5.Text.Replace("И", "(");
                                }
                                else if (hifrovka[i] == 'Й')
                                {
                                    label5.Text = label5.Text.Replace("Й", ")");
                                }
                                else if (hifrovka[i] == 'К')
                                {
                                    label5.Text = label5.Text.Replace("К", "_");
                                }
                                else if (hifrovka[i] == 'Л')
                                {
                                    label5.Text = label5.Text.Replace("Л", "-");
                                }
                                else if (hifrovka[i] == 'М')
                                {
                                    label5.Text = label5.Text.Replace("М", "=");
                                }
                                else if (hifrovka[i] == 'Н')
                                {
                                    label5.Text = label5.Text.Replace("Н", "+");
                                }
                                else if (hifrovka[i] == 'О')
                                {
                                    label5.Text = label5.Text.Replace("О", "L");
                                }
                                else if (hifrovka[i] == 'П')
                                {
                                    label5.Text = label5.Text.Replace("П", ",");
                                }
                                else if (hifrovka[i] == 'Р')
                                {
                                    label5.Text = label5.Text.Replace("Р", ".");
                                }
                                else if (hifrovka[i] == 'С')
                                {
                                    label5.Text = label5.Text.Replace("С", ":");
                                }
                                else if (hifrovka[i] == 'Т')
                                {
                                    label5.Text = label5.Text.Replace("Т", ";");
                                }
                                else if (hifrovka[i] == 'У')
                                {
                                    label5.Text = label5.Text.Replace("У", "[");
                                }
                                else if (hifrovka[i] == 'Ф')
                                {
                                    label5.Text = label5.Text.Replace("Ф", "]");
                                }
                                else if (hifrovka[i] == 'Х')
                                {
                                    label5.Text = label5.Text.Replace("Х", "{");
                                }
                                else if (hifrovka[i] == 'Ц')
                                {
                                    label5.Text = label5.Text.Replace("Ц", "}");
                                }
                                else if (hifrovka[i] == 'Ч')
                                {
                                    label5.Text = label5.Text.Replace("Ч", "|");
                                }
                                else if (hifrovka[i] == 'Ш')
                                {
                                    label5.Text = label5.Text.Replace("Ш", "V");
                                }
                                else if (hifrovka[i] == 'Щ')
                                {
                                    label5.Text = label5.Text.Replace("Щ", "~");
                                }
                                else if (hifrovka[i] == 'Ъ')
                                {
                                    label5.Text = label5.Text.Replace("Ъ", "`");
                                }
                                else if (hifrovka[i] == 'Ы')
                                {
                                    label5.Text = label5.Text.Replace("Ы", "K");
                                }
                                else if (hifrovka[i] == 'Ь')
                                {
                                    label5.Text = label5.Text.Replace("Ь", "№");
                                }
                                else if (hifrovka[i] == 'Э')
                                {
                                    label5.Text = label5.Text.Replace("Э", "Z");
                                }
                                else if (hifrovka[i] == 'Ю')
                                {
                                    label5.Text = label5.Text.Replace("Ю", "M");
                                }
                                else if (hifrovka[i] == 'Я')
                                {
                                    label5.Text = label5.Text.Replace("Я", "N");
                                }             
                            }
                            File.AppendAllText(@"Indicator.sql", label5.Text);
                        }
                    }
                    f.Close();
                    f1.Close();

                    if (textBox18.TextLength == 0 || textBox19.TextLength == 0 || textBox1.TextLength == 0)
                    {
                        checkBox1.Checked = false;
                        MessageBox.Show("Для того чтобы запомнить пользователя в системе заполните все поля и нажмите ещё раз на галочку запомнить пользователя в системе!", "Авторизация");
                    }
                    else if (textBox18.TextLength != 0 & textBox19.TextLength != 0 & textBox1.TextLength != 0)
                    {
                        if (textBox1.Text != label4.Text)
                        {
                            checkBox1.Checked = false;
                            MessageBox.Show("Вы указали неправильный код с картинки, попробуйте ввести его заново!", "Авторизация");
                            Random hf1 = new Random();
                            label4.Text = hf1.Next(10000, 999999).ToString();
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Регистрация fr = new Регистрация();
            fr.ShowDialog();
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox1, "Зарегистрировать нового пользователя.");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Регистрация fr = new Регистрация();
            fr.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 HELOK = new Form3();
            HELOK.ShowDialog();
            this.Close();
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox2, "При нажатий на кнопку в попадёте на форму смены пароля.");
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле капча запрещено, в поле капча можно писать только цыфрами!", "Авторизация");
                e.Handled = true;
            }
        }
    }
}
