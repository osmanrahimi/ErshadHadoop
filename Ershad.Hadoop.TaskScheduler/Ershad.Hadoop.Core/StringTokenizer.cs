using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ershad.Hadoop.Core
{
    public class StringTokenizer
    {
        private static char[] defaultDelimiters = { ' ' , '\t' , '\n' , '\r' , '\f'  };

        private string[] tokens;
        private int numTokens;
        private int curToken;

        public StringTokenizer(string line, char[] delimiters)
        {
            tokens = line.Split(delimiters);
            numTokens = tokens.Length;
            curToken = 0;
        }

        public StringTokenizer(string line)
        : this(line, defaultDelimiters)
        {
        }

        public bool hasMoreTokens()
        {
            if (curToken < numTokens) return true;
            else return false;
        }

        public string nextToken()
        {
            if (hasMoreTokens()) return tokens[curToken++];
            else throw new IndexOutOfRangeException();
        }
    }
}

