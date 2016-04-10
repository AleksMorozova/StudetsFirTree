namespace OOPSong
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMesssage = new System.Windows.Forms.ListBox();
            this.buttonPlaySong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxMesssage
            // 
            this.listBoxMesssage.FormattingEnabled = true;
            this.listBoxMesssage.Location = new System.Drawing.Point(27, 132);
            this.listBoxMesssage.Name = "listBoxMesssage";
            this.listBoxMesssage.Size = new System.Drawing.Size(416, 147);
            this.listBoxMesssage.TabIndex = 0;
            // 
            // buttonPlaySong
            // 
            this.buttonPlaySong.Location = new System.Drawing.Point(95, 32);
            this.buttonPlaySong.Name = "buttonPlaySong";
            this.buttonPlaySong.Size = new System.Drawing.Size(287, 45);
            this.buttonPlaySong.TabIndex = 1;
            this.buttonPlaySong.Text = "Play song";
            this.buttonPlaySong.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 291);
            this.Controls.Add(this.buttonPlaySong);
            this.Controls.Add(this.listBoxMesssage);
            this.Name = "MainForm";
            this.Text = "Imitation song";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMesssage;
        private System.Windows.Forms.Button buttonPlaySong;
    }
}

