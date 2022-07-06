
public class Cycler
{
    private string[] array;
    private int index = -1;

    public  Cycler(string[] array)
    {
        this.array = array;
    }

    public  string GetNext()
    {
        index++;
        int size = array.Length;
        if (size == index)
        {
            index = index - size;
        }
        return array[index];
    }
}
public class Employee
{
    static void Main()
    {
        string[] array = { "1", "2", "3" };
         var cycler = new Cycler(array);
         Console.WriteLine(cycler.GetNext());
         Console.WriteLine(cycler.GetNext());
         Console.WriteLine(cycler.GetNext());
         Console.WriteLine(cycler.GetNext());
         Console.WriteLine("-----------------------------------");

    }

}

