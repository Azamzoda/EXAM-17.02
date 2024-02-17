int n=Convert.ToInt32(Console.ReadLine());
int [] arr=new int [n];
for (int i=0; i<n; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int min=999999, max=-999999, z=0 ,x=0;;
for (int i=0; i<n; i++)
{
    if (arr[i]<min)
    {
        min=arr[i];
        z=i;
    }
    if (arr[i]>max)
    {
        max=arr[i];
        x=i;
    }

}
System.Console.Write(min+" ");
for (int i=z+1; i<x; i++)
{
    System.Console.Write(arr[i]+" ");
    
}
System.Console.Write(max);
