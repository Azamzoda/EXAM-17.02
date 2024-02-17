void Even(int a, int b)
{
    if (a==b)
    {
        return;
    }
    else {
        if (a%2==0){ 
        System.Console.WriteLine(a);
        Even(a+1,b);
        }
    }
}
void Odd(int a, int b)
{
    if (a==b)
    {
        return;
    }
    else {
        if (a%2!=0){ 
        System.Console.WriteLine(a);
        
        }
    }
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
Even(a,b);
Odd(a,b);