﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> dictionary = new MyDictionary<int,string>();
            dictionary.Add(1,"ahmet");
            Console.WriteLine(dictionary.Length);
            foreach (var key in dictionary.Keys)
            {
                foreach (var value in dictionary.Values)
                {
                    Console.WriteLine(key);
                    Console.WriteLine(value);

                }
            }
        }
    }

    class MyDictionary<T,Z>
    {
        private T[] keys;
        private Z[] values;


        public MyDictionary()
        {
            keys = new T[0];
            values = new Z[0];

        }

        public void Add(T key, Z value)
        {
            T[] tempArray = keys;
            Z[] tempArray2 = values;


            keys = new T[keys.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                keys[i] = tempArray[i];
            }
            keys[keys.Length - 1] = key;

            //-----------------------------------------

            values = new Z[values.Length + 1];
            for (int j = 0; j < tempArray2.Length; j++)
            {
                values[j] = tempArray2[j];
            }
            values[values.Length - 1] = value;
        }

        public int Length
        {
            get { return keys.Length; }
        }

        public T[] Keys
        {
            get { return keys; }
        }

        public Z[] Values
        {
            get { return values; }
        }
    }
}
