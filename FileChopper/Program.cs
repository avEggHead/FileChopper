namespace FileChopper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing file size saving");
            string testString = "This string has a certain length asdfasdfa safsdf asdf asdf ";
            Console.WriteLine("Length of string is: " + testString.Length);
            var path = @"C:\TestLength.txt";
            File.Create(path).Close();
            File.AppendAllText(path, testString);
            Console.WriteLine("I just wrote the file go see if it is " + testString.Length + " bytes");
            Console.ReadKey();
        }
    }
}