using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class LazySingleton
    {
        private static Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
            /*
             * singleton implementation with Lazy
             */
        }

        public static LazySingleton GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
