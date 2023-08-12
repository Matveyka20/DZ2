int num = new Random().Next(100,1000);
System.Console.WriteLine($"Было сгенерировано число {num} ");
int digit1 = num / 10;
int digit2 = digit1 % 10;
System.Console.WriteLine($"Вторая цифра этого числа {digit2} ");