
public class Cycler <T>
{
    private List<T> array;
    private int _index = -1;

    public int Index
    {
        get {  return _index;  }

        set
        {
            _index = value;

            if (value >= array.Count)
                _index = 0;
        }
    }

    public Cycler(List<T> array)
    {
        this.array = array;
    }

    public T GetNext()
    {
        Index++;
        return array[Index];
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
        var word = new Cycler<string>(listString);
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

