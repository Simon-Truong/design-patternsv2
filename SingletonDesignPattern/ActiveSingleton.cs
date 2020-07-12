using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class ActiveSingleton
    {
        private static ActiveSingleton _instance = new ActiveSingleton();

        private ActiveSingleton()
        {
            /*
             * non-lazy singleton implementation
             * this implementation is thread safe because when the class is referenced
             * the object is already created
             */
        }

        public static ActiveSingleton GetInstance
        {
            get
            {
                return _instance;
            }
        }
    }
}
