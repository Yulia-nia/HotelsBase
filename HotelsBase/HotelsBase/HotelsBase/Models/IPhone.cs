using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HotelsBase.Models
{
    public interface IPhone
    {
        Task Call(string phoneNumber);
    }
}
