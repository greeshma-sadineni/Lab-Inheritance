using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_of_Strings
{
    class Stackofstrings:Stack<string>
    {
        private List<string> data = new List<string>();
       
        public void Push(string item)
        {
            data.Add(item);
           
        }
        public string pop()
        {
            string item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;
        }
        public string peek()
        {
            return data[data.Count - 1];
        }
        public Boolean IsEmpty()
        {
            return data.Count == 0;
        }

    }
      
}
