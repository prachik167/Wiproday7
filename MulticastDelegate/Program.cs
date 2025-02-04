namespace MulticastDelegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            MathopDel d = new MathopDel(MathOpe.Add);
            d.Invoke(10, 20);
            d += MathOpe.Sub;
            d += MathOpe.Mul;
            d += MathOpe.Div;
            d(20, 10);
        }
    }
}
