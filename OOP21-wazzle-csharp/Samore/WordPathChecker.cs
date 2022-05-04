using System;
using System.Collections.Generic;

namespace WazzleLuca
{
    public sealed class WordPathChecker
    {
        static IDictionary<Tuple<int, int>, bool> visited = new Dictionary<Tuple<int, int>, bool>();

        public bool Exist(IDictionary<Tuple<int, int>, char> board, string word)
        {
            visited.Clear();

            for(int i = 0; i < Math.Sqrt(board.Count); i++)
            {
                for (int j = 0; j < Math.Sqrt(board.Count); j++)
                {
                    if((word[0] == board[new Tuple<int, int>(i,j)]) && Search(board, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Search(IDictionary<Tuple<int, int>, char> board, string word, int i, int j, int index)
        {
            if(index == word.Length)
            {
                return true;
            }

            if(i >= Math.Sqrt(board.Count) || 
                i < 0 ||
                j >= Math.Sqrt(board.Count) ||
                j < 0 ||
                board[new Tuple<int, int>(i,j)] != word[index] ||
                visited.ContainsKey(new Tuple<int, int>(i, j)))
            {
                return false;
            }

            visited.Add(new Tuple<int, int>(i, j), true);

            if (Search(board, word, i - 1, j, index + 1) || 
                Search(board, word, i + 1, j, index + 1) || 
                Search(board, word, i, j - 1, index + 1) || 
                Search(board, word, i, j + 1, index + 1) || 
                Search(board, word, i - 1, j + 1, index + 1) || 
                Search(board, word, i + 1, j + 1, index + 1) || 
                Search(board, word, i - 1, j - 1, index + 1) || 
                Search(board, word, i + 1, j - 1, index + 1))
            {
                return true;
            }

            visited.Remove(new Tuple<int, int>(i, j));
            visited.Add(new Tuple<int, int>(i, j), false);

            return false;
        }
    }
}
