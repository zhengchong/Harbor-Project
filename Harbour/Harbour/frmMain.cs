using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Harbour_BLL;
using Model;
using System.Reflection;

namespace Harbour
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private BLLMain bll = new BLLMain();
        public static pl_user_info userInfo { set; get; }


        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogIn frmLogin = new frmLogIn();
            frmLogin.ShowDialog();
            if (frmLogin.IsQuited)
            {
                return;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

            CreateMainMenu();
            SetMenuEnabled();
        }

        private void CreateMainMenu()
        {
            IList<pl_menu> listMenuStrip = bll.getMenuStrip();//获取所有主菜单项
            MenuStrip mainMenu = new MenuStrip();//设置主菜单控件
            foreach (pl_menu menu in listMenuStrip)//menu是主菜单项
            {
                ToolStripMenuItem stripItemMain = new ToolStripMenuItem();
                stripItemMain.Text = menu.menu_title;
                //stripItemMain.Name = menu.menu_function_name;
                CreateMenuItem(stripItemMain,menu);
                mainMenu.Items.Add(stripItemMain);
            }
            this.MainMenuStrip = mainMenu;
            this.Controls.Add(mainMenu);
        }

        private void CreateMenuItem(ToolStripMenuItem currentStrip,pl_menu baseItem)
        {
            IList<pl_menu> childItems = bll.getChildItemByGkey(baseItem.menu_gkey);
            foreach(pl_menu cItem in childItems)
            {
                ToolStripMenuItem newStrip = new ToolStripMenuItem();
                newStrip.Text = cItem.menu_title;
                newStrip.Name = cItem.menu_function_name;
                currentStrip.DropDownItems.Add(newStrip);//把新菜单项加进去
                if (cItem.menu_has_child == 1)//有子菜单
                {
                    CreateMenuItem(newStrip, cItem);//递归调用
                }
                else
                {
                    newStrip.Click += new EventHandler(subMenuClick);
                }
            }
        }

        /// <summary>
        /// 为每个菜单绑定一个窗口，使用反射
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subMenuClick(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Name;
            Assembly assembly = Assembly.Load("Harbour");
            Form frm = (Form)assembly.CreateInstance("Harbour." + name);
            frm.MdiParent = this;
            frm.Show();
        }

        private void SetMenuEnabled()
        {
            IList<int> roleList = userInfo.pl_user_role_info.Select(u => u.user_role_role_id).ToList();
            if (!roleList.Contains(1))//如果是管理员身份则不用判断
            {
                foreach (ToolStripMenuItem menuItem in this.MainMenuStrip.Items)
                {
                    foreach (ToolStripMenuItem item in menuItem.DropDownItems)//双循环，遍历每个菜单项
                    {
                        pl_func_parameters menuPara = bll.getFuncParametersByMenuTitle(item.Text);
                        if (menuPara != null)//说明有加入控制的菜单
                        {
                            //获取可以使用该菜单的角色
                            IList<int> enabledRoleIdList = menuPara.pl_function_priviledge.Where(p => p.func_priv_function_para_key == menuPara.func_para_gkey
                                && p.func_priv_function_enable == 1).Select(p => p.func_priv_role_id).ToList();
                            if (enabledRoleIdList == null || enabledRoleIdList.Count == 0)
                                item.Enabled = false;
                            else
                            {
                                bool foundFlag = false;
                                foreach (int roleid in enabledRoleIdList)
                                {
                                    if (roleList.Contains(roleid))
                                    {
                                        foundFlag = true;
                                    }
                                }
                                item.Enabled = foundFlag;
                            }
                        }
                    }
                }
            }
        }
    }
}
