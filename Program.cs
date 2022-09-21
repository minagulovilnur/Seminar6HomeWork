/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4


void ShowArray (double [] array, string [] arrString)
{
  for (double i = 0; i < array.Length; i++)
  {
  array[i] = Convert.Todouble32(arrString[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}


Console.Write("Введите произвольные числа, разделенных запятой : ");
string? enterNumbers = Console.ReadLine();

string[] arrayNumbers = new string [enterNumbers.Length];
double j =0;
for (double i = 0; i < arrayNumbers.Length; i++)
{
    if (enterNumbers[i] == ','){
        j++;
    }
        else {
            arrayNumbers[j] = arrayNumbers[j] + $"{enterNumbers[i]}";
        }

} j++;


double [] resultNumbers = new double[j];
ShowArray (resultNumbers, arrayNumbers);

double sum = 0;
for (double i = 0; i < j; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0 равно " +sum );
*/



/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x =(b2-b1)/(k1-k2);                                 
double y = k1*((b2-b1)/(k1-k2)) + b1;     
 
    if (b1>=k1 && b2>=k2){
    Console.WriteLine("Прямые не пересекаются"); 
   }
        else Console.WriteLine($"Точка пересечения двух прямых - это точка  ({x}:{y})");     
                                                                                      
                                                