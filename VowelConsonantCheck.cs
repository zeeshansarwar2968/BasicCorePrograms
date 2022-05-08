using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class VowelConsonantCheck
    {
        public void vowelCheck()
        {
            char[] vowelsArr = { 'a', 'e', 'i', 'o', 'u'};

            //Taking in number input from user
            Console.Write("Please Enter the Alphabet for check : ");
            char alphabet = Convert.ToChar(Console.ReadLine());
            int flag = 0;
            
            //Looping through the vowels array and setting the flag if the input alphabet matches with any array element
            for (int i = 0; i < vowelsArr.Length; i++)
            {
                if (vowelsArr[i] == alphabet)
                {
                    flag = 1;
                }
            }
            //After the for loop, checking the flag value to validate the alphabet's type
            if (flag == 1)
            {
                Console.WriteLine("The input alphabet letter '{0}' is a vowel", alphabet);
            }
            else
            {
                Console.WriteLine("The input alphabet letter '{0}' is a consonant", alphabet);
            }
        }
    }
}
