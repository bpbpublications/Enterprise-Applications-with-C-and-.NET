namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Figure 7.1

            string myMessage = "My custom message";
            double version = 3.2;

            Console.WriteLine(myMessage);
            Console.WriteLine(version);

            //Figure 7.2

            bool enabled = true;
            bool? myNullableBoolVar = null;

            Console.WriteLine(enabled);
            Console.WriteLine(myNullableBoolVar);

            //Figure 7.3

            int intVar = 10;

            bool boolVar = true;

            string stringVar = "My string variable";

            byte byteVar = 255;

            char charVar = 'A';

            object objVar = "Generic object";

            float floatVar = 1000;

            double doubleVar = 100000;

            decimal decimalVar = 10000000;

            //Figure 7.4

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };

            //Figure 7.5

            List<string> daysOfWeekList = new List<string>();
            daysOfWeekList.Add("Monday");
            daysOfWeekList.Add("Tuesday");
            daysOfWeekList.Add("Wednesday");
            daysOfWeekList.Add("Thursday");
            daysOfWeekList.Add("Friday");

            //Figure 7.7

            int timesExecuted = 0;

            while(timesExecuted < 25)
            {
                Console.WriteLine(timesExecuted);
                timesExecuted++;
            }

            //Figure 7.8

            timesExecuted = 0;

            do
            {
                Console.WriteLine(timesExecuted);
                timesExecuted++;
            }
            while (timesExecuted < 25);


            //Figure 7.9

            foreach(string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            //Figure 7.10

            int number1 = 50;
            int number2 = 25;

            int totalSubstraction = number1 - number2;
            int totalAddition = number2 + number1;
            int totalMultiplication = number2 * number1;
            int totalDivision = number1 / number2;

            Console.WriteLine("Total substraction: " + totalSubstraction);
            Console.WriteLine("Total addition: " + totalAddition);
            Console.WriteLine("Total multiplication: " + totalMultiplication);
            Console.WriteLine("Total division: " + totalDivision);


            //Figure 7.11

            myMessage = "My variable is assigned with this value";
            
            int myNumber = 5;

            int x, y, z;

            x = y = z = 10;

            Console.WriteLine("My Message:" + myMessage);
            Console.WriteLine("My Number:" + myNumber);
            Console.WriteLine("Variable X:" + x);
            Console.WriteLine("Variable Y:" + y);
            Console.WriteLine("Variable Z:" + z);


            //Figure 7.12

            number1 = 25;
            number2 = 50;
            bool resultOperation;

            resultOperation = number1 == number2;

            resultOperation = number1 != number2;

            resultOperation = number1 < number2;

            resultOperation = number1 > number2;

            resultOperation = number2 <= number2;

            resultOperation = number1 >= number2;

            //Figure 7.13

            var currentDayOfWeek = DateTime.Now.DayOfWeek;

            if(currentDayOfWeek == DayOfWeek.Monday || currentDayOfWeek == DayOfWeek.Tuesday)
            {
                //MY CUSTOM IMPLEMENTATION
            }

            //Figure 7.14

            currentDayOfWeek = DateTime.Now.DayOfWeek;
            var currentHour = DateTime.Now.Hour;

            if (currentDayOfWeek == DayOfWeek.Saturday || currentHour > 6)
            {
                //MY CUSTOM IMPLEMENTATION
            }

            //Figure 7.15

            int numberExample = 25;
            numberExample++;
            numberExample--;
            numberExample--;

            //Figure 7.16

            var dayOfWeek = DateTime.Now.DayOfWeek;

            string message = dayOfWeek == DayOfWeek.Monday ? "Today is Monday" : "Today is not Monday";

            //Figure 7.17

            int firstExample = 25;
            firstExample += 10;

            int secondExample = 15;
            secondExample *= 5;

            //Figure 7.18

            if(dayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("Today is Saturday");
            }
            else
            {
                Console.WriteLine("Today is NOT Saturday");

            }

            //Figure 7.19

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is Monday");
                    break
                 case DayOfWeek.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Today is Thursday");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is Friday");
                    break;
            }
        }
    }
}