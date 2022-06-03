namespace 悬浮窗口1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_distance_time = new System.Windows.Forms.Label();
            this.lab_Word = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lab_time
            // 
            this.lab_time.Font = new System.Drawing.Font("华文行楷", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_time.ForeColor = System.Drawing.Color.DarkOrange;
            this.lab_time.Location = new System.Drawing.Point(188, 9);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(965, 66);
            this.lab_time.TabIndex = 0;
            this.lab_time.Text = "现在时间";
            // 
            // lab_distance_time
            // 
            this.lab_distance_time.Font = new System.Drawing.Font("华文行楷", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_distance_time.ForeColor = System.Drawing.Color.Red;
            this.lab_distance_time.Location = new System.Drawing.Point(188, 92);
            this.lab_distance_time.Name = "lab_distance_time";
            this.lab_distance_time.Size = new System.Drawing.Size(965, 59);
            this.lab_distance_time.TabIndex = 1;
            this.lab_distance_time.Text = "距离高考：";
            // 
            // lab_Word
            // 
            this.lab_Word.Font = new System.Drawing.Font("华文行楷", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Word.Location = new System.Drawing.Point(12, 191);
            this.lab_Word.Name = "lab_Word";
            this.lab_Word.Size = new System.Drawing.Size(1403, 87);
            this.lab_Word.TabIndex = 2;
            this.lab_Word.Text = "于高山之巅，方见大河奔涌；于群峰之上，更觉长风浩荡。";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("华文行楷", 39F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1370, 93);
            this.label1.TabIndex = 3;
            this.label1.Text = "看什么呢？还不去卷！严恒润都卷疯了！！！";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_Word);
            this.Controls.Add(this.lab_distance_time);
            this.Controls.Add(this.lab_time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_time;
        private System.Windows.Forms.Label lab_distance_time;
        private System.Windows.Forms.Label lab_Word;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

