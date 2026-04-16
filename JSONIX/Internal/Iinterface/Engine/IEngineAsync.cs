using System;
using System.Collections.Generic;
using System.Text;

namespace Internal.Iinterface.Engine
{
    internal interface IEngineAsync
    {
        Task<Dictionary<string, object>> LoadAsync(string path = null);

        Task InsertAsync(Dictionary<string, object> data, string path = null);
    }
}
