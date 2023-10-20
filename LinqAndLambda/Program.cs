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
                (arg1, arg2, arg3) => 1.78m;

            Console.WriteLine(differentParameterTypesFunc(false, "string kintamasis", DateTime.Now));

            Func<string> funcWithoutParameters = () => "returning from func without parameters";
            Console.WriteLine(funcWithoutParameters());

            Func<int, bool> isIntegerHigherThanTen = (number) => number > 10;
            int numberToCheck = 4;
            if (isIntegerHigherThanTen(numberToCheck))
            {
                Console.WriteLine("Skaicius didesnis nei 10");
            }
            else
            {
                Console.WriteLine("Skaicius nedidesnis nei 10");
            }

            Func<int, int, int> filterNumber =
                (number1, number2) => number1 > number2 ? number1 : number2;


        }
    }
}