
namespace _20217052
{
    partial class MainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MemberRegistration = new System.Windows.Forms.Button();
            this.EndBotton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MemberRegistration
            // 
            this.MemberRegistration.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MemberRegistration.Location = new System.Drawing.Point(162, 192);
            this.MemberRegistration.Name = "MemberRegistration";
            this.MemberRegistration.Size = new System.Drawing.Size(182, 84);
            this.MemberRegistration.TabIndex = 0;
            this.MemberRegistration.Text = "会員登録管理";
            this.MemberRegistration.UseVisualStyleBackColor = true;
            this.MemberRegistration.Click += new System.EventHandler(this.MemberRegistrationClick);
            // 
            // EndBotton
            // 
            this.EndBotton.Font = new System.Drawing.Font("UD デジタル 教科書体 N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndBotton.Location = new System.Drawing.Point(457, 192);
            this.EndBotton.Name = "EndBotton";
            this.EndBotton.Size = new System.Drawing.Size(182, 84);
            this.EndBotton.TabIndex = 1;
            this.EndBotton.Text = "終了";
            this.EndBotton.UseVisualStyleBackColor = true;
            this.EndBotton.Click += new System.EventHandler(this.EndBottonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "HCSスポーツクラブ会員登録システム";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndBotton);
            this.Controls.Add(this.MemberRegistration);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MemberRegistration;
        private System.Windows.Forms.Button EndBotton;
        private System.Windows.Forms.Label label1;
    }
}

