﻿namespace WindowsFormsAppSulemanov4
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxInputInfo = new System.Windows.Forms.GroupBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelHeigth = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxInputInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProgramToolStripMenuItem
            // 
            this.ProgramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LeaveToolStripMenuItem});
            this.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem";
            this.ProgramToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ProgramToolStripMenuItem.Text = "Программа";
            // 
            // LeaveToolStripMenuItem
            // 
            this.LeaveToolStripMenuItem.Name = "LeaveToolStripMenuItem";
            this.LeaveToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.LeaveToolStripMenuItem.Text = "Закрыть";
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramInfoToolStripMenuItem});
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.InfoToolStripMenuItem.Text = "Справка";
            // 
            // ProgramInfoToolStripMenuItem
            // 
            this.ProgramInfoToolStripMenuItem.Name = "ProgramInfoToolStripMenuItem";
            this.ProgramInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProgramInfoToolStripMenuItem.Text = "О программе";
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 39);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(298, 278);
            this.dataGridView.TabIndex = 1;
            // 
            // groupBoxInputInfo
            // 
            this.groupBoxInputInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInputInfo.Controls.Add(this.textBoxB);
            this.groupBoxInputInfo.Controls.Add(this.textBoxA);
            this.groupBoxInputInfo.Controls.Add(this.textBoxHeight);
            this.groupBoxInputInfo.Controls.Add(this.textBoxWeight);
            this.groupBoxInputInfo.Controls.Add(this.labelB);
            this.groupBoxInputInfo.Controls.Add(this.labelA);
            this.groupBoxInputInfo.Controls.Add(this.labelHeigth);
            this.groupBoxInputInfo.Controls.Add(this.labelWidth);
            this.groupBoxInputInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputInfo.ForeColor = System.Drawing.Color.White;
            this.groupBoxInputInfo.Location = new System.Drawing.Point(12, 325);
            this.groupBoxInputInfo.Name = "groupBoxInputInfo";
            this.groupBoxInputInfo.Size = new System.Drawing.Size(206, 103);
            this.groupBoxInputInfo.TabIndex = 2;
            this.groupBoxInputInfo.TabStop = false;
            this.groupBoxInputInfo.Text = "Ввод информации";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(111, 79);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(86, 20);
            this.textBoxB.TabIndex = 7;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(111, 57);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(86, 20);
            this.textBoxA.TabIndex = 6;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(111, 35);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(86, 20);
            this.textBoxHeight.TabIndex = 5;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(111, 13);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(86, 20);
            this.textBoxWeight.TabIndex = 4;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.ForeColor = System.Drawing.Color.White;
            this.labelB.Location = new System.Drawing.Point(12, 82);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(86, 16);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "Элемент Б";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.ForeColor = System.Drawing.Color.White;
            this.labelA.Location = new System.Drawing.Point(12, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(86, 16);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "Элемент А";
            // 
            // labelHeigth
            // 
            this.labelHeigth.AutoSize = true;
            this.labelHeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeigth.ForeColor = System.Drawing.Color.White;
            this.labelHeigth.Location = new System.Drawing.Point(12, 38);
            this.labelHeigth.Name = "labelHeigth";
            this.labelHeigth.Size = new System.Drawing.Size(53, 16);
            this.labelHeigth.TabIndex = 1;
            this.labelHeigth.Text = "Длина";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWidth.ForeColor = System.Drawing.Color.White;
            this.labelWidth.Location = new System.Drawing.Point(12, 16);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(64, 16);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Ширина";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(224, 329);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(86, 37);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonLeave
            // 
            this.buttonLeave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeave.ForeColor = System.Drawing.Color.White;
            this.buttonLeave.Location = new System.Drawing.Point(224, 388);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(86, 37);
            this.buttonLeave.TabIndex = 4;
            this.buttonLeave.Text = "Выход";
            this.buttonLeave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 437);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.groupBoxInputInfo);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(338, 476);
            this.Name = "Form1";
            this.Text = "Практическая работа № 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxInputInfo.ResumeLayout(false);
            this.groupBoxInputInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramInfoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxInputInfo;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelHeigth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
    }
}

