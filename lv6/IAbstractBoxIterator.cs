using System;
using System.Collections.Generic;
using System.Text;

namespace lv6
{
    interface IAbstractBoxIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
