/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int GetNumber(string msg){
    int resultNumber = 0;
    while(true){
        Console.WriteLine(msg);
        if(int.TryParse(Console.ReadLine(), out resultNumber)&& resultNumber > 0) break;
        else Console.WriteLine("Вы ввели не коректное число");
    }
    return resultNumber;
}

int GetResult(int a, int b){
    int result = 0;
    result = (int)Math.Pow(a,b);
    return result;
}
int A = GetNumber("Введите число A, которое хотите возвести в степень B: ");
int B = GetNumber("Введите число B, которое хотите возводит число A : ");
int result = GetResult(A,B);
Console.WriteLine($"Число {A} в степени {B} = {result}");