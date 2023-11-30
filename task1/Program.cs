// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


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

void Tesk1(int [] array){
    int num = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] >= 20 && array[i] <= 90){
            num++;
        }
    }
    Console.WriteLine($"{num} элементов массива лежат в отрезке [20,90]");
}

Console.WriteLine("Введите длинну массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);

ShowArray(array);
Tesk1(array);
