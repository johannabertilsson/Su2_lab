//Diana Thomory
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaA_Uppgift2
{

    class Entry
    {
        public object myKey;
        public object myValue;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        
        
        public Entry(object key, object value)
        {
            myKey = key;
            myValue = value;
        }
        /// <summary>
        /// Compair two keys
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Entry keyValue = (Entry)obj;

            return myKey.Equals(keyValue.myKey);
        }
    }
}