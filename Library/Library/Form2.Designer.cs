namespace Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox_Serier = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeries_Tilføj = new System.Windows.Forms.Button();
            this.btnSeries_Videre = new System.Windows.Forms.Button();
            this.btnSeries_Save = new System.Windows.Forms.Button();
            this.textBox_Series = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SeriesFjern = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Serier
            // 
            this.listBox_Serier.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Serier.FormattingEnabled = true;
            this.listBox_Serier.ItemHeight = 24;
            this.listBox_Serier.Location = new System.Drawing.Point(404, 132);
            this.listBox_Serier.Name = "listBox_Serier";
            this.listBox_Serier.Size = new System.Drawing.Size(211, 412);
            this.listBox_Serier.TabIndex = 0;
            this.listBox_Serier.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBox_Serier_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btnSeries_Tilføj
            // 
            this.btnSeries_Tilføj.BackColor = System.Drawing.Color.Orange;
            this.btnSeries_Tilføj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries_Tilføj.Location = new System.Drawing.Point(12, 238);
            this.btnSeries_Tilføj.Name = "btnSeries_Tilføj";
            this.btnSeries_Tilføj.Size = new System.Drawing.Size(174, 78);
            this.btnSeries_Tilføj.TabIndex = 2;
            this.btnSeries_Tilføj.Text = "Tilføj!";
            this.btnSeries_Tilføj.UseVisualStyleBackColor = false;
            this.btnSeries_Tilføj.Click += new System.EventHandler(this.BtnSeries_Tilføj_Click);
            // 
            // btnSeries_Videre
            // 
            this.btnSeries_Videre.BackColor = System.Drawing.Color.Olive;
            this.btnSeries_Videre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries_Videre.Location = new System.Drawing.Point(12, 490);
            this.btnSeries_Videre.Name = "btnSeries_Videre";
            this.btnSeries_Videre.Size = new System.Drawing.Size(174, 78);
            this.btnSeries_Videre.TabIndex = 3;
            this.btnSeries_Videre.Text = "Videre!";
            this.btnSeries_Videre.UseVisualStyleBackColor = false;
            // 
            // btnSeries_Save
            // 
            this.btnSeries_Save.BackColor = System.Drawing.Color.Khaki;
            this.btnSeries_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries_Save.Location = new System.Drawing.Point(12, 406);
            this.btnSeries_Save.Name = "btnSeries_Save";
            this.btnSeries_Save.Size = new System.Drawing.Size(174, 78);
            this.btnSeries_Save.TabIndex = 4;
            this.btnSeries_Save.Text = "Save";
            this.btnSeries_Save.UseVisualStyleBackColor = false;
            this.btnSeries_Save.Click += new System.EventHandler(this.BtnSeries_Save_Click);
            // 
            // textBox_Series
            // 
            this.textBox_Series.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Series.Location = new System.Drawing.Point(12, 176);
            this.textBox_Series.Multiline = true;
            this.textBox_Series.Name = "textBox_Series";
            this.textBox_Series.Size = new System.Drawing.Size(220, 44);
            this.textBox_Series.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Skriv navnet på den serie der skal tilføjes";
            // 
            // btn_SeriesFjern
            // 
            this.btn_SeriesFjern.BackColor = System.Drawing.Color.Peru;
            this.btn_SeriesFjern.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeriesFjern.Location = new System.Drawing.Point(12, 322);
            this.btn_SeriesFjern.Name = "btn_SeriesFjern";
            this.btn_SeriesFjern.Size = new System.Drawing.Size(174, 78);
            this.btn_SeriesFjern.TabIndex = 7;
            this.btn_SeriesFjern.Text = "Fjern";
            this.btn_SeriesFjern.UseVisualStyleBackColor = false;
            this.btn_SeriesFjern.Click += new System.EventHandler(this.Btn_SeriesFjern_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(404, 76);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(211, 31);
            this.textBox_Search.TabIndex = 8;
            this.textBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Searchbar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(627, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.btn_SeriesFjern);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Series);
            this.Controls.Add(this.btnSeries_Save);
            this.Controls.Add(this.btnSeries_Videre);
            this.Controls.Add(this.btnSeries_Tilføj);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox_Serier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Serier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSeries_Tilføj;
        private System.Windows.Forms.Button btnSeries_Videre;
        private System.Windows.Forms.Button btnSeries_Save;
        private System.Windows.Forms.TextBox textBox_Series;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SeriesFjern;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label2;
    }
}