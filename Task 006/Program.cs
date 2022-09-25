int [,] sort (int [,] array){
    for(int k = 0; k < array.GetLength(0); k++){
        int temp;
        for(int j = 0; j < array.GetLength(1); j++){
             for(int i = 0; i < array.GetLength(1)-1; i++){
                if(array[k,i] < array[k,i+1]){
                      temp = array[k,i];
                      array[k,i] = array[k,i+1];
                      array[k,i+1] = temp;
                     }
               }
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
int [,] numbers = new int [2,5]{{3,6,7,8,5},{6,8,4,7,2}};
int [] num = new int [5]{3,6,7,8,5};
showArray(sort(numbers));