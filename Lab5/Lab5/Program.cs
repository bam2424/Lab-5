//Grading ID: R2221
// CIS 199-02
// 03/06/22
//Lab 5
// The purpose of this is for a user to input temperature values into an interactive program
// and receive the number of valid temperatures while also receiving the average temp.
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int count = 0; // valid temp variable
            double sum = 0; // used for mean
            string input = ""; // inital variable before tryparse


            WriteLine("Enter temperatures from -20 to 130 (999 to stop)."); // instructions
            WriteLine(""); // empty space

            while (!input.Equals("999")) // while statment determining whether temp equals 999. 
            {
                WriteLine("Enter Temperature:"); // first written line
                input = ReadLine(); // interactive line

                if (!input.Equals("999")) // if statement for sentinel value.
                {
                    int temp; // temp variable.
                    if (int.TryParse(input, out temp)) // tryparse input to temp.
                    {
                        if (temp >= -20 && temp <= 130) // if statement determining temp limits.
                        {
                            ++count; // prefix count 
                            sum += temp; // sum + temp
                        }
                        else // if temp is any other value, it isn't valid.
                            WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature"); //invalid

                    }
                    else // Used for determining invalid statements. Letters...
                            WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature"); //invalid

                }
            }
            // Both are summarization statements to show valid temps/ the mean.
            WriteLine("You entered {0} valid temperatures", count);
            WriteLine("Your mean temperature is {0:F1}", sum / count); 








            




        }
    }
}
