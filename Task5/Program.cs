int n=int.Parse(Console.ReadLine());
int[] arr=new int[n];
for (int i=0; i<n; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}
int b=int.Parse(Console.ReadLine());
int cnt=0;
for (int i=0; i<n; i++)
{
    if (arr[i]==b)cnt++;
}
System.Console.WriteLine(cnt);