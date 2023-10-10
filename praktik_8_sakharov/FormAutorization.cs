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
using praktik_8_sakharov.ModelEF_1;

namespace praktik_8_sakharov
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        int n = 0;
        public static Users Enter_User;
        private void btn_enter_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            if (textBox_log.Text == "" || textBox_pass.Text == "") MessageBox.Show("Вы не ввели логин или пароль");
            else
            {

                Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBox_log.Text && x.Password == textBox_pass.Text);

                if (Enter_User != null)
                {
                    switch (Enter_User.RoleID)
                    {
                        case 1:
                            FormManager formManager = new FormManager();
                            formManager.ShowDialog();
                            break;
                        case 2:
                            FormDirector formDirector = new FormDirector();
                            formDirector.ShowDialog();
                            break;
                        case 3:
                            FormSeller formSeller = new FormSeller();
                            formSeller.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль, лох");
                    n++;
                    if (n == 3)
                    {
                        Thread.Sleep(30000);
                    }
                }
            }
        }
    }
}
