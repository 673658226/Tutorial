using Qx.Tools.CommonExtendMethods;
using Qx.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using users.Services;
using users.Entity;

namespace users.Repository
{

    public class usersRepository : BaseRepository, IRepository<Entity.users>
    {
        public List<SelectListItem> ToSelectItems(string value = "")
        {
            var dest = Db.users.Select(a => new SelectListItem() { Text = a.UserID, Value = a.UserName }).ToList();
            return dest.Format(value);
        }

        public string Add(Entity.users model)
        {
            model.UserID = Pk;
            if (Find(model.UserID) == null)
            {
                return Db.SaveAdd(model) ? Pk : null;
            }
            else
            {
                return "";
            }
        }

        public bool Delete(object id)
        {
            return Db.SaveDelete(id);
        }

        public bool Update(Entity.users model, string note = "")
        {
            if (Find(model.UserID) != null)
            {
                return Db.SaveModified(model);
            }
            else
            {
                return false;
            }
        }

        public Entity.users Find(object id)
        {
            return Db.users.NoTrackingFind(a => a.UserID == (string)id);
        }

        public List<Entity.users> All()
        {
            return Db.users.NoTrackingToList();
        }

        public List<Entity.users> All(Func<Entity.users, bool> filter)
        {
            return Db.users.NoTrackingWhere(filter);
        }
    }
}
