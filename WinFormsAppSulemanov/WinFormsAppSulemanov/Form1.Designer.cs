namespace WinFormsAppSulemanov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            files = new ContextMenuStrip(components);
            enquiry = new ContextMenuStrip(components);
            Calculator = new TabPage();
            button1 = new Button();
            buttonStart = new Button();
            groupResult = new GroupBox();
            textBoxY = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupStartInfo = new GroupBox();
            textBoxX = new TextBox();
            labalX = new Label();
            groupQuest = new GroupBox();
            labelQuation = new Label();
            Formula = new PictureBox();
            tabControl = new TabControl();
            вычислитьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            очиститьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem1 = new ToolStripMenuItem();
            files.SuspendLayout();
            enquiry.SuspendLayout();
            Calculator.SuspendLayout();
            groupResult.SuspendLayout();
            groupStartInfo.SuspendLayout();
            groupQuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Formula).BeginInit();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // files
            // 
            files.Items.AddRange(new ToolStripItem[] { вычислитьToolStripMenuItem, toolStripSeparator1, очиститьToolStripMenuItem, выходToolStripMenuItem });
            files.Name = "files";
            files.Size = new Size(181, 98);
            files.Text = "Файл";
            // 
            // enquiry
            // 
            enquiry.Items.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem1 });
            enquiry.Name = "enquiry";
            enquiry.Size = new Size(150, 26);
            enquiry.Text = "Справка";
            // 
            // Calculator
            // 
            Calculator.BackColor = SystemColors.Desktop;
            Calculator.Controls.Add(button1);
            Calculator.Controls.Add(buttonStart);
            Calculator.Controls.Add(groupResult);
            Calculator.Controls.Add(groupBox2);
            Calculator.Controls.Add(groupStartInfo);
            Calculator.Controls.Add(groupQuest);
            Calculator.Location = new Point(4, 24);
            Calculator.Name = "Calculator";
            Calculator.Padding = new Padding(3);
            Calculator.Size = new Size(479, 334);
            Calculator.TabIndex = 0;
            Calculator.Text = "Расчеты";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.Yellow;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(302, 282);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 4;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.BackgroundImageLayout = ImageLayout.None;
            buttonStart.FlatAppearance.BorderColor = Color.Yellow;
            buttonStart.FlatAppearance.BorderSize = 5;
            buttonStart.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            buttonStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            buttonStart.Location = new Point(47, 282);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(126, 23);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Вычеслить";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // groupResult
            // 
            groupResult.Controls.Add(textBoxY);
            groupResult.Controls.Add(label1);
            groupResult.ForeColor = SystemColors.ButtonFace;
            groupResult.Location = new Point(261, 161);
            groupResult.Name = "groupResult";
            groupResult.Size = new Size(212, 92);
            groupResult.TabIndex = 2;
            groupResult.TabStop = false;
            groupResult.Text = "Результат";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(41, 42);
            textBoxY.Name = "textBoxY";
            textBoxY.PlaceholderText = "Тут будет ответ";
            textBoxY.Size = new Size(165, 23);
            textBoxY.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = " y = ";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(236, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(0, 0);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задание";
            // 
            // groupStartInfo
            // 
            groupStartInfo.Controls.Add(textBoxX);
            groupStartInfo.Controls.Add(labalX);
            groupStartInfo.ForeColor = SystemColors.ButtonFace;
            groupStartInfo.Location = new Point(6, 161);
            groupStartInfo.Name = "groupStartInfo";
            groupStartInfo.Size = new Size(212, 92);
            groupStartInfo.TabIndex = 1;
            groupStartInfo.TabStop = false;
            groupStartInfo.Text = "Исходные данные";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(41, 42);
            textBoxX.Name = "textBoxX";
            textBoxX.PlaceholderText = "Сюда x";
            textBoxX.Size = new Size(165, 23);
            textBoxX.TabIndex = 1;
            // 
            // labalX
            // 
            labalX.AutoSize = true;
            labalX.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labalX.Location = new Point(6, 45);
            labalX.Name = "labalX";
            labalX.Size = new Size(29, 15);
            labalX.TabIndex = 0;
            labalX.Text = " x = ";
            labalX.Click += label1_Click;
            // 
            // groupQuest
            // 
            groupQuest.BackColor = SystemColors.Desktop;
            groupQuest.Controls.Add(labelQuation);
            groupQuest.Controls.Add(Formula);
            groupQuest.Cursor = Cursors.SizeAll;
            groupQuest.FlatStyle = FlatStyle.Flat;
            groupQuest.ForeColor = SystemColors.ButtonFace;
            groupQuest.Location = new Point(6, 6);
            groupQuest.Name = "groupQuest";
            groupQuest.Size = new Size(467, 130);
            groupQuest.TabIndex = 0;
            groupQuest.TabStop = false;
            groupQuest.Text = "Задание";
            // 
            // labelQuation
            // 
            labelQuation.AutoSize = true;
            labelQuation.Location = new Point(79, 19);
            labelQuation.Name = "labelQuation";
            labelQuation.Size = new Size(307, 15);
            labelQuation.TabIndex = 3;
            labelQuation.Text = "Расчитать значение выражение при исходных данных";
            // 
            // Formula
            // 
            Formula.Location = new Point(170, 45);
            Formula.Name = "Formula";
            Formula.Size = new Size(130, 70);
            Formula.TabIndex = 3;
            Formula.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(Calculator);
            tabControl.Location = new Point(-1, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(487, 362);
            tabControl.TabIndex = 2;
            // 
            // вычислитьToolStripMenuItem
            // 
            вычислитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            вычислитьToolStripMenuItem.Name = "вычислитьToolStripMenuItem";
            вычислитьToolStripMenuItem.Size = new Size(180, 22);
            вычислитьToolStripMenuItem.Text = "Вычислить";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(180, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // очиститьToolStripMenuItem
            // 
            очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            очиститьToolStripMenuItem.Size = new Size(180, 22);
            очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            оПрограммеToolStripMenuItem1.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem1.Text = "О программе";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(484, 361);
            Controls.Add(tabControl);
            MaximumSize = new Size(500, 400);
            MinimumSize = new Size(500, 400);
            Name = "Form1";
            Text = "Моё приложение";
            files.ResumeLayout(false);
            enquiry.ResumeLayout(false);
            Calculator.ResumeLayout(false);
            groupResult.ResumeLayout(false);
            groupResult.PerformLayout();
            groupStartInfo.ResumeLayout(false);
            groupStartInfo.PerformLayout();
            groupQuest.ResumeLayout(false);
            groupQuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Formula).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip files;
        private ContextMenuStrip enquiry;
        private TabPage Calculator;
        private TabControl tabControl;
        private GroupBox groupBox2;
        private GroupBox groupStartInfo;
        private GroupBox groupQuest;
        private GroupBox groupResult;
        private PictureBox Formula;
        private Label labalX;
        private Label labelQuation;
        private TextBox textBoxY;
        private Label label1;
        private TextBox textBoxX;
        private Button button1;
        private Button buttonStart;
        private ToolStripMenuItem вычислитьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem1;
    }
}
