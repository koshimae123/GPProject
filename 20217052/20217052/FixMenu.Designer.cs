
namespace _20217052
{
    partial class FixMenu
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
            this.Txt_MemberFix = new System.Windows.Forms.TextBox();
            this.MemberFixGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Tel = new System.Windows.Forms.TextBox();
            this.FixBotton = new System.Windows.Forms.Button();
            this.CheckBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberFixGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(643, 361);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(129, 66);
            this.Return.TabIndex = 0;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(89, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "修正する会員番号を入力して下さい";
            // 
            // Txt_MemberFix
            // 
            this.Txt_MemberFix.Location = new System.Drawing.Point(422, 42);
            this.Txt_MemberFix.Name = "Txt_MemberFix";
            this.Txt_MemberFix.Size = new System.Drawing.Size(132, 22);
            this.Txt_MemberFix.TabIndex = 2;
            // 
            // MemberFixGridView
            // 
            this.MemberFixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberFixGridView.Location = new System.Drawing.Point(78, 154);
            this.MemberFixGridView.Name = "MemberFixGridView";
            this.MemberFixGridView.RowHeadersWidth = 51;
            this.MemberFixGridView.RowTemplate.Height = 24;
            this.MemberFixGridView.Size = new System.Drawing.Size(547, 273);
            this.MemberFixGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(74, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "氏名";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(78, 114);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(132, 22);
            this.Txt_Name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(267, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "住所";
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(271, 114);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.Size = new System.Drawing.Size(132, 22);
            this.Txt_Address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(460, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "電話番号";
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Location = new System.Drawing.Point(464, 116);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(132, 22);
            this.Txt_Tel.TabIndex = 9;
            // 
            // FixBotton
            // 
            this.FixBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FixBotton.Location = new System.Drawing.Point(643, 258);
            this.FixBotton.Name = "FixBotton";
            this.FixBotton.Size = new System.Drawing.Size(129, 66);
            this.FixBotton.TabIndex = 10;
            this.FixBotton.Text = "修正";
            this.FixBotton.UseVisualStyleBackColor = true;
            this.FixBotton.Click += new System.EventHandler(this.FixBottonClick);
            // 
            // CheckBotton
            // 
            this.CheckBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CheckBotton.Location = new System.Drawing.Point(643, 154);
            this.CheckBotton.Name = "CheckBotton";
            this.CheckBotton.Size = new System.Drawing.Size(129, 66);
            this.CheckBotton.TabIndex = 11;
            this.CheckBotton.Text = "確認";
            this.CheckBotton.UseVisualStyleBackColor = true;
            this.CheckBotton.Click += new System.EventHandler(this.CheckBottonClick);
            // 
            // FixMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBotton);
            this.Controls.Add(this.FixBotton);
            this.Controls.Add(this.Txt_Tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MemberFixGridView);
            this.Controls.Add(this.Txt_MemberFix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Name = "FixMenu";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FixMenuLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MemberFixGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_MemberFix;
        private System.Windows.Forms.DataGridView MemberFixGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Tel;
        private System.Windows.Forms.Button FixBotton;
        private System.Windows.Forms.Button CheckBotton;
    }
}