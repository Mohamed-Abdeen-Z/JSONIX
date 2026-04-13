using Internal.Synchronous.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.Engine
{
    internal interface IEngine
    {
        Dictionary<string, object> Load(string path = null);

        void Insert(Dictionary<string, object> data, string path = null);
    }
}
