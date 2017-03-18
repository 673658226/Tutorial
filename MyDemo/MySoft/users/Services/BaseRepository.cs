using System;
using Qx.Tools.CommonExtendMethods;
using users.Entity;

namespace users.Services
{
    public class BaseRepository
    {
        private MyDbContext db;

        protected MyDbContext Db
        {
            get
            {
                if (db == null)
                {
                    db = new MyDbContext();
                }
                return db;
            }
        }

        protected string Pk { get { return DateTime.Now.Random().ToString(); } }
    }
}
