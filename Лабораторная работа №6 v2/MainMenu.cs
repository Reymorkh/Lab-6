using MyLibWF;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Лабораторная_работа__6_v2
{
  public partial class MainMenu : Form
  {
    public static bool isEdit1, Task2Init = false;
    public static int[] arrayMainOne;
    public static Random random = new Random();
    public static string Task2 = string.Empty;

    public MainMenu()
    {
      InitializeComponent();
    }

    private void OneDimCreateButton_Click(object sender, EventArgs e)
    {
      OneDimArrayForm form = new OneDimArrayForm();
      ActionsWF.FormInit(form);
      if (OneDimArrayForm.isInitialized)
        ActionsWF.BoxPrint(OneDimArrayForm.isInitialized, MainWindow, arrayMainOne);
    }

    private void OneDimEditButton_Click(object sender, EventArgs e)
    {
      if (OneDimArrayForm.isInitialized)
      {
        isEdit1 = true;
        OneDimArrayForm form = new OneDimArrayForm();
        ActionsWF.FormInit(form);
        ActionsWF.BoxPrint(OneDimArrayForm.isInitialized, MainWindow, arrayMainOne);
        isEdit1 = false;
      }
      else
        MessageBox.Show("Не с чем работать.", "Ошибка");
    }

    private void OneDimPrintButton_Click(object sender, EventArgs e)
    {
      ActionsWF.BoxPrint(OneDimArrayForm.isInitialized, MainWindow, arrayMainOne);
    }

    private void OneDimRandomButton_Click(object sender, EventArgs e)
    {
      if (OneDimArrayForm.isInitialized && arrayMainOne.Length > 0)
      {
        for (int i = 0; i < arrayMainOne.Length; i++)
          arrayMainOne[i] = random.Next(-100, 100);
        ActionsWF.BoxPrint(OneDimArrayForm.isInitialized, MainWindow, arrayMainOne);
      }
      else
        MessageBox.Show("Массив не инициализирован.", "Ошибка");
    }

    private void SortButton_Click(object sender, EventArgs e)
    {
      if (OneDimArrayForm.isInitialized)
      {
        int[] arrayTemp = new int[arrayMainOne.Length];
        for (int i = 0; i < arrayMainOne.Length; i++)
          arrayTemp[i] = arrayMainOne[i];
        arrayTemp = ActionsWF.HoarahSort(arrayTemp, 0, arrayTemp.Length - 1);
        int j = 0;
        for (int i = 0; i < arrayMainOne.Length; i++)
        {
          if (arrayMainOne[i] % 2 == 0)
          {
            arrayMainOne[i] = arraySearch(arrayTemp, ref j);
          }
        }
        ActionsWF.BoxPrint(OneDimArrayForm.isInitialized, MainWindow, arrayMainOne);
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
      StringEnterForm f = new StringEnterForm();
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
        string[] sentences = Task2.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
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
          switch (Task2[i])
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

    private void GuideButton_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Создать - запускает процедуру создания одномерного массива.\nРедактировать - открывает окно редактирования элементов массива.\n" +
          "Заполнить - заполняет массив случайными числами.\nПечать - выводит данные о массиве на экран столбиком по 10 элементов.\n" +
          "Сорт - сортировка по убыванию всех элементов, кроме нечётных", "Информация");
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Ввести строку - ввод строки для работы по варианту.\nПечать - выводит данные о строке на экран.\nПереворот - переворачивает каждое нечётное предложение.", "Информация");
    }
  }
}