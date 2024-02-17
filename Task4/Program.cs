int n=Convert.ToInt32(Console.ReadLine());
int [] arr= new int[n];
for (int i=0; i<n; i++)
{
    arr[i]=int.Parse(Console.ReadLine());
}
for (int i=0; i<n; i++)
{
    if (arr[i]>0)arr[i]=0;
    System.Console.Write(arr[i]+" ");
}