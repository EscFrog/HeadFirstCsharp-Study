namespace P207_Chapter4_ElephantSwap {
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
            this.button_Lloyd = new System.Windows.Forms.Button();
            this.button_Lucinda = new System.Windows.Forms.Button();
            this.button_Swap = new System.Windows.Forms.Button();
            this.button_island = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Lloyd
            // 
            this.button_Lloyd.Location = new System.Drawing.Point(13, 13);
            this.button_Lloyd.Name = "button_Lloyd";
            this.button_Lloyd.Size = new System.Drawing.Size(75, 23);
            this.button_Lloyd.TabIndex = 0;
            this.button_Lloyd.Text = "Lloyd";
            this.button_Lloyd.UseVisualStyleBackColor = true;
            this.button_Lloyd.Click += new System.EventHandler(this.button_Lloyd_Click);
            // 
            // button_Lucinda
            // 
            this.button_Lucinda.Location = new System.Drawing.Point(13, 43);
            this.button_Lucinda.Name = "button_Lucinda";
            this.button_Lucinda.Size = new System.Drawing.Size(75, 23);
            this.button_Lucinda.TabIndex = 1;
            this.button_Lucinda.Text = "Lucinda";
            this.button_Lucinda.UseVisualStyleBackColor = true;
            this.button_Lucinda.Click += new System.EventHandler(this.button_Lucinda_Click);
            // 
            // button_Swap
            // 
            this.button_Swap.Location = new System.Drawing.Point(13, 73);
            this.button_Swap.Name = "button_Swap";
            this.button_Swap.Size = new System.Drawing.Size(75, 23);
            this.button_Swap.TabIndex = 2;
            this.button_Swap.Text = "Swap!";
            this.button_Swap.UseVisualStyleBackColor = true;
            this.button_Swap.Click += new System.EventHandler(this.button_Swap_Click);
            // 
            // button_island
            // 
            this.button_island.Location = new System.Drawing.Point(13, 113);
            this.button_island.Name = "button_island";
            this.button_island.Size = new System.Drawing.Size(75, 23);
            this.button_island.TabIndex = 3;
            this.button_island.Text = "island";
            this.button_island.UseVisualStyleBackColor = true;
            this.button_island.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 165);
            this.Controls.Add(this.button_island);
            this.Controls.Add(this.button_Swap);
            this.Controls.Add(this.button_Lucinda);
            this.Controls.Add(this.button_Lloyd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Lloyd;
        private System.Windows.Forms.Button button_Lucinda;
        private System.Windows.Forms.Button button_Swap;
        private System.Windows.Forms.Button button_island;
    }
}

