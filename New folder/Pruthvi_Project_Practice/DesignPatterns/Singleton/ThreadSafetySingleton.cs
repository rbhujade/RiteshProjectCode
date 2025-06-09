using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ThreadSafetySingleton
    {
        private static ThreadSafetySingleton? instance = null;
        private static readonly object instanceLock = new object();

        private ThreadSafetySingleton()
        {
        }

        public static ThreadSafetySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafetySingleton();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
