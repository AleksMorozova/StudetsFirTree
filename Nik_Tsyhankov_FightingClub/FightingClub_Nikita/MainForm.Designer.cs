﻿namespace FightingClub_Nikita
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuMainStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.butHead = new System.Windows.Forms.Button();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.butBody = new System.Windows.Forms.Button();
            this.butLeg = new System.Windows.Forms.Button();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblHPPlayer1 = new System.Windows.Forms.Label();
            this.lblHPPlayer2 = new System.Windows.Forms.Label();
            this.pictureBoxPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerTwo = new System.Windows.Forms.PictureBox();
            this.statusMainStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRounds = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFinish = new System.Windows.Forms.Label();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerTwo)).BeginInit();
            this.statusMainStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMainStrip
            // 
            this.menuMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuMainStrip.Location = new System.Drawing.Point(0, 0);
            this.menuMainStrip.Name = "menuMainStrip";
            this.menuMainStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuMainStrip.Size = new System.Drawing.Size(785, 25);
            this.menuMainStrip.TabIndex = 3;
            this.menuMainStrip.Text = "menuMainStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.stToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveGameToolStripMenuItem.Text = "Save game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.loadGameToolStripMenuItem.Text = "Load game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // stToolStripMenuItem
            // 
            this.stToolStripMenuItem.Name = "stToolStripMenuItem";
            this.stToolStripMenuItem.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(353, 74);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 28);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Atack!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butHead
            // 
            this.butHead.Location = new System.Drawing.Point(329, 118);
            this.butHead.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.butHead.Name = "butHead";
            this.butHead.Size = new System.Drawing.Size(109, 40);
            this.butHead.TabIndex = 5;
            this.butHead.Text = "Head";
            this.butHead.UseVisualStyleBackColor = true;
            this.butHead.Click += new System.EventHandler(this.butHead_Click);
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.Location = new System.Drawing.Point(49, 308);
            this.progressBarPlayer1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            this.progressBarPlayer1.Size = new System.Drawing.Size(167, 23);
            this.progressBarPlayer1.TabIndex = 8;
            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.Location = new System.Drawing.Point(565, 308);
            this.progressBarPlayer2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.progressBarPlayer2.Name = "progressBarPlayer2";
            this.progressBarPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBarPlayer2.Size = new System.Drawing.Size(169, 23);
            this.progressBarPlayer2.Step = 1;
            this.progressBarPlayer2.TabIndex = 9;
            // 
            // butBody
            // 
            this.butBody.Location = new System.Drawing.Point(329, 186);
            this.butBody.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.butBody.Name = "butBody";
            this.butBody.Size = new System.Drawing.Size(109, 40);
            this.butBody.TabIndex = 10;
            this.butBody.Text = "Body";
            this.butBody.UseVisualStyleBackColor = true;
            this.butBody.Click += new System.EventHandler(this.butBody_Click);
            // 
            // butLeg
            // 
            this.butLeg.Location = new System.Drawing.Point(329, 257);
            this.butLeg.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.butLeg.Name = "butLeg";
            this.butLeg.Size = new System.Drawing.Size(109, 40);
            this.butLeg.TabIndex = 11;
            this.butLeg.Text = "Leg";
            this.butLeg.UseVisualStyleBackColor = true;
            this.butLeg.Click += new System.EventHandler(this.butLeg_Click);
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(624, 45);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(72, 26);
            this.lblPlayer2.TabIndex = 12;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Minion Pro Cond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(105, 45);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(72, 26);
            this.lblPlayer1.TabIndex = 15;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblHPPlayer1
            // 
            this.lblHPPlayer1.AutoSize = true;
            this.lblHPPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPPlayer1.Location = new System.Drawing.Point(96, 334);
            this.lblHPPlayer1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHPPlayer1.Name = "lblHPPlayer1";
            this.lblHPPlayer1.Size = new System.Drawing.Size(14, 13);
            this.lblHPPlayer1.TabIndex = 16;
            this.lblHPPlayer1.Text = "0";
            // 
            // lblHPPlayer2
            // 
            this.lblHPPlayer2.AutoSize = true;
            this.lblHPPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPPlayer2.Location = new System.Drawing.Point(672, 334);
            this.lblHPPlayer2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblHPPlayer2.Name = "lblHPPlayer2";
            this.lblHPPlayer2.Size = new System.Drawing.Size(14, 13);
            this.lblHPPlayer2.TabIndex = 17;
            this.lblHPPlayer2.Text = "0";
            // 
            // pictureBoxPlayer1
            // 
            this.pictureBoxPlayer1.Image = global::FightingClub_Nikita.Properties.Resources.Fighter1;
            this.pictureBoxPlayer1.Location = new System.Drawing.Point(49, 74);
            this.pictureBoxPlayer1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.pictureBoxPlayer1.Name = "pictureBoxPlayer1";
            this.pictureBoxPlayer1.Size = new System.Drawing.Size(167, 230);
            this.pictureBoxPlayer1.TabIndex = 13;
            this.pictureBoxPlayer1.TabStop = false;
            // 
            // pictureBoxPlayerTwo
            // 
            this.pictureBoxPlayerTwo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayerTwo.Image")));
            this.pictureBoxPlayerTwo.Location = new System.Drawing.Point(565, 74);
            this.pictureBoxPlayerTwo.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.pictureBoxPlayerTwo.Name = "pictureBoxPlayerTwo";
            this.pictureBoxPlayerTwo.Size = new System.Drawing.Size(169, 230);
            this.pictureBoxPlayerTwo.TabIndex = 19;
            this.pictureBoxPlayerTwo.TabStop = false;
            // 
            // statusMainStrip
            // 
            this.statusMainStrip.AutoSize = false;
            this.statusMainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRounds});
            this.statusMainStrip.Location = new System.Drawing.Point(0, 489);
            this.statusMainStrip.Name = "statusMainStrip";
            this.statusMainStrip.Size = new System.Drawing.Size(785, 22);
            this.statusMainStrip.SizingGrip = false;
            this.statusMainStrip.TabIndex = 20;
            this.statusMainStrip.Text = "statusMainStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Round: ";
            // 
            // lblRounds
            // 
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRounds.Size = new System.Drawing.Size(13, 17);
            this.lblRounds.Text = "0";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFinish.Location = new System.Drawing.Point(304, 308);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(0, 25);
            this.lblFinish.TabIndex = 21;
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFinish.Visible = false;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 22;
            this.listBoxLog.Location = new System.Drawing.Point(12, 352);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLog.Size = new System.Drawing.Size(761, 136);
            this.listBoxLog.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 511);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.statusMainStrip);
            this.Controls.Add(this.pictureBoxPlayerTwo);
            this.Controls.Add(this.lblHPPlayer2);
            this.Controls.Add(this.lblHPPlayer1);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.pictureBoxPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.butLeg);
            this.Controls.Add(this.butBody);
            this.Controls.Add(this.progressBarPlayer2);
            this.Controls.Add(this.progressBarPlayer1);
            this.Controls.Add(this.butHead);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuMainStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuMainStrip;
            this.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fighting Club!";
            this.menuMainStrip.ResumeLayout(false);
            this.menuMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerTwo)).EndInit();
            this.statusMainStrip.ResumeLayout(false);
            this.statusMainStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button butHead;
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.ProgressBar progressBarPlayer2;
        private System.Windows.Forms.Button butBody;
        private System.Windows.Forms.Button butLeg;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblHPPlayer1;
        private System.Windows.Forms.Label lblHPPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxPlayerTwo;
        private System.Windows.Forms.StatusStrip statusMainStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRounds;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator stToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}

