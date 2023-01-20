
namespace _20217052
{
    partial class RegisterMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Txt_Tel = new System.Windows.Forms.TextBox();
            this.RegisterBotton = new System.Windows.Forms.Button();
            this.MemberRegisterGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MemberRegisterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(631, 360);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(129, 66);
            this.Return.TabIndex = 1;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(198, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "住所";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(333, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話番号";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(64, 53);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(113, 22);
            this.Txt_Name.TabIndex = 5;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(202, 53);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(113, 22);
            this.Txt_Address.TabIndex = 6;
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Location = new System.Drawing.Point(337, 53);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(113, 22);
            this.Txt_Tel.TabIndex = 7;
            // 
            // RegisterBotton
            // 
            this.RegisterBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegisterBotton.Location = new System.Drawing.Point(631, 244);
            this.RegisterBotton.Name = "RegisterBotton";
            this.RegisterBotton.Size = new System.Drawing.Size(129, 66);
            this.RegisterBotton.TabIndex = 8;
            this.RegisterBotton.Text = "登録";
            this.RegisterBotton.UseVisualStyleBackColor = true;
            this.RegisterBotton.Click += new System.EventHandler(this.RegisterBottonClick);
            // 
            // MemberRegisterGridView
            // 
            this.MemberRegisterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberRegisterGridView.Location = new System.Drawing.Point(64, 100);
            this.MemberRegisterGridView.Name = "MemberRegisterGridView";
            this.MemberRegisterGridView.RowHeadersWidth = 51;
            this.MemberRegisterGridView.RowTemplate.Height = 24;
            this.MemberRegisterGridView.Size = new System.Drawing.Size(540, 326);
            this.MemberRegisterGridView.TabIndex = 9;
            // 
            // RegisterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MemberRegisterGridView);
            this.Controls.Add(this.RegisterBotton);
            this.Controls.Add(this.Txt_Tel);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Name = "RegisterMenu";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.MemberRegisterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.TextBox Txt_Tel;
        private System.Windows.Forms.Button RegisterBotton;
        private System.Windows.Forms.DataGridView MemberRegisterGridView;
    }
}