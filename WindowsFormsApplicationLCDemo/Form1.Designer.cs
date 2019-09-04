namespace WindowsFormsApplicationLCDemo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.apiBoxShow = new System.Windows.Forms.TextBox();
            this.HTGETRealTimeDataAPIbutton = new System.Windows.Forms.Button();
            this.HT_Login_POST_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "post api";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "get api";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "HelloWorld";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.AutoSize = true;
            this.HelloWorldLabel.Location = new System.Drawing.Point(29, 236);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(101, 12);
            this.HelloWorldLabel.TabIndex = 3;
            this.HelloWorldLabel.Text = "请点击HelloWorld";
            this.HelloWorldLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // apiBoxShow
            // 
            this.apiBoxShow.Location = new System.Drawing.Point(188, 57);
            this.apiBoxShow.Multiline = true;
            this.apiBoxShow.Name = "apiBoxShow";
            this.apiBoxShow.Size = new System.Drawing.Size(226, 191);
            this.apiBoxShow.TabIndex = 5;
            // 
            // HTGETRealTimeDataAPIbutton
            // 
            this.HTGETRealTimeDataAPIbutton.Location = new System.Drawing.Point(290, 28);
            this.HTGETRealTimeDataAPIbutton.Name = "HTGETRealTimeDataAPIbutton";
            this.HTGETRealTimeDataAPIbutton.Size = new System.Drawing.Size(133, 23);
            this.HTGETRealTimeDataAPIbutton.TabIndex = 7;
            this.HTGETRealTimeDataAPIbutton.Text = "HT_GET_RealTimeData _API";
            this.HTGETRealTimeDataAPIbutton.UseVisualStyleBackColor = true;
            this.HTGETRealTimeDataAPIbutton.Click += new System.EventHandler(this.HTGETRealTimeDataAPIbutton_Click);
            // 
            // HT_Login_POST_button
            // 
            this.HT_Login_POST_button.Location = new System.Drawing.Point(188, 28);
            this.HT_Login_POST_button.Name = "HT_Login_POST_button";
            this.HT_Login_POST_button.Size = new System.Drawing.Size(96, 23);
            this.HT_Login_POST_button.TabIndex = 8;
            this.HT_Login_POST_button.Text = "HT_Login_POST";
            this.HT_Login_POST_button.UseVisualStyleBackColor = true;
            this.HT_Login_POST_button.Click += new System.EventHandler(this.HT_Login_POST_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 458);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "发送邮件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "send to(邮箱格式):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "标题:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "内容:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(98, 414);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 67);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 351);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 21);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(290, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 21);
            this.textBox4.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 500);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.HT_Login_POST_button);
            this.Controls.Add(this.HTGETRealTimeDataAPIbutton);
            this.Controls.Add(this.apiBoxShow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HelloWorldLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "LCTest窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label HelloWorldLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox apiBoxShow;
        private System.Windows.Forms.Button HTGETRealTimeDataAPIbutton;
        private System.Windows.Forms.Button HT_Login_POST_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

