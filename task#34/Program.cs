//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве

int[] numbers = new int[7];

void FillArray(int[] array, int min, int max){
 for (int i = 0; i<array.Length; i++ ){
 array[i] = new Random().Next(min, max);
  }
}

void ShowArray(int[] array){
 for (int i = 0; i<array.Length; i++ ){
 Console.Write(array[i] + " ");
  }
 Console.WriteLine();
}

int MathCheck(int[] array)
{

    int coint = 0;

    for (int i = 0; i < array.Length; i++)

        if (array[i] % 2 == 1) coint++;


    return coint;

}
FillArray(numbers, 100, 1000);
ShowArray(numbers);
Console.WriteLine();

int res =MathCheck(numbers);
Console.WriteLine($"Количество чётных чисел : {res}");












