namespace GenericTypeExample
{
    public class Book
    {
        public string Name { get; set; }
        public int PageNo { get; set; }
        public string Note { get; set; }
        public Book(string Name, int PageNo, string note)
        {
            this.Name = Name;
            this.PageNo = PageNo;
            this.Note = note;
        }
        public override string ToString() => $"Name:{Name}, PageNo:{PageNo, Note:{Note}";
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
