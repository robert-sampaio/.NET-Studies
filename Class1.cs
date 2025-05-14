using System;

public class Class1
{
	public Class1()
	{
	}

    static void Main(string[] args)
    {
        string[] someWords =
        {
            "the",
            "quick",
            "brown",
            "fox",
            "jumps"
        };

        //string[] moreWords =
        //{
        //    "over",
        //    "the",
        //    "lazy",
        //    "dog"
        //};

        IEnumerable<string> query = from word in someWords
                                    orderby word
                                    select word;

        foreach (string str in query)
        {
            Console.WriteLine(str);
        }
    }
}