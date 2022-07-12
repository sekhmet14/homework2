
Console.Write($"Введи число (количество чисел): ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[num];

void InputNumbers(int num){
for (int i = 0; i < num; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int simile(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
        if(arrayNumbers[i] > 0)


        count++;
    }
  return count;
}

InputNumbers(num);

Console.WriteLine($"Введено чисел больше 0: {simile(arrayNumbers)} ");