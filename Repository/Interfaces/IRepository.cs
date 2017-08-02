using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    interface IRepository
    {
        void Add();
        void Remove();
        void Get(int id);
        void Find();
    }
}
