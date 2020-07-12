using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonDesignPattern
{
    public class MutexSingleton
    {
        private static MutexSingleton _instance;
        private static Mutex _mutex = new Mutex();

        private MutexSingleton()
        {
            /**
             * thread-safe singleton implementation using mutex
             */
        }

        public static MutexSingleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    if (_mutex.WaitOne())
                    {
                        _instance = new MutexSingleton();
                        _mutex.ReleaseMutex();
                    }
                }

                return _instance;
            }
        }
    }
}
