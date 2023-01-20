
namespace _20217052
{
    partial class SubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Return = new System.Windows.Forms.Button();
            this.Registration = new System.Windows.Forms.Button();
            this.MemberSearch = new System.Windows.Forms.Button();
            this.MemberFix = new System.Windows.Forms.Button();
            this.MemberDelete = new System.Windows.Forms.Button();
            this.MakeTable = new System.Windows.Forms.Button();
            this.DeleteBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(629, 319);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(149, 66);
            this.Return.TabIndex = 0;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnClick);
            // 
            // Registration
            // 
            this.Registration.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Registration.Location = new System.Drawing.Point(188, 175);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(181, 79);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "会員登録";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.RegistrationClick);
            // 
            // MemberSearch
            // 
            this.MemberSearch.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberSearch.Location = new System.Drawing.Point(188, 306);
            this.MemberSearch.Name = "MemberSearch";
            this.MemberSearch.Size = new System.Drawing.Size(181, 79);
            this.MemberSearch.TabIndex = 2;
            this.MemberSearch.Text = "会員検索";
            this.MemberSearch.UseVisualStyleBackColor = true;
            this.MemberSearch.Click += new System.EventHandler(this.MemberSearchClick);
            // 
            // MemberFix
            // 
            this.MemberFix.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberFix.Location = new System.Drawing.Point(406, 175);
            this.MemberFix.Name = "MemberFix";
            this.MemberFix.Size = new System.Drawing.Size(181, 79);
            this.MemberFix.TabIndex = 3;
            this.MemberFix.Text = "会員修正";
            this.MemberFix.UseVisualStyleBackColor = true;
            this.MemberFix.Click += new System.EventHandler(this.MemberFixClick);
            // 
            // MemberDelete
            // 
            this.MemberDelete.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberDelete.Location = new System.Drawing.Point(406, 306);
            this.MemberDelete.Name = "MemberDelete";
            this.MemberDelete.Size = new System.Drawing.Size(181, 79);
            this.MemberDelete.TabIndex = 4;
            this.MemberDelete.Text = "会員削除";
            this.MemberDelete.UseVisualStyleBackColor = true;
            this.MemberDelete.Click += new System.EventHandler(this.MemberDeleteClick);
            // 
            // MakeTable
            // 
            this.MakeTable.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MakeTable.Location = new System.Drawing.Point(188, 49);
            this.MakeTable.Name = "MakeTable";
            this.MakeTable.Size = new System.Drawing.Size(181, 79);
            this.MakeTable.TabIndex = 5;
            this.MakeTable.Text = "テーブル作成";
            this.MakeTable.UseVisualStyleBackColor = true;
            this.MakeTable.Click += new System.EventHandler(this.MakeTableClick);
            // 
            // DeleteBotton
            // 
            this.DeleteBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteBotton.Location = new System.Drawing.Point(406, 49);
            this.DeleteBotton.Name = "DeleteBotton";
            this.DeleteBotton.Size = new System.Drawing.Size(181, 79);
            this.DeleteBotton.TabIndex = 6;
            this.DeleteBotton.Text = "テーブル削除";
            this.DeleteBotton.UseVisualStyleBackColor = true;
            this.DeleteBotton.Click += new System.EventHandler(this.DeleteBottonClick);
            // 
            // SubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBotton);
            this.Controls.Add(this.MakeTable);
            this.Controls.Add(this.MemberDelete);
            this.Controls.Add(this.MemberFix);
            this.Controls.Add(this.MemberSearch);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Return);
            this.Name = "SubMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button MemberSearch;
        private System.Windows.Forms.Button MemberFix;
        private System.Windows.Forms.Button MemberDelete;
        private System.Windows.Forms.Button MakeTable;
        private System.Windows.Forms.Button DeleteBotton;
    }
}