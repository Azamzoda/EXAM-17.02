 void Swap(ref int a, ref int b)
 {
    int c=a;
     a=b;
     b=c;
     System.Console.WriteLine($"x = {a}");
     System.Console.WriteLine($"y = {b}");

 }
 int x=Convert.ToInt32(Console.ReadLine());
 int y=Convert.ToInt32(Console.ReadLine());
 Swap(ref x, ref y);