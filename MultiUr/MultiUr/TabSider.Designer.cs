﻿namespace MultiUr
{
    partial class TabSider
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Timer = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button14 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Tim = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Tid.SuspendLayout();
            this.stopUr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Alarm.SuspendLayout();
            this.Timer.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.timer1.Tick += new System.EventHandler(this.DagsDato);
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
            this.tabControl1.Controls.Add(this.Alarm);
            this.tabControl1.Controls.Add(this.Timer);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 75);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 710);
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
            this.Tid.Size = new System.Drawing.Size(1125, 627);
            this.Tid.TabIndex = 0;
            this.Tid.Text = "Nuværende Tid";
            // 
            // stopUr
            // 
            this.stopUr.BackColor = System.Drawing.Color.RosyBrown;
            this.stopUr.Controls.Add(this.groupBox1);
            this.stopUr.Controls.Add(this.listView1);
            this.stopUr.Controls.Add(this.label3);
            this.stopUr.Controls.Add(this.label2);
            this.stopUr.Location = new System.Drawing.Point(4, 79);
            this.stopUr.Name = "stopUr";
            this.stopUr.Padding = new System.Windows.Forms.Padding(3);
            this.stopUr.Size = new System.Drawing.Size(1125, 627);
            this.stopUr.TabIndex = 1;
            this.stopUr.Text = "Stop Ur";
            this.stopUr.Click += new System.EventHandler(this.StopUr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(251, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 362);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stop Ur";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartStopUr);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 117);
            this.button3.TabIndex = 3;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ResetStopUr);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 117);
            this.button4.TabIndex = 7;
            this.button4.Text = "MARKER";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MarkerStopUr);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 117);
            this.button2.TabIndex = 2;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StopStopUr);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(820, 219);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(281, 361);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(621, 132);
            this.label3.TabIndex = 5;
            this.label3.Text = "00:00:00:000";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            // 
            // Alarm
            // 
            this.Alarm.BackColor = System.Drawing.Color.RosyBrown;
            this.Alarm.Controls.Add(this.button10);
            this.Alarm.Controls.Add(this.button9);
            this.Alarm.Controls.Add(this.button8);
            this.Alarm.Controls.Add(this.button7);
            this.Alarm.Controls.Add(this.listBox1);
            this.Alarm.Location = new System.Drawing.Point(4, 79);
            this.Alarm.Name = "Alarm";
            this.Alarm.Padding = new System.Windows.Forms.Padding(3);
            this.Alarm.Size = new System.Drawing.Size(1125, 627);
            this.Alarm.TabIndex = 3;
            this.Alarm.Text = "Alarm";
            this.Alarm.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(455, 309);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(230, 139);
            this.button10.TabIndex = 5;
            this.button10.Text = "Rediger Alarm";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RedigerAlarmKnap);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(745, 309);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(230, 139);
            this.button9.TabIndex = 4;
            this.button9.Text = "Slet Alle Alarmer";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SletAlleAlarmerKnap);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(745, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(230, 139);
            this.button8.TabIndex = 3;
            this.button8.Text = "Slet Alarm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SletAlarmKnap);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(455, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(230, 135);
            this.button7.TabIndex = 2;
            this.button7.Text = "Tilføj Alarm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.TilføjAlarmKnap);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(34, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 499);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // Timer
            // 
            this.Timer.BackColor = System.Drawing.Color.RosyBrown;
            this.Timer.Controls.Add(this.label11);
            this.Timer.Controls.Add(this.label10);
            this.Timer.Controls.Add(this.label9);
            this.Timer.Controls.Add(this.textBox3);
            this.Timer.Controls.Add(this.textBox2);
            this.Timer.Controls.Add(this.textBox1);
            this.Timer.Controls.Add(this.button6);
            this.Timer.Controls.Add(this.button5);
            this.Timer.Controls.Add(this.label8);
            this.Timer.Controls.Add(this.label7);
            this.Timer.Controls.Add(this.label6);
            this.Timer.Controls.Add(this.label5);
            this.Timer.Controls.Add(this.label4);
            this.Timer.Location = new System.Drawing.Point(4, 79);
            this.Timer.Name = "Timer";
            this.Timer.Padding = new System.Windows.Forms.Padding(3);
            this.Timer.Size = new System.Drawing.Size(1125, 627);
            this.Timer.TabIndex = 2;
            this.Timer.Text = "Timer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Indsæt Sekunder";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Indsæt Minutter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Indsæt Timer";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(688, 318);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 31);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(446, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 31);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 31);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(889, 344);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 105);
            this.button6.TabIndex = 6;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.StopTimerKnap);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(889, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 105);
            this.button5.TabIndex = 5;
            this.button5.Text = "Start";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.StartTimerKnap);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 85);
            this.label8.TabIndex = 4;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(362, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 85);
            this.label7.TabIndex = 3;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(675, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 85);
            this.label6.TabIndex = 2;
            this.label6.Text = "00";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 85);
            this.label5.TabIndex = 1;
            this.label5.Text = "00";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 85);
            this.label4.TabIndex = 0;
            this.label4.Text = "00";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.Tim);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 79);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1125, 627);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Flere Timer";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(567, 319);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(171, 164);
            this.button14.TabIndex = 13;
            this.button14.Text = "Start Timer";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.StartTimerFraListeKnap);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(288, 533);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(79, 33);
            this.comboBox3.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 533);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 533);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 33);
            this.comboBox1.TabIndex = 10;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(809, 44);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(168, 173);
            this.button13.TabIndex = 9;
            this.button13.Text = "SletTimer";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SletTimer);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(260, 533);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "S";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "M";
            // 
            // Tim
            // 
            this.Tim.AutoSize = true;
            this.Tim.Location = new System.Drawing.Point(23, 533);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(25, 25);
            this.Tim.TabIndex = 6;
            this.Tim.Text = "T";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(391, 533);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(98, 35);
            this.button12.TabIndex = 2;
            this.button12.Text = "Sæt Tid";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.SætEnTimer);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(567, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(171, 173);
            this.button11.TabIndex = 1;
            this.button11.Text = "Tilføj Timer";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ViTilføjerTilVoresListeKnap);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(54, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(313, 439);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 79);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 627);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "VisueltUr";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(109, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(843, 279);
            this.label15.TabIndex = 1;
            this.label15.Text = "1";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Black;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(28, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 33);
            this.label14.TabIndex = 0;
            this.label14.Text = "label14";
            this.label14.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.stopWatch);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.Timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.Timer5_Tick);
            // 
            // TabSider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1142, 734);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TabSider";
            this.Text = "Ur";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.TabSider_Shown);
            this.tabControl1.ResumeLayout(false);
            this.Tid.ResumeLayout(false);
            this.stopUr.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Alarm.ResumeLayout(false);
            this.Timer.ResumeLayout(false);
            this.Timer.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage Timer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Alarm;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Tim;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Timer timer5;
    }
}
