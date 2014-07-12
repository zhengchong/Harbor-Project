using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Harbour_DAL;

namespace Harbour_BLL
{
    public class BLLMain
    {
        public IList<pl_menu> getMenuStrip()
        {
            DALMain dal = new DALMain();
            return dal.getMenuStrip();
        }

        public IList<pl_menu> getChildItemByGkey(int gkey)
        {
            DALMain dal = new DALMain();
            return dal.getChildItemByGkey(gkey);
        }

        public pl_func_parameters getFuncParametersByMenuTitle(string title)
        {
            DALMain dal = new DALMain();
            return dal.getFuncParametersByMenuTitle(title);
        }
    }
}
