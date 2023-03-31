// Площадь треугольника
// (Время: 1 сек. Память: 16 Мб Сложность: 15%)
// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

// Входные данные
// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не превышают 106 по абсолютной величине.

// Выходные данные
// В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

Console.Clear();
System.Console.WriteLine("Введите x1: ");
double x1=Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введите y1: ");
double y1=Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введите x2: ");
double x2=Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введите y2: ");
double y2=Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введите x3: ");
double x3=Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введите y3: ");
double y3=Convert.ToDouble(Console.ReadLine()!);
double d12=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
double d23=Math.Sqrt((x3-x2)*(x3-x2)+(y3-y2)*(y3-y2));
double d31=Math.Sqrt((x1-x3)*(x1-x3)+(y1-y3)*(y1-y3));
double p = (d12+d23+d31)/2;
double S =Math.Sqrt(p*(p-d12)*(p-d23)*(p-d31));
System.Console.WriteLine(S);