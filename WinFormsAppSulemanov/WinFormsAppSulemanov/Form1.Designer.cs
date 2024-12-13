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
            Calculator = new TabPage();
            button1 = new Button();
            buttonStart = new Button();
            groupResult = new GroupBox();
            textBoxY = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupStartInfo = new GroupBox();
            textBoxC = new TextBox();
            labelC = new Label();
            textBoxB = new TextBox();
            labelB = new Label();
            textBoxA = new TextBox();
            labalA = new Label();
            groupQuest = new GroupBox();
            labelQuation = new Label();
            Formula = new PictureBox();
            tabControl = new TabControl();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBoxStart = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemClear = new ToolStripMenuItem();
            toolStripMenuItemClose = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBoxAboutProgram = new ToolStripTextBox();
            toolTip1 = new ToolTip(components);
            Calculator.SuspendLayout();
            groupResult.SuspendLayout();
            groupStartInfo.SuspendLayout();
            groupQuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Formula).BeginInit();
            tabControl.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Calculator
            // 
            Calculator.BackColor = Color.SlateGray;
            Calculator.Controls.Add(button1);
            Calculator.Controls.Add(buttonStart);
            Calculator.Controls.Add(groupResult);
            Calculator.Controls.Add(groupBox2);
            Calculator.Controls.Add(groupStartInfo);
            Calculator.Controls.Add(groupQuest);
            Calculator.Location = new Point(4, 24);
            Calculator.Name = "Calculator";
            Calculator.Padding = new Padding(3);
            Calculator.Size = new Size(479, 307);
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
            button1.Location = new Point(303, 263);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 4;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackgroundImageLayout = ImageLayout.None;
            buttonStart.FlatAppearance.BorderColor = Color.Yellow;
            buttonStart.FlatAppearance.BorderSize = 5;
            buttonStart.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            buttonStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            buttonStart.Location = new Point(48, 263);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(126, 23);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "Вычеслить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // groupResult
            // 
            groupResult.Controls.Add(textBoxY);
            groupResult.Controls.Add(label1);
            groupResult.ForeColor = SystemColors.ButtonFace;
            groupResult.Location = new Point(262, 142);
            groupResult.Name = "groupResult";
            groupResult.Size = new Size(212, 115);
            groupResult.TabIndex = 2;
            groupResult.TabStop = false;
            groupResult.Text = "Результат";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(77, 42);
            textBoxY.Name = "textBoxY";
            textBoxY.PlaceholderText = "Тут будет ответ";
            textBoxY.Size = new Size(129, 23);
            textBoxY.TabIndex = 3;
            textBoxY.MouseHover += textBoxY_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(6, 45);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = " Ответ = ";
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
            groupStartInfo.Controls.Add(textBoxC);
            groupStartInfo.Controls.Add(labelC);
            groupStartInfo.Controls.Add(textBoxB);
            groupStartInfo.Controls.Add(labelB);
            groupStartInfo.Controls.Add(textBoxA);
            groupStartInfo.Controls.Add(labalA);
            groupStartInfo.ForeColor = SystemColors.ButtonFace;
            groupStartInfo.Location = new Point(7, 142);
            groupStartInfo.Name = "groupStartInfo";
            groupStartInfo.Size = new Size(212, 115);
            groupStartInfo.TabIndex = 1;
            groupStartInfo.TabStop = false;
            groupStartInfo.Text = "Исходные данные";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(41, 80);
            textBoxC.Name = "textBoxC";
            textBoxC.PlaceholderText = "Введите c";
            textBoxC.Size = new Size(165, 23);
            textBoxC.TabIndex = 5;
            textBoxC.MouseHover += textBoxC_MouseHover;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelC.Location = new Point(6, 83);
            labelC.Name = "labelC";
            labelC.Size = new Size(29, 15);
            labelC.TabIndex = 4;
            labelC.Text = " c = ";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(41, 51);
            textBoxB.Name = "textBoxB";
            textBoxB.PlaceholderText = "Введите b";
            textBoxB.Size = new Size(165, 23);
            textBoxB.TabIndex = 3;
            textBoxB.MouseHover += textBoxB_MouseHover;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labelB.Location = new Point(6, 54);
            labelB.Name = "labelB";
            labelB.Size = new Size(31, 15);
            labelB.TabIndex = 2;
            labelB.Text = " b = ";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(41, 22);
            textBoxA.Name = "textBoxA";
            textBoxA.PlaceholderText = "Введите а";
            textBoxA.Size = new Size(165, 23);
            textBoxA.TabIndex = 1;
            textBoxA.TextChanged += textBoxA_TextChanged;
            textBoxA.MouseHover += textBoxA_MouseHover;
            // 
            // labalA
            // 
            labalA.AutoSize = true;
            labalA.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            labalA.Location = new Point(6, 25);
            labalA.Name = "labalA";
            labalA.Size = new Size(31, 15);
            labalA.TabIndex = 0;
            labalA.Text = " a = ";
            // 
            // groupQuest
            // 
            groupQuest.BackColor = Color.SlateGray;
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
            Formula.ImageLocation = "D:\\Users\\1213-3\\Documents\\2-ИСПд\\Сулейманов\\WindowsForms 1/Math.png";
            Formula.Location = new Point(130, 52);
            Formula.Name = "Formula";
            Formula.Size = new Size(221, 38);
            Formula.TabIndex = 3;
            Formula.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(Calculator);
            tabControl.Location = new Point(1, 26);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(487, 335);
            tabControl.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(489, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxStart, toolStripSeparator1, toolStripMenuItemClear, toolStripMenuItemClose });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripTextBoxStart
            // 
            toolStripTextBoxStart.Name = "toolStripTextBoxStart";
            toolStripTextBoxStart.Size = new Size(134, 22);
            toolStripTextBoxStart.Text = "Вычеслить";
            toolStripTextBoxStart.Click += toolStripTextBoxStart_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(131, 6);
            // 
            // toolStripMenuItemClear
            // 
            toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            toolStripMenuItemClear.Size = new Size(134, 22);
            toolStripMenuItemClear.Text = "Очистить";
            toolStripMenuItemClear.Click += toolStripMenuItemClear_Click;
            // 
            // toolStripMenuItemClose
            // 
            toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            toolStripMenuItemClose.Size = new Size(134, 22);
            toolStripMenuItemClose.Text = "Выход";
            toolStripMenuItemClose.Click += toolStripMenuItemClose_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxAboutProgram });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStripTextBoxAboutProgram
            // 
            toolStripTextBoxAboutProgram.Name = "toolStripTextBoxAboutProgram";
            toolStripTextBoxAboutProgram.Size = new Size(100, 23);
            toolStripTextBoxAboutProgram.Text = "О программе";
            toolStripTextBoxAboutProgram.Click += toolStripTextBoxAboutProgram_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(489, 361);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            MaximumSize = new Size(505, 400);
            MinimumSize = new Size(505, 400);
            Name = "Form1";
            Text = "Моё приложение";
            Load += Form1_Load;
            Calculator.ResumeLayout(false);
            groupResult.ResumeLayout(false);
            groupResult.PerformLayout();
            groupStartInfo.ResumeLayout(false);
            groupStartInfo.PerformLayout();
            groupQuest.ResumeLayout(false);
            groupQuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Formula).EndInit();
            tabControl.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabPage Calculator;
        private TabControl tabControl;
        private GroupBox groupBox2;
        private GroupBox groupStartInfo;
        private GroupBox groupQuest;
        private GroupBox groupResult;
        private PictureBox Formula;
        private Label labalA;
        private Label labelQuation;
        private TextBox textBoxY;
        private Label label1;
        private TextBox textBoxA;
        private Button button1;
        private Button buttonStart;
        private TextBox textBoxC;
        private Label labelC;
        private TextBox textBoxB;
        private Label labelB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripTextBox toolStripTextBoxAboutProgram;
        private ToolStripMenuItem toolStripTextBoxStart;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemClear;
        private ToolStripMenuItem toolStripMenuItemClose;
        private ToolTip toolTip1;
    }
}
