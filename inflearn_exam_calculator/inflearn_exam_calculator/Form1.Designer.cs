namespace inflearn_exam_calculator {
    partial class Calculator {
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
            this.numScreen = new System.Windows.Forms.Label();
            this.numButton1 = new System.Windows.Forms.Button();
            this.numButton2 = new System.Windows.Forms.Button();
            this.numButton3 = new System.Windows.Forms.Button();
            this.numButton4 = new System.Windows.Forms.Button();
            this.numButton5 = new System.Windows.Forms.Button();
            this.numButton6 = new System.Windows.Forms.Button();
            this.numButton7 = new System.Windows.Forms.Button();
            this.numButton8 = new System.Windows.Forms.Button();
            this.numButton9 = new System.Windows.Forms.Button();
            this.numButton0 = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.equationButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numScreen
            // 
            this.numScreen.BackColor = System.Drawing.SystemColors.Window;
            this.numScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numScreen.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numScreen.Location = new System.Drawing.Point(13, 13);
            this.numScreen.Name = "numScreen";
            this.numScreen.Size = new System.Drawing.Size(171, 31);
            this.numScreen.TabIndex = 0;
            this.numScreen.Text = "0";
            this.numScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numButton1
            // 
            this.numButton1.Location = new System.Drawing.Point(12, 95);
            this.numButton1.Name = "numButton1";
            this.numButton1.Size = new System.Drawing.Size(36, 38);
            this.numButton1.TabIndex = 1;
            this.numButton1.Text = "1";
            this.numButton1.UseVisualStyleBackColor = true;
            this.numButton1.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton2
            // 
            this.numButton2.Location = new System.Drawing.Point(54, 95);
            this.numButton2.Name = "numButton2";
            this.numButton2.Size = new System.Drawing.Size(36, 38);
            this.numButton2.TabIndex = 2;
            this.numButton2.Text = "2";
            this.numButton2.UseVisualStyleBackColor = true;
            this.numButton2.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton3
            // 
            this.numButton3.Location = new System.Drawing.Point(96, 95);
            this.numButton3.Name = "numButton3";
            this.numButton3.Size = new System.Drawing.Size(36, 38);
            this.numButton3.TabIndex = 3;
            this.numButton3.Text = "3";
            this.numButton3.UseVisualStyleBackColor = true;
            this.numButton3.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton4
            // 
            this.numButton4.Location = new System.Drawing.Point(12, 139);
            this.numButton4.Name = "numButton4";
            this.numButton4.Size = new System.Drawing.Size(36, 38);
            this.numButton4.TabIndex = 4;
            this.numButton4.Text = "4";
            this.numButton4.UseVisualStyleBackColor = true;
            this.numButton4.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton5
            // 
            this.numButton5.Location = new System.Drawing.Point(54, 139);
            this.numButton5.Name = "numButton5";
            this.numButton5.Size = new System.Drawing.Size(36, 38);
            this.numButton5.TabIndex = 5;
            this.numButton5.Text = "5";
            this.numButton5.UseVisualStyleBackColor = true;
            this.numButton5.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton6
            // 
            this.numButton6.Location = new System.Drawing.Point(96, 139);
            this.numButton6.Name = "numButton6";
            this.numButton6.Size = new System.Drawing.Size(36, 38);
            this.numButton6.TabIndex = 6;
            this.numButton6.Text = "6";
            this.numButton6.UseVisualStyleBackColor = true;
            this.numButton6.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton7
            // 
            this.numButton7.Location = new System.Drawing.Point(12, 183);
            this.numButton7.Name = "numButton7";
            this.numButton7.Size = new System.Drawing.Size(36, 38);
            this.numButton7.TabIndex = 7;
            this.numButton7.Text = "7";
            this.numButton7.UseVisualStyleBackColor = true;
            this.numButton7.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton8
            // 
            this.numButton8.Location = new System.Drawing.Point(55, 183);
            this.numButton8.Name = "numButton8";
            this.numButton8.Size = new System.Drawing.Size(36, 38);
            this.numButton8.TabIndex = 8;
            this.numButton8.Text = "8";
            this.numButton8.UseVisualStyleBackColor = true;
            this.numButton8.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton9
            // 
            this.numButton9.Location = new System.Drawing.Point(96, 183);
            this.numButton9.Name = "numButton9";
            this.numButton9.Size = new System.Drawing.Size(36, 38);
            this.numButton9.TabIndex = 9;
            this.numButton9.Text = "9";
            this.numButton9.UseVisualStyleBackColor = true;
            this.numButton9.Click += new System.EventHandler(this.numButton_Click);
            // 
            // numButton0
            // 
            this.numButton0.Location = new System.Drawing.Point(55, 227);
            this.numButton0.Name = "numButton0";
            this.numButton0.Size = new System.Drawing.Size(36, 38);
            this.numButton0.TabIndex = 10;
            this.numButton0.Text = "0";
            this.numButton0.UseVisualStyleBackColor = true;
            this.numButton0.Click += new System.EventHandler(this.numButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(148, 95);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(36, 38);
            this.plusButton.TabIndex = 11;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 38);
            this.button3.TabIndex = 14;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // equationButton
            // 
            this.equationButton.Location = new System.Drawing.Point(13, 271);
            this.equationButton.Name = "equationButton";
            this.equationButton.Size = new System.Drawing.Size(171, 38);
            this.equationButton.TabIndex = 15;
            this.equationButton.Text = "=";
            this.equationButton.UseVisualStyleBackColor = true;
            this.equationButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(13, 315);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(171, 38);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 363);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equationButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.numButton0);
            this.Controls.Add(this.numButton9);
            this.Controls.Add(this.numButton8);
            this.Controls.Add(this.numButton7);
            this.Controls.Add(this.numButton6);
            this.Controls.Add(this.numButton5);
            this.Controls.Add(this.numButton4);
            this.Controls.Add(this.numButton3);
            this.Controls.Add(this.numButton2);
            this.Controls.Add(this.numButton1);
            this.Controls.Add(this.numScreen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numScreen;
        private System.Windows.Forms.Button numButton1;
        private System.Windows.Forms.Button numButton2;
        private System.Windows.Forms.Button numButton3;
        private System.Windows.Forms.Button numButton4;
        private System.Windows.Forms.Button numButton5;
        private System.Windows.Forms.Button numButton6;
        private System.Windows.Forms.Button numButton7;
        private System.Windows.Forms.Button numButton8;
        private System.Windows.Forms.Button numButton9;
        private System.Windows.Forms.Button numButton0;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button equationButton;
        private System.Windows.Forms.Button clearButton;
    }
}

