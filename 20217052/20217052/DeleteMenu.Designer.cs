
namespace _20217052
{
    partial class DeleteMenu
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
            this.Txt_DeleteID = new System.Windows.Forms.TextBox();
            this.MemberDeleteGridView = new System.Windows.Forms.DataGridView();
            this.DeleteBotton = new System.Windows.Forms.Button();
            this.CheckBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberDeleteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Return.Location = new System.Drawing.Point(635, 346);
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
            this.label1.Location = new System.Drawing.Point(120, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "削除したいIDを入力してください";
            // 
            // Txt_DeleteID
            // 
            this.Txt_DeleteID.Location = new System.Drawing.Point(441, 74);
            this.Txt_DeleteID.Name = "Txt_DeleteID";
            this.Txt_DeleteID.Size = new System.Drawing.Size(166, 22);
            this.Txt_DeleteID.TabIndex = 2;
            // 
            // MemberDeleteGridView
            // 
            this.MemberDeleteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberDeleteGridView.Location = new System.Drawing.Point(60, 146);
            this.MemberDeleteGridView.Name = "MemberDeleteGridView";
            this.MemberDeleteGridView.RowHeadersWidth = 51;
            this.MemberDeleteGridView.RowTemplate.Height = 24;
            this.MemberDeleteGridView.Size = new System.Drawing.Size(547, 273);
            this.MemberDeleteGridView.TabIndex = 3;
            // 
            // DeleteBotton
            // 
            this.DeleteBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DeleteBotton.Location = new System.Drawing.Point(635, 251);
            this.DeleteBotton.Name = "DeleteBotton";
            this.DeleteBotton.Size = new System.Drawing.Size(129, 66);
            this.DeleteBotton.TabIndex = 4;
            this.DeleteBotton.Text = "削除";
            this.DeleteBotton.UseVisualStyleBackColor = true;
            this.DeleteBotton.Click += new System.EventHandler(this.DeleteBottonClick);
            // 
            // CheckBotton
            // 
            this.CheckBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CheckBotton.Location = new System.Drawing.Point(635, 146);
            this.CheckBotton.Name = "CheckBotton";
            this.CheckBotton.Size = new System.Drawing.Size(129, 66);
            this.CheckBotton.TabIndex = 5;
            this.CheckBotton.Text = "確認";
            this.CheckBotton.UseVisualStyleBackColor = true;
            this.CheckBotton.Click += new System.EventHandler(this.CheckBottonClick);
            // 
            // DeleteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBotton);
            this.Controls.Add(this.DeleteBotton);
            this.Controls.Add(this.MemberDeleteGridView);
            this.Controls.Add(this.Txt_DeleteID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Name = "DeleteMenu";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.DeleteMenuLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MemberDeleteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_DeleteID;
        private System.Windows.Forms.DataGridView MemberDeleteGridView;
        private System.Windows.Forms.Button DeleteBotton;
        private System.Windows.Forms.Button CheckBotton;
    }
}