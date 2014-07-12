using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Harbour_DAL
{
    public class DALLogin : DALBase
    {
        public IList<pl_user_info> getUserInfoByName(string userName, string password)
        {
            return entities.pl_user_info.Where(u => u.user_name == userName && u.user_pswd == password).ToList();
        }
    }
}
