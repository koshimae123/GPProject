using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _20217052
{
    public partial class SearchMenu : Form
    {
        public SearchMenu()
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
            //会員登録管理画面を表示する
            SubMenu subMenu = new SubMenu();
            subMenu.Visible = true;

            //画面を閉じる
            this.Close();
        }

        /// <summary>
        /// 会員登録情報を検索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBottonClick(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                //DataTableを生成します
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product WHERE member_id =" + Txt_SearchID.Text, con);
                adapter.Fill(dataTable);
                MemberSearchGridView.DataSource = dataTable;
            }
        }

        /// <summary>
        /// DataGridviewの幅を調整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchMenu_Load(object sender, EventArgs e)
        {
            //DataGridviewの幅を調整
            MemberSearchGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            MemberSearchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
