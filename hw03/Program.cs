//*** Домшнее задание к семинару 3 ***

// Задание 1 **********************************************************************************
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int number1 = 0;
string numberStr1 = "";

// Вводим число и проверяем его на пятизначность
while(true){
	Console.Write("Введите пятизначное число: ");
	number1 = Convert.ToInt32(Console.ReadLine());
	numberStr1 = number1.ToString();
	if(numberStr1.Length == 5){break;}
}

// Проверяем, является ли число палиндромом и выводим результат
if(numberStr1[0] == numberStr1[4] && numberStr1[1] == numberStr1[3]){
	Console.WriteLine("Число палиндром");
}
// *** В задаче идёт речь о пятизначном числе. Программу можно доработать, чтобы она проверяла числа любой длины.



// Задание 2 **********************************************************************************
/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координаты первой точки");
Console.Write("Xa = ");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Ya = ");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Za = ");
int Za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("Xb = ");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Yb = ");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Zb = ");
int Zb = Convert.ToInt32(Console.ReadLine());

double Cx = Math.Pow((Xb - Xa), 2);
double Cy = Math.Pow((Yb - Ya), 2);
double Cz = Math.Pow((Zb - Za), 2);

double res = Math.Sqrt(Cx + Cy + Cz);

Console.WriteLine(Math.Round(res,2));

//*** В задаче ничего не сказано про какие-либо ограничения для вводимых чисел
//***  поэтому и проверок нет



// Задание 3 **********************************************************************************
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number3; i++){
	double cube = Math.Pow(i, 3);
	Console.Write( $"{cube} " );
}

