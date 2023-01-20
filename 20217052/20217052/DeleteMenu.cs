using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _20217052
{
    public partial class DeleteMenu : Form
    {
        public DeleteMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 会員登録管理画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnClick(object sender, EventArgs e)
        {
            //会員登録管理画面を表示
            SubMenu subMenu = new SubMenu();
            subMenu.Visible = true;

            //画面を閉じる
            this.Close();
        }

        /// <summary>
        /// 会員登録情報を削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBottonClick(object sender, EventArgs e)
        {
            //削除する確認ダイアログを表示
            DialogResult result = MessageBox.Show("削除しますか？", "確認", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "DELETE FROM HCS_product WHERE member_id = @member_id";
                        //パラメータセット
                        cmd.Parameters.Add("member_id", DbType.Int64);
                        //データ削除
                        cmd.Parameters["member_id"].Value = int.Parse(Txt_DeleteID.Text);
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                        MessageBox.Show("削除しました");
                    }
                }
            }
            //削除しない場合の確認ダイアログを表示
            else if (result == DialogResult.No)
            {
                MessageBox.Show("キャンセルしました");
            }
        }

        /// <summary>
        /// 会員登録情報を確認
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBottonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                //DataTableを生成します。
                DataTable dataTable = new DataTable();
                //SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product", con);
                adapter.Fill(dataTable);
                MemberDeleteGridView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// DataGridviewの幅を調整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMenuLoad(object sender, EventArgs e)
        {
            MemberDeleteGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MemberDeleteGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
