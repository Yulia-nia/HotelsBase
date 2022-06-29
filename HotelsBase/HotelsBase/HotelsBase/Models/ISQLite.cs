using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsBase.Models
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
