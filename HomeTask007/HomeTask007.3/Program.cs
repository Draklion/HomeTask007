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
  CW("Задание 3. Программа, которая находит элементы массива, у которых оба индекса чётные, и заменяет эти элементы на их квадраты.");

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
  CW("");
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < colums; j++)
    {
      if (i % 2 == 0 && j % 2 == 0 && i != 0 && j != 0) array[i, j] = array[i, j] * array[i, j];
      CWR(array[i, j].ToString() + " ");
    }
    CW("");
  }
}
catch (InvalidCastException e) { }
