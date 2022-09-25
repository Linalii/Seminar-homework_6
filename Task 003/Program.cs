int [,] numbers = new int [2,5]{{3,6,7,8,5},{6,8,4,7,2}};
int [,] replaceEvenElement (int [,] arrayToShow){
    for(int i = 0; i < arrayToShow.GetLength(0); i++){
        for(int j = 0; j < arrayToShow.GetLength(1); j++){
            if(i%2==0 &&j%2==0){
                arrayToShow[i,j] = arrayToShow[i,j]*arrayToShow[i,j];
            }
        }
    }
    return arrayToShow;
}
void showArray (int [,] arrayToShow){
    for(int i = 0; i < arrayToShow.GetLength(0); i++){
        for(int j = 0; j < arrayToShow.GetLength(1); j++){
            Console.Write(arrayToShow[i,j]+" ");
        }
        Console.WriteLine();
    }
}
showArray(replaceEvenElement(numbers));