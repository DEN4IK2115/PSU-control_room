namespace Airport.GameViewController
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAirline = new System.Windows.Forms.Button();
            this.btnBoard = new System.Windows.Forms.Button();
            this.btnPlanesMarket = new System.Windows.Forms.Button();
            this.lblDateAndIco = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblBalanceValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnUpThree = new System.Windows.Forms.Button();
            this.btnUpTwo = new System.Windows.Forms.Button();
            this.btnUpOne = new System.Windows.Forms.Button();
            this.picDate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAirline
            // 
            this.btnAirline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAirline.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAirline.Location = new System.Drawing.Point(1, 0);
            this.btnAirline.Margin = new System.Windows.Forms.Padding(0);
            this.btnAirline.Name = "btnAirline";
            this.btnAirline.Size = new System.Drawing.Size(189, 45);
            this.btnAirline.TabIndex = 4;
            this.btnAirline.Text = "Текущее положение дел";
            this.btnAirline.UseVisualStyleBackColor = true;
            this.btnAirline.Click += new System.EventHandler(this.BtnAirline_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoard.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoard.Location = new System.Drawing.Point(189, 0);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(212, 45);
            this.btnBoard.TabIndex = 2;
            this.btnBoard.Text = "Контракты";
            this.btnBoard.UseVisualStyleBackColor = true;
            this.btnBoard.Click += new System.EventHandler(this.BtnBoard_Click);
            // 
            // btnPlanesMarket
            // 
            this.btnPlanesMarket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlanesMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanesMarket.Font = new System.Drawing.Font("Arial", 9F);
            this.btnPlanesMarket.Location = new System.Drawing.Point(400, 0);
            this.btnPlanesMarket.Name = "btnPlanesMarket";
            this.btnPlanesMarket.Size = new System.Drawing.Size(401, 45);
            this.btnPlanesMarket.TabIndex = 3;
            this.btnPlanesMarket.Text = "Покупка/Продажа трансорта";
            this.btnPlanesMarket.UseVisualStyleBackColor = true;
            this.btnPlanesMarket.Click += new System.EventHandler(this.BtnPlanesMarket_Click);
            // 
            // lblDateAndIco
            // 
            this.lblDateAndIco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateAndIco.AutoSize = true;
            this.lblDateAndIco.BackColor = System.Drawing.Color.White;
            this.lblDateAndIco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateAndIco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateAndIco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateAndIco.Location = new System.Drawing.Point(801, 0);
            this.lblDateAndIco.Margin = new System.Windows.Forms.Padding(0);
            this.lblDateAndIco.MinimumSize = new System.Drawing.Size(282, 45);
            this.lblDateAndIco.Name = "lblDateAndIco";
            this.lblDateAndIco.Size = new System.Drawing.Size(282, 45);
            this.lblDateAndIco.TabIndex = 1;
            this.lblDateAndIco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDateValue
            // 
            this.lblDateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.BackColor = System.Drawing.Color.White;
            this.lblDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateValue.Location = new System.Drawing.Point(851, 13);
            this.lblDateValue.MinimumSize = new System.Drawing.Size(11, 11);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(31, 15);
            this.lblDateValue.TabIndex = 7;
            this.lblDateValue.Text = "date";
            this.lblDateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBalanceValue
            // 
            this.lblBalanceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanceValue.Location = new System.Drawing.Point(12, 64);
            this.lblBalanceValue.Name = "lblBalanceValue";
            this.lblBalanceValue.Size = new System.Drawing.Size(269, 34);
            this.lblBalanceValue.TabIndex = 9;
            this.lblBalanceValue.Text = "Value";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.BackColor = System.Drawing.Color.White;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeValue.Location = new System.Drawing.Point(914, 28);
            this.lblTimeValue.MaximumSize = new System.Drawing.Size(72, 0);
            this.lblTimeValue.MinimumSize = new System.Drawing.Size(72, 0);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(72, 15);
            this.lblTimeValue.TabIndex = 11;
            this.lblTimeValue.Text = "Value";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(851, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 15);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Время:";
            // 
            // btnUpThree
            // 
            this.btnUpThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpThree.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.btnUpThree.Location = new System.Drawing.Point(987, 48);
            this.btnUpThree.Name = "btnUpThree";
            this.btnUpThree.Size = new System.Drawing.Size(96, 25);
            this.btnUpThree.TabIndex = 14;
            this.btnUpThree.Text = "очень быстро";
            this.btnUpThree.UseVisualStyleBackColor = true;
            this.btnUpThree.Click += new System.EventHandler(this.BtnUpThree_Click);
            // 
            // btnUpTwo
            // 
            this.btnUpTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpTwo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpTwo.Location = new System.Drawing.Point(889, 48);
            this.btnUpTwo.Name = "btnUpTwo";
            this.btnUpTwo.Size = new System.Drawing.Size(103, 25);
            this.btnUpTwo.TabIndex = 13;
            this.btnUpTwo.Text = "быстро";
            this.btnUpTwo.UseVisualStyleBackColor = true;
            this.btnUpTwo.Click += new System.EventHandler(this.BtnUpTwo_Click);
            // 
            // btnUpOne
            // 
            this.btnUpOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpOne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpOne.Location = new System.Drawing.Point(801, 48);
            this.btnUpOne.Name = "btnUpOne";
            this.btnUpOne.Size = new System.Drawing.Size(90, 25);
            this.btnUpOne.TabIndex = 12;
            this.btnUpOne.Text = "нормально";
            this.btnUpOne.UseVisualStyleBackColor = true;
            this.btnUpOne.Click += new System.EventHandler(this.BtnUpOne_Click);
            // 
            // picDate
            // 
            this.picDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDate.BackColor = System.Drawing.Color.White;
            this.picDate.Image = ((System.Drawing.Image)(resources.GetObject("picDate.Image")));
            this.picDate.Location = new System.Drawing.Point(807, 4);
            this.picDate.Name = "picDate";
            this.picDate.Size = new System.Drawing.Size(36, 36);
            this.picDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDate.TabIndex = 6;
            this.picDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Темп игры";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpThree);
            this.Controls.Add(this.btnUpTwo);
            this.Controls.Add(this.btnUpOne);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDateValue);
            this.Controls.Add(this.lblBalanceValue);
            this.Controls.Add(this.picDate);
            this.Controls.Add(this.lblDateAndIco);
            this.Controls.Add(this.btnPlanesMarket);
            this.Controls.Add(this.btnBoard);
            this.Controls.Add(this.btnAirline);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 550);
            this.MinimumSize = new System.Drawing.Size(1100, 550);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Симулятор аэропорта";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAirline;
        private System.Windows.Forms.Button btnBoard;
        private System.Windows.Forms.Button btnPlanesMarket;
        private System.Windows.Forms.Label lblDateAndIco;
        private System.Windows.Forms.PictureBox picDate;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnUpOne;
        private System.Windows.Forms.Button btnUpTwo;
        private System.Windows.Forms.Button btnUpThree;
        public System.Windows.Forms.Label lblBalanceValue;
        private System.Windows.Forms.Label label1;
    }
}