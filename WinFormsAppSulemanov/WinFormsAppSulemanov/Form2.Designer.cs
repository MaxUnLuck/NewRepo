namespace WinFormsAppSulemanov
{
    partial class Form2
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
            labelEmail = new Label();
            label1 = new Label();
            labelNameCreator = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(6, 49);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(56, 15);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Контакт: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Специальность: ИСПд";
            // 
            // labelNameCreator
            // 
            labelNameCreator.AutoSize = true;
            labelNameCreator.Location = new Point(6, 19);
            labelNameCreator.Name = "labelNameCreator";
            labelNameCreator.Size = new Size(173, 15);
            labelNameCreator.TabIndex = 3;
            labelNameCreator.Text = "Разработал: Сулейманов М.А.";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelNameCreator);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Location = new Point(12, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 73);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Информация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 64);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "D:\\Users\\1213-3\\Documents\\2-ИСПд\\Сулейманов\\WindowsForms 1/Talant.jpg";
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 222);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 322);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(89, 27);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "Назад";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(63, 49);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(157, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://t.me/BackSpacePeek";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(244, 361);
            Controls.Add(buttonClose);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            MaximumSize = new Size(260, 400);
            MinimumSize = new Size(260, 400);
            Name = "Form2";
            Text = "О программе";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label labelEmail;
        private Label label1;
        private Label labelNameCreator;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Button buttonClose;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}