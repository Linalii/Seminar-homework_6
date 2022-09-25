int [,] replaceColumnRow( int [,] array){
    int temp;
       for(int i = 0; i < array.GetLength(0); i++){
            for (int j = i; j < array.GetLength(0); j++){
                temp = array [i,j];
                array [i,j] = array [j,i];
                array [j,i] = temp;
            } 
       }     
    return array;
}
void showArray (int [,] arrayToShow){
    for(int i = 0; i < arrayToShow.GetLength(0); i++){
        for(int j = 0; j < arrayToShow.GetLength(1); j++){
            Console.Write(arrayToShow[i,j]+" ");
        }
        Console.WriteLine();
    }
}
int [,] numbers = new int [5,5]{{3,6,7,8,5},{6,8,4,7,2},{1,1,1,1,1},{5,5,5,5,5},{3,2,3,2,3}};
showArray(numbers);
Console.WriteLine();
if(numbers.GetLength(0)!= numbers.GetLength(1)){
    Console.WriteLine("Нельзя заменить столбцы на строки в неквадратной матрице!");
}
else showArray(replaceColumnRow(numbers));