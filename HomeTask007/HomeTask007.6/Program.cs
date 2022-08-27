void CW(string msg)
{
  Console.WriteLine(msg);
}
void CWR(string msg)
{
  Console.Write(msg);
}
string CR()
{
  return Console.ReadLine();
}

try
{
  CW("Задание 6. Программа, которая находит среднее арифметическое элементов в каждом столбце массива.");

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);
  double[,] array = new double[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(-10, 10);
      CWR(array[i, j].ToString() + "  ");
    }
    CW("");
  }
  CWR("Среднее арифметическое элементов в каждом столбце массива:");
  for (int i = 0; i < columns; i++)
  {
    double sum = 0;
    for (int j = 0; j < rows; j++) sum = sum + array[j, i];
    CWR((sum / rows).ToString() + " ");
  }
}
catch (InvalidCastException e) { }
