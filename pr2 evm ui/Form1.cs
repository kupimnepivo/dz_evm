using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dz_evm
{



    public partial class Form1 : Form
    {
        Point lastpoint;

        private int min, max, seed;
        private int[] x;
        private double[] y;


        public Form1()
        {
            InitializeComponent();
        }

        // основные события для формы

        private void panel1_MouseDown(object sender, MouseEventArgs e) // получение текущих координат при нажатии на лкм
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) // движение формы вместе с мышкой при нажатой лкм.
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) // выход из программы
        {
            Application.Exit();
        }

        // ограничения на ввод в текстбоксы

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // проверка нажатия клавиш, дабы вводить только цифры
        {
            if (Char.IsDigit(e.KeyChar) == true | e.KeyChar == (char)Keys.Back | e.KeyChar == (char)'-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void EnterBox_2_KeyPress(object sender, KeyPressEventArgs e) // ввод только нуля и еденицы в текстбокс для перевода из 2 в 10
        {
            if (e.KeyChar == (char)'0' | e.KeyChar == (char)'1' | e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        // функции для помещения данных в таблицы
        private void insertToDGV(int[] x, double[] y) // заполнение первой таблицы для рассчета сигмоид для второй лабы
        {
           
            this.dataGridView1.Rows.Clear();
            for (int i = 0; i < x.Length; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i].Cells[0].Value = x[i];
                this.dataGridView1.Rows[i].Cells[1].Value = Math.Round(y[i], 4);
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);

        }

        private void insertToDGV(List <char> x, int[] y, double[] Z) // заполнение второй таблицы для рассчета энтропии и частоты символов для 3 лабы
        {
            for (int k = 0; k < x.Count; k++)
            {
                this.dataGridView2.Rows.Add(x[k], y[k], Z[k]);
            }
        }

        // функции для передачи данных на график
        private void InsertToChart(int[] x, double[] y) // передача значений в график для второй лабы
        {

            this.chart1.Series[0].Points.Clear();
            for (int i = 0; i < x.Length; i++)
            {
                this.chart1.Series[0].Points.AddXY((double)x[i], y[i]);
            }
            this.chart1.Series[0].Color = Color.Black;

        }

        private void InsertToChart() // передача значений в график для третей лабы
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                this.chart2.Series[0].Points.AddY((double)dataGridView2.Rows[i].Cells[2].Value);
                this.chart2.Series[0].Points[i].AxisLabel = this.dataGridView2.Rows[i].Cells[0].Value.ToString();
            }
        }

        // события для первой лабы

        private void OKButton_1_Click(object sender, EventArgs e) // запуск расчета энтропии
        {
            Entropy ent = new Entropy();
            ent.analyser(EnterBox_1.Text);
            ResultBox_1.Text = ent.string_out;
        }

        private void OKButton_2_Click(object sender, EventArgs e) // запуск перевода из 2 в 10
        {
            To10 toTen = new To10();
            ResultBox_2.Text = toTen.to10(EnterBox_2.Text);
        }

        // события для второй лабы
        private void ChoiceBox_SelectedIndexChanged(object sender, EventArgs e) // функция для изменения альфабокса для функций, где необходима альфа.
        {
            switch (ChoiceBox.SelectedIndex)
            {
                case 2:
                    label4.Visible = true;
                    AlphaBox.Visible = true;
                    break;
                case 3:
                    label4.Visible = true;
                    AlphaBox.Visible = true;
                    break;
                default:
                    label4.Visible = false;
                    AlphaBox.Visible = false;
                    break;
            }
        }

        private void RunButton_Click(object sender, EventArgs e) // событие при нажатие на кнопку Run. запускает собственно весь веселый процесс
        {
            int alpha;
            try
            {
                this.min = Convert.ToInt32(MinTextBox.Text);
                this.max = Convert.ToInt32(MaxTextBox.Text);
                this.seed = Convert.ToInt32(SeedTextBox.Text);
            }
            catch (FormatException)
            {
                this.min = 10;
                this.max = 100;
                this.seed = 1;
            }
            this.x = Sigmoid.NormalDistrib(min, max, seed, 50);
            Array.Sort(x, (x, y) => x.CompareTo(y)); // сортируем x по возрастанию.
            switch (ChoiceBox.SelectedIndex) // выбор уравнения, по которому будут происходит расчеты y
            {
                case 0:
                    this.y = Sigmoid.LogCurve(x);
                    break;
                case 1:
                    this.y = Sigmoid.Guderman(x);
                    break;
                case 2:
                    alpha = Convert.ToInt32(AlphaBox.Text);
                    this.y = Sigmoid.Fermi(x, alpha);
                    break;
                case 3:
                    alpha = Convert.ToInt32(AlphaBox.Text);
                    this.y = Sigmoid.RSigma(x, alpha);
                    break;
            }
            insertToDGV(x, y);
            InsertToChart(x, y);

        }

        // события для третей лабы
        private void CalculateLaba3Button_Click(object sender, EventArgs e)
        {
            TextParser tp = new TextParser(InputLaba3TextBox.Text);
            tp.parser();
            insertToDGV(tp.alfabet, tp.count, tp.frequancy);
            InsertToChart();
            FrequancySumTextBox.Text = tp.frequancy.Sum().ToString();
            MostOftenTextBox.Text = tp.alfabet[Array.IndexOf(tp.count, tp.count.Max())].ToString();
            LessOftenTextBox.Text = tp.alfabet[Array.IndexOf(tp.count, tp.count.Min())].ToString();
            if (LessOftenTextBox.Text == " ")
                LessOftenTextBox.Text = "_";
            if (MostOftenTextBox.Text == " ")
                MostOftenTextBox.Text = "_";
            EntropyTextBox.Text = Math.Round(Math.Abs(tp.entropy), 5).ToString();
            

        }

        // события для четвертой лабы
        private void INCbutton_Click(object sender, EventArgs e)
        {
            ResultLaba4TextBox.Text = Processor.INC(AlphaLaba4TextBox.Text);
        }

        private void SUBbutton_Click(object sender, EventArgs e)
        {
            ResultLaba4TextBox.Text = Processor.SUB(AlphaLaba4TextBox.Text, BettaLaba4TextBox.Text);
        }

        private void DECbutton_Click(object sender, EventArgs e)
        {
            ResultLaba4TextBox.Text = Processor.DEC(AlphaLaba4TextBox.Text);
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            ResultLaba4TextBox.Text = Processor.ADD(AlphaLaba4TextBox.Text, BettaLaba4TextBox.Text);
        }

        private void ADCbutton_Click(object sender, EventArgs e)
        {
            ResultLaba4TextBox.Text = Processor.ADC(AlphaLaba4TextBox.Text, BettaLaba4TextBox.Text);
        }

        

    }

    internal class Entropy // класс расчета энтропии для введенной строки
    {
        public string string_out;
        enum MyEnum // создание перечисления 
        {
            LenghtOfString,
            AmountOfInform,
            LenghtOfWord,
            CountOfInformation
        }

        double N_calc(int M, int Code_Count)
        {
            return Math.Pow(M, Code_Count);
        }

        double I_calc(double N)
        {
            return Math.Log(N, 2);
        }

        void print(string target, MyEnum My) // фукнция дополняет переменную string_out, которая впоследствие будет использована для вывода.
        {
            switch (My)
            {
                case MyEnum.LenghtOfString:
                    string_out += "Значение K: " + target + "\r\n";
                    break;
                case MyEnum.AmountOfInform:
                    string_out += "Значение I: " + target + "\r\n";
                    break;
                case MyEnum.LenghtOfWord:
                    string_out += "Значение N: " + target + "\r\n";
                    break;
                case MyEnum.CountOfInformation:
                    string_out += "Значение V: " + target + "\r\n";
                    break;
            }
        }
        public void analyser(string s)
        {
            int K = s.Length; // длина введенной строки
            int M = 64;            // мощность алфавита
            double N = N_calc(M, 8); // расчет N
            double I = I_calc(N); // расчет I
            double V = K * I; // расчет V
            print(K.ToString(), MyEnum.LenghtOfString); // запись в string_out значения K
            print(N.ToString(), MyEnum.LenghtOfWord); // запись в string_out значения N
            print(I.ToString(), MyEnum.AmountOfInform); // запись в string_out значения I
            print(V.ToString(), MyEnum.CountOfInformation); // запись в string_out значения V
        }
    }

    internal class To10 // класс для перевода из 2 в 10 
    {
        public string to10(string s)
        {
            int _d10 = 0;
            char[] _d2 = s.ToCharArray();   // создаем массив символов из введенной строки
            for (int i = 0; i < s.Length; i++)
            {
                if (_d2[i] == '0') // если символ равен нулю, то ничего с ним не делаем
                    continue;
                _d10 += (int)Math.Pow(2, _d2.Length - i - 1);
            }
            return _d10.ToString();
        }
    }

    internal static class Sigmoid // класс для вычисления значений по функциям сигмоид
    {

        public static int[] NormalDistrib(int min, int max, int seed, int lenght) // функция для генерации массива случайных значений x
        {
            Random rnd = new Random();
            int[] temp = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                temp[i] = rnd.Next(min, max);
            }
            return temp;
        }

        public static double[] LogCurve(int[] x) // считаем y по лог-кривой
        {
            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = 1 / (1 + Math.Exp(-x[i])); // заполняем массив значениями лог-кривой
            }
            return result;
        }

        public static double[] Guderman(int[] x) // считаем y по уравнению гуддерсона
        {
            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = Math.Atan(Math.Tanh(x[i] / 2));
            }
            return result;
        }

        public static double[] Fermi(int[] x, int alpha) // считаем y по уравнению Ферми-Дирака
        {
            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = 1 / (1 + Math.Exp(-2 * alpha * x[i]));
            }
            return result;
        }

        public static double[] RSigma(int[] x, int alpha) // считаем y по рациональной сигмоиде
        {
            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = (double)x[i] / (Math.Abs(x[i]) + (double)alpha);
            }
            return result;
        }
    }

    internal class TextParser // класс для парсинга текста
    {
       string InputLine = "";
       public int[] count;
       public double[] frequancy;
       public double entropy;

       public List<char> alfabet = new List<char>();

        public TextParser(string input)
        {
            this.InputLine = input.ToLower();
        }


        public void parser()
        {
            //по всему тексту
            foreach (char _c in InputLine)
            {
                // записываем в алфавит символ
                alfabet.Add(_c);
            }
            alfabet = alfabet.Distinct().ToList(); // distinct позволяет вернуть уникальные значения массива
            count = new int[alfabet.Count];
            frequancy = new double[alfabet.Count];
            //в массиве по всему алфавиту
            for (int k = 0; k < alfabet.Count; k++)
            {
                //по всей входной строке
                for (int i = 0; i < InputLine.Length; i++)
                {
                    // при совпадении
                    if (InputLine[i] == alfabet[k])
                    {
                        count[k]++;
                    }
                }
                frequancy[k] = count[k] / (double)InputLine.Length;
            }
            for (int i = 0; i < count.Length; i++)
            {

                entropy += ((double)count[i] / InputLine.Length) * Math.Log((double)count[i] / InputLine.Length, 2);
            }
        }
    }

    internal static class Processor // класс для реализации некоторых функций процессоралшббб
    {

        // регистры аккумуляторы
        static byte[] ax = new byte[16];
        static byte[] ax_temp = new byte[16];
        static byte[] bx = new byte[16];
        static byte[] cx = new byte[16];
        static byte[] dx = new byte[16];
        static int alfa = 0, betta = 0;

        static byte CF = 0; // флаг переноса

        private static byte OR(byte x1, byte x2)
        {
            // Пробегаем по всей таблице истинности
            if (x1 == 0 && x2 == 0) // 0 или 0 = 0
            {
                CF = 0;
                return 0;
            }
            if (x1 == 1 && x2 == 1) // 1 или 1 = 0 (и 1 запомнили)
            {
                CF = 1;
                return 0;
            }
            if (x1 == 0 && x2 == 1) // 0 или 1 = 1
            {
                CF = 0;
                return 1;
            }
            if (x1 == 1 && x2 == 0) // 1 или 0 = 1
            {
                CF = 0;
                return 1;
            }
            return 0;
        }
        private static byte OR(byte x1, byte x2, byte F)
        {
            // Пробегаем по всей таблице истинности
            if (x1 == 0 && x2 == 0 && F == 0) // 0 или 0 = 0
            {
                CF = 0;
                return 0;
            }
            if (x1 == 0 && x2 == 0 && F == 1) // 1 или 1 = 0 (и 1 запомнили)
            {
                CF = 0;
                return 1;
            }
            if (x1 == 0 && x2 == 1 && F == 0) // 0 или 1 = 1
            {
                CF = 0;
                return 1;
            }
            if (x1 == 1 && x2 == 0 && F == 0) // 1 или 0 = 1
            {
                CF = 0;
                return 1;
            }
            if (x1 == 1 && x2 == 0 && F == 1) // 0 или 0 = 0
            {
                CF = 1;
                return 0;
            }
            if (x1 == 1 && x2 == 1 && F == 0) // 1 или 1 = 0 (и 1 запомнили)
            {
                CF = 1;
                return 0;
            }
            if (x1 == 1 && x2 == 1 && F == 1) // 0 или 1 = 1
            {
                CF = 1;
                return 1;
            }
            if (x1 == 0 && x2 == 1 && F == 1) // 1 или 0 = 1
            {
                CF = 1;
                return 0;
            }
            return 0;
        }


        private static void INC_temp(int alfa)
        {
            int inc = 1, counter = 0;
            byte[] _temp = new byte[ax.Length];
            if (counter == 0)
            {
                MOV(ax, alfa);
                MOV(bx, inc);
                for (int i = ax.Length - 1; i > 0; i--)
                {
                    _temp[i] = OR(ax[i], bx[i], CF);
                }
                ax = _temp;
            }
            else
            {
                for (int i = ax.Length - 1; i > 0; i--)
                {
                    _temp[i] = OR(ax_temp[i], bx[i], CF);
                }
                ax = _temp;
            }
        }
        private static void DEC_temp(int alfa)
        {
            int inc = 1, counter = 0;
            {
                counter = 0;
                MOV(ax, alfa);
                MOV(bx, inc);
                for (int i = ax.Length - 1; i > 0; i--)
                {
                    if (ax[i] != 0)
                    {
                        ax[i] = 0;
                        for (int j = 1; j <= counter; j++)
                        {
                            ax[i + j] = 1;
                            if (ax[14] == 0)
                            {
                                ax[15] = 1;
                            }
                            if (j == counter - 1)
                                break;
                        }
                        break;
                    }
                    counter++;
                }
            }
        }
        private static byte AND(byte x1, byte x2)
        {
            if (x1 == 0 && x2 == 0) return 0;
            if (x1 == 1 && x2 == 0) return 0;
            if (x1 == 1 && x2 == 1)


                return 1;

            if (x1 == 0 && x2 == 1) return 0;
            return 0;
        }
        private static byte XOR(byte x1, byte x2)
        {
            if (x1 == 0 && x2 == 0) return 0;
            if (x1 == 1 && x2 == 0) return 1;
            if (x1 == 1 && x2 == 1) return 0;
            if (x1 == 0 && x2 == 1)
            {
                CF = 1;
                return 1;
            }
            return 0;
        }
        private static void MOV(byte[] registr, int value)
        {
            // Перевод десятичного числа в двоичное
            char[] s_1 = (Convert.ToString(Convert.ToInt32(value), 2)).ToArray();
            // Вычисляем разницу в размерности между двоичным числом и регистром
            int _gap = registr.Length - s_1.Length;
            // Создаем счетчик для двоичного числа
            int _cc = s_1.Length - 1;
            // По разрядам регистра с конца в начало
            for (int i = registr.Length - 1; i > 0; i--)
            {
                // Если индекс все еще больше, чем разница между размерностью чисел минус 1
                if (i > _gap - 1)
                {
                    // Если двоичный символ 1
                    if (s_1[_cc] == '1')
                    {
                        // Запомнить битовую единицу
                        registr[i] = 1;
                    }
                    // Если двоичный символ 0
                    if (s_1[_cc] == '0')
                    {
                        // Запомнить битовый ноль
                        registr[i] = 0;
                    }
                    _cc--;
                }
                else
                {
                    registr[i] = 0;
                }
            }
        }
        private static void ADD_temp(int alfa, int betta)
        {
            // Вызов функции перемещения числа в регистры
            MOV(ax, alfa);
            MOV(bx, betta);
            // Печать регистров на экран
            // Содаем временный массив байт
            byte[] _temp = new byte[ax.Length];
            // В цикле по всему регистру АХ с начала и до конца
            for (int i = ax.Length - 1; i > 0; i--)
            {
                // Выполняем операцию логического ИЛИ
                _temp[i] = OR(ax[i], bx[i]);
            }
            // Приравниваем полученные временные массив к регистру АХ
            ax = _temp;
        }
        private static void SUB_temp(int alfa, int betta)
        {
            MOV(ax, alfa);
            MOV(bx, betta);
            byte[] _temp = new byte[ax.Length];
            for (int i = 0; i < ax.Length; i++)
            {
                _temp[i] = XOR(ax[i], bx[i]);
            }
            ax = _temp;
        }
        private static void ADC_temp(int alfa, int betta)
        {
            MOV(ax, alfa);
            MOV(bx, betta);
            byte[] _temp = new byte[ax.Length];
            for (int i = ax.Length - 1; i > 0; i--)
            {
                _temp[i] = OR(ax[i], bx[i], CF);
            }
            ax = _temp;
        }
        public static string INC(string InputLineAlpha)
        {
            alfa = (Convert.ToInt32(InputLineAlpha));
            INC_temp(alfa);
            string output = "";
            for (int i = 0; i < ax.Length; i++)
            {
                output += Convert.ToString(ax[i]);
            }
            return output;
        }
        public static string DEC(string InputLineAlpha)
        {
            alfa = (Convert.ToInt32(InputLineAlpha));
            DEC_temp(alfa);
            string output = "";
            for (int i = 0; i < ax.Length; i++)
            {
                output += Convert.ToString(ax[i]);
            }
            return output;

        }
        public static string SUB(string InputLineAlpha, string InputLineBetta)
        {
            alfa = (Convert.ToInt32(InputLineAlpha));
            betta = (Convert.ToInt32(InputLineBetta));
            string output;
            if (alfa >= betta)
            {
                SUB_temp(alfa, betta);
                output = "";
            }
            else
            {
                SUB_temp(betta, alfa);
                output = "-";
            }
            for (int i = 0; i < ax.Length; i++)
            {
                output += Convert.ToString(ax[i]);
            }
            return output;

        }
        public static string ADD(string InputLineAlpha, string InputLineBetta)
        {
            alfa = (Convert.ToInt32(InputLineAlpha));
            betta = (Convert.ToInt32(InputLineBetta));
            string output = "";
            ADD_temp(alfa, betta);
            for (int i = 0; i < ax.Length; i++)
            {
                output += Convert.ToString(ax[i]);
            }
            return output;
        }
        public static string ADC(string InputLineAlpha, string InputLineBetta)
        {
            alfa = (Convert.ToInt32(InputLineAlpha));
            betta = (Convert.ToInt32(InputLineBetta));
            string output = "";
            ADC_temp(alfa, betta);
            for (int i = 0; i < ax.Length; i++)
            {
                output += Convert.ToString(ax[i]);
            }
            return output;

        }
    }
}
