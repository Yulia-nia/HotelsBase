using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace HotelsBase
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}