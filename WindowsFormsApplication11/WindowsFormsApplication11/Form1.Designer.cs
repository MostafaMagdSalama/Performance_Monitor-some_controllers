namespace WindowsFormsApplication11
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cpucounter = new System.Diagnostics.PerformanceCounter();
            this.ramcounter = new System.Diagnostics.PerformanceCounter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.endprocrs = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.startprocrss = new System.Windows.Forms.PictureBox();
            this.startp = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Recyclebin = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uninstaller = new System.Windows.Forms.PictureBox();
            this.shutdown = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpubar = new MetroFramework.Controls.MetroProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.rambar = new MetroFramework.Controls.MetroProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.memorybar = new MetroFramework.Controls.MetroProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpuper = new System.Windows.Forms.Label();
            this.ramper = new System.Windows.Forms.Label();
            this.memoryper = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpucounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramcounter)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startprocrss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recyclebin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uninstaller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdown)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 55);
            this.panel1.TabIndex = 10000;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // close
            // 
            this.close.Image = global::WindowsFormsApplication11.Properties.Resources.close__2_;
            this.close.Location = new System.Drawing.Point(837, 18);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 39);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(385, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Performance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_computer_48;
            this.pictureBox1.Location = new System.Drawing.Point(320, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(198, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 498);
            this.tabControl1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 488);
            this.panel2.TabIndex = 5000;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 100);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "MONITOR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.pictureBox2.Location = new System.Drawing.Point(144, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 47);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPU&&RAM";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.shutdown);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.uninstaller);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.Recyclebin);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.startprocrss);
            this.tabPage2.Controls.Add(this.startp);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.endprocrs);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cpucounter
            // 
            this.cpucounter.CategoryName = "processor";
            this.cpucounter.CounterName = "% Processor Time";
            this.cpucounter.InstanceName = "_Total";
            // 
            // ramcounter
            // 
            this.ramcounter.CategoryName = "Memory";
            this.ramcounter.CounterName = "% Committed Bytes In Use";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(82)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(0, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 100);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.pictureBox3.Location = new System.Drawing.Point(144, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 47);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(4, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 28);
            this.label11.TabIndex = 3;
            this.label11.Text = "Controllers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label10.Location = new System.Drawing.Point(266, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Start Process";
            // 
            // endprocrs
            // 
            this.endprocrs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.endprocrs.CustomButton.Image = null;
            this.endprocrs.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.endprocrs.CustomButton.Name = "";
            this.endprocrs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.endprocrs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.endprocrs.CustomButton.TabIndex = 1;
            this.endprocrs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.endprocrs.CustomButton.UseSelectable = true;
            this.endprocrs.CustomButton.Visible = false;
            this.endprocrs.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.endprocrs.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.endprocrs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.endprocrs.Lines = new string[0];
            this.endprocrs.Location = new System.Drawing.Point(445, 268);
            this.endprocrs.MaxLength = 32767;
            this.endprocrs.Name = "endprocrs";
            this.endprocrs.PasswordChar = '\0';
            this.endprocrs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.endprocrs.SelectedText = "";
            this.endprocrs.SelectionLength = 0;
            this.endprocrs.SelectionStart = 0;
            this.endprocrs.ShortcutsEnabled = true;
            this.endprocrs.Size = new System.Drawing.Size(122, 23);
            this.endprocrs.TabIndex = 6;
            this.endprocrs.UseCustomBackColor = true;
            this.endprocrs.UseCustomForeColor = true;
            this.endprocrs.UseSelectable = true;
            this.endprocrs.UseStyleColors = true;
            this.endprocrs.WaterMarkColor = System.Drawing.Color.White;
            this.endprocrs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.pictureBox4.Location = new System.Drawing.Point(594, 250);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 47);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // startprocrss
            // 
            this.startprocrss.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.startprocrss.Location = new System.Drawing.Point(592, 123);
            this.startprocrss.Name = "startprocrss";
            this.startprocrss.Size = new System.Drawing.Size(48, 47);
            this.startprocrss.TabIndex = 7;
            this.startprocrss.TabStop = false;
            this.startprocrss.Click += new System.EventHandler(this.startprocrss_Click);
            // 
            // startp
            // 
            this.startp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.startp.CustomButton.Image = null;
            this.startp.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.startp.CustomButton.Name = "";
            this.startp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.startp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.startp.CustomButton.TabIndex = 1;
            this.startp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.startp.CustomButton.UseSelectable = true;
            this.startp.CustomButton.Visible = false;
            this.startp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.startp.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.startp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.startp.Lines = new string[0];
            this.startp.Location = new System.Drawing.Point(445, 136);
            this.startp.MaxLength = 32767;
            this.startp.Name = "startp";
            this.startp.PasswordChar = '\0';
            this.startp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.startp.SelectedText = "";
            this.startp.SelectionLength = 0;
            this.startp.SelectionStart = 0;
            this.startp.ShortcutsEnabled = true;
            this.startp.Size = new System.Drawing.Size(122, 23);
            this.startp.TabIndex = 9;
            this.startp.UseCustomBackColor = true;
            this.startp.UseCustomForeColor = true;
            this.startp.UseSelectable = true;
            this.startp.UseStyleColors = true;
            this.startp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.startp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label12.Location = new System.Drawing.Point(266, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 28);
            this.label12.TabIndex = 8;
            this.label12.Text = "End Process";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label13.Location = new System.Drawing.Point(9, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(219, 28);
            this.label13.TabIndex = 10;
            this.label13.Text = "Clear Recycle Bin";
            // 
            // Recyclebin
            // 
            this.Recyclebin.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.Recyclebin.Location = new System.Drawing.Point(252, 50);
            this.Recyclebin.Name = "Recyclebin";
            this.Recyclebin.Size = new System.Drawing.Size(48, 47);
            this.Recyclebin.TabIndex = 11;
            this.Recyclebin.TabStop = false;
            this.Recyclebin.Click += new System.EventHandler(this.Recyclebin_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label14.Location = new System.Drawing.Point(3, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 28);
            this.label14.TabIndex = 12;
            this.label14.Text = "Open Uninstaller";
            // 
            // uninstaller
            // 
            this.uninstaller.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.uninstaller.Location = new System.Drawing.Point(252, 186);
            this.uninstaller.Name = "uninstaller";
            this.uninstaller.Size = new System.Drawing.Size(48, 47);
            this.uninstaller.TabIndex = 13;
            this.uninstaller.TabStop = false;
            this.uninstaller.Click += new System.EventHandler(this.uninstaller_Click);
            // 
            // shutdown
            // 
            this.shutdown.Image = global::WindowsFormsApplication11.Properties.Resources.icons8_forward_48__3_;
            this.shutdown.Location = new System.Drawing.Point(252, 333);
            this.shutdown.Name = "shutdown";
            this.shutdown.Size = new System.Drawing.Size(48, 47);
            this.shutdown.TabIndex = 15;
            this.shutdown.TabStop = false;
            this.shutdown.Click += new System.EventHandler(this.shutdown_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label15.Location = new System.Drawing.Point(3, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(200, 28);
            this.label15.TabIndex = 14;
            this.label15.Text = "Force Shutdown";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label4.Location = new System.Drawing.Point(42, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPU";
            // 
            // cpubar
            // 
            this.cpubar.Location = new System.Drawing.Point(47, 80);
            this.cpubar.Name = "cpubar";
            this.cpubar.Size = new System.Drawing.Size(506, 53);
            this.cpubar.Style = MetroFramework.MetroColorStyle.Blue;
            this.cpubar.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(42, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "RAM";
            // 
            // rambar
            // 
            this.rambar.Location = new System.Drawing.Point(47, 205);
            this.rambar.Name = "rambar";
            this.rambar.Size = new System.Drawing.Size(506, 50);
            this.rambar.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.label6.Location = new System.Drawing.Point(60, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "C";
            // 
            // memorybar
            // 
            this.memorybar.Location = new System.Drawing.Point(47, 334);
            this.memorybar.Name = "memorybar";
            this.memorybar.Size = new System.Drawing.Size(506, 54);
            this.memorybar.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(108, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(108, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(108, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = ":";
            // 
            // cpuper
            // 
            this.cpuper.AutoSize = true;
            this.cpuper.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.cpuper.Location = new System.Drawing.Point(593, 89);
            this.cpuper.Name = "cpuper";
            this.cpuper.Size = new System.Drawing.Size(16, 22);
            this.cpuper.TabIndex = 14;
            this.cpuper.Text = ":";
            // 
            // ramper
            // 
            this.ramper.AutoSize = true;
            this.ramper.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.ramper.Location = new System.Drawing.Point(593, 217);
            this.ramper.Name = "ramper";
            this.ramper.Size = new System.Drawing.Size(16, 22);
            this.ramper.TabIndex = 15;
            this.ramper.Text = ":";
            // 
            // memoryper
            // 
            this.memoryper.AutoSize = true;
            this.memoryper.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.memoryper.Location = new System.Drawing.Point(592, 350);
            this.memoryper.Name = "memoryper";
            this.memoryper.Size = new System.Drawing.Size(16, 22);
            this.memoryper.TabIndex = 16;
            this.memoryper.Text = ":";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.memoryper);
            this.tabPage1.Controls.Add(this.ramper);
            this.tabPage1.Controls.Add(this.cpuper);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.memorybar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rambar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cpubar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpucounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramcounter)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startprocrss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Recyclebin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uninstaller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shutdown)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter cpucounter;
        private System.Diagnostics.PerformanceCounter ramcounter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox Recyclebin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox startprocrss;
        private MetroFramework.Controls.MetroTextBox startp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroTextBox endprocrs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox uninstaller;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox shutdown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label memoryper;
        private System.Windows.Forms.Label ramper;
        private System.Windows.Forms.Label cpuper;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroProgressBar memorybar;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroProgressBar rambar;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroProgressBar cpubar;
        private System.Windows.Forms.Label label4;
    }
}

