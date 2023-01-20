using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _20217052
{
    public partial class SubMenu : Form
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// メインメニューに遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnClick(object sender, EventArgs e)
        {
            //メインメニューを表示
            MainMenu mainMenu = new MainMenu();
            mainMenu.Visible = true;

            //画面を閉じる
            this.Close();
        }

        /// <summary>
        /// 会員登録画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //会員登録画面を表示
            RegisterMenu registerMenu = new RegisterMenu();
            registerMenu.Show();
        }

        /// <summary>
        /// 会員検索画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberSearchClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //会員検索画面を表示
            SearchMenu searchMenu = new SearchMenu();
            searchMenu.Show();
        }

        /// <summary>
        /// 会員修正画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberFixClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //会員修正画面を表示
            FixMenu fixMenu = new FixMenu();
            fixMenu.Show();
        }

        /// <summary>
        /// 会員削除画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MemberDeleteClick(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //会員削除画面を表示
            DeleteMenu deleteMenu = new DeleteMenu();
            deleteMenu.Show();
        }

        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeTableClick(object sender, EventArgs e)
        {
            //テーブル作成する確認ダイアログを表示
            DialogResult result = MessageBox.Show("登録しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //コネクションを開いてテーブル作成して閉じる
                using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "create table HCS_product(member_id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, address TEXT, phone_number)";
                        command.ExecuteNonQuery();
                        MessageBox.Show("登録しました");
                    }
                    con.Close();
                }
            }
            //テーブル作成しない場合の確認ダイアログを表示
            else if (result == DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
            }
        }

        /// <summary>
        /// テーブル削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBottonClick(object sender, EventArgs e)
        {
            //削除する確認ダイアログを表示
            DialogResult result = MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //コネクションを開いてテーブル削除して閉じる
                using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
                {
                    con.Open();
                    using (SQLiteCommand command = con.CreateCommand())
                    {
                        command.CommandText =
                            "drop table HCS_product";
                        command.ExecuteNonQuery();
                        MessageBox.Show("削除しました");
                    }
                    con.Close();
                }
            }
            //削除しない場合の確認ダイアログを表示
            else if (result == DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
            }
        }
    }
}
