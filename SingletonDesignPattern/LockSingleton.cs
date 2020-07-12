using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public class LockSingleton
    {
        private static LockSingleton _instance;
        private static readonly object padlock = new object();

        private LockSingleton()
        {
            /*
             * thread-safe singleton implementation by using locks
             * also utilizes the double check, so we do not have to lock every time we get the instance
             */
        }

        public static LockSingleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new LockSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
