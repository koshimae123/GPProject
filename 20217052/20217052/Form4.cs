using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace _20217052
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2を表示
            Form2 f2 = new Form2();
            f2.Visible = true;
            
            //画面を閉じる
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "UPDATE HCS_product set name = @name, address = @add, phone_number = @phone WHERE member_id = @member_id";
                    //パラメータセット
                    cmd.Parameters.Add("name", System.Data.DbType.String);
                    cmd.Parameters.Add("add", System.Data.DbType.String);
                    cmd.Parameters.Add("phone", System.Data.DbType.Int64);
                    cmd.Parameters.Add("member_id", System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["name"].Value = textBox2.Text;
                    cmd.Parameters["add"].Value = textBox3.Text;
                    cmd.Parameters["phone"].Value = int.Parse(textBox4.Text);
                    cmd.Parameters["member_id"].Value = int.Parse(textBox1.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                    //DataTableを生成します。
                    var dataTable = new DataTable();
                    //SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product", con);
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                //DataTableを生成します。
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
