namespace GenericTypeExample
{
    public class Book
    {
        public string Name { get; set; }
        public int PageNo { get; set; }
        public Book(string Name, int PageNo)
        {
            this.Name = Name;
            this.PageNo = PageNo;
        }
        //public override string ToString() => $"Name:{Name}, PageNo:{PageNo}";
    }


    //internal class BookOld
    //{
    //    public string Name { get; set; }
    //    public int PageNo { get; set; }
    //    public BookOld(string Name, int PageNo)
    //    {
    //        this.Name = Name;
    //        this.PageNo = PageNo;
    //    }

    //    public override string ToString() => $"Name:{Name}, PageNo:{PageNo}";

    //}
}
