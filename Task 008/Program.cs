int findMinSumRow (int [,] arrayToShow){
    int sum = 0;
    int temp = 0;
    int row = 0;
    for(int i = 0; i < arrayToShow.GetLength(0); i++){
        for(int j = 0; j < arrayToShow.GetLength(1); j++){
            sum = sum + arrayToShow[i,j];
            row = i;
        }
        
        if(i > 0){
            if(temp > sum){
                temp = sum;
                row = i;
            }
        }
        temp = sum;
        sum = 0;
    }
    Console.WriteLine("Наименьшая сумма "+temp+" в строке "+(row+1));
    return temp;
}


void showArray (int [,] arrayToShow){
    for(int i = 0; i < arrayToShow.GetLength(0); i++){
        for(int j = 0; j < arrayToShow.GetLength(1); j++){
            Console.Write(arrayToShow[i,j]+" ");
        }
        Console.WriteLine();
    }
}
int [,] numbers = new int [3,5]{{3,6,7,8,5},{6,8,4,7,2},{1,1,1,1,1}};
findMinSumRow(numbers);