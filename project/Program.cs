/*
Итоговый проект

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равноа 3 символа.
*/

string[] myStrArray = new string[] {
	"Строка Раз",
	"Строка Два",
	"Строка Три",
	"Строка Четыре"
};

System.Console.Clear();
System.Console.WriteLine("Исходный массив строк: ");
GetSourceArray(myStrArray);



/*** Функции ******************************************************************/
void GetSourceArray(string[] sourceArr){
	foreach (var item in sourceArr){
		System.Console.WriteLine($"{item}");
	}
}

