/*
Итоговый проект

Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа.
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

System.Console.WriteLine(String.Empty);
System.Console.WriteLine("Из них строки с длиной не более 3 символов: ");
GetDestArray(myStrArray);



/*** Функции ******************************************************************/
void GetSourceArray(string[] sourceArr){
	foreach (var item in sourceArr){
		System.Console.WriteLine($"{item}");
	}
}

void GetDestArray(string[] destArray){
	System.Console.WriteLine("ИТОГ");
}
