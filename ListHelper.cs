namespace GenericTypeExample
{
    public class ListHelper<T>
    {
        public static void Show(List<T> Items)
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
    }
}
