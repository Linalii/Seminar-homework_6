int [,] numbers = new int [2,5]{{3,6,7,8,5},{6,8,4,7,2}};
double sum = 0;
int counter = 0;
void showArray (int [,] arrayToShow){
    for(int i = 0; i < arrayToShow.GetLength(1); i++){
        for(int j = 0; j < arrayToShow.GetLength(0); j++){
            sum = sum + arrayToShow[j,i];
        }
        counter++;
        Console.WriteLine("Среднее арифметическое элементов столбца "+counter+" = "+(sum)/arrayToShow.GetLength(0));
        sum = 0;
    }
}
showArray(numbers);
