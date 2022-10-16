// Описание основного метода: поиск элементов из первого массива, значения которых короче 4 символов и добавление их во второй массив
string[] inputNewArray(string[] array, string[] newArray) {
    int index = 0;
    for ( int j=0; j<array.Length; j++ ) {
        if ( array[j].Length < 4 ) {
            newArray[index] = array[j];
            index++;
        }
    }
    return newArray;
}

// Определяем длину первого массива
Console.Write("Количество элементов массива: ");
int amountElements = Convert.ToInt32(Console.ReadLine());

// Создаём первый строковый массив
string[] array = new string[amountElements];
int amountElementsNewArray = 0;

// Заполняем первый массив и ведём счётчик количества элементов которые короче 4 символов
for ( int i=0; i<array.Length; i++ ) {
    Console.Write($"{i+1} элемент массива: ");
    array[i] = Console.ReadLine();
    if ( array[i].Length < 4 ) {
        amountElementsNewArray++;
    }
}
Console.WriteLine();
Console.WriteLine("Первый массив:");
Console.WriteLine($"[\"{string.Join("\", \"", array)}\"]");

// Создаём второй строковый массив и вызываем метод, который заполняет его
string[] newArray = new string[amountElementsNewArray];
newArray = inputNewArray(array, newArray);

Console.WriteLine();
Console.WriteLine("Второй массив:");
Console.WriteLine($"[\"{string.Join("\", \"", newArray)}\"]");