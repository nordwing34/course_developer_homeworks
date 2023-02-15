//*** Домашнее задание к семинару 5 ***


// Предлагаем пользователю ввести размер массива
int sizeOfArray = 0;
while(true){
	System.Console.Write("Введите размер массива [число от 2 до 16]: ");
	sizeOfArray = Convert.ToInt32(System.Console.ReadLine());
	if(sizeOfArray > 1 && sizeOfArray <= 16){break;}
}

// Создаём массив указанного размера
int[] myArray = new int[sizeOfArray];


// Задание 1 ---------------------------------------------------------
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
MyRand(myArray, 100, 999);	// Заполняем массив числами
PrintArray(myArray);		// Печатаем получившийся массив
System.Console.WriteLine(			// Вычисляем количество чётных чисел в массиве
	$"Количество чётных чисел в этом массиве: {SummOfEvenNumbers(myArray)}"
	);



// Задание 2 ---------------------------------------------------------
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
MyRand(myArray, 0, 99);		// Заполняем массив числами
PrintArray(myArray);		// Печатаем получившийся массив
PrintSummOddElements(myArray);		// Печатаем сумму элементов, стоящих на нечётных позициях



// Задание 3 ---------------------------------------------------------
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76
MyRand(myArray, 0, 300);	// Заполняем массив числами
PrintArray(myArray);	// Печатаем получившийся массив
System.Console.WriteLine(		// Находим разницу между максимальным и минимальным элементом массива
	$"Разница между минимаьным и максимальным элементами: {DifferenceMinMaxElements(myArray)}"
	);




/* Функции ************************************************************************************/

// Функция заполняет массив случайными числами
int[] MyRand(int[] parArray, int parMinNumber, int parMaxNumber){
	Random rnd = new Random();

	for(int i = 0; i <= parArray.Length - 1; i++){
		parArray[i] = rnd.Next(parMinNumber, parMaxNumber);
	}

	return parArray;
}

// Функция печатает массив в консоль
void PrintArray(int[] parArray){
	foreach(int i in parArray){
		System.Console.Write($"{i} ");
	}
	System.Console.WriteLine(String.Empty);
}

// Функция вычисляет количество чётных чисел в массиве
int SummOfEvenNumbers(int[] parArray){
	int ret = 0;
	foreach(int i in parArray){
		if(i % 2 == 0){
			ret++;
		}
	}
	return ret;
}

// Функция печатает сумму элементов, стоящих на нечётных позициях
void PrintSummOddElements(int[] parArray){
	int sumOddElements = 0;

	for(int i=0; i<parArray.Length; i++){
		if(i % 2 != 0){
			sumOddElements += parArray[i];
		}
	}

	System.Console.WriteLine($"Сумма нечётных элементов: {sumOddElements}");
}

// Функция находит разницу между максимальным и минимальным элементами массива
int DifferenceMinMaxElements(int[] parArray){
	return parArray.Max() - parArray.Min();
}

