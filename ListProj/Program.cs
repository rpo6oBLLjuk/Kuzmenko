public static class Program
{
    public static CustomList.List CustomList = new();

    public static void Main()
    {
        WriteList();

        CustomList.AddItem("0");
        Console.WriteLine($"1. AddItem \"0\"");
        WriteList();

        CustomList.AddItem("1");
        CustomList.AddItem("2");
        CustomList.AddItem("3");
        Console.WriteLine($"2. AddItem \"1\", \"2\", \"3\"");
        WriteList();

        CustomList.Drop(2);
        CustomList.Drop(1);
        Console.WriteLine($"3. Drop 1 and 2 indexes");
        WriteList();

        Console.WriteLine($"4. Item by index 1");
        Console.WriteLine($">> {CustomList.Item(1)}");

        Console.WriteLine($"5. Length");
        Console.WriteLine($">> {CustomList.Length}");

        string[] clone = CustomList.GetDOMObject();
        Console.WriteLine($"6. GetDOMObject");
        Console.WriteLine($">> Clone: [{string.Join(", ", clone)}]");
    }

    private static void WriteList(bool writeline = true)
    {
        Console.Write(">> List: [");

        string[] array = CustomList.GetDOMObject();

        if (array.Length > 0)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                string item = array[i];
                Console.Write($"{item}, ");
            }
            Console.Write(array[array.Length - 1]);
        }

        if (writeline)
            Console.WriteLine("]");
        else
            Console.Write("]");
    }
}

#region CustomList

namespace CustomList
{
    public class List
    {
        public int Length => _array.Length;

        private string[] _array;


        public List() => _array = [];

        public void AddItem(string addedItem)
        {
            string[] newArray = new string[_array.Length + 1];

            for (int i = 0; i < _array.Length; i++)
                newArray[i] = _array[i];

            newArray[newArray.Length - 1] = addedItem;
            _array = newArray;
        }
        public void Drop(int droppedItemIndex)
        {
            if (_array.Length < droppedItemIndex - 1)
                return;

            string[] newArray = new string[_array.Length - 1];

            for (int i = 0; i < droppedItemIndex; i++)
                newArray[i] = _array[i];
            for (int i = droppedItemIndex + 1; i < _array.Length; i++)
                newArray[i - 1] = _array[i];

            _array = newArray;
        }

        public string Item(int index) => _array[index];
        public string[] GetDOMObject() => _array;
    }
}
#endregion