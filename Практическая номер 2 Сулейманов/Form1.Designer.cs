namespace Практическая_номер_2_Сулейманов
{
    partial class FormMain
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
            this.Text1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Text2 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Leave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Text1.Location = new System.Drawing.Point(6, 16);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(167, 20);
            this.Text1.TabIndex = 0;
            this.Text1.Text = "Введите значения";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Text2.Location = new System.Drawing.Point(6, 59);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(62, 20);
            this.Text2.TabIndex = 2;
            this.Text2.Text = "Ответ";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.Output);
            this.groupBox.Controls.Add(this.Input);
            this.groupBox.Controls.Add(this.Text1);
            this.groupBox.Controls.Add(this.Text2);
            this.groupBox.Location = new System.Drawing.Point(12, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(309, 90);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Рабочая область";
            // 
            // Input
            // 
            this.Input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Input.Location = new System.Drawing.Point(179, 18);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(124, 20);
            this.Input.TabIndex = 3;
            // 
            // Output
            // 
            this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Output.Location = new System.Drawing.Point(179, 59);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(124, 20);
            this.Output.TabIndex = 4;
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start.Location = new System.Drawing.Point(12, 123);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(99, 42);
            this.Start.TabIndex = 4;
            this.Start.Text = "Считать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Leave
            // 
            this.Leave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Leave.Location = new System.Drawing.Point(222, 123);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(99, 42);
            this.Leave.TabIndex = 5;
            this.Leave.Text = "Выход";
            this.Leave.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 177);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(349, 216);
            this.Name = "FormMain";
            this.Text = "Generic program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Leave;
    }
}

