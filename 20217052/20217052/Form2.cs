﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1を表示
            Form1 f1 = new Form1();
            f1.Visible = true;

            //画面を閉じる
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //次画面を非表示
            this.Visible = false;

            //Form3を表示
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル作成して閉じる
            using (var con = new SQLiteConnection("Data Source=table.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table t_product(CD INTEGER PRIMARY KEY AUTOINCREMENT, productname TEXT, price INTEGER)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
