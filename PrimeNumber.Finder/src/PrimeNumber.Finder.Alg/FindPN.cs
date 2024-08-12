﻿namespace PrimeNumber.Finder.Alg
{
    public class FindPN
    {
        public FindPN()
        {
        }


        //Finds all Prime numbers up to maxNum
        public List<int> FindLinar(int maxNum)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= maxNum; i++)
            {
                bool isP = true;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        isP = false;
                        break;
                    }
                }
                if (isP)
                    result.Add(i);
            }
            return result;
        }
    }
}
