double [,] numbers = new double [2,2]{{1.2,-2.8},{1.5,5.5}};
void showArray (double [,] arrayToShow){
    for(int i = 0; i < arrayToShow.GetLength(0); i++){
        for(int j = 0; j < arrayToShow.GetLength(1); j++){
            Console.Write(arrayToShow[i,j]+" ");
        }
        Console.WriteLine();
    }
}
showArray(numbers);