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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2を表示する
            Form2 f2 = new Form2();
            f2.Visible = true;

            //画面を閉じる
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=table.db"))
            {
                //DataTableを生成します
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM HCS_product WHERE member_id =" + textBox1.Text, con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
