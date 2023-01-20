using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _20217052
{
    public partial class RegisterMenu : Form
    {
        public RegisterMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 会員登録画面に遷移
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
        /// 会員登録を実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterBottonClick(object sender, EventArgs e)
        {
            MemberRegisterGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO HCS_product (name, address, phone_number) VALUES (@name, @address, @phone_number)";
                    //パラメータセット
                    cmd.Parameters.Add("name", DbType.String);
                    cmd.Parameters.Add("address", DbType.String);
                    cmd.Parameters.Add("phone_number", DbType.Int64);
                    //データ追加
                    cmd.Parameters["name"].Value = Txt_Name.Text;
                    cmd.Parameters["address"].Value = Txt_Address.Text;
                    cmd.Parameters["phone_number"].Value = int.Parse(Txt_Tel.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                    //DataTableを生成します。
                    DataTable dataTable = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product", con);
                    adapter.Fill(dataTable);
                    MemberRegisterGridView.DataSource = dataTable;
                }
            }
        }
    }
}
