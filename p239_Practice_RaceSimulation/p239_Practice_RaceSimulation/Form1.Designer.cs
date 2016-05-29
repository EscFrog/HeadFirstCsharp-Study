namespace p239_Practice_RaceSimulation {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_dog1 = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.pictureBox_dog2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dog3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_dog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_dogNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.button_race = new System.Windows.Forms.Button();
            this.player3RadioButton = new System.Windows.Forms.RadioButton();
            this.player2RadioButton = new System.Windows.Forms.RadioButton();
            this.player1RadioButton = new System.Windows.Forms.RadioButton();
            this.button_bet = new System.Windows.Forms.Button();
            this.checkedNameLabel = new System.Windows.Forms.Label();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.betsLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_dog1
            // 
            this.pictureBox_dog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog1.Image")));
            this.pictureBox_dog1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_dog1.Name = "pictureBox_dog1";
            this.pictureBox_dog1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox_dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_dog1.TabIndex = 0;
            this.pictureBox_dog1.TabStop = false;
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Top;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(601, 200);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // pictureBox_dog2
            // 
            this.pictureBox_dog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog2.Image")));
            this.pictureBox_dog2.Location = new System.Drawing.Point(12, 58);
            this.pictureBox_dog2.Name = "pictureBox_dog2";
            this.pictureBox_dog2.Size = new System.Drawing.Size(75, 20);
            this.pictureBox_dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_dog2.TabIndex = 2;
            this.pictureBox_dog2.TabStop = false;
            // 
            // pictureBox_dog3
            // 
            this.pictureBox_dog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog3.Image")));
            this.pictureBox_dog3.Location = new System.Drawing.Point(12, 112);
            this.pictureBox_dog3.Name = "pictureBox_dog3";
            this.pictureBox_dog3.Size = new System.Drawing.Size(75, 20);
            this.pictureBox_dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_dog3.TabIndex = 3;
            this.pictureBox_dog3.TabStop = false;
            // 
            // pictureBox_dog4
            // 
            this.pictureBox_dog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dog4.Image")));
            this.pictureBox_dog4.Location = new System.Drawing.Point(12, 164);
            this.pictureBox_dog4.Name = "pictureBox_dog4";
            this.pictureBox_dog4.Size = new System.Drawing.Size(75, 20);
            this.pictureBox_dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_dog4.TabIndex = 4;
            this.pictureBox_dog4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown_dogNumber);
            this.groupBox1.Controls.Add(this.numericUpDown_amount);
            this.groupBox1.Controls.Add(this.button_race);
            this.groupBox1.Controls.Add(this.player3RadioButton);
            this.groupBox1.Controls.Add(this.player2RadioButton);
            this.groupBox1.Controls.Add(this.player1RadioButton);
            this.groupBox1.Controls.Add(this.button_bet);
            this.groupBox1.Controls.Add(this.checkedNameLabel);
            this.groupBox1.Controls.Add(this.alBetLabel);
            this.groupBox1.Controls.Add(this.bobBetLabel);
            this.groupBox1.Controls.Add(this.joeBetLabel);
            this.groupBox1.Controls.Add(this.betsLabel);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "bucks on dog number";
            // 
            // numericUpDown_dogNumber
            // 
            this.numericUpDown_dogNumber.Location = new System.Drawing.Point(320, 145);
            this.numericUpDown_dogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_dogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_dogNumber.Name = "numericUpDown_dogNumber";
            this.numericUpDown_dogNumber.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown_dogNumber.TabIndex = 12;
            this.numericUpDown_dogNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_dogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Location = new System.Drawing.Point(136, 145);
            this.numericUpDown_amount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown_amount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown_amount.TabIndex = 11;
            this.numericUpDown_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button_race
            // 
            this.button_race.Location = new System.Drawing.Point(397, 37);
            this.button_race.Name = "button_race";
            this.button_race.Size = new System.Drawing.Size(192, 129);
            this.button_race.TabIndex = 10;
            this.button_race.Text = "Race!";
            this.button_race.UseVisualStyleBackColor = true;
            this.button_race.Click += new System.EventHandler(this.button_race_Click);
            // 
            // player3RadioButton
            // 
            this.player3RadioButton.AutoSize = true;
            this.player3RadioButton.Location = new System.Drawing.Point(10, 105);
            this.player3RadioButton.Name = "player3RadioButton";
            this.player3RadioButton.Size = new System.Drawing.Size(100, 16);
            this.player3RadioButton.TabIndex = 9;
            this.player3RadioButton.Text = "alRadioButton";
            this.player3RadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // player2RadioButton
            // 
            this.player2RadioButton.AutoSize = true;
            this.player2RadioButton.Location = new System.Drawing.Point(10, 73);
            this.player2RadioButton.Name = "player2RadioButton";
            this.player2RadioButton.Size = new System.Drawing.Size(111, 16);
            this.player2RadioButton.TabIndex = 8;
            this.player2RadioButton.Text = "bobRadioButton";
            this.player2RadioButton.UseVisualStyleBackColor = true;
            this.player2RadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // player1RadioButton
            // 
            this.player1RadioButton.AutoSize = true;
            this.player1RadioButton.Checked = true;
            this.player1RadioButton.Location = new System.Drawing.Point(10, 40);
            this.player1RadioButton.Name = "player1RadioButton";
            this.player1RadioButton.Size = new System.Drawing.Size(107, 16);
            this.player1RadioButton.TabIndex = 7;
            this.player1RadioButton.TabStop = true;
            this.player1RadioButton.Text = "joeRadioButton";
            this.player1RadioButton.UseVisualStyleBackColor = true;
            this.player1RadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // button_bet
            // 
            this.button_bet.Location = new System.Drawing.Point(55, 144);
            this.button_bet.Name = "button_bet";
            this.button_bet.Size = new System.Drawing.Size(75, 23);
            this.button_bet.TabIndex = 6;
            this.button_bet.Text = "Bets";
            this.button_bet.UseVisualStyleBackColor = true;
            this.button_bet.Click += new System.EventHandler(this.button_bet_Click);
            // 
            // checkedNameLabel
            // 
            this.checkedNameLabel.AutoSize = true;
            this.checkedNameLabel.Location = new System.Drawing.Point(12, 149);
            this.checkedNameLabel.Name = "checkedNameLabel";
            this.checkedNameLabel.Size = new System.Drawing.Size(37, 12);
            this.checkedNameLabel.TabIndex = 5;
            this.checkedNameLabel.Text = "name";
            this.checkedNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alBetLabel
            // 
            this.alBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alBetLabel.Location = new System.Drawing.Point(156, 102);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(210, 23);
            this.alBetLabel.TabIndex = 4;
            this.alBetLabel.Text = "alBetLabel";
            this.alBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(156, 70);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(210, 23);
            this.bobBetLabel.TabIndex = 3;
            this.bobBetLabel.Text = "bobBetLabel";
            this.bobBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(156, 37);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(210, 23);
            this.joeBetLabel.TabIndex = 2;
            this.joeBetLabel.Text = "joeBetLabel";
            this.joeBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // betsLabel
            // 
            this.betsLabel.AutoSize = true;
            this.betsLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.betsLabel.Location = new System.Drawing.Point(154, 21);
            this.betsLabel.Name = "betsLabel";
            this.betsLabel.Size = new System.Drawing.Size(34, 12);
            this.betsLabel.TabIndex = 1;
            this.betsLabel.Text = "Bets";
            this.betsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.minimumBetLabel.Location = new System.Drawing.Point(8, 21);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(122, 12);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimumBetLabel";
            this.minimumBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox_dog4);
            this.Controls.Add(this.pictureBox_dog3);
            this.Controls.Add(this.pictureBox_dog2);
            this.Controls.Add(this.pictureBox_dog1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dog4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_dogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_dog1;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox pictureBox_dog2;
        private System.Windows.Forms.PictureBox pictureBox_dog3;
        private System.Windows.Forms.PictureBox pictureBox_dog4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_dogNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private System.Windows.Forms.Button button_race;
        private System.Windows.Forms.RadioButton player3RadioButton;
        private System.Windows.Forms.RadioButton player2RadioButton;
        private System.Windows.Forms.RadioButton player1RadioButton;
        private System.Windows.Forms.Button button_bet;
        private System.Windows.Forms.Label checkedNameLabel;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label betsLabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

