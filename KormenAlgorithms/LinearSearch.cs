using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionBook.KormenAlgorithms
{
    internal class LinearSearch
    {
        public int FirstLinearSearch(string[] books, int count, string searchedBook)
        {
            int answer = 0;
            for (int i = 1; i <= count; i++)
            {
                if (books[i] == searchedBook)
                    answer = i;
            }
            return answer;
        }

        public int BetterLinearSearch(string[] books, int count, string searchedBook)
        {
            for (int i = 1; i <= count; i++)
            {
                if (books[i] == searchedBook)
                    return i;
            }
            return 0;
        }

        public int SentinelLinearSearch(string[] books, int count, string searchedBook)
        {
            var last = books[count - 1];
            books[count - 1] = searchedBook;
            int i = 0;
            while (books[i] != searchedBook)
                i++;
            books[count - 1] = last;
            if (i < count && books[count - 1] == searchedBook)
                return i;
            else
                return 0;
        }
    }
}
