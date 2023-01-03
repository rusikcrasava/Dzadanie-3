  Console.Write("Введите значение X первой точки: "); 
    int X1 = int.Parse(Console.ReadLine());
    Console.Write("Введите значение Y первой точки: "); 
    int Y1 = int.Parse(Console.ReadLine());  
    Console.Write("Введите значение Z первой точки: "); 
    int Z1 = int.Parse(Console.ReadLine());      
    Console.Write("Введите значение X второй точки: "); 
    int X2 = int.Parse(Console.ReadLine());
    Console.Write("Введите значение Y второй точки: "); 
    int Y2 = int.Parse(Console.ReadLine()); 
    Console.Write("Введите значение Z второй точки: "); 
    int Z2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Расстояние между точкой с координатами ({X1},{Y1},{Z1}) и точкой с координатами ({X2},{Y2},{Z2}) составляет: {Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2)+ Math.Pow(Z2-Z1,2)):f2}");
