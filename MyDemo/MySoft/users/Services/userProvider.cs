using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using users.Entity;
using users.Interfaces;

namespace users.Services
{
    public class userProvider : BaseRepository, IuserPrivider
    {
        public bool Login(string uid, string psw)
        {
            var user = Db.users.Find(uid);
            if (user == null)
            {
                throw new Exception("不存在id为" + uid + "的用户");
            }
            else
            {
                if (psw == user.Psw)
                    return true;
                else
                {
                    return false;
                }
            }
        }

        public Entity.users UserInfo(string uid)
        {
            var user = Db.users.Find(uid);
            if (user == null)
            {
                throw new Exception("不存在id为" + uid + "的用户");
            }
            else
            {
                return user;
            }
        }
    }
}
