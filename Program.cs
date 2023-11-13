using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string input =
            @"public static void GoodFunctionName() \n {\n        byte vbyte = new(); //byte  \n        sbyte vsbyte = new(); //sbyte  \n        short vshort = new(); //short  \n        ushort vushort = new(); //ushort  \n        int vint = new(); //int  \n        uint vuint = new(); //uint  \n        long vlong = new(); //long  \n        ulong vulong = new(); //ulong  \n        float vfloat = new(); //float  \n        double vdouble = new(); //double  \n        decimal vdecimal = new(); //decimal  \n        char vchar = new(); //char  \n        bool vbool = new(); //bool  \n        // object a = new(); //object  \n        string string1 = new(""sda""); //string   \n        string string2 = new(""sda""); //string   \n        DateTime vDateTime = new(); //DateTime  \n    }\n\n    static void badFunctionName()\n    {\n    }";
        string pattern = @"\b((?!new\s*\()[a-z]\w*(?=\())";
        Console.WriteLine("\n");

        foreach (Match match in Regex.Matches(input, pattern))
        {
            Console.WriteLine($"Matched text: {match.Value}");
            // Console.WriteLine(doesmatch.Success);
        }
    }

    public static void GoodFunctionName()
    {
        byte vbyte = new(); //byte  
        sbyte vsbyte = new(); //sbyte  
        short vshort = new(); //short  
        ushort vushort = new(); //ushort  
        int vint = new(); //int  
        uint vuint = new(); //uint  
        long vlong = new(); //long  
        ulong vulong = new(); //ulong  
        float vfloat = new(); //float  
        double vdouble = new(); //double  
        decimal vdecimal = new(); //decimal  
        char vchar = new(); //char  
        bool vbool = new(); //bool  
        // object a = new(); //object  
        string string1 = new("sda"); //string   
        string string2 = new("sda"); //string   
        DateTime vDateTime = new(); //DateTime  
    }

    static void badFunctionName()
    {
    }
}