using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Of_Work
{
    public interface IOrderRepository
    {
        void Add();
        void Delete();
        void Update();
    }
}
