namespace cast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long longValue = 123456789012345;
            int intValue = 123456;
            byte byteValue = 123;

            Bits bitsFromLong = longValue; // Неявное приведение из long в Bits
            Bits bitsFromInt = intValue;   // Неявное приведение из int в Bits
            Bits bitsFromByte = byteValue; // Неявное приведение из byte в Bits

            Console.WriteLine($"Bits from long: {bitsFromLong}");
            Console.WriteLine($"Bits from int: {bitsFromInt}");
            Console.WriteLine($"Bits from byte: {bitsFromByte}");
        }
    }
}
