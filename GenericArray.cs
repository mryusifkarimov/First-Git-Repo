namespace GenericTypeExample
{
    //struct - value type
    //class - referance type
    //new() non paramter conustuctor
    //Parent - base calss
    public class GenericArray<T> 
        //where T : IParent
    {
        public T[] Items { get; set; }

        public GenericArray(T[] items)
        {
            Items = items;
        }

        public void Show()
        {
            for (int i = 0; i < Items.Count(); i++)
            {
                Console.Write(Items[i]);

                if (i < Items.Count() - 1)
                {
                    Console.Write(',');
                }
            }

            Console.WriteLine("\n------------------------------------------------------\n");
        }

        public void Update(T item, int indexNo)
        {
            Items[indexNo - 1] = item;
        }
    }
}