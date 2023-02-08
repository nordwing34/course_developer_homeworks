//*** Домашнее задание к семинару 4 ***

// Задание 1 **********************************************************************************
/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

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




// Задание 2 **********************************************************************************
/*

*/

