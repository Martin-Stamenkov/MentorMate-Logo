using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo
{
    public class Engine
    {
        private int n;
        private int leftMinus;
        private int leftAndRigthStars;
        private int middleMinus;
        private int rightMinus;
        private int middleStars;
        public Engine(int n)
        {
            this.n = n;
            this.leftMinus = n;
            this.leftAndRigthStars = n;
            this.middleMinus = n;
            this.rightMinus = n;
            this.middleStars = 0;
        }
       
        public void Draw(int n)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"N = {n}");

            string currentLine;     

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                currentLine = firstPartOfLogo(leftMinus, leftAndRigthStars, middleMinus, rightMinus);
                sb.AppendLine(currentLine);

                leftMinus -= 1;
                leftAndRigthStars += 2;
                middleMinus -= 2;
                rightMinus -= 1;
            }

             middleStars = (n * 2) - 1;
             leftMinus = n - (n + 1) / 2;
             leftAndRigthStars = n;
             middleMinus = 1;
             rightMinus = ((n + 1) / 2) - 1;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                currentLine = secondPartOfLogo(leftMinus, leftAndRigthStars, middleStars, middleMinus, rightMinus);
                sb.AppendLine(currentLine);

                leftMinus -= 1;
                middleMinus += 2;
                middleStars -= 2;
                rightMinus -= 1;
            }

            Console.WriteLine(sb.ToString());
        }   
        private static string firstPartOfLogo(int leftSide, int stars, int middle, int rightSide)
        {
            var currentLine = new string('-', leftSide)
                + new string('*', stars)
                + new string('-', middle)
                + new string('*', stars)
                + new string('-', rightSide);

            return currentLine + currentLine;
        }
        static string secondPartOfLogo(int leftMinus, int leftAndRigthStars, int middleStars, int middleMinus, int rightMinus)
        {
            var currentLine = new string('-', leftMinus)
                + new string('*', leftAndRigthStars)
                + new string('-', middleMinus)
                + new string('*', middleStars)
                + new string('-', middleMinus)
                + new string('*', leftAndRigthStars)
                + new string('-', rightMinus);

            return currentLine + currentLine;
        }
    }
}
