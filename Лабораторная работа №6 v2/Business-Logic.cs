using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyLibStructWF.ArrayTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Лабораторная_работа__5
{
  public static class BusinessLogic
  {
    public static string task2String = string.Empty;
    public const string alphabetLowerCase =  "абвгдеёжзийклмнопрстуфхцчшщъыьэюя", alphabetUpperCase = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    public static OneDim OneDimMain = new OneDim(0), OneDimTemp = new OneDim(0);
    public static Random random = new Random();

    #region random fill
    public static void RandomFill_OneDim()
    {
      if (OneDimMain.Length != 0)
      {
        for (int i = 0; i < OneDimMain.Length; i++)
          OneDimMain.array[i] = random.Next(-100, 100);
      }
    }

    public static string RandomStringGenerator
    {
      get
      {
        StreamReader reader = new StreamReader("Пермь для лаб 6.txt");
        List<string> stringList = new List<string>();
        while (!reader.EndOfStream)
        {
          string line = reader.ReadLine();
          stringList.Add(line);
        }
        var random = new Random();
        string stroka = string.Empty;
        for (var i = 0; i < random.Next(4,7); i++) //случайный выбор количества строк
        {
          var pickIndex = random.Next(stringList.Count);
          stroka += stringList[pickIndex] + ' ';
          stringList.RemoveAt(pickIndex);
        }
        reader.Close();
        return stroka;
      }
    }
    #endregion

    #region Major Tasks
    public static void Task1()
    {
      int[] arrayTemp = new int[OneDimMain.Length];
      for (int i = 0; i < OneDimMain.Length; i++)
        arrayTemp[i] = OneDimMain.array[i];
      arrayTemp = HoarahSort(arrayTemp, 0, arrayTemp.Length - 1);
      int j = 0;
      for (int i = 0; i < OneDimMain.Length; i++)
      {
        if (OneDimMain.array[i] % 2 == 0)
        {
          OneDimMain.array[i] = EvenNumberSearch(arrayTemp, ref j);
        }
      }
    }

    static int EvenNumberSearch(int[] arrayTemp, ref int j)
    {
      for (int i = j; i < arrayTemp.Length; i++)
        if (arrayTemp[i] % 2 == 0)
        {
          j = i + 1;
          return arrayTemp[i];
        }
      return -1;
    }

    public static string Reverse_String()
    {
      string[] sentences = task2String.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);//делёжка ввода на предложения
      for (int i = 0; i < sentences.Length; i += + 2)
      {
        string[] withCommas = sentences[i].Split(' ', StringSplitOptions.RemoveEmptyEntries), words = sentences[i].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        Array.Reverse(withCommas);
        words[words.Length - 1] = CharUpperToLower(StringToChar(words[words.Length - 1]));
        words[0] = CharLowerToUpper(StringToChar(words[0]));
        sentences[i] = string.Empty;
        sentences[i] += " " + words[0];
        for (int j = 1; j < words.Length; j++)
        {
          if (Char.IsPunctuation(withCommas[j][withCommas[j].Length - 1]) && words[j].Length > 1)
            sentences[i] += withCommas[j][withCommas[j].Length - 1] + " " + words[j];
          else
            sentences[i] += " " + words[j];
        }
      }
      string temp = string.Empty;
      int sentenceCounter = 0;
      for (int i = 0; i < task2String.Length; i++)
      {
        switch (task2String[i])
        {
          case '.':
            temp += sentences[sentenceCounter] + '.';
            sentenceCounter++;
            break;
          case '!':
            temp += sentences[sentenceCounter] + '!';
            sentenceCounter++;
            break;
          case '?':
            temp += sentences[sentenceCounter] + '?';
            sentenceCounter++;
            break;
        }
      }
      return temp.Trim(' ');
    }

    public static char[] StringToChar(string word)
    {
      int length = word.Length;
      char[] tempWord = new char[length];
      for (int i = 0; i < length; i++)
        tempWord[i] = word[i];
      return tempWord;
    }

    public static string CharLowerToUpper(char[] word)
    {
      if (alphabetLowerCase.Contains(word[0]))
        word[0] = alphabetUpperCase[alphabetLowerCase.IndexOf(word[0])];
      return new string(word);
    }

    public static string CharUpperToLower(char[] word)
    {
      if (alphabetUpperCase.Contains(word[0]))
        word[0] = alphabetLowerCase[alphabetUpperCase.IndexOf(word[0])];
      return new string(word);

    }
    #endregion

    #region Copy
    public static int[] Copy(int[] array) // для случаев, когда надо сделать не перменную-ссылку на другую переменную, а отдельный новый идентичный массив
    {
      int[] newArray = new int[array.Length];
      array.CopyTo(newArray, 0);
      return newArray;
    }
    #endregion

    #region Load
    public static string FileReader() //Получение обобщёных данных из файла
    {
      var fileContent = string.Empty;
      var filePath = string.Empty;

      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.InitialDirectory = "E:\\stuff\\Проекты VS\\Лабораторная работа №5\\Лабораторная работа №5\\bin\\Debug\\net7.0-windows";
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          filePath = openFileDialog.FileName;
          var fileStream = openFileDialog.OpenFile();
          using (StreamReader reader = new StreamReader(fileStream))
          {
            fileContent = reader.ReadToEnd();
          }
        }
      }
      return fileContent;
    }

    public static bool IsFileCorrect_OneDim(string text) //проверка на корректность указанного файла одномерного массива
    {
      string[] arrStrings = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
      if (arrStrings.Length == 1)
        return true;
      return false;
    }

    public static int Load_OneDim(string fileContent)
    {
      int errorNumber = 0;
      string[] contentLines = fileContent.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      int[] arrayLocal = new int[contentLines.Length];
      for (int i = 0; i < contentLines.Length; i++)
      {
        int x;
        if (int.TryParse(contentLines[i], out x))
          arrayLocal[i] = x;
        else
          errorNumber++;
      }
      OneDimMain.array = arrayLocal;
      return errorNumber;
    }
    #endregion

    #region Box Check (inteface thingy)
    public static bool OneDimBoxesCheck
    {
      get
      {
        foreach (var box in textBoxes)
        {
          if (!int.TryParse(box.Text, out int y))
          {
            return false;
          }
        }
        return true;
      }
    }
    #endregion

    #region Sort
    static int Partition(int[] array, int indexLeft, int indexRight)
    {
      int pen = indexLeft - 1;
      for (int i = indexLeft; i < indexRight; i++)
      {
        if (array[i] > array[indexRight])
        {
          pen++;
          (array[pen], array[i]) = (array[i], array[pen]);
        }
      }
      pen++;
      (array[pen], array[indexRight]) = (array[indexRight], array[pen]);
      return pen;
    }

    public static int[] HoarahSort(int[] array, int indexLeft, int indexRight)
    {
      if (indexLeft >= indexRight)
      {
        return array; //финальная сдача массива
      }
      int pivotIndex = Partition(array, indexLeft, indexRight); // определение опорного элемента в массиве и перестановка
      HoarahSort(array, indexLeft, pivotIndex - 1); // сорт по левому краю от опорного элемента
      HoarahSort(array, pivotIndex + 1, indexRight); // сорт по правому краю от опорного элемента

      return array;
    }
    #endregion

    public static bool Task2StringCorrect
    {
      get
      {
        if (task2String != string.Empty)
          switch (task2String[task2String.Length - 1])
          {
            case ' ':
              task2String = task2String.Trim(' ');
              return Task2StringCorrect;
            case '.':
              return true;
            case '!':
              return true;
            case '?':
              return true;
          }
        return false;
      }
    }

    public static string StringShow
    {
      get
      {
        if (task2String != string.Empty)
          return "Введённая строка:" + Environment.NewLine + task2String;
        else
          return "Строка пуста";
      }
    }
  }
}