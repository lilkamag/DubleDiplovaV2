using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp19
{
    public partial class Регистрация : Form
    {
        Random rnd = new Random();
        StringBuilder str = new StringBuilder(8);
        List<int> Symbols = new List<int> { 35, 36, 37, 38, 42, 64 };
        public Регистрация()
        {
            InitializeComponent();
            Screen currentScreen = Screen.FromRectangle(Bounds);
            Random hf1 = new Random();
            label7.Text = hf1.Next(10000, 999999).ToString();
        }
        public void FakeTransTextBox()
        {

        }
        private void Регистрация_Load(object sender, EventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }     
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string str233 = "";
            str233 = textBox14.Text.ToUpper();

            for (int i = 0; i < str233.Length; ++i)
            {
                char[] hifrovka = str233.ToCharArray();

                if (hifrovka[i] == 'A')
                {
                    str233 = str233.Replace("A", "!");
                }
                else if (hifrovka[i] == 'B')
                {
                    str233 = str233.Replace("B", "@");
                }
                else if (hifrovka[i] == 'C')
                {
                    str233 = str233.Replace("C", "#");
                }
                else if (hifrovka[i] == 'D')
                {
                    str233 = str233.Replace("D", "$");
                }
                else if (hifrovka[i] == 'E')
                {
                    str233 = str233.Replace("E", "%");
                }
                else if (hifrovka[i] == 'F')
                {
                    str233 = str233.Replace("F", "^");
                }
                else if (hifrovka[i] == 'G')
                {
                    str233 = str233.Replace("G", "&");
                }
                else if (hifrovka[i] == 'H')
                {
                    str233 = str233.Replace("H", "?");
                }
                else if (hifrovka[i] == 'I')
                {
                    str233 = str233.Replace("I", "*");
                }
                else if (hifrovka[i] == 'J')
                {
                    str233 = str233.Replace("J", "(");
                }
                else if (hifrovka[i] == 'K')
                {
                    str233 = str233.Replace("K", ")");
                }
                else if (hifrovka[i] == 'L')
                {
                    str233 = str233.Replace("L", "_");
                }
                else if (hifrovka[i] == 'M')
                {
                    str233 = str233.Replace("M", "-");
                }
                else if (hifrovka[i] == 'N')
                {
                    str233 = str233.Replace("N", "=");
                }
                else if (hifrovka[i] == 'O')
                {
                    str233 = str233.Replace("O", "+");
                }
                else if (hifrovka[i] == 'P')
                {
                    str233 = str233.Replace("P", "Ж");
                }
                else if (hifrovka[i] == 'Q')
                {
                    str233 = str233.Replace("Q", ",");
                }
                else if (hifrovka[i] == 'R')
                {
                    str233 = str233.Replace("R", ".");
                }
                else if (hifrovka[i] == 'S')
                {
                    str233 = str233.Replace("S", ":");
                }
                else if (hifrovka[i] == 'T')
                {
                    str233 = str233.Replace("T", ";");
                }
                else if (hifrovka[i] == 'U')
                {
                    str233 = str233.Replace("U", "[");
                }
                else if (hifrovka[i] == 'V')
                {
                    str233 = str233.Replace("V", "]");
                }
                else if (hifrovka[i] == 'W')
                {
                    str233 = str233.Replace("W", "{");
                }
                else if (hifrovka[i] == 'X')
                {
                    str233 = str233.Replace("X", "}");
                }
                else if (hifrovka[i] == 'Z')
                {
                    str233 = str233.Replace("Z", "|");
                }
                else if (hifrovka[i] == '1')
                {
                    str233 = str233.Replace("1", "Й");
                }
                else if (hifrovka[i] == '2')
                {
                    str233 = str233.Replace("2", "Ц");
                }
                else if (hifrovka[i] == '3')
                {
                    str233 = str233.Replace("3", "У");
                }
                else if (hifrovka[i] == '4')
                {
                    str233 = str233.Replace("4", "К");
                }
                else if (hifrovka[i] == '5')
                {
                    str233 = str233.Replace("5", "Е");
                }
                else if (hifrovka[i] == '6')
                {
                    str233 = str233.Replace("6", "Н");
                }
                else if (hifrovka[i] == '7')
                {
                    str233 = str233.Replace("7", "Г");
                }
                else if (hifrovka[i] == '8')
                {
                    str233 = str233.Replace("8", "Ш");
                }
                else if (hifrovka[i] == '9')
                {
                    str233 = str233.Replace("9", "Щ");
                }
                else if (hifrovka[i] == '0')
                {
                    str233 = str233.Replace("0", "З");
                }
                else if (hifrovka[i] == 'А')
                {
                    str233 = str233.Replace("А", "!");
                }
                else if (hifrovka[i] == 'Б')
                {
                    str233 = str233.Replace("Б", "@");
                }
                else if (hifrovka[i] == 'В')
                {
                    str233 = str233.Replace("В", "#");
                }
                else if (hifrovka[i] == 'Г')
                {
                    str233 = str233.Replace("Г", "$");
                }
                else if (hifrovka[i] == 'Д')
                {
                    str233 = str233.Replace("Д", "%");
                }
                else if (hifrovka[i] == 'Е')
                {
                    str233 = str233.Replace("Е", "^");
                }
                else if (hifrovka[i] == 'Ё')
                {
                    str233 = str233.Replace("Ё", "&");
                }
                else if (hifrovka[i] == 'Ж')
                {
                    str233 = str233.Replace("Ж", "?");
                }
                else if (hifrovka[i] == 'З')
                {
                    str233 = str233.Replace("З", "*");
                }
                else if (hifrovka[i] == 'И')
                {
                    str233 = str233.Replace("И", "(");
                }
                else if (hifrovka[i] == 'Й')
                {
                    str233 = str233.Replace("Й", ")");
                }
                else if (hifrovka[i] == 'К')
                {
                    str233 = str233.Replace("К", "_");
                }
                else if (hifrovka[i] == 'Л')
                {
                    str233 = str233.Replace("Л", "-");
                }
                else if (hifrovka[i] == 'М')
                {
                    str233 = str233.Replace("М", "=");
                }
                else if (hifrovka[i] == 'Н')
                {
                    str233 = str233.Replace("Н", "+");
                }
                else if (hifrovka[i] == 'О')
                {
                    str233 = str233.Replace("О", "L");
                }
                else if (hifrovka[i] == 'П')
                {
                    str233 = str233.Replace("П", ",");
                }
                else if (hifrovka[i] == 'Р')
                {
                    str233 = str233.Replace("Р", ".");
                }
                else if (hifrovka[i] == 'С')
                {
                    str233 = str233.Replace("С", ":");
                }
                else if (hifrovka[i] == 'Т')
                {
                    str233 = str233.Replace("Т", ";");
                }
                else if (hifrovka[i] == 'У')
                {
                    str233 = str233.Replace("У", "[");
                }
                else if (hifrovka[i] == 'Ф')
                {
                    str233 = str233.Replace("Ф", "]");
                }
                else if (hifrovka[i] == 'Х')
                {
                    str233 = str233.Replace("Х", "{");
                }
                else if (hifrovka[i] == 'Ц')
                {
                    str233 = str233.Replace("Ц", "}");
                }
                else if (hifrovka[i] == 'Ч')
                {
                    str233 = str233.Replace("Ч", "|");
                }
                else if (hifrovka[i] == 'Ш')
                {
                    str233 = str233.Replace("Ш", "V");
                }
                else if (hifrovka[i] == 'Щ')
                {
                    str233 = str233.Replace("Щ", "~");
                }
                else if (hifrovka[i] == 'Ъ')
                {
                    str233 = str233.Replace("Ъ", "`");
                }
                else if (hifrovka[i] == 'Ы')
                {
                    str233 = str233.Replace("Ы", "K");
                }
                else if (hifrovka[i] == 'Ь')
                {
                    str233 = str233.Replace("Ь", "№");
                }
                else if (hifrovka[i] == 'Э')
                {
                    str233 = str233.Replace("Э", "Z");
                }
                else if (hifrovka[i] == 'Ю')
                {
                    str233 = str233.Replace("Ю", "M");
                }
                else if (hifrovka[i] == 'Я')
                {
                    str233 = str233.Replace("Я", "N");
                }
            }
            textBox14.Text = str233;
            textBox3.Visible = true;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox4.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            string login1;
            StreamReader f1 = new StreamReader(@"login.sql", true);
            while ((login1 = f1.ReadLine()) != null)
            {
                if (textBox14.Text == login1)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox14.Clear();
                    MessageBox.Show("Такой пользователь с таким логином уже существует!", "Регестрация");
                    break;
                }
            }
            f1.Close();

            if (textBox14.Text != login1)
            {
                if (textBox14.TextLength == 0 || textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || textBox4.TextLength == 0 || textBox5.TextLength == 0)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox14.Clear();
                    MessageBox.Show("Заполните все поля!", "Регестрация");
                }
                else if (textBox14.Text != "" & textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "")
                {
                    if (textBox5.Text != label7.Text)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox14.Clear();
                        MessageBox.Show("Не верно введён код с картинки по пробуйте ещё раз!", "Регистрация");
                        Random hf1 = new Random();
                        label7.Text = hf1.Next(10000, 999999).ToString();
                    }
                    else if (textBox3.Text != textBox4.Text)
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        textBox14.Clear();
                        MessageBox.Show("Пароли не совпадают!", "Регестрация");
                    }
                    else if (textBox5.Text == label7.Text)
                    {
                        if (textBox14.TextLength != 1 & textBox14.TextLength != 2 & textBox14.TextLength != 3 & textBox3.TextLength != 1 & textBox3.TextLength != 2 & textBox3.TextLength != 3)
                        {                            
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

                            string str1 = "";
                            str1 = textBox3.Text.ToUpper();

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
                            textBox14.Text = str;
                            textBox3.Text = str1;
                            File.AppendAllText("login.sql", textBox14.Text + Environment.NewLine);
                            File.AppendAllText("password.sql", textBox3.Text + Environment.NewLine);

                            try
                            {
                                File.Delete(@"Indicator.sql");
                                File.Create(@"Indicator.sql");
                            }
                            catch
                            {

                            }
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox14.Clear();
                            MessageBox.Show("Новый пользователь успешно зарегистрирован!", "Регестрация");
                            this.Hide();
                            Form2 f = new Form2();
                            f.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            textBox6.Clear();
                            textBox7.Clear();
                            textBox14.Clear();
                            MessageBox.Show("При регистрации пароль и логин не должен быть меньше четырех символов!", "Регестрация");
                        } 
                    }
                }
            }
        }
      
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click_1(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox14, "Поля для ввода логина.");
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

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox3, "Поля для ввода пароля.");
        }

        private void textBox7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox7, "Поля для ввода пароля.");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(label7, "Картинка с кодам.");
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(textBox5, "Поля для ввода кода с картинки.");
        }

        private void pictureBox23_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox23, "Нажмите кнопку для того чтобы зарегистрироваться.");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox20_MouseEnter(object sender, EventArgs e)
        {

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

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox4, "Нажмите кнопку для того чтобы сгенерировать пароль.");
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация f = new Авторизация();
            f.ShowDialog();
        }

        private void pictureBox27_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox27, "Вернуться обратно на форму Авторизации.");
        }

        private void pictureBox27_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поля имя запрещено, имя должно быть написано только буквами!", "Регистрация");
                e.Handled = true;
            }                
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (ModifierKeys == Keys.Control) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод цифр и символов в поля фамилия запрещено, имя должно быть написано только буквами!", "Регистрация");
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (ModifierKeys == Keys.Control) || e.KeyChar == (char)Keys.Back || (ModifierKeys == Keys.Control))
            {
                return;
            }
            else
            {
                MessageBox.Show("Ввод букв и символов в поле капча запрещено, в поле капча можно писать только цыфрами!", "Регистрация");
                e.Handled = true;
            }
        }
    }
}
    
