class Program
{
    static void Main(string[] args)
    {
        GoodFunctionName();
        var a = "Hello";
        // string a;
        badFunctionName();
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
        object a = new(); //object  
        string string1 = new("sda"); //string   
        string string2 = new("sda"); //string   
        DateTime vDateTime = new(); //DateTime  
    }

    static void badFunctionName()
    {
        
    }
}