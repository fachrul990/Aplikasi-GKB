namespace WindowsFormsApp1
{
    partial class game
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.batu = new System.Windows.Forms.PictureBox();
            this.kertas = new System.Windows.Forms.PictureBox();
            this.gunting = new System.Windows.Forms.PictureBox();
            this.winscore = new System.Windows.Forms.Label();
            this.tiesscore = new System.Windows.Forms.Label();
            this.winscorecpu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kertascpu = new System.Windows.Forms.PictureBox();
            this.kertasp = new System.Windows.Forms.PictureBox();
            this.batucpu = new System.Windows.Forms.PictureBox();
            this.batup = new System.Windows.Forms.PictureBox();
            this.guntingcpu = new System.Windows.Forms.PictureBox();
            this.guntingp = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.round = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.batu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kertascpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kertasp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batucpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guntingcpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guntingp)).BeginInit();
            this.SuspendLayout();
            // 
            // batu
            // 
            this.batu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batu.Image = ((System.Drawing.Image)(resources.GetObject("batu.Image")));
            this.batu.Location = new System.Drawing.Point(301, 491);
            this.batu.Name = "batu";
            this.batu.Size = new System.Drawing.Size(81, 58);
            this.batu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batu.TabIndex = 23;
            this.batu.TabStop = false;
            this.batu.Click += new System.EventHandler(this.batu_Click);
            // 
            // kertas
            // 
            this.kertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kertas.Image = ((System.Drawing.Image)(resources.GetObject("kertas.Image")));
            this.kertas.Location = new System.Drawing.Point(186, 491);
            this.kertas.Name = "kertas";
            this.kertas.Size = new System.Drawing.Size(81, 58);
            this.kertas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kertas.TabIndex = 24;
            this.kertas.TabStop = false;
            this.kertas.Click += new System.EventHandler(this.kertas_Click);
            // 
            // gunting
            // 
            this.gunting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunting.Image = ((System.Drawing.Image)(resources.GetObject("gunting.Image")));
            this.gunting.Location = new System.Drawing.Point(73, 491);
            this.gunting.Name = "gunting";
            this.gunting.Size = new System.Drawing.Size(81, 58);
            this.gunting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunting.TabIndex = 25;
            this.gunting.TabStop = false;
            this.gunting.Click += new System.EventHandler(this.gunting_Click);
            // 
            // winscore
            // 
            this.winscore.AutoSize = true;
            this.winscore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winscore.Location = new System.Drawing.Point(214, 113);
            this.winscore.Name = "winscore";
            this.winscore.Size = new System.Drawing.Size(21, 23);
            this.winscore.TabIndex = 19;
            this.winscore.Text = "0";
            // 
            // tiesscore
            // 
            this.tiesscore.AutoSize = true;
            this.tiesscore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesscore.Location = new System.Drawing.Point(529, 113);
            this.tiesscore.Name = "tiesscore";
            this.tiesscore.Size = new System.Drawing.Size(21, 23);
            this.tiesscore.TabIndex = 20;
            this.tiesscore.Text = "0";
            // 
            // winscorecpu
            // 
            this.winscorecpu.AutoSize = true;
            this.winscorecpu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winscorecpu.Location = new System.Drawing.Point(845, 113);
            this.winscorecpu.Name = "winscorecpu";
            this.winscorecpu.Size = new System.Drawing.Size(21, 23);
            this.winscorecpu.TabIndex = 21;
            this.winscorecpu.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(831, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "WIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "TIES";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "WIN";
            // 
            // kertascpu
            // 
            this.kertascpu.Image = ((System.Drawing.Image)(resources.GetObject("kertascpu.Image")));
            this.kertascpu.Location = new System.Drawing.Point(699, 189);
            this.kertascpu.Name = "kertascpu";
            this.kertascpu.Size = new System.Drawing.Size(309, 230);
            this.kertascpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kertascpu.TabIndex = 16;
            this.kertascpu.TabStop = false;
            // 
            // kertasp
            // 
            this.kertasp.Image = ((System.Drawing.Image)(resources.GetObject("kertasp.Image")));
            this.kertasp.Location = new System.Drawing.Point(73, 189);
            this.kertasp.Name = "kertasp";
            this.kertasp.Size = new System.Drawing.Size(309, 230);
            this.kertasp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kertasp.TabIndex = 15;
            this.kertasp.TabStop = false;
            // 
            // batucpu
            // 
            this.batucpu.Image = ((System.Drawing.Image)(resources.GetObject("batucpu.Image")));
            this.batucpu.Location = new System.Drawing.Point(699, 189);
            this.batucpu.Name = "batucpu";
            this.batucpu.Size = new System.Drawing.Size(309, 230);
            this.batucpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batucpu.TabIndex = 14;
            this.batucpu.TabStop = false;
            // 
            // batup
            // 
            this.batup.Image = ((System.Drawing.Image)(resources.GetObject("batup.Image")));
            this.batup.Location = new System.Drawing.Point(73, 189);
            this.batup.Name = "batup";
            this.batup.Size = new System.Drawing.Size(309, 230);
            this.batup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batup.TabIndex = 13;
            this.batup.TabStop = false;
            // 
            // guntingcpu
            // 
            this.guntingcpu.Image = ((System.Drawing.Image)(resources.GetObject("guntingcpu.Image")));
            this.guntingcpu.Location = new System.Drawing.Point(699, 189);
            this.guntingcpu.Name = "guntingcpu";
            this.guntingcpu.Size = new System.Drawing.Size(309, 230);
            this.guntingcpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guntingcpu.TabIndex = 12;
            this.guntingcpu.TabStop = false;
            // 
            // guntingp
            // 
            this.guntingp.Image = ((System.Drawing.Image)(resources.GetObject("guntingp.Image")));
            this.guntingp.Location = new System.Drawing.Point(73, 189);
            this.guntingp.Name = "guntingp";
            this.guntingp.Size = new System.Drawing.Size(309, 230);
            this.guntingp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guntingp.TabIndex = 11;
            this.guntingp.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "ROUND";
            this.label5.Click += new System.EventHandler(this.Label3_Click);
            // 
            // round
            // 
            this.round.AutoSize = true;
            this.round.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round.Location = new System.Drawing.Point(576, 189);
            this.round.Name = "round";
            this.round.Size = new System.Drawing.Size(21, 23);
            this.round.TabIndex = 18;
            this.round.Text = "0";
            this.round.Click += new System.EventHandler(this.Label3_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(488, 263);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(109, 23);
            this.result.TabIndex = 18;
            this.result.Text = "-";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.result.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLAYER";
            this.label1.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(831, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "CPU";
            this.label6.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(699, 491);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(309, 58);
            this.textBox1.TabIndex = 26;
            this.textBox1.TabStop = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "RESTART";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.batu);
            this.Controls.Add(this.kertas);
            this.Controls.Add(this.gunting);
            this.Controls.Add(this.winscore);
            this.Controls.Add(this.tiesscore);
            this.Controls.Add(this.winscorecpu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.round);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kertascpu);
            this.Controls.Add(this.kertasp);
            this.Controls.Add(this.batucpu);
            this.Controls.Add(this.batup);
            this.Controls.Add(this.guntingcpu);
            this.Controls.Add(this.guntingp);
            this.Name = "game";
            this.Size = new System.Drawing.Size(1080, 600);
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kertascpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kertasp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batucpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guntingcpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guntingp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox batu;
        private System.Windows.Forms.PictureBox kertas;
        public System.Windows.Forms.PictureBox gunting;
        public System.Windows.Forms.Label winscore;
        private System.Windows.Forms.Label tiesscore;
        private System.Windows.Forms.Label winscorecpu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kertascpu;
        private System.Windows.Forms.PictureBox kertasp;
        private System.Windows.Forms.PictureBox batucpu;
        private System.Windows.Forms.PictureBox batup;
        private System.Windows.Forms.PictureBox guntingcpu;
        private System.Windows.Forms.PictureBox guntingp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label round;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
    }
}
