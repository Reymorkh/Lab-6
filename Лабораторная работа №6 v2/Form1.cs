using System;
using static System.Net.Mime.MediaTypeNames;

namespace Лабораторная_работа__6_v2
{
    public partial class Form1 : Form
    {
        public static bool isEdit1, Task2Init = false;
        public static int[] arrayMainOne;
        public static Random random = new Random();
        public static string Task2;
        public Form1()
        {
            InitializeComponent();

        }

        int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pen = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    pen++;
                    SwapInt(ref array[pen], ref array[i]);
                }
            }

            pen++;
            SwapInt(ref array[pen], ref array[maxIndex]);
            return pen;
        }

        int[] HoarahSort(int[] array, int indexLeft, int indexRight)
        {
            if (indexLeft >= indexRight)
            {
                return array; //финальная сдача массива
            }

            var pivotIndex = Partition(array, indexLeft, indexRight); // определение опорного элемента в массиве и перестановка
            HoarahSort(array, indexLeft, pivotIndex - 1); // сорт по краям от опорного элемента
            HoarahSort(array, pivotIndex + 1, indexRight); // сорт по краям от опорного элемента

            return array;
        }

        public static void SwapInt(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void OneDimCreateButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            f.Dispose();
            Form2.textBoxes.Clear();
            Form2.labels.Clear();
            if (Form2.isInitialized)
                OneDimPrint();
        }

        private void OneDimEditButton_Click(object sender, EventArgs e)
        {
            if (Form2.isInitialized)
            {
                isEdit1 = true;
                Form2 f = new Form2();
                f.ShowDialog();
                f.Dispose();
                Form2.textBoxes.Clear();
                Form2.labels.Clear();
                if (arrayMainOne.Length > 0)
                    OneDimPrint();
                isEdit1 = false;
            }
            else
                MessageBox.Show("Не с чем работать.", "Ошибка");
        }

        private void OneDimPrintButton_Click(object sender, EventArgs e)
        {
            OneDimPrint();
        }

        public void OneDimPrint()
        {
            MainWindow.Text = "Одномерный массив массив:";
            if (Form2.isInitialized)
            {
                int temp = 0;
                do
                {
                    MainWindow.Text += Environment.NewLine;
                    if (arrayMainOne.Length % 10 != 0)
                        switch (arrayMainOne.Length - temp > 10)
                        {
                            case (true):
                                OneDimSubPrint(temp, 10);
                                break;

                            case (false):
                                OneDimSubPrint(temp, arrayMainOne.Length - temp);
                                break;
                        }
                    else
                        OneDimSubPrint(temp, 10);
                    temp += 10;
                }
                while (temp < arrayMainOne.Length);
            }
            else
                MessageBox.Show("Массив пока не инициализирован.", "Ошибка");
        }

        public void OneDimSubPrint(int temp, int x)
        {
            for (int i = temp; i < temp + x; i++)
                MainWindow.Text += arrayMainOne[i] + " ";
        }

        private void OneDimRandomButton_Click(object sender, EventArgs e)
        {
            if (Form2.isInitialized && arrayMainOne.Length > 0)
            {
                for (int i = 0; i < arrayMainOne.Length; i++)
                    arrayMainOne[i] = random.Next(-100, 100);
                OneDimPrint();
            }
            else
                MessageBox.Show("Массив не инициализирован.", "Ошибка");
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (Form2.isInitialized)
            {
                int[] arrayTemp = new int[arrayMainOne.Length];
                for (int i = 0; i < arrayMainOne.Length; i++)
                    arrayTemp[i] = arrayMainOne[i];
                arrayTemp = HoarahSort(arrayTemp, 0, arrayTemp.Length - 1);
                int j = 0;
                for (int i = 0; i < arrayMainOne.Length; i++)
                {
                    if (arrayMainOne[i] % 2 == 0)
                    {
                        arrayMainOne[i] = arraySearch(arrayTemp, ref j);
                    }
                }
                OneDimPrint();
            }
            else
                MessageBox.Show("Массив не инициализирован.", "Ошибка");
        }

        public int arraySearch(int[] arrayTemp, ref int j)
        {
            for (int i = j; i < arrayTemp.Length; i++)
                if (arrayTemp[i] % 2 == 0)
                {
                    j = i + 1;
                    return arrayTemp[i];
                }
            return -1;
        }

        private void StringEnterButton_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
            f.Dispose();
            if (Task2Init)
                MainWindow.Text = "Введённая строка:" + Environment.NewLine + Task2;
            else
                MessageBox.Show("Не с чем работать.", "Ошибка");
        }

        private void StringPrintButton_Click(object sender, EventArgs e)
        {
            if (Task2Init)
                MainWindow.Text = "Введённая строка:" + Environment.NewLine + Task2;
            else
                MessageBox.Show("Не с чем работать.", "Ошибка");
        }

        private void ReverseStringButton_Click(object sender, EventArgs e)
        {
            if (Task2Init)
            {
                string[] sentences = Task2.Split(new char[] { '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < sentences.Length; i++)
                {
                    if ((i + 1) % 2 == 1)
                    {
                        string[] words = sentences[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        Array.Reverse(words);
                        sentences[i] = string.Empty;
                        int j;
                        for (j = 0; j < words.Length - 1; j++)
                            sentences[i] += words[j] + " ";
                        sentences[i] += words[j];
                    }
                }
                string temp = string.Empty;
                int x = 0;
                for (int i = 0; i < Task2.Length; i++)
                {
                    switch(Task2[i])
                    {
                        case '.':
                            temp += sentences[x] + '.';
                            x++;
                            break;
                        case '!':
                            temp += sentences[x] + '!';
                            x++;
                            break;
                        case '?':
                            temp += sentences[x] + '?';
                            x++;
                            break;

                    }
                }
                Task2 = temp;
                MainWindow.Text = "Введённая строка:" + Environment.NewLine + Task2;
            }
            else
                MessageBox.Show("Не с чем работать.", "Ошибка");
        }
    }
}