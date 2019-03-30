namespace p419_CardShuffle_ver2 {
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
            this.cardAmount = new System.Windows.Forms.NumericUpDown();
            this.pickButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.pickResult = new System.Windows.Forms.TextBox();
            this.suffleResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "몇 장 뽑을까요?";
            // 
            // cardAmount
            // 
            this.cardAmount.Location = new System.Drawing.Point(110, 18);
            this.cardAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cardAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cardAmount.Name = "cardAmount";
            this.cardAmount.Size = new System.Drawing.Size(54, 21);
            this.cardAmount.TabIndex = 1;
            this.cardAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pickButton
            // 
            this.pickButton.Location = new System.Drawing.Point(16, 57);
            this.pickButton.Name = "pickButton";
            this.pickButton.Size = new System.Drawing.Size(148, 23);
            this.pickButton.TabIndex = 2;
            this.pickButton.Text = "Pick Cards!!";
            this.pickButton.UseVisualStyleBackColor = true;
            this.pickButton.Click += new System.EventHandler(this.pickButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(181, 57);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(148, 23);
            this.shuffleButton.TabIndex = 3;
            this.shuffleButton.Text = "Shuffle!!";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // pickResult
            // 
            this.pickResult.Location = new System.Drawing.Point(16, 86);
            this.pickResult.Multiline = true;
            this.pickResult.Name = "pickResult";
            this.pickResult.Size = new System.Drawing.Size(148, 206);
            this.pickResult.TabIndex = 4;
            // 
            // suffleResult
            // 
            this.suffleResult.Location = new System.Drawing.Point(181, 86);
            this.suffleResult.Multiline = true;
            this.suffleResult.Name = "suffleResult";
            this.suffleResult.Size = new System.Drawing.Size(148, 206);
            this.suffleResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 308);
            this.Controls.Add(this.suffleResult);
            this.Controls.Add(this.pickResult);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.pickButton);
            this.Controls.Add(this.cardAmount);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pick and Shuffle";
            ((System.ComponentModel.ISupportInitialize)(this.cardAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown cardAmount;
        private System.Windows.Forms.Button pickButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.TextBox pickResult;
        private System.Windows.Forms.TextBox suffleResult;
    }
}

