double[,] ratio = new double[2, 2];
double[] Point = new double[2];

void InputCoefficients(){
  for (int i = 0; i < ratio.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < ratio.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      ratio[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] ratio)
{
  Point[0] = (ratio[1,1] - ratio[0,1]) / (ratio[0,0] - ratio[1,0]);
  Point[1] = crossPoint[0] * ratio[0,0] + ratio[0,1];
  return Point;
}

void OutputResponse(double[,] ratio)
{
  if (ratio[0,0] == ratio[1,0] && ratio[0,1] == ratio[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (ratio[0,0] == ratio[1,0] && ratio[0,1] != ratio[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(ratio);
    Console.Write($"\nТочка пересечения прямых: ({Point[0]}, {Point[1]})");
  }
}

InputCoefficients();
OutputResponse(ratio);