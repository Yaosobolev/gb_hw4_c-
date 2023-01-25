/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */
// Проверка вводимого числа на число
int GetNumber(string msg){
    int resultNumber = 0;
    while(true){
        Console.Write(msg);
        if(int.TryParse(Console.ReadLine(), out resultNumber)) break;
        else Console.WriteLine("Вы ввели не коректное число ");
    }
    return resultNumber;
}

int[] GetDig(int x){//Разделяет число на цифры
    string strNum = x.ToString();
    int[] nums = new int[strNum.Length];
    for(int i = 0; i<strNum.Length;i++){
        nums[i] = Convert.ToInt32(strNum[i])-48;
        if(nums[0]<0)nums[0]=0;    
    }
    return nums;
}
int GetSum(int[] array){//СУММИРУЕТ ЦИФРЫ      
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        summ +=array[i]; 
    }
    return summ;
}

int number = GetNumber("Введите число: ");
int[] array = GetDig(number);
//Console.WriteLine(string.Join(" ",array));
int summ = GetSum(array);
Console.WriteLine($"Сумма цифр числа - {number} = {summ}");