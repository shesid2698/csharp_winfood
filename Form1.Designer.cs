namespace winFood
{
    partial class Form_order
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_out = new System.Windows.Forms.RadioButton();
            this.rbtn_in = new System.Windows.Forms.RadioButton();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_welcome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_chicken = new System.Windows.Forms.TextBox();
            this.cb_chicken = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_burger = new System.Windows.Forms.TextBox();
            this.cb_burger = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_orange_jui = new System.Windows.Forms.TextBox();
            this.cb_orange_jui = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_treemilk = new System.Windows.Forms.TextBox();
            this.cb_treemilk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_milktea = new System.Windows.Forms.TextBox();
            this.cb_milktea = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_blktea = new System.Windows.Forms.TextBox();
            this.cb_blktea = new System.Windows.Forms.CheckBox();
            this.tbox_total = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.rbtn_out);
            this.groupBox1.Controls.Add(this.rbtn_in);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(15, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "內用\\外帶";
            // 
            // rbtn_out
            // 
            this.rbtn_out.AutoSize = true;
            this.rbtn_out.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtn_out.Location = new System.Drawing.Point(23, 118);
            this.rbtn_out.Name = "rbtn_out";
            this.rbtn_out.Size = new System.Drawing.Size(72, 24);
            this.rbtn_out.TabIndex = 1;
            this.rbtn_out.TabStop = true;
            this.rbtn_out.Text = "外帶";
            this.rbtn_out.UseVisualStyleBackColor = true;
            // 
            // rbtn_in
            // 
            this.rbtn_in.AutoSize = true;
            this.rbtn_in.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rbtn_in.Location = new System.Drawing.Point(23, 52);
            this.rbtn_in.Name = "rbtn_in";
            this.rbtn_in.Size = new System.Drawing.Size(158, 24);
            this.rbtn_in.TabIndex = 0;
            this.rbtn_in.TabStop = true;
            this.rbtn_in.Text = "內用(加10元)";
            this.rbtn_in.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_reset.Location = new System.Drawing.Point(260, 149);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 48);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "取消";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_submit.Location = new System.Drawing.Point(260, 72);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(104, 47);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "結帳";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label_welcome);
            this.groupBox2.Controls.Add(this.btn_reset);
            this.groupBox2.Controls.Add(this.btn_submit);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(21, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 267);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_welcome.Location = new System.Drawing.Point(10, 225);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(169, 30);
            this.label_welcome.TabIndex = 5;
            this.label_welcome.Text = "歡迎光臨!!";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 783);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Tan;
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbox_chicken);
            this.groupBox4.Controls.Add(this.cb_chicken);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbox_burger);
            this.groupBox4.Controls.Add(this.cb_burger);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbox_orange_jui);
            this.groupBox4.Controls.Add(this.cb_orange_jui);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tbox_treemilk);
            this.groupBox4.Controls.Add(this.cb_treemilk);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tbox_milktea);
            this.groupBox4.Controls.Add(this.cb_milktea);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbox_blktea);
            this.groupBox4.Controls.Add(this.cb_blktea);
            this.groupBox4.Font = new System.Drawing.Font("標楷體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(21, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 466);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "菜單";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(314, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "份";
            // 
            // tbox_chicken
            // 
            this.tbox_chicken.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_chicken.Location = new System.Drawing.Point(228, 346);
            this.tbox_chicken.Name = "tbox_chicken";
            this.tbox_chicken.Size = new System.Drawing.Size(80, 31);
            this.tbox_chicken.TabIndex = 16;
            this.tbox_chicken.Text = "0";
            this.tbox_chicken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_chicken.TextChanged += new System.EventHandler(this.tbox_chicken_TextChanged);
            // 
            // cb_chicken
            // 
            this.cb_chicken.AutoSize = true;
            this.cb_chicken.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_chicken.Location = new System.Drawing.Point(29, 347);
            this.cb_chicken.Name = "cb_chicken";
            this.cb_chicken.Size = new System.Drawing.Size(186, 24);
            this.cb_chicken.TabIndex = 15;
            this.cb_chicken.Text = "麥脆雞塊 [120元]";
            this.cb_chicken.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_chicken.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(314, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "份";
            // 
            // tbox_burger
            // 
            this.tbox_burger.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_burger.Location = new System.Drawing.Point(228, 289);
            this.tbox_burger.Name = "tbox_burger";
            this.tbox_burger.Size = new System.Drawing.Size(80, 31);
            this.tbox_burger.TabIndex = 13;
            this.tbox_burger.Text = "0";
            this.tbox_burger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_burger.TextChanged += new System.EventHandler(this.tbox_burger_TextChanged);
            // 
            // cb_burger
            // 
            this.cb_burger.AutoSize = true;
            this.cb_burger.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_burger.Location = new System.Drawing.Point(29, 290);
            this.cb_burger.Name = "cb_burger";
            this.cb_burger.Size = new System.Drawing.Size(186, 24);
            this.cb_burger.TabIndex = 12;
            this.cb_burger.Text = "漢堡A餐  [100元]";
            this.cb_burger.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_burger.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(314, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "杯";
            // 
            // tbox_orange_jui
            // 
            this.tbox_orange_jui.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_orange_jui.Location = new System.Drawing.Point(228, 230);
            this.tbox_orange_jui.Name = "tbox_orange_jui";
            this.tbox_orange_jui.Size = new System.Drawing.Size(80, 31);
            this.tbox_orange_jui.TabIndex = 10;
            this.tbox_orange_jui.Text = "0";
            this.tbox_orange_jui.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_orange_jui.TextChanged += new System.EventHandler(this.tbox_orange_jui_TextChanged);
            // 
            // cb_orange_jui
            // 
            this.cb_orange_jui.AutoSize = true;
            this.cb_orange_jui.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_orange_jui.Location = new System.Drawing.Point(29, 231);
            this.cb_orange_jui.Name = "cb_orange_jui";
            this.cb_orange_jui.Size = new System.Drawing.Size(179, 24);
            this.cb_orange_jui.TabIndex = 9;
            this.cb_orange_jui.Text = "柳橙汁     [40]元";
            this.cb_orange_jui.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_orange_jui.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(314, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "杯";
            // 
            // tbox_treemilk
            // 
            this.tbox_treemilk.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_treemilk.Location = new System.Drawing.Point(228, 174);
            this.tbox_treemilk.Name = "tbox_treemilk";
            this.tbox_treemilk.Size = new System.Drawing.Size(80, 31);
            this.tbox_treemilk.TabIndex = 7;
            this.tbox_treemilk.Text = "0";
            this.tbox_treemilk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_treemilk.TextChanged += new System.EventHandler(this.tbox_treemilk_TextChanged);
            // 
            // cb_treemilk
            // 
            this.cb_treemilk.AutoSize = true;
            this.cb_treemilk.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_treemilk.Location = new System.Drawing.Point(29, 175);
            this.cb_treemilk.Name = "cb_treemilk";
            this.cb_treemilk.Size = new System.Drawing.Size(176, 24);
            this.cb_treemilk.TabIndex = 6;
            this.cb_treemilk.Text = "木瓜牛奶 [40]元";
            this.cb_treemilk.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_treemilk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(314, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "杯";
            // 
            // tbox_milktea
            // 
            this.tbox_milktea.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_milktea.Location = new System.Drawing.Point(228, 121);
            this.tbox_milktea.Name = "tbox_milktea";
            this.tbox_milktea.Size = new System.Drawing.Size(80, 31);
            this.tbox_milktea.TabIndex = 4;
            this.tbox_milktea.Text = "0";
            this.tbox_milktea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_milktea.TextChanged += new System.EventHandler(this.tbox_milktea_TextChanged);
            // 
            // cb_milktea
            // 
            this.cb_milktea.AutoSize = true;
            this.cb_milktea.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_milktea.Location = new System.Drawing.Point(29, 122);
            this.cb_milktea.Name = "cb_milktea";
            this.cb_milktea.Size = new System.Drawing.Size(176, 24);
            this.cb_milktea.TabIndex = 3;
            this.cb_milktea.Text = "珍珠奶茶 [35]元";
            this.cb_milktea.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_milktea.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(314, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "杯";
            // 
            // tbox_blktea
            // 
            this.tbox_blktea.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_blktea.Location = new System.Drawing.Point(228, 69);
            this.tbox_blktea.Name = "tbox_blktea";
            this.tbox_blktea.Size = new System.Drawing.Size(80, 31);
            this.tbox_blktea.TabIndex = 1;
            this.tbox_blktea.Text = "0";
            this.tbox_blktea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_blktea.TextChanged += new System.EventHandler(this.tbox_blktea_TextChanged);
            // 
            // cb_blktea
            // 
            this.cb_blktea.AutoSize = true;
            this.cb_blktea.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_blktea.Location = new System.Drawing.Point(29, 70);
            this.cb_blktea.Name = "cb_blktea";
            this.cb_blktea.Size = new System.Drawing.Size(176, 24);
            this.cb_blktea.TabIndex = 0;
            this.cb_blktea.Text = "泡沫紅茶 [30]元";
            this.cb_blktea.UseVisualStyleBackColor = true;
            // 
            // tbox_total
            // 
            this.tbox_total.BackColor = System.Drawing.Color.Bisque;
            this.tbox_total.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbox_total.Location = new System.Drawing.Point(465, 79);
            this.tbox_total.Multiline = true;
            this.tbox_total.Name = "tbox_total";
            this.tbox_total.ReadOnly = true;
            this.tbox_total.Size = new System.Drawing.Size(442, 697);
            this.tbox_total.TabIndex = 3;
            // 
            // Form_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 808);
            this.Controls.Add(this.tbox_total);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form_order";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_out;
        private System.Windows.Forms.RadioButton rbtn_in;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_blktea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_milktea;
        private System.Windows.Forms.CheckBox cb_milktea;
        private System.Windows.Forms.TextBox tbox_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_chicken;
        private System.Windows.Forms.CheckBox cb_chicken;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_burger;
        private System.Windows.Forms.CheckBox cb_burger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_orange_jui;
        private System.Windows.Forms.CheckBox cb_orange_jui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_treemilk;
        private System.Windows.Forms.CheckBox cb_treemilk;
        public System.Windows.Forms.CheckBox cb_blktea;
    }
}

