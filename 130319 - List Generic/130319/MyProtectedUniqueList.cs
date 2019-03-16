using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _130319
{
    public class MyProtectedUniqueList<T> : IEnumerable<T>
    {
        private List<T> words;
        private string KeyWord;
  
        public MyProtectedUniqueList(string word)
        {
            KeyWord = word;
            words = new List<T>();
        }
        public void Add(T word)
        {
            if (word == null || word.ToString() == "")
            {
                throw new ArgumentNullException("The argument is null or blank");
            }
            foreach (T w in words)
            {
                if (w.Equals(word))
                {
                    throw new InvalidOperationException("The argument exist");
                }
            }
            words.Add(word);
        }
        public void RemoveAt(int index)
        {
                if(index < 0 && index > words.Count-1)
                {
                throw new ArgumentOutOfRangeException("The index is out of range");
                }
            words.RemoveAt(index);
        }
        public void Remove(T word)
        {
            bool find = false;
            if (word == null || word.ToString() == "")
            {
                throw new ArgumentNullException("The argument is null or blank");
            }
            foreach(T w in words)
            {
                if (w.Equals(word))
                {
                    find = true;
                    break;
                }
            }
            if (!find)
                throw new ArgumentException("The argument does not exist");
            words.Remove(word);
        }
        public void Clear(T word)
        {
            if (!word.Equals(KeyWord))
            {
                throw new AccessViolationException("The word is not keyword");
            }
            words.Clear();
        }
        public void Sort(T word)
        {
            if (!word.Equals(KeyWord))
            {
                throw new AccessViolationException("The word is not keyword");
            }
            words.Sort();
        }
        public override string ToString()
        {
            string temp = "";
            foreach (T str in words)
            {
                temp += str + "\n"; //maybe also + '\n' to put them on their own line.
            }
            return $"The list is:\n{temp}";
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }
}
