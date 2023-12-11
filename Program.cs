
class Program
{
    static void Main(string[] args)
    {
        string str = null;
        
        int? a = null;

        DateTime? dateTime = null;


        Console.WriteLine(a == null); // True 
        Console.WriteLine(a.HasValue); // False
        Console.WriteLine(a.GetValueOrDefault()); // 0
        Console.WriteLine(a.GetValueOrDefault(3)); // 3
        Console.WriteLine(a ?? 55); // 55

        try
        {
            Console.WriteLine(a.Value); // InvalidOperationException
        }catch (Exception ex)
        {
            Console.WriteLine("no Data");
        }
        
    }
}