namespace Photo_Sort
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.photos_dir = new System.Windows.Forms.TextBox();
            this.get_photo_dir = new System.Windows.Forms.Button();
            this.get_new_dir = new System.Windows.Forms.Button();
            this.new_dir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.photo_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.new_photo_dir = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть папку з фото:";
            // 
            // photos_dir
            // 
            this.photos_dir.Location = new System.Drawing.Point(15, 28);
            this.photos_dir.Name = "photos_dir";
            this.photos_dir.ReadOnly = true;
            this.photos_dir.Size = new System.Drawing.Size(194, 20);
            this.photos_dir.TabIndex = 1;
            // 
            // get_photo_dir
            // 
            this.get_photo_dir.Location = new System.Drawing.Point(215, 26);
            this.get_photo_dir.Name = "get_photo_dir";
            this.get_photo_dir.Size = new System.Drawing.Size(32, 23);
            this.get_photo_dir.TabIndex = 2;
            this.get_photo_dir.Text = "...";
            this.get_photo_dir.UseVisualStyleBackColor = true;
            this.get_photo_dir.Click += new System.EventHandler(this.get_photo_dir_Click);
            // 
            // get_new_dir
            // 
            this.get_new_dir.Location = new System.Drawing.Point(215, 68);
            this.get_new_dir.Name = "get_new_dir";
            this.get_new_dir.Size = new System.Drawing.Size(32, 23);
            this.get_new_dir.TabIndex = 5;
            this.get_new_dir.Text = "...";
            this.get_new_dir.UseVisualStyleBackColor = true;
            this.get_new_dir.Click += new System.EventHandler(this.get_new_dir_Click);
            // 
            // new_dir
            // 
            this.new_dir.Location = new System.Drawing.Point(15, 70);
            this.new_dir.Name = "new_dir";
            this.new_dir.ReadOnly = true;
            this.new_dir.Size = new System.Drawing.Size(194, 20);
            this.new_dir.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Виберіть папку для фото:";
            // 
            // start_button
            // 
            this.start_button.Enabled = false;
            this.start_button.Location = new System.Drawing.Point(79, 126);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(92, 32);
            this.start_button.TabIndex = 6;
            this.start_button.Text = "Розпочати";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(232, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // photo_dir
            // 
            this.photo_dir.Description = "Виберіть папку з вашими фото";
            // 
            // new_photo_dir
            // 
            this.new_photo_dir.Description = "Виберіть папку де будуть нові фото";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.get_new_dir);
            this.Controls.Add(this.new_dir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.get_photo_dir);
            this.Controls.Add(this.photos_dir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Сортування фото";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox photos_dir;
        private System.Windows.Forms.Button get_photo_dir;
        private System.Windows.Forms.Button get_new_dir;
        private System.Windows.Forms.TextBox new_dir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog photo_dir;
        private System.Windows.Forms.FolderBrowserDialog new_photo_dir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

