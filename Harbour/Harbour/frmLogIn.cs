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

namespace Harbour
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        BLLLogin bll = new BLLLogin();
        public bool IsQuited { get; set; }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            IsQuited = true;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //判断是否可以登录
            frmMain.userInfo = bll.getUserInfoByName(this.txtUserName.Text, this.txtPassword.Text);
            if(frmMain.userInfo == null)
            {
                MessageBox.Show("no users!", "Error");
            }
            else
            {
                IsQuited = false;
                this.Close();
            }
            //
        }
    }
}
