using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1: first check in
            //Console.WriteLine("");
            //step 2: successfully cloned into local and checked out
            //step 3: now merge this with initial version of code
            //step 4: added as FirstBranch
            //step 5: created SecondBranch and merging with FirstBranch
            string str = Console.ReadLine();
            Console.WriteLine(str);
            char[] str1 = new char[10];
            str1 = str.ToCharArray();
            for(int i=0;i<str1.Length-1;i++)
            {
                if(str1[i]>str1[i+1])
                {
                    Console.WriteLine("Incorrect");
                }
                
            }
            Console.ReadKey();
        }
    }
}
