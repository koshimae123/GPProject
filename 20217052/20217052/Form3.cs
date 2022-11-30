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
    public partial class Form3 : Form
    {
        public Form3()
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO HCS_product (name, address, phone_number) VALUES (@name, @address, @phone_number)";
                    //パラメータセット
                    cmd.Parameters.Add("name", System.Data.DbType.String);
                    cmd.Parameters.Add("address", System.Data.DbType.String);
                    cmd.Parameters.Add("phone_number", System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["name"].Value = textBox1.Text;
                    cmd.Parameters["address"].Value = textBox2.Text;
                    cmd.Parameters["phone_number"].Value = int.Parse(textBox3.Text);
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
    }
}
