
public class Cycler <T>
{
    public List<T> array;
    private int index = -1;

    public  Cycler (List<T>array)
    {
        this.array = array;
    }

    public  T GetNext()
    {

        index++;
        int size = array.Count;
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
        List<int>  listInt = new (){1,2,3};
        List<string> listString = new() { "s", "q" };
        List<char> listChar = new() { 'a', 'b' };

        var numbers = new Cycler<int> (listInt);
        var word = new Cycler<string>(listString );
        var letter = new Cycler<char>(listChar);



         Console.WriteLine(numbers .GetNext());
         Console.WriteLine(numbers .GetNext());
         Console.WriteLine(numbers .GetNext());
         Console.WriteLine(numbers .GetNext());
         Console.WriteLine("-----------------------------------");
         Console.WriteLine(word.GetNext());
         Console.WriteLine(word.GetNext());
         Console.WriteLine(word.GetNext());
         Console.WriteLine(word.GetNext());
         Console.WriteLine("-----------------------------------");
         Console.WriteLine(letter.GetNext());
         Console.WriteLine(letter.GetNext());
         Console.WriteLine(letter.GetNext());
         Console.WriteLine(letter.GetNext());
    }


}

