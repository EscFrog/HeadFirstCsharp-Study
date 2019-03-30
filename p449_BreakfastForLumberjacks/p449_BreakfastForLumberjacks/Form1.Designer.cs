namespace p449_BreakfastForLumberjacks {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.button_addLumberjack = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.listBox_line = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.banana = new System.Windows.Forms.RadioButton();
            this.button_addFlapjacks = new System.Windows.Forms.Button();
            this.button_nextLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nextInLine = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lunberjack name :";
            // 
            // button_addLumberjack
            // 
            this.button_addLumberjack.Location = new System.Drawing.Point(16, 37);
            this.button_addLumberjack.Name = "button_addLumberjack";
            this.button_addLumberjack.Size = new System.Drawing.Size(306, 23);
            this.button_addLumberjack.TabIndex = 1;
            this.button_addLumberjack.Text = "Add lunberjack";
            this.button_addLumberjack.UseVisualStyleBackColor = true;
            this.button_addLumberjack.Click += new System.EventHandler(this.button_addLumberjack_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(143, 10);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(179, 21);
            this.textBox_name.TabIndex = 2;
            // 
            // listBox_line
            // 
            this.listBox_line.FormattingEnabled = true;
            this.listBox_line.ItemHeight = 12;
            this.listBox_line.Location = new System.Drawing.Point(16, 91);
            this.listBox_line.Name = "listBox_line";
            this.listBox_line.Size = new System.Drawing.Size(120, 268);
            this.listBox_line.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.button_addFlapjacks);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(143, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 254);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 21);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(72, 21);
            this.howMany.TabIndex = 0;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(7, 49);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(60, 16);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(7, 71);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(59, 16);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(7, 93);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(73, 16);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(7, 115);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(66, 16);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // button_addFlapjacks
            // 
            this.button_addFlapjacks.Location = new System.Drawing.Point(7, 138);
            this.button_addFlapjacks.Name = "button_addFlapjacks";
            this.button_addFlapjacks.Size = new System.Drawing.Size(166, 23);
            this.button_addFlapjacks.TabIndex = 5;
            this.button_addFlapjacks.Text = "Add flapjacks";
            this.button_addFlapjacks.UseVisualStyleBackColor = true;
            this.button_addFlapjacks.Click += new System.EventHandler(this.button_addFlapjacks_Click);
            // 
            // button_nextLumberjack
            // 
            this.button_nextLumberjack.Location = new System.Drawing.Point(143, 336);
            this.button_nextLumberjack.Name = "button_nextLumberjack";
            this.button_nextLumberjack.Size = new System.Drawing.Size(179, 23);
            this.button_nextLumberjack.TabIndex = 5;
            this.button_nextLumberjack.Text = "Next lunberjack";
            this.button_nextLumberjack.UseVisualStyleBackColor = true;
            this.button_nextLumberjack.Click += new System.EventHandler(this.button_nextLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Breakfast line";
            // 
            // nextInLine
            // 
            this.nextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextInLine.Location = new System.Drawing.Point(6, 164);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(167, 77);
            this.nextInLine.TabIndex = 7;
            this.nextInLine.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_nextLumberjack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_line);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_addLumberjack);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addLumberjack;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ListBox listBox_line;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_addFlapjacks;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.Button button_nextLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nextInLine;
    }
}

