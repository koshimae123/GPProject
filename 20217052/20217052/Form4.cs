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
                    cmd.CommandText = "UPDATE FROM HCS_product set name = @name, address = @address, phone_number = phone_number WHERE member_id = @member_id";
                    //パラメータセット
                    cmd.Parameters.Add("name", System.Data.DbType.String);
                    cmd.Parameters.Add("address", System.Data.DbType.String);
                    cmd.Parameters.Add("phone_number", System.Data.DbType.Int64);
                    cmd.Parameters.Add("member_id", System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["name"].Value = textBox1.Text;
                    cmd.Parameters["address"].Value = textBox2.Text;
                    cmd.Parameters["phone_number"].Value = int.Parse(textBox3.Text);
                    cmd.Parameters["member_id"].Value = int.Parse(textBox4.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }
    }
}
