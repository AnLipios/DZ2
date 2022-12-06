//Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
while (number<6)
{
    
    Console.WriteLine("Иди работать");
    number++;
}
if (number == 6||number == 7)

{
    Console.WriteLine("Ура! Это выходной!");
}
else 
{
    Console.WriteLine("Такого дня недели нет");
}

