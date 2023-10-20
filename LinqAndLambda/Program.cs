namespace LinqAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, int> multiplyByFive = (int num) =>
            //{
            //    Console.WriteLine("tuoj dauginsiu is 5");
            //    int result = num * 5;
            //    return result;
            //};
            //int result = multiplyByFive(7);
            //Console.WriteLine(result);

            //Func<int, int, int> multiply = (int num1, int num2) =>
            //{
            //    Console.WriteLine($"tuoj dauginsiu is {num1} * {num2}");
            //    return num1 * num2;
            //};
            //Console.WriteLine(multiply(3, 7));

            //Func<bool, string, DateTime, decimal> differentParameterTypesFunc =
            //    (arg1, arg2, arg3) => 1.78m;

            //Console.WriteLine(differentParameterTypesFunc(false, "string kintamasis", DateTime.Now));

            //Func<string> funcWithoutParameters = () => "returning from func without parameters";
            //Console.WriteLine(funcWithoutParameters());

            //Func<int, bool> isIntegerHigherThanTen = (number) => number > 10;
            //int numberToCheck = 4;
            //if (isIntegerHigherThanTen(numberToCheck))
            //{
            //    Console.WriteLine("Skaicius didesnis nei 10");
            //}
            //else
            //{
            //    Console.WriteLine("Skaicius nedidesnis nei 10");
            //}

            //Func<int, int, int> filterNumber =
            //    (number1, number2) => number1 > number2 ? number1 : number2;


            Func<string, string> selector = (str) => str.ToUpper();
            string[] words = new string[] { "orange", "apple", "Article", "elephant" };

            //List<string> upperWords = new List<string>();
            //foreach (string word in words)
            //{
            //    upperWords.Add(selector(word));
            //}

            var upperWordsWithLinq = words.Select((word) => word.ToUpper());    // Func<string, string>
            var wordsLengths = words.Select((word) => word.Length);             // Func<string, int>
            var areWordsLongerThan5 = words.Select((word) => word.Length > 5);  // Func<string, bool>

            var wordsLongerThan5 = words.Where(str => str.Length > 5);

            var orderedWords = words.OrderBy(word => word);
            var orderedWordsByLength = words.OrderBy(word => word.Length);

            // Grazint zodi pagal ilgi, arba ismes klaida jei keli zodziai tokio ilgio,
            // arba grazins null jei nei vienas nera tokio ilgio
            string singleOrDefaultWordWith8Symbols = words.SingleOrDefault(word => word.Length == 8);
            // Tas pats kas SingleOrDefault, bet bus klaida jei nerado tokio ilgio zodzio
            string singleWordWith8Symbols = words.Single(word => word.Length == 8);

            var wordsCount = words.Count();
            var wordsCountLongerThan5 = words.Count(word => word.Length > 5);

            // ForEach veikia tik Listams taigi masyva paverciame i List<string> su ToList() metodu
            // ir ForEach yra voidinis
            words.ToList().ForEach(word => Console.WriteLine(word));


            var person1 = new Person
            {
                Name = "Petras",
                Pets = new List<Pet>
                {
                    new Pet { PetName = "Suo"},
                    new Pet { PetName = "Kate"},
                }
            };

            var person2 = new Person
            {
                Name = "Jonas",
                Pets = new List<Pet>
                {
                    new Pet { PetName = "Sunis"},
                    new Pet { PetName = "Katinas"},
                    new Pet { PetName = "Papuga"},
                }
            };

            var person3 = new Person
            {
                Name = "Juozas",
                Pets = new List<Pet>
                {
                    new Pet { PetName = "Smauglys"}
                }
            };
            var personsList = new List<Person> { person1, person2, person3 };
            List<Pet> personsPets = personsList.SelectMany(person => person.Pets).ToList();
        }
    }
}