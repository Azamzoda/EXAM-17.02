 void Fibonacci(int n)
 {
    int sum=0;
    
    if (n==0 || n==1)
    {
        System.Console.Write(n);
    }
    else{
        for (int i=n; i>0; i-=1)
        {
            sum=n-1+n-2;
            System.Console.Write(sum+" ");
        }
    }
 }
 int n=Convert.ToInt32(Console.ReadLine());
 Fibonacci(n);