//*** Домашнее задание к семинару 9 ***

// Задание 1
/*
Вывести все натуральные числа от N до 1
*/


System.Console.Write($"Введите натуральное число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write($"Натуральные числа от N до 1: {NumberRec(num1)}");

string NumberRec(int n){
	if(n >= 1) {
		return $"{n} " + NumberRec(n-1);
	} else {
		return String.Empty;
	}
}


// Задание 2
/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int num2Min = 0;
int num2Max = 0;

while(true){
	System.Console.WriteLine($"Введите два натуральных числа: ");
	num2Min = SetNumber("Минимум: ");
	num2Max = SetNumber("Максимум: ");

	if(num2Min < num2Max){break;}

	Console.Clear();
}

System.Console.Write(String.Empty);
System.Console.Write($"Сумма натуральных чисел от M до N: {NumberSum(num2Min, num2Max)}");

int NumberSum(int min, int max){
	if(min <= max){
		return min + NumberSum(min+1, max);
	} else {
		return 0;
	}
}



// Задание 3
/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

// Функцию Аккермана я не понял. А списывать не хочу.



// *** Функции *************************************************************************************
// Универсальная функция для приёма чисел от пользователя.
int SetNumber(string par){
	System.Console.Write($"{par}: ");
	int ret = Convert.ToInt32(System.Console.ReadLine());
	return ret;
}


