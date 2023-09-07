namespace Calculator
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
            menuStrip1 = new MenuStrip();
            gToolStripMenuItem = new ToolStripMenuItem();
            greutateToolStripMenuItem = new ToolStripMenuItem();
            temperaturaToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(360, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gToolStripMenuItem
            // 
            gToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { greutateToolStripMenuItem, temperaturaToolStripMenuItem, exitToolStripMenuItem, exitToolStripMenuItem1 });
            gToolStripMenuItem.Name = "gToolStripMenuItem";
            gToolStripMenuItem.Size = new Size(87, 24);
            gToolStripMenuItem.Text = "Conversie";
            // 
            // greutateToolStripMenuItem
            // 
            greutateToolStripMenuItem.Image = Properties.Resources.scales_uaw_kobol_9;
            greutateToolStripMenuItem.Name = "greutateToolStripMenuItem";
            greutateToolStripMenuItem.Size = new Size(224, 26);
            greutateToolStripMenuItem.Text = "Greutate";
            greutateToolStripMenuItem.Click += greutateToolStripMenuItem_Click;
            // 
            // temperaturaToolStripMenuItem
            // 
            temperaturaToolStripMenuItem.Image = Properties.Resources.Thermometer_icon;
            temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            temperaturaToolStripMenuItem.Size = new Size(224, 26);
            temperaturaToolStripMenuItem.Text = "Temperatura";
            temperaturaToolStripMenuItem.Click += temperaturaToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.pngimg_com___ruler_PNG65;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Lungime";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(224, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kilograme", "Grame", "Uncii", "Livre" });
            comboBox1.Location = new Point(25, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Tag = "";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Kilograme", "Grame", "Uncii", "Livre" });
            comboBox2.Location = new Point(209, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 120);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(126, 214);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 5;
            button1.Text = "Converteste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 260);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Calculator Convertor";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gToolStripMenuItem;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private ToolStripMenuItem greutateToolStripMenuItem;
        private ToolStripMenuItem temperaturaToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
    }
}
