Console.Write("Введите пятизначное число: ");
    string pol = Console.ReadLine();
    if(pol[0] == '-') {pol=pol.Substring(1);}  
    if (!int.TryParse(pol, out int y))
      {
        Console.Write("Это не число");
      }
    else 
    {
      int n=-1;  
      for (int i=0; i<=pol.Length/2; i++)
        { 
          if (pol[i]==pol[pol.Length-1-i])
            {
              n=1;
            }
          else {n=0; break;}
        }
      if (n==1)
        {
          Console.Write("да, это палиндром"); 
        }
      else 
        {
          Console.Write("нет, это не палиндром");
        }
    }
