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
  CW("Задание 5. Программа, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

  CW("Введите позицию элемента массива:");

  int[] position = new int[2];

  for (int i = 0; i < position.Length; i++) position[i] = Int32.Parse(CR());

  int rows = new Random().Next(1, 6);
  int columns = new Random().Next(1, 6);
  int[,] array = new int[rows, columns];

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      array[i, j] = new Random().Next(-10, 10);
      CWR(array[i, j].ToString() + " ");
    }
    CW("");
  }

  CW($"Значение элемента: {(position[0] < rows && position[1] < columns ? array[position[0] - 1, position[1] - 1] + "." : "отсутствует.")}");
}
catch (InvalidCastException e) { }
