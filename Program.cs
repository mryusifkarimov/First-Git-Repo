using GenericTypeExample;

/*
Calculation.Sum(34, 67);

Calculation.Sum(777.675, 944.77);

Calculation.Sum("Salam ", " Dunya");

Calculation.Show<int>(45);
Console.WriteLine("------------------------------------------------------");

Calculation.Show(45, 777);
Calculation.Show(45, "Salam");
Calculation.Show("Salam", true);
Calculation.Show('A', "Salam");
Calculation.Show("Salam", 78.98);
Console.WriteLine("------------------------------------------------------");

Calculation.ShowObj(1);
Calculation.ShowObj("Salam");
Calculation.ShowObj(false);
Calculation.ShowObj('D');
Calculation.ShowObj(789.44);

*/


var intArray = new GenericArray<int>(new int[] { 1, 2, 3, 4, 5 });
intArray.Show();

Console.WriteLine("index no daxil et:");
intArray.Update(67, Convert.ToInt32(Console.ReadLine()));
intArray.Show();

var stringArray = new GenericArray<string>(new string[] { "Ali", "Mamed", "Vugar", "Ramil" });
stringArray.Show();

var ali = "Ali";
var mamed = "Mamed";
var vugar = "Vugar";
var ramil = "Ramil";

var age = 45;


if (typeof(age).IsPrimitive)
{

}

var names = new string[] {
ali, mamed, vugar, ramil,
};
// her bir element Book clasindan

var book1 = new Book("Book1", 456);
var book2 = new Book("Book2", 222);
var book3 = new Book("Book3", 213);

var bookArray = new Book[]
{
    book1, book2, book3
};

var bookArray1 = new Book[]
{
    new Book("Book1", 456), new Book("Book2", 222), new Book("Book3", 213)
};

var genericBookArray1 = new GenericArray<Book>
                        (
                                bookArray1
                        );

var genericBookArray = new GenericArray<Book>
                        (new Book[] 
                            {
                                new Book("Book1", 456),
                                new Book("Book2", 222),
                                new Book("Book3", 213),
                                new Book("Book4", 678),
                                new Book("Book5", 444)
                            }
                        );

 genericBookArray.Show();


var personArray = new GenericArray<Person>(
    new Person[] { }
);

var childArray = new GenericArray<Child>(
    new Child[] { }
);
 

var numbers1 = new int[5] { 1, 2, 3, 4, 5 };
int[] numbers1_1 = { 1, 2, 3, 4, 5 };

// List<>


var numbers = new List<int>() { 1, 2, 3, 4, 5 };
var numbers_1 = new List<int>() { 8, 9, 10 };

var books = new List<Book>();
books.Add(new Book("Book1", 34));
books.Add(new Book("Book2", 54));
books.Add(new Book("Book3", 74));

var book1Name = (new Book("Book1", 34)).Name;

books.ForEach(book => {
    Console.WriteLine($"{book.Name} - {book.PageNo}");
});

foreach (var book in books)
{
    Console.WriteLine($"{book.Name} - {book.PageNo}");
}

var bookNames = books
                .Select(x => x.Name)
                .ToList();

for (int i = 0; i < bookNames.Count(); i++)
{
    Console.WriteLine(bookNames[i]);
}

ListHelper<int>.Show(numbers);

numbers.Add(6);
numbers.Add(7);

ListHelper<int>.Show(numbers);

numbers.AddRange(numbers_1);
ListHelper<int>.Show(numbers);

//delegate
var find5 = numbers.Where(x => x > 1 && x < 7).ToList();

ListHelper<int>.Show(find5);

numbers.RemoveAt(0);
numbers.Remove(10);

numbers.Contains(9);

//numbers.

ListHelper<int>.Show(numbers);

Console.WriteLine(numbers.Count());
numbers.Clear();
Console.WriteLine(numbers.Count());


//var str = "salam dunya salam";
//Console.ReadLine();


//Console.WriteLine(ChainFunction.RemoveALetter(str));

//var removedS = ChainFunction.ReplaceSLetterWithG(ChainFunction.RemoveALetter(str));

//Console.WriteLine(removedS);

//var str1 = str.RemoveALetter();

//Console.WriteLine(str1.ReplaceSLetterWithG());


//Console.WriteLine(str.RemoveALetter().ReplaceSLetterWithG().ToString().RemoveALetter().ReplaceSLetterWithG().ToString().RemoveALetter());
