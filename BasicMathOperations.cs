namespace CodeWars
{
    class BasicMathOperations
    {
        public static double basicOp (char operation, double x, double y)
        {
            double result = 0;
            if (operation == '+')
            {
                result = x + y;
            }
            else if (operation == '-')
            {
                result = x - y;
            }
            else if (operation == '*')
            {
                result = x * y;
            }
            else if (operation == '/')
            {
                result = x / y;
            }
            return result;
        }
    }
}
