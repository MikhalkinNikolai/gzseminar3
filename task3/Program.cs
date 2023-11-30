// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

int [] CreateArray(int min, int max, int size){
    int [] array = new int [size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max + 1);
        }
    return array;
}

void ShowArray(int [] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Tesk3(int [] array){
    int maxnum = 0;
    for(int i = 0; i < array.Length; i++){
        if (array[i] > maxnum){
            maxnum = array[i];
        } 
    }
    int minnum = maxnum;
     for(int i = 0; i < array.Length; i++){
        if (array[i] < minnum){
            minnum = array[i];
        }
    }
    int num = maxnum - minnum;
    Console.WriteLine($"{maxnum}, {minnum}");
    Console.WriteLine($"Разница между максимальным и минимальным значением массива состовляет {num}");
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);

ShowArray(array);
Tesk3(array);