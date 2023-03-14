// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 7)
    Console.WriteLine("В неделе всего 7 дней");
else{
if (num == 6)
    Console.WriteLine("Это выходной");
else if (num == 7)
    Console.WriteLine("Это выходной");
else
    Console.WriteLine("Это НЕ выходной");
}


