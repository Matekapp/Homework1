class Program
{
    static void Main()
    {
        // 1) Convert decimal to binary
        int number1 = 17;
        int number2 = 34;
        int number3 = 255;

        Console.WriteLine(Convert.ToString(number1, 2));
        Console.WriteLine(Convert.ToString(number2, 2));
        Console.WriteLine(Convert.ToString(number3, 2));

        // 2) Convert binary to decimal
        string binary1 = "10101";
        string binary2 = "110011";
        string binary3 = "10000000";

        Console.WriteLine(Convert.ToInt32(binary1, 2));
        Console.WriteLine(Convert.ToInt32(binary2, 2));
        Console.WriteLine(Convert.ToInt32(binary3, 2));
    }
}