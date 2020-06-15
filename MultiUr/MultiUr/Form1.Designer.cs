namespace MultiUr
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TidNu = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tid = new System.Windows.Forms.TabPage();
            this.stopUr = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Tid.SuspendLayout();
            this.stopUr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuværende Klokke:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TidNu
            // 
            this.TidNu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TidNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TidNu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TidNu.Location = new System.Drawing.Point(499, 30);
            this.TidNu.Name = "TidNu";
            this.TidNu.Size = new System.Drawing.Size(541, 82);
            this.TidNu.TabIndex = 1;
            this.TidNu.Text = "TidNu";
            this.TidNu.Click += new System.EventHandler(this.TidNu_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tid);
            this.tabControl1.Controls.Add(this.stopUr);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 75);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 710);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Tag = "";
            // 
            // Tid
            // 
            this.Tid.BackColor = System.Drawing.Color.RosyBrown;
            this.Tid.Controls.Add(this.TidNu);
            this.Tid.Controls.Add(this.label1);
            this.Tid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tid.Location = new System.Drawing.Point(4, 79);
            this.Tid.Name = "Tid";
            this.Tid.Padding = new System.Windows.Forms.Padding(3);
            this.Tid.Size = new System.Drawing.Size(1107, 627);
            this.Tid.TabIndex = 0;
            this.Tid.Text = "Nuværende Tid";
            // 
            // stopUr
            // 
            this.stopUr.BackColor = System.Drawing.Color.RosyBrown;
            this.stopUr.Controls.Add(this.button4);
            this.stopUr.Controls.Add(this.listView1);
            this.stopUr.Controls.Add(this.label3);
            this.stopUr.Controls.Add(this.button3);
            this.stopUr.Controls.Add(this.button2);
            this.stopUr.Controls.Add(this.button1);
            this.stopUr.Controls.Add(this.label2);
            this.stopUr.Location = new System.Drawing.Point(4, 79);
            this.stopUr.Name = "stopUr";
            this.stopUr.Padding = new System.Windows.Forms.Padding(3);
            this.stopUr.Size = new System.Drawing.Size(1107, 627);
            this.stopUr.TabIndex = 1;
            this.stopUr.Text = "Stop Ur";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 117);
            this.button4.TabIndex = 7;
            this.button4.Text = "MARKER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(650, 219);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 361);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(960, 132);
            this.label3.TabIndex = 5;
            this.label3.Text = "00:00:00:000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 117);
            this.button3.TabIndex = 3;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 117);
            this.button2.TabIndex = 2;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1139, 734);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ur";
            this.tabControl1.ResumeLayout(false);
            this.Tid.ResumeLayout(false);
            this.stopUr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TidNu;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tid;
        private System.Windows.Forms.TabPage stopUr;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
    }
}

