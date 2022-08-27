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
  CW("Задание 1. Программа, которая задает двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.");
  CW("Введите количество строк массива: ");
  int rows = Int32.Parse(CR());
  CW("Введите количество столбцов массива: ");

  int colums = Int32.Parse(CR());
  int[,] array = new int[rows, colums];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < colums; j++)
    {
      array[i, j] = i + j;
      CWR($"{array[i, j]}  ");
    }
    CW("");
  }

}
catch (InvalidCastException e) { }
