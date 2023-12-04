using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static MyLibStructWF.ArrayTypes;
using static Лабораторная_работа__5.BusinessLogic;

namespace Лабораторная_работа__6_v2
{
  public partial class MainMenu : Form
  {
    public static bool isEdit = false;

    public MainMenu()
    {
      InitializeComponent();
    }

    private void OneDimCreateButton_Click(object sender, EventArgs e)
    {
      OneDimArrayForm form = new OneDimArrayForm();
      form.ShowDialog();
      MainWindow.Text = OneDimMain.Show;
    }

    private void OneDimEditButton_Click(object sender, EventArgs e)
    {
      if (OneDimMain.Length > 0)
      {
        isEdit = true;
        OneDimArrayForm form = new OneDimArrayForm();
        form.ShowDialog(); // не вызываю dispose с этой формой, так как в ней прописано при закрытии вызывать собственный dispose
        MainWindow.Text = OneDimMain.Show;
        isEdit = false;
      }
      else
        MessageBox.Show("Не с чем работать.", "Ошибка");
    }

    private void OneDimPrintButton_Click(object sender, EventArgs e)
    {
      MainWindow.Text = OneDimMain.Show;
    }

    private void OneDimRandomButton_Click(object sender, EventArgs e)
    {
      RandomFill_OneDim();
      MainWindow.Text = OneDimMain.Show;
    }

    private void SortButton_Click(object sender, EventArgs e)
    {
      if (OneDimMain.Length > 0)
      {
        Task1();
      }
      MainWindow.Text = OneDimMain.Show;
    }

    private void StringEnterButton_Click(object sender, EventArgs e)
    {
      StringEnterForm f = new StringEnterForm();
      f.ShowDialog();
      f.Dispose();
      MainWindow.Text = StringShow;
    }

    private void StringPrintButton_Click(object sender, EventArgs e)
    {
      MainWindow.Text = StringShow;
    }

    private void ReverseStringButton_Click(object sender, EventArgs e)
    {
      if (Task2StringCorrect)
      {
        task2String = Reverse_String();
        MainWindow.Text = "Введённая строка:" + Environment.NewLine + task2String;
      }
      else
        MessageBox.Show("Ввод некорректен. Предложения должны оканчиваться знаком препинания.", "Ошибка");
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

    private void RandomStringButton_Click(object sender, EventArgs e)
    {
      task2String = RandomStringGenerator;
      MainWindow.Text = "Введённая строка:" + Environment.NewLine + task2String;
    }
  }
}