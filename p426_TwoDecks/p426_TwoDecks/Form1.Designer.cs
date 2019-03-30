namespace p426_TwoDecks {
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
            this.labelDeck1 = new System.Windows.Forms.Label();
            this.listBoxDeck1 = new System.Windows.Forms.ListBox();
            this.labelDeck2 = new System.Windows.Forms.Label();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.listBoxDeck2 = new System.Windows.Forms.ListBox();
            this.resetDeck1 = new System.Windows.Forms.Button();
            this.resetDeck2 = new System.Windows.Forms.Button();
            this.shuffleDeck1 = new System.Windows.Forms.Button();
            this.shuffleDeck2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeck1
            // 
            this.labelDeck1.AutoSize = true;
            this.labelDeck1.Location = new System.Drawing.Point(11, 9);
            this.labelDeck1.Name = "labelDeck1";
            this.labelDeck1.Size = new System.Drawing.Size(38, 12);
            this.labelDeck1.TabIndex = 0;
            this.labelDeck1.Text = "label1";
            // 
            // listBoxDeck1
            // 
            this.listBoxDeck1.FormattingEnabled = true;
            this.listBoxDeck1.ItemHeight = 12;
            this.listBoxDeck1.Location = new System.Drawing.Point(13, 29);
            this.listBoxDeck1.Name = "listBoxDeck1";
            this.listBoxDeck1.Size = new System.Drawing.Size(139, 292);
            this.listBoxDeck1.TabIndex = 1;
            // 
            // labelDeck2
            // 
            this.labelDeck2.AutoSize = true;
            this.labelDeck2.Location = new System.Drawing.Point(211, 9);
            this.labelDeck2.Name = "labelDeck2";
            this.labelDeck2.Size = new System.Drawing.Size(38, 12);
            this.labelDeck2.TabIndex = 3;
            this.labelDeck2.Text = "label2";
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(158, 132);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(49, 23);
            this.moveToDeck2.TabIndex = 4;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(158, 161);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(49, 23);
            this.moveToDeck1.TabIndex = 5;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // listBoxDeck2
            // 
            this.listBoxDeck2.FormattingEnabled = true;
            this.listBoxDeck2.ItemHeight = 12;
            this.listBoxDeck2.Location = new System.Drawing.Point(213, 29);
            this.listBoxDeck2.Name = "listBoxDeck2";
            this.listBoxDeck2.Size = new System.Drawing.Size(139, 292);
            this.listBoxDeck2.TabIndex = 6;
            // 
            // resetDeck1
            // 
            this.resetDeck1.Location = new System.Drawing.Point(13, 328);
            this.resetDeck1.Name = "resetDeck1";
            this.resetDeck1.Size = new System.Drawing.Size(139, 23);
            this.resetDeck1.TabIndex = 7;
            this.resetDeck1.Text = "Reset Deck #1";
            this.resetDeck1.UseVisualStyleBackColor = true;
            this.resetDeck1.Click += new System.EventHandler(this.resetDeck1_Click);
            // 
            // resetDeck2
            // 
            this.resetDeck2.Location = new System.Drawing.Point(213, 327);
            this.resetDeck2.Name = "resetDeck2";
            this.resetDeck2.Size = new System.Drawing.Size(139, 23);
            this.resetDeck2.TabIndex = 8;
            this.resetDeck2.Text = "Reset Deck #2";
            this.resetDeck2.UseVisualStyleBackColor = true;
            this.resetDeck2.Click += new System.EventHandler(this.resetDeck2_Click);
            // 
            // shuffleDeck1
            // 
            this.shuffleDeck1.Location = new System.Drawing.Point(13, 357);
            this.shuffleDeck1.Name = "shuffleDeck1";
            this.shuffleDeck1.Size = new System.Drawing.Size(139, 23);
            this.shuffleDeck1.TabIndex = 9;
            this.shuffleDeck1.Text = "Shuffle Deck #1";
            this.shuffleDeck1.UseVisualStyleBackColor = true;
            this.shuffleDeck1.Click += new System.EventHandler(this.shuffleDeck1_Click);
            // 
            // shuffleDeck2
            // 
            this.shuffleDeck2.Location = new System.Drawing.Point(213, 357);
            this.shuffleDeck2.Name = "shuffleDeck2";
            this.shuffleDeck2.Size = new System.Drawing.Size(139, 23);
            this.shuffleDeck2.TabIndex = 10;
            this.shuffleDeck2.Text = "Shuffle Deck #2";
            this.shuffleDeck2.UseVisualStyleBackColor = true;
            this.shuffleDeck2.Click += new System.EventHandler(this.shuffleDeck2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 402);
            this.Controls.Add(this.shuffleDeck2);
            this.Controls.Add(this.shuffleDeck1);
            this.Controls.Add(this.resetDeck2);
            this.Controls.Add(this.resetDeck1);
            this.Controls.Add(this.listBoxDeck2);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.labelDeck2);
            this.Controls.Add(this.listBoxDeck1);
            this.Controls.Add(this.labelDeck1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeck1;
        private System.Windows.Forms.ListBox listBoxDeck1;
        private System.Windows.Forms.Label labelDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.ListBox listBoxDeck2;
        private System.Windows.Forms.Button resetDeck1;
        private System.Windows.Forms.Button resetDeck2;
        private System.Windows.Forms.Button shuffleDeck1;
        private System.Windows.Forms.Button shuffleDeck2;
    }
}

