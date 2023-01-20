using System;
using System.Windows.Forms;

namespace _20217052
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 会員登録管理画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberRegistrationClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //会員登録管理画面を表示
            SubMenu subMenu = new SubMenu();
            subMenu.ShowDialog();
        }

        /// <summary>
        /// システム終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndBottonClick(object sender, EventArgs e)
        {
            //システム終了の確認ダイアログを表示
            if (MessageBox.Show("終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
