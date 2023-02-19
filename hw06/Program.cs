//*** Домашнее задание к семинару 6 ***

// Задание 1
/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Получаем от пользователя строку с числами
System.Console.Write("Введите числа, разделёные пробелом: ");
string myString = System.Console.ReadLine();
string[] myStrArray = myString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

// Переводим строковые значения в числовые
int[] myNumbersArray = StringToNumbers(myStrArray);

// Считаем количество чисел больше нуля
int positiveNmbers = CountOfPositiveNumbers(myNumbersArray);
System.Console.WriteLine($"Количество положительных чисел: {positiveNmbers}");



/*** Функции ******************************************************************/

// Функция переводит строковые значения в числовые и записывает их в массив
int[] StringToNumbers(string[] parStrArray){
	int[] ret = new int[parStrArray.Length];

	for(int i=0; i<parStrArray.Length; i++){
		ret[i] = Convert.ToInt32(parStrArray[i]);
	}

	return ret;
}

// Функция считает количество положительных чисел в массиве
int CountOfPositiveNumbers(int[] parNumbers){
	int ret = 0;

	foreach(int i in parNumbers){
		if(i>0){ret++;}
	}

	return ret;
}
