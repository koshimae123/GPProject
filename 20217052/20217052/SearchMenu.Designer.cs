
namespace _20217052
{
    partial class SearchMenu
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
            this.MemberSearchGridView = new System.Windows.Forms.DataGridView();
            this.Txt_SearchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberSearchGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(608, 336);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(129, 66);
            this.Return.TabIndex = 0;
            this.Return.Text = "戻る";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnClick);
            // 
            // MemberSearchGridView
            // 
            this.MemberSearchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberSearchGridView.Location = new System.Drawing.Point(74, 146);
            this.MemberSearchGridView.Name = "MemberSearchGridView";
            this.MemberSearchGridView.RowHeadersWidth = 51;
            this.MemberSearchGridView.RowTemplate.Height = 24;
            this.MemberSearchGridView.Size = new System.Drawing.Size(504, 255);
            this.MemberSearchGridView.TabIndex = 1;
            // 
            // Txt_SearchID
            // 
            this.Txt_SearchID.Location = new System.Drawing.Point(383, 57);
            this.Txt_SearchID.Name = "Txt_SearchID";
            this.Txt_SearchID.Size = new System.Drawing.Size(207, 22);
            this.Txt_SearchID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(70, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "検索したいIDを入力してください";
            // 
            // SearchBotton
            // 
            this.SearchBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SearchBotton.Location = new System.Drawing.Point(608, 244);
            this.SearchBotton.Name = "SearchBotton";
            this.SearchBotton.Size = new System.Drawing.Size(129, 66);
            this.SearchBotton.TabIndex = 4;
            this.SearchBotton.Text = "検索";
            this.SearchBotton.UseVisualStyleBackColor = true;
            this.SearchBotton.Click += new System.EventHandler(this.SearchBottonClick);
            // 
            // SearchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBotton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_SearchID);
            this.Controls.Add(this.MemberSearchGridView);
            this.Controls.Add(this.Return);
            this.Name = "SearchMenu";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.SearchMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemberSearchGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.DataGridView MemberSearchGridView;
        private System.Windows.Forms.TextBox Txt_SearchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBotton;
    }
}