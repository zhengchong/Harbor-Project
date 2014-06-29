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

namespace Harbour
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private BLLMain bll = new BLLMain();

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogIn frmLogin = new frmLogIn();
            //frmLogin.ShowDialog();
            CreateMainMenu();
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
            }
        }
    }
}
