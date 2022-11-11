string[] SelectingElements(string[] arr, int index = 0, int size = 3) {
// Функция что формирует массив строк нужного размера на основе полного массива строк
// Принимает на вход массив и размерность элементов при необходимости
    while (index <= arr.Length - 1 && arr[index].Length <= size) index++;
    // Проверка индекса на соответсвие диапазону и элемента на соответствие размеру. Поиск неподходящего элемента
    if (index > arr.Length - 1) return arr;  // Завершение рекурсии выводом массива
    int twins = 0;  // Для удаление сразу всех повторов и избегания ошибок кода
    foreach (string item in arr) {  // Поиск дублей
        if (item == arr[index]) twins++; 
    }
    string[] a = new string[arr.Length - twins];  // Создание нового массива без лишнего элемента
    int j = 0;  // Переменная для корректного заполнения нового массива
    for (int i = 0; i < arr.Length; i++) {  // Заполнение нового массива с проверкой на соответсвие элементу-исключению{
        if (arr[i] != arr[index])  {
            a[j] = arr[i];
            j++;
        }
    }
    return SelectingElements(a);

}

Console.Write("Введите элементы массива: ");  // Получение от пользователя перечня элементов
string[] workingArray = Console.ReadLine()!.Split(new char[] { ' ', ',', '#', ';' }, StringSplitOptions.RemoveEmptyEntries); // Формирование массива строк
string[] result = SelectingElements(workingArray); // Формирование результирующего массива строк
foreach (string item in result) Console.Write($"{item} ");  // Вывод элементов результирующего массива
