using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazySingleton = new Lazy<LazySingleton>(() => new LazySingleton());
        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get
            {
                return lazySingleton.Value;
            }
        }
    }
}
