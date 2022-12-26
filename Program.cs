// Решение задания №64

Console.Write("Введите натуральное число:");
int n = 0;
int.TryParse(Console.ReadLine(), out n);

while(n > 1)
{
    Console.Write($"{n}, ");
    n = n - 1;
}
Console.WriteLine(1);

// Решение задания №66

Console.Write("Введите натуральное число N:");
int n1 = 0;
int.TryParse(Console.ReadLine(), out n1);

Console.Write("Введите натуральное число M:");
int m = 0;
int.TryParse(Console.ReadLine(), out m);

int summ = 0;

while(n1 >= m)
{
    summ = summ + n1;
    n1 = n1 - 1;
}
Console.WriteLine($"{summ}");

// Вычисление функции Аккермана 

int  Akkerman(int n2, int m2)
{
  if (n2 == 0)
    return m2 + 1;
  else
    if ((n2 != 0) && (m2 == 0))
      return Akkerman(n2 - 1, 1);
    else
      return Akkerman(n2 - 1, Akkerman(n2, m2 - 1));
}

//
int n2 = 0;
int m2 = 0;

Console.Write("Введите первый параметр функции Аккермана (N):");
int.TryParse(Console.ReadLine(), out n2);

Console.Write("Введите второй параметр функции Аккермана (M):");
int.TryParse(Console.ReadLine(), out m2);

double akkerans = Akkerman(n2,m2);

Console.WriteLine($"Значение функции Аккермана: {akkerans}");
