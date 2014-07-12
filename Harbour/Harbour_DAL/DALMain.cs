using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Harbour_DAL
{
    public class DALMain : DALBase
    {
        public IList<pl_menu> getMenuStrip()//主菜单
        {
            return entities.pl_menu.Where(m => m.menu_parent_key == 0 && m.menu_record_status == null).ToList();
        }

        /// <summary>
        /// 通过gkey获取子菜单
        /// </summary>
        /// <param name="gkey"></param>
        /// <returns></returns>
        public IList<pl_menu> getChildItemByGkey(int gkey)
        {
            return entities.pl_menu.Where(m => m.menu_parent_key == gkey && m.menu_record_status == null).ToList();
        }

        public pl_func_parameters getFuncParametersByMenuTitle(string title)
        {
            IList<pl_func_parameters> menuParas = entities.pl_func_parameters.Where(p => p.func_para_menu_title == title).ToList();
            return menuParas != null && menuParas.Count > 0 ? menuParas[0] : null;
        }
    }
}
