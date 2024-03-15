namespace microservice_project
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            ButtonLogin = new Button();
            passwordInput = new TextBox();
            pictureBox2 = new PictureBox();
            LoginInput = new TextBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LoggingInToARecord = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(ButtonLogin);
            panel1.Controls.Add(passwordInput);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(LoginInput);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 477);
            panel1.TabIndex = 0;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogin.Location = new Point(182, 347);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(198, 59);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Войти";
            ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(182, 224);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(257, 59);
            passwordInput.TabIndex = 4;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = Properties.Resources._8664831_user_icon;
            pictureBox2.Image = Properties.Resources._3643755_hide_lock_locked_padlock_private_icon;
            pictureBox2.Location = new Point(78, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // LoginInput
            // 
            LoginInput.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoginInput.Location = new Point(182, 137);
            LoginInput.Multiline = true;
            LoginInput.Name = "LoginInput";
            LoginInput.Size = new Size(257, 64);
            LoginInput.TabIndex = 2;
            LoginInput.TextChanged += LoginInput_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources._8664831_user_icon;
            pictureBox1.Image = Properties.Resources._8664831_user_icon;
            pictureBox1.Location = new Point(78, 137);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(LoggingInToARecord);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(565, 101);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // LoggingInToARecord
            // 
            LoggingInToARecord.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            LoggingInToARecord.Location = new Point(3, 0);
            LoggingInToARecord.Name = "LoggingInToARecord";
            LoggingInToARecord.Size = new Size(558, 79);
            LoggingInToARecord.TabIndex = 0;
            LoggingInToARecord.Text = "Вход в учётную запись";
            LoggingInToARecord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 477);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LoggingInToARecord;
        private PictureBox pictureBox1;
        private TextBox LoginInput;
        private TextBox passwordInput;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private Button ButtonLogin;
    }
}