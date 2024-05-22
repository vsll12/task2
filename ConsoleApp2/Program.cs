namespace ConsoleApp2
{

       //Calculator
    //Add
    //Mult
    //Div
    //Subt
    //funksiyalari olsun
    //ve switch istifade ederek
    //kalkulyator yazmaq lazimdir.

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double input1;
                double input2;
                char choice;

                Console.Write("Birinci ededi daxil edin : ");

                input1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Emeliyyati daxil edin (+,-,*,/) : ");

                choice = Convert.ToChar(Console.ReadLine());

                Console.Write("Ikinci ededi daxil edin : ");

                input2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(Calculator(input1, choice, input2));

                Thread.Sleep(2000);
            }
        }

        static double Calculator(double input1, char choice, double input2)
        {
            switch (choice)
            {
                case '+':
                    return sum(input1, input2);
                case '-':
                    return sub(input1, input2);
                case '*':
                    return mult(input1, input2);
                case '/':
                    if(div(input1, input2) != 0)
                    {
                        return div(input1, input2);
                    }
                    else
                    {
                        Console.WriteLine("0-a bolunme yoxdur!");
                        return 0;
                    }
                default:
                    Console.WriteLine("Duzgun secim daxil elemediniz!");
                    return 0;
            }
        }

        static double sum(double input1, double input2)
        {
            return input1 + input2;
        }

        static double sub(double input1, double input2)
        {
            return input1 - input2;
        }

        static double mult(double input1, double input2)
        {
            return input1 * input2;
        }

        static double div(double input1, double input2)
        {
            if (input2 != 0)
            {
                return input1 / input2;
            }
            else
            {
                return 0;
            }
        }
    }
}