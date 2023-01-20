using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _20217052
{
    public partial class FixMenu : Form
    {
        public FixMenu()
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
        /// 会員登録情報を修正
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FixBottonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "UPDATE HCS_product set name = @name, address = @add, phone_number = @phone WHERE member_id = @member_id";
                    //パラメータセット
                    cmd.Parameters.Add("name", DbType.String);
                    cmd.Parameters.Add("add", DbType.String);
                    cmd.Parameters.Add("phone", DbType.Int64);
                    cmd.Parameters.Add("member_id", DbType.Int64);
                    //データ追加
                    cmd.Parameters["name"].Value = Txt_Name.Text;
                    cmd.Parameters["add"].Value = Txt_Address.Text;
                    cmd.Parameters["phone"].Value = int.Parse(Txt_Tel.Text);
                    cmd.Parameters["member_id"].Value = int.Parse(Txt_MemberFix.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                    //DataTableを生成します。
                    DataTable dataTable = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product", con);
                    adapter.Fill(dataTable);
                    MemberFixGridView.DataSource = dataTable;
                }
            }
        }

        /// <summary>
        /// 会員登録情報の確認
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
                MemberFixGridView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// DataGridViewの幅を調整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FixMenuLoad(object sender, EventArgs e)
        {
            MemberFixGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MemberFixGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
