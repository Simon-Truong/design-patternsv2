using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        private SimpleSingleton()
        {
            /*
             * simple singleton design pattern
             * NOTE: DO NOT USE
             * this implementation is not thread safe, multiple threads can get to line #22,
             * therefore two singleton objects can be returned
             */
        }

        public static SimpleSingleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SimpleSingleton();
                }

                return _instance;
            }
        }
    }
}
