
class program
{
    static int plusmethodint (int x, int y)
        {
        return x + y;
}
    static double plusmethoddouble(double x, double y)
    {
        return x + y;
    }
    static void main(string[] args)
    {
        int num1=plusmethodint(1, 2);
        double mynum2=plusmethoddouble(4.3, 2.7);
        Console.WriteLine("int:" + num1);
        Console.WriteLine("double:" + mynum2);
    }
}