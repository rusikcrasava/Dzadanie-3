Console.Clear();
    Console.Write("Введите положительное число: ");
    int N = int.Parse(Console.ReadLine());
    if (N<1)
      {
        Console.WriteLine("Вы ввели не положительное число");
      }
    else
      {
        Console.WriteLine($"таблица кубов от 1 до {N}: ");
        int i=1; 
        while (i<=N)
          {
            Console.Write($"{Math.Pow(i,3)} ");
            i++;        
          }
      }
