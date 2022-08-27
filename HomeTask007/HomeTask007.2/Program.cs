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
  CW("Задание 2. Программа, которая задает двумерный массив и заполняет его случайными числами.");
  CW("Введите количество строк массива: ");
  int rows = Int32.Parse(CR());
  CW("Введите количество столбцов массива: ");
  Random rand = new Random();
  int colums = Int32.Parse(CR());
  double[,] array = new double[rows, colums];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < colums; j++)
    {
      array[i, j] = Convert.ToDouble(rand.Next(-100, 100) / 10.0);
      CWR($"{array[i, j]}  ");
    }
    CW("");
  }

}
catch (InvalidCastException e) { }
