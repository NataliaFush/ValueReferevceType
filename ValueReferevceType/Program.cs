using ValueReferevceType;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car("blue");
        object car = car1;

        Console.WriteLine("Address car1         "+MemoryAddress.Get(car1));
        Console.WriteLine("Address ref car=car1 " + MemoryAddress.Get(ref car));

        int a = 7;
        object b = a;

        Console.WriteLine("Address int a       " + MemoryAddress.Get(a));
        Console.WriteLine("Address ref int b=a " + MemoryAddress.Get(ref b));

        string str1 = "MyStr";
        object str2 = str1;

        Console.WriteLine("Address str1         " + MemoryAddress.Get(str1));
        Console.WriteLine("Address ref srt2=str1" + MemoryAddress.Get(ref str2));






    }
}