using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Harbour_DAL;
using Common;

namespace Harbour_BLL
{
    public class BLLLogin
    {
        public pl_user_info getUserInfoByName(string userName, string passwordDecrypted)
        {
            DALLogin dal = new DALLogin();
            string passwordEncrypted = EncryptorHelper.Encryptor(passwordDecrypted);
            IList<pl_user_info> userInfo = dal.getUserInfoByName(userName, passwordEncrypted);
            if (userInfo.Count > 0)
                return userInfo[0];
            else return null;
        }
    }
}
