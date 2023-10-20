namespace LinqAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> multiplyByFive = (int num) =>
            {
                Console.WriteLine("tuoj dauginsiu is 5");
                int result = num * 5;
                return result;
            };
            int result = multiplyByFive(7);
            Console.WriteLine(result);

            Func<int, int, int> multiply = (int num1, int num2) =>
            {
                Console.WriteLine($"tuoj dauginsiu is {num1} * {num2}");
                return num1 * num2;
            };
            Console.WriteLine(multiply(3, 7));

            Func<bool, string, DateTime, decimal> differentParameterTypesFunc =
                (bool arg1, string arg2, DateTime arg3) =>
                {
                    Console.WriteLine(arg1);
                    Console.WriteLine(arg2);
                    Console.WriteLine(arg3);

                    return 1.78m;
                };

            Console.WriteLine(differentParameterTypesFunc(false, "string kintamasis", DateTime.Now));

            Func<string> funcWithoutParameters = () =>
            {
                Console.WriteLine("spausdinu metodo viduj");

                return "returning from func without parameters";
            };
            funcWithoutParameters();
        }
    }
}