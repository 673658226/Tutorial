using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace users.Interfaces
{
    public interface IuserPrivider
    {
        Entity.users UserInfo(string userid);
        bool Login(string uid, string psw);
    }
}
