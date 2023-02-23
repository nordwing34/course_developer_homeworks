//*** Домашнее задание к семинару 7 ***

// Задание 1
/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

System.Console.WriteLine("Введите размеры массива:");
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");

var matrix = GetMatrixD(numRows, numColumns);
System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Получился такой массив:");
PrintMatrixD(matrix);


// Задание 2
/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

System.Console.WriteLine("Введите размеры массива:");
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
var matrix = GetMatrixInt(numRows, numColumns);

System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Получился такой массив:");
PrintMatrixInt(matrix);

System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Введите индекс:");
int indX = SetNumber($"строка от 0 до {numRows}");
int indY = SetNumber($"столбец от 0 до {numColumns}");

int res = IndexPosition(matrix, indX, indY);
if(res != 0){
	System.Console.WriteLine($"Получили элемент массива: {res}");
} else {
	System.Console.WriteLine("Такого элемента нет");
}


// Задание 3
/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

System.Console.WriteLine("Введите размеры массива:");
int numRows = SetNumber("Rows");
int numColumns = SetNumber("Columns");
var matrix = GetMatrixInt(numRows, numColumns);

System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Получился такой массив:");
PrintMatrixInt(matrix);

System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Среднее арифметическое каждого столбца:");
PrintAverage(matrix);




// *** Функции *************************************************************************************
// Универсальная функция для приёма чисел от пользователя.
int SetNumber(string par){
	System.Console.Write($"Введите число ({par}): ");
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

// Функция создаёт двумерный массив и заполняет его случайными вещественными числами
double[,] GetMatrixD(int rows, int cols){
	double[,] matrix = new double[rows, cols];

	for (int i = 0; i < rows; i++){
		for (int l = 0; l < cols; l++){
			double tmp = new Random().NextDouble() * 10;
			matrix[i,l] = Math.Round(tmp, 2);
		}
	}

	return matrix;
}

// Функция выводит двумерный массив в консоль (вещественные числа)
void PrintMatrixD(double[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int l = 0; l < matrix.GetLength(1); l++){
			System.Console.Write(matrix[i,l] + " ");
		}
		System.Console.WriteLine(String.Empty);
	}
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

// Функция принимает два индекса двумерного массива 
// и возвращает значение элемента
int IndexPosition(int[,] matrix, int x, int y){
	if(x > matrix.GetLength(0) || y > matrix.GetLength(1)){
		return 0;
	} else {
		return matrix[x, y];
	}
}

// Функция вычисляет среднее арифметическое каждого столбца массива
// и печатает результат в консоль
void PrintAverage(int[,] matrix){
	int[] tempMatrix = new int[matrix.GetLength(1)];

	for (int i = 0; i < matrix.GetLength(0); i++){
		for (int l = 0; l < matrix.GetLength(1); l++){
			tempMatrix[l] += matrix[i,l];
		}
	}

	string res = "";
	foreach (var item in tempMatrix){
		double tmp = (double)item / (double)matrix.GetLength(0);
		res += Math.Round(tmp, 2) + " ";
	}
	System.Console.WriteLine(res);

}


