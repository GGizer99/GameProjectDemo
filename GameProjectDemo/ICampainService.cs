using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    interface ICampainService
    {
        void Add(Campain campain);
        void Delete(Campain campain);
        void Update(Campain campain);
    }
}
