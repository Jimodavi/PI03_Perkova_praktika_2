namespace praktika_2
{
    partial class Form
    {
        //Required designer variable.
        private System.ComponentModel.IContainer components = null;

        //Clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.ScrollBarTimer = new System.Windows.Forms.HScrollBar();
            this.LabelProbabilityM = new System.Windows.Forms.Label();
            this.LabelProbabilityV = new System.Windows.Forms.Label();
            this.ScrollBarM = new System.Windows.Forms.HScrollBar();
            this.ButtonColor4 = new System.Windows.Forms.Button();
            this.ButtonColor3 = new System.Windows.Forms.Button();
            this.ButtonColor2 = new System.Windows.Forms.Button();
            this.ButtonColor1 = new System.Windows.Forms.Button();
            this.ScrollBarV = new System.Windows.Forms.HScrollBar();
            this.LabelColor4 = new System.Windows.Forms.Label();
            this.LabelColor3 = new System.Windows.Forms.Label();
            this.LabelColor2 = new System.Windows.Forms.Label();
            this.LabelColor1 = new System.Windows.Forms.Label();
            this.PictureBoxDead = new System.Windows.Forms.PictureBox();
            this.PictureBoxMacrophage = new System.Windows.Forms.PictureBox();
            this.PictureBoxVirus = new System.Windows.Forms.PictureBox();
            this.PictureBoxHealthy = new System.Windows.Forms.PictureBox();
            this.LabelSize = new System.Windows.Forms.Label();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.ButtonNew = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SquareSize = new System.Windows.Forms.NumericUpDown();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMacrophage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHealthy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareSize)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainer
            // 
            this.SplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.PictureBoxMain);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.ScrollBarTimer);
            this.SplitContainer.Panel2.Controls.Add(this.LabelProbabilityM);
            this.SplitContainer.Panel2.Controls.Add(this.LabelProbabilityV);
            this.SplitContainer.Panel2.Controls.Add(this.ScrollBarM);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonColor4);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonColor3);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonColor2);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonColor1);
            this.SplitContainer.Panel2.Controls.Add(this.ScrollBarV);
            this.SplitContainer.Panel2.Controls.Add(this.LabelColor4);
            this.SplitContainer.Panel2.Controls.Add(this.LabelColor3);
            this.SplitContainer.Panel2.Controls.Add(this.LabelColor2);
            this.SplitContainer.Panel2.Controls.Add(this.LabelColor1);
            this.SplitContainer.Panel2.Controls.Add(this.PictureBoxDead);
            this.SplitContainer.Panel2.Controls.Add(this.PictureBoxMacrophage);
            this.SplitContainer.Panel2.Controls.Add(this.PictureBoxVirus);
            this.SplitContainer.Panel2.Controls.Add(this.PictureBoxHealthy);
            this.SplitContainer.Panel2.Controls.Add(this.LabelSize);
            this.SplitContainer.Panel2.Controls.Add(this.LabelTimer);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonNew);
            this.SplitContainer.Panel2.Controls.Add(this.ButtonStart);
            this.SplitContainer.Panel2.Controls.Add(this.SquareSize);
            this.SplitContainer.Size = new System.Drawing.Size(1255, 1004);
            this.SplitContainer.SplitterDistance = 1004;
            this.SplitContainer.TabIndex = 0;
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(1000, 1000);
            this.PictureBoxMain.TabIndex = 0;
            this.PictureBoxMain.TabStop = false;
            // 
            // ScrollBarTimer
            // 
            this.ScrollBarTimer.LargeChange = 500;
            this.ScrollBarTimer.Location = new System.Drawing.Point(50, 290);
            this.ScrollBarTimer.Maximum = 5000;
            this.ScrollBarTimer.Minimum = 1000;
            this.ScrollBarTimer.Name = "ScrollBarTimer";
            this.ScrollBarTimer.Size = new System.Drawing.Size(150, 15);
            this.ScrollBarTimer.SmallChange = 50;
            this.ScrollBarTimer.TabIndex = 24;
            this.ScrollBarTimer.Value = 1000;
            this.ScrollBarTimer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarTimer_Scroll);
            // 
            // LabelProbabilityM
            // 
            this.LabelProbabilityM.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelProbabilityM.Location = new System.Drawing.Point(-2, 850);
            this.LabelProbabilityM.Name = "LabelProbabilityM";
            this.LabelProbabilityM.Size = new System.Drawing.Size(242, 20);
            this.LabelProbabilityM.TabIndex = 23;
            this.LabelProbabilityM.Text = "Вероятность появления макрофагов";
            // 
            // LabelProbabilityV
            // 
            this.LabelProbabilityV.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelProbabilityV.Location = new System.Drawing.Point(8, 785);
            this.LabelProbabilityV.Name = "LabelProbabilityV";
            this.LabelProbabilityV.Size = new System.Drawing.Size(232, 20);
            this.LabelProbabilityV.TabIndex = 21;
            this.LabelProbabilityV.Text = "Вероятность появления вирусов";
            // 
            // ScrollBarM
            // 
            this.ScrollBarM.Location = new System.Drawing.Point(50, 870);
            this.ScrollBarM.Minimum = 1;
            this.ScrollBarM.Name = "ScrollBarM";
            this.ScrollBarM.Size = new System.Drawing.Size(150, 15);
            this.ScrollBarM.TabIndex = 20;
            this.ScrollBarM.Value = 100;
            this.ScrollBarM.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarM_Scroll);
            // 
            // ButtonColor4
            // 
            this.ButtonColor4.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonColor4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonColor4.Location = new System.Drawing.Point(50, 725);
            this.ButtonColor4.Name = "ButtonColor4";
            this.ButtonColor4.Size = new System.Drawing.Size(150, 30);
            this.ButtonColor4.TabIndex = 19;
            this.ButtonColor4.Text = "Изменить цвет";
            this.ButtonColor4.UseVisualStyleBackColor = false;
            this.ButtonColor4.Click += new System.EventHandler(this.ButtonColor4_Click);
            // 
            // ButtonColor3
            // 
            this.ButtonColor3.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonColor3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonColor3.Location = new System.Drawing.Point(50, 615);
            this.ButtonColor3.Name = "ButtonColor3";
            this.ButtonColor3.Size = new System.Drawing.Size(150, 30);
            this.ButtonColor3.TabIndex = 18;
            this.ButtonColor3.Text = "Изменить цвет";
            this.ButtonColor3.UseVisualStyleBackColor = false;
            this.ButtonColor3.Click += new System.EventHandler(this.ButtonColor3_Click);
            // 
            // ButtonColor2
            // 
            this.ButtonColor2.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonColor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonColor2.Location = new System.Drawing.Point(50, 505);
            this.ButtonColor2.Name = "ButtonColor2";
            this.ButtonColor2.Size = new System.Drawing.Size(150, 30);
            this.ButtonColor2.TabIndex = 17;
            this.ButtonColor2.Text = "Изменить цвет";
            this.ButtonColor2.UseVisualStyleBackColor = false;
            this.ButtonColor2.Click += new System.EventHandler(this.ButtonColor2_Click);
            // 
            // ButtonColor1
            // 
            this.ButtonColor1.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonColor1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonColor1.Location = new System.Drawing.Point(50, 395);
            this.ButtonColor1.Name = "ButtonColor1";
            this.ButtonColor1.Size = new System.Drawing.Size(150, 30);
            this.ButtonColor1.TabIndex = 16;
            this.ButtonColor1.Text = "Изменить цвет";
            this.ButtonColor1.UseVisualStyleBackColor = false;
            this.ButtonColor1.Click += new System.EventHandler(this.ButtonColor1_Click);
            // 
            // ScrollBarV
            // 
            this.ScrollBarV.Location = new System.Drawing.Point(50, 805);
            this.ScrollBarV.Minimum = 1;
            this.ScrollBarV.Name = "ScrollBarV";
            this.ScrollBarV.Size = new System.Drawing.Size(150, 15);
            this.ScrollBarV.TabIndex = 15;
            this.ScrollBarV.Value = 100;
            this.ScrollBarV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarV_Scroll);
            // 
            // LabelColor4
            // 
            this.LabelColor4.AutoSize = true;
            this.LabelColor4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColor4.Location = new System.Drawing.Point(90, 690);
            this.LabelColor4.Name = "LabelColor4";
            this.LabelColor4.Size = new System.Drawing.Size(110, 20);
            this.LabelColor4.TabIndex = 14;
            this.LabelColor4.Text = "Мёртвые клетки";
            // 
            // LabelColor3
            // 
            this.LabelColor3.AutoSize = true;
            this.LabelColor3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColor3.Location = new System.Drawing.Point(90, 580);
            this.LabelColor3.Name = "LabelColor3";
            this.LabelColor3.Size = new System.Drawing.Size(123, 20);
            this.LabelColor3.TabIndex = 13;
            this.LabelColor3.Text = "Клетки макрофаги";
            // 
            // LabelColor2
            // 
            this.LabelColor2.AutoSize = true;
            this.LabelColor2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColor2.Location = new System.Drawing.Point(90, 470);
            this.LabelColor2.Name = "LabelColor2";
            this.LabelColor2.Size = new System.Drawing.Size(98, 20);
            this.LabelColor2.TabIndex = 12;
            this.LabelColor2.Text = "Клетки вируса";
            // 
            // LabelColor1
            // 
            this.LabelColor1.AutoSize = true;
            this.LabelColor1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelColor1.Location = new System.Drawing.Point(90, 360);
            this.LabelColor1.Name = "LabelColor1";
            this.LabelColor1.Size = new System.Drawing.Size(118, 20);
            this.LabelColor1.TabIndex = 11;
            this.LabelColor1.Text = "Здоровые клетки";
            // 
            // PictureBoxDead
            // 
            this.PictureBoxDead.BackColor = System.Drawing.Color.DimGray;
            this.PictureBoxDead.Location = new System.Drawing.Point(50, 685);
            this.PictureBoxDead.Name = "PictureBoxDead";
            this.PictureBoxDead.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxDead.TabIndex = 10;
            this.PictureBoxDead.TabStop = false;
            // 
            // PictureBoxMacrophage
            // 
            this.PictureBoxMacrophage.BackColor = System.Drawing.Color.SaddleBrown;
            this.PictureBoxMacrophage.Location = new System.Drawing.Point(50, 575);
            this.PictureBoxMacrophage.Name = "PictureBoxMacrophage";
            this.PictureBoxMacrophage.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxMacrophage.TabIndex = 9;
            this.PictureBoxMacrophage.TabStop = false;
            // 
            // PictureBoxVirus
            // 
            this.PictureBoxVirus.BackColor = System.Drawing.Color.OrangeRed;
            this.PictureBoxVirus.Location = new System.Drawing.Point(50, 465);
            this.PictureBoxVirus.Name = "PictureBoxVirus";
            this.PictureBoxVirus.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxVirus.TabIndex = 8;
            this.PictureBoxVirus.TabStop = false;
            // 
            // PictureBoxHealthy
            // 
            this.PictureBoxHealthy.BackColor = System.Drawing.Color.BurlyWood;
            this.PictureBoxHealthy.Location = new System.Drawing.Point(50, 355);
            this.PictureBoxHealthy.Name = "PictureBoxHealthy";
            this.PictureBoxHealthy.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxHealthy.TabIndex = 7;
            this.PictureBoxHealthy.TabStop = false;
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelSize.Location = new System.Drawing.Point(50, 187);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(123, 20);
            this.LabelSize.TabIndex = 5;
            this.LabelSize.Text = "Размер квадратов";
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTimer.Location = new System.Drawing.Point(50, 267);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(147, 20);
            this.LabelTimer.TabIndex = 4;
            this.LabelTimer.Text = "Интервал обновления";
            // 
            // ButtonNew
            // 
            this.ButtonNew.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonNew.Location = new System.Drawing.Point(50, 130);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(150, 30);
            this.ButtonNew.TabIndex = 2;
            this.ButtonNew.Text = "Новое поле";
            this.ButtonNew.UseVisualStyleBackColor = false;
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonStart.Enabled = false;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.Location = new System.Drawing.Point(50, 50);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(150, 30);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // SquareSize
            // 
            this.SquareSize.BackColor = System.Drawing.SystemColors.Control;
            this.SquareSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SquareSize.Location = new System.Drawing.Point(50, 210);
            this.SquareSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SquareSize.Name = "SquareSize";
            this.SquareSize.Size = new System.Drawing.Size(150, 29);
            this.SquareSize.TabIndex = 0;
            this.SquareSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SquareSize.ValueChanged += new System.EventHandler(this.SquareSize_ValueChanged);
            // 
            // Timer
            // 
            this.Timer.Interval = 200;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 1004);
            this.Controls.Add(this.SplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модель жизни клеток";
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMacrophage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHealthy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SquareSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.NumericUpDown SquareSize;
        private System.Windows.Forms.Button ButtonNew;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.PictureBox PictureBoxHealthy;
        private System.Windows.Forms.PictureBox PictureBoxVirus;
        private System.Windows.Forms.PictureBox PictureBoxMacrophage;
        private System.Windows.Forms.PictureBox PictureBoxDead;
        private System.Windows.Forms.Label LabelColor1;
        private System.Windows.Forms.Label LabelColor4;
        private System.Windows.Forms.Label LabelColor3;
        private System.Windows.Forms.Label LabelColor2;
        private System.Windows.Forms.HScrollBar ScrollBarV;
        private System.Windows.Forms.Button ButtonColor2;
        private System.Windows.Forms.Button ButtonColor1;
        private System.Windows.Forms.HScrollBar ScrollBarM;
        private System.Windows.Forms.Button ButtonColor4;
        private System.Windows.Forms.Button ButtonColor3;
        private System.Windows.Forms.Label LabelProbabilityV;
        private System.Windows.Forms.Label LabelProbabilityM;
        private System.Windows.Forms.HScrollBar ScrollBarTimer;
        private System.Windows.Forms.ColorDialog ColorDialog;
    }
}