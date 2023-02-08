//*** Домашнее задание к семинару 4 ***

// Задание 1 **********************************************************************************
/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
System.Console.WriteLine("Введите два числа");
System.Console.Write("Основание степени: ");
int numbA = int.Parse(System.Console.ReadLine());
System.Console.Write("Показатель степени: ");
int numbB = int.Parse(System.Console.ReadLine());
System.Console.WriteLine(String.Empty);

// Вариант 1
int ret = 1;
for(int i = 1; i <= numbB; i++){
	ret = ret * numbA;
}
System.Console.WriteLine($"Результат: {ret}");

// Вариант 2
int myPow(int par1, int par2){
	int ret = 1;
	for(int i = 1; i <= par2; i++){
		ret = ret * par1;
	}	
	return ret;
}
System.Console.WriteLine($"Результат: {myPow(numbA, numbB)}");
*/



// Задание 2 **********************************************************************************
/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// Вводим число
System.Console.Write("Введите число: ");
int number2 = int.Parse(System.Console.ReadLine());

// Число должно быть натуральным
if(number2 < 1){
	System.Console.WriteLine("Число меньше 1");
} else {
	System.Console.WriteLine($"Сумма цифр в этом числе = {mySum(number2)}");
}

// Функция подсчитывает сумму цифр в числе
int mySum(int param1){
	int ret = 0;
	int index = param1;

	while(index > 0){
		ret = ret + (index % 10);
		index = index / 10;
	}
	return ret;
}



// Задание 3 **********************************************************************************
/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

