/*  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] GetArray(){
    int[] array = new int [8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1,100); // рандом
        /* Console.Write($"Введите {i+1} элемент массива: "); //C Клавиатуры
        if(int.TryParse(Console.ReadLine(), out array[i]));
        else Console.WriteLine("Вы ввели не коректное число "); */
        
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        
    }
    Console.Write(string.Join(" ",array));
}
int[] a = GetArray();
Console.WriteLine(string.Join(" ",a));//только 1 методом
PrintArray(a);//двумя методами