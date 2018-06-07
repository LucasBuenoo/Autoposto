using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAutoPosto
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            for(int i = 0; i <= 400; i++)
            {
                Thread.Sleep(10);//Carregando
            }
            t.Abort();//Completo
        }

        void Loading()
        {
            frmSplash frm = new frmSplash();
            Application.Run(frm);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
        }

        private void mtxtUsername_Click(object sender, EventArgs e)
        {
            mtxtUsername.Text = "";
        }

        private void mtxtPassword_Click(object sender, EventArgs e)
        {
            mtxtPassword.Text = "";
        }

        private void mbtnLogar_Click_1(object sender, EventArgs e)
        {
            TelaPrincipal.frmPrincipal frmPrincipal = new TelaPrincipal.frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }


    }
}
