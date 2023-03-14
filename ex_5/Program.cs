Console.WriteLine("Введите колличество программистов в зале");
int n = Convert.ToInt32(Console.ReadLine());
int s = n;
string end_a = "а";
string end_ov = "ов";

if (n > 9)
    n = n % 10;
if (n == 0)
    Console.WriteLine($"В зале {s} программист{end_ov}");
if (n == 1)
    Console.WriteLine($"В зале {s} программист");
if (n == 2)
    Console.WriteLine($"В зале {s} программист{end_a}");
if (n == 3)
    Console.WriteLine($"В зале {s} программист{end_a}");
if (n == 4)
    Console.WriteLine($"В зале {s} программист{end_a}");
if (n == 5)
    Console.WriteLine($"В зале {s} программист{end_ov}");
if (n == 6)
    Console.WriteLine($"В зале {s} программист{end_ov}");
if (n == 7)
    Console.WriteLine($"В зале {s} программист{end_ov}");
if (n == 8)
    Console.WriteLine($"В зале {s} программист{end_ov}");
if (n == 9)
    Console.WriteLine($"В зале {s} программист{end_ov}");

