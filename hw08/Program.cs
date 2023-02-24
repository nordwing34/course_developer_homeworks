//*** Домашнее задание к семинару 8 ***

// Задание 1
/*
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

System.Console.WriteLine("Введите размеры массива:");
int numRows = SetNumber("Строки: ");
int numColumns = SetNumber("Колонки: ");

var matrix = GetMatrixInt(numRows, numColumns);
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Получили такой массив:");
PrintMatrixInt(matrix);

System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Упорядочим этот массив согласно заданию:");
var matrixOrder = OrderMatrix(matrix);
PrintMatrixInt(matrixOrder);



// Задание 2
/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

System.Console.WriteLine("Введите размеры массива:");
int numRows = SetNumber("Строки: ");
int numColumns = SetNumber("Колонки: ");

var matrix = GetMatrixInt(numRows, numColumns);
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Получили такой массив:");
PrintMatrixInt(matrix);

System.Console.WriteLine(String.Empty);
System.Console.Write("Строка с наименьшей суммой элементов: " + MinimumString(matrix));



// Задание 3
/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

System.Console.WriteLine("Задайте размер двух матриц");
int dimMatrix = SetNumber("Натуральное число: ");

// Создаём две одинаковые матрицы и заполняем их случайными натуральными числами
// Этот пример - только частный случай, потому что:
// - задаются две одинаковые квадратные матрицы
// - не проверяется входной параметр
// - матрицы заполняются числами из заранее заданного диапазона (от 10 до 99)
var matrixOne = GetMatrixInt(dimMatrix, dimMatrix);
var matrixTwo = GetMatrixInt(dimMatrix, dimMatrix);
System.Console.WriteLine(String.Empty);
PrintMatrixInt(matrixOne);
System.Console.WriteLine(String.Empty);
PrintMatrixInt(matrixTwo);

// Перемножаем две матрицы
var matrixRet = GetMatrixRet(matrixOne, matrixTwo);
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Произведение этих матриц:");
PrintMatrixInt(matrixRet);





// *** Функции *************************************************************************************
// Универсальная функция для приёма чисел от пользователя.
int SetNumber(string par){
	System.Console.Write($"({par}): ");
	int ret = Convert.ToInt32(System.Console.ReadLine());
	return ret;
}


// Функция создаёт двумерный массив и заполняет его случайными целыми числами
int[,] GetMatrixInt(int rows, int cols){
	int[,] matrix = new int[rows, cols];
	int min = 10;
	int max = 99;

	for (int i = 0; i < rows; i++){
		for (int l = 0; l < cols; l++){
			matrix[i,l] = new Random().Next(min, max+1);
		}
	}

	return matrix;
}

// Функция выводит двумерный массив в консоль (целые числа)
void PrintMatrixInt(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int l = 0; l < matrix.GetLength(1); l++){
			System.Console.Write(matrix[i,l] + " ");
		}
		System.Console.WriteLine(String.Empty);
	}
}

// Функция упорядочивает элементы каждой строки массива по убыванию
int[,] OrderMatrix(int[,] matrixOne){
	int[] matrixTmp = new int[matrixOne.GetLength(0)];

	for (int i = 0; i < matrixOne.GetLength(0); i++){
		for (int l = 0; l < matrixOne.GetLength(1); l++){
			matrixTmp[l] = matrixOne[i,l];
		}
		Array.Sort(matrixTmp);
		Array.Reverse(matrixTmp);
		for (int l = 0; l < matrixOne.GetLength(1); l++){
			matrixOne[i,l] = matrixTmp[l];
		}
	}

	return matrixOne;
}

// Функция считает сумму элементов в каждой строке массива, находит минимальную и возвращает номер этой строки
int MinimumString(int[,] matrix){
	int ret = 0;
	int rowSum = 100000;
	int tmpSum = 0;

	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int l = 0; l < matrix.GetLength(1); l++){
			tmpSum += matrix[i,l];
		}
		if(tmpSum < rowSum){
			rowSum = tmpSum;
			ret = i;
		}
		tmpSum = 0;
	}

	return ret;
}


// Функция перемножает две матрицы и возвращает матрицу-результат
// Исходные матрицы должны быть квадратные
int[,] GetMatrixRet(int[,] matrixOne, int[,] matrixTwo){
	int[,] matrixRet = new int[matrixOne.GetLength(0), matrixOne.GetLength(0)];

	for (int i = 0; i < matrixRet.GetLength(0); i++){
		for (int l = 0; l < matrixRet.GetLength(1); l++){
			matrixRet[i,l] = GetMatrixComp(i, l, matrixOne, matrixTwo);
		}
	}

	return matrixRet;
}

// Функция возвращает одно значение при перемножении матриц
int GetMatrixComp(int row, int col, int[,] matrixOne, int[,] matrixTwo){
	int ret = 0;

	for (int i = 0; i < matrixOne.GetLength(0); i++){
		ret += matrixOne[row, i] * matrixTwo[i, col];
	}

	return ret;
}

