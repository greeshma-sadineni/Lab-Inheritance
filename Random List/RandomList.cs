using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Random_List
{
    class RandomList:List<string>
    {
        //List<string> mylist = new List<string>();
        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0,Count);
            String element = this[index];
            this.RemoveAt(index);
            return element;
            
        }
      
       
        }
    }

