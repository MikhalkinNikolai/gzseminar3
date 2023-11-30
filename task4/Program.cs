void Svap(int num){
    int count = 0;
    int num1 = num;

    while (num1 != 0){
        num1 /= 10;
        count++;
    }
    int [] array = new int [count];
    
    for(int i = 0; i < count; i++){
        array[i] = num % 10;
        num /= 10;
        Console.Write(array[i] + " ");
    }
}


Svap(765764);
