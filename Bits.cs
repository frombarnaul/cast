public struct Bits
{
    private readonly ulong _value;

    public Bits(ulong value)
    {
        _value = value;
    }

    // Неявное приведение из long в Bits
    public static implicit operator Bits(long value)
    {
        return new Bits((ulong)value);
    }

    // Неявное приведение из int в Bits
    public static implicit operator Bits(int value)
    {
        return new Bits((ulong)value);
    }

    // Неявное приведение из byte в Bits
    public static implicit operator Bits(byte value)
    {
        return new Bits((ulong)value);
    }

    // Перегрузка ToString для удобства вывода
    public override string ToString()
    {
        return _value.ToString();
    }
}