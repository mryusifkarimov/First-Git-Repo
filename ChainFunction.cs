namespace GenericTypeExample
{
    public static class ChainFunction
    {
        public static string RemoveALetter(this string x) => x.Replace("a", string.Empty);
        //public static string ReplaceSLetterWithG(this string x) => x.Replace("s", "g");
        public static int ReplaceSLetterWithG(this string x, int y) => 5;

    }
}
