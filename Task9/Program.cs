 void IncrementArrayElements(ref int[] arr, ref int n) 
 {
    int sum=0;
    System.Console.Write($"[");
    for (int i=0; i<n; i++)
    {
        sum=arr[i]+n;
        System.Console.Write($"{sum}");
        if (i<n-1)System.Console.Write($", ");
    }
    System.Console.WriteLine($"]");
 }
 int a=Convert.ToInt32(Console.ReadLine());
 int [] arr=new int [a];
 for(int i=0; i<a; i++)
 {
    arr[i]=Convert.ToInt32(Console.ReadLine());
 }
 int n=Convert.ToInt32(Console.ReadLine());
IncrementArrayElements(ref arr, ref  n);