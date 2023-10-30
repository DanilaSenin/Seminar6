Console.WriteLine("Введите k1, b1, k2, b2: ");
decimal k1 = decimal.Parse(Console.ReadLine());
decimal b1 = decimal.Parse(Console.ReadLine());
decimal k2 = decimal.Parse(Console.ReadLine());
decimal b2 = decimal.Parse(Console.ReadLine());
decimal x = (b2 - b1)/(k1-k2);
decimal y = k1*x+b1;
Console.Write($"Координаты точки ({x}, {y})");