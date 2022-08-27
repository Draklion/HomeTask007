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
  CW("Задание 4. Программа, которая находит сумму элементов, находящихся на главной диагонали.");

  CW("Введите количество строк массива: ");
  int rows = Int32.Parse(CR());
  CW("Введите количество столбцов массива: ");
  int colums = Int32.Parse(CR());
  int[,] array = new int[rows, colums];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < colums; j++)
    {
      array[i, j] = new Random().Next(-10, 10);
      CWR(array[i, j].ToString() + " ");
    }
    CW("");
  }
  int sum = 0;
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < colums; j++)
    {
      if (i == j) sum = sum + array[i, j];
    }
  }
  CW($"Сумма всех элементов, находящихся на главной диагонали = {sum.ToString()}");
}
catch (InvalidCastException e) { }
