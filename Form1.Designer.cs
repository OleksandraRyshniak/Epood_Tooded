namespace Epood_Tooded
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
            dataGridView1 = new DataGridView();
            Toode_pb = new PictureBox();
            lbl_toode = new Label();
            lbl_kogus = new Label();
            lbl_hind = new Label();
            lbl_kateg = new Label();
            Toode_txt = new TextBox();
            Kogus_txt = new TextBox();
            Hind_txt = new TextBox();
            Lisa_Kat_btn = new Button();
            kustuta_btn = new Button();
            Uuenda_btn = new Button();
            Lisa_btn = new Button();
            otsi_fail_btn = new Button();
            puhasta_btn = new Button();
            kust_btn = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            tb_pood = new TextBox();
            Kat_box = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Toode_pb).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 370);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(735, 221);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // Toode_pb
            // 
            Toode_pb.Location = new Point(46, 34);
            Toode_pb.Name = "Toode_pb";
            Toode_pb.Size = new Size(266, 234);
            Toode_pb.TabIndex = 1;
            Toode_pb.TabStop = false;
            // 
            // lbl_toode
            // 
            lbl_toode.AutoSize = true;
            lbl_toode.Location = new Point(384, 34);
            lbl_toode.Name = "lbl_toode";
            lbl_toode.Size = new Size(40, 15);
            lbl_toode.TabIndex = 2;
            lbl_toode.Text = "Toode";
            // 
            // lbl_kogus
            // 
            lbl_kogus.AutoSize = true;
            lbl_kogus.Location = new Point(384, 80);
            lbl_kogus.Name = "lbl_kogus";
            lbl_kogus.Size = new Size(40, 15);
            lbl_kogus.TabIndex = 3;
            lbl_kogus.Text = "Kogus";
            // 
            // lbl_hind
            // 
            lbl_hind.AutoSize = true;
            lbl_hind.Location = new Point(384, 133);
            lbl_hind.Name = "lbl_hind";
            lbl_hind.Size = new Size(33, 15);
            lbl_hind.TabIndex = 4;
            lbl_hind.Text = "Hind";
            // 
            // lbl_kateg
            // 
            lbl_kateg.AutoSize = true;
            lbl_kateg.Location = new Point(384, 186);
            lbl_kateg.Name = "lbl_kateg";
            lbl_kateg.Size = new Size(71, 15);
            lbl_kateg.TabIndex = 5;
            lbl_kateg.Text = "Kategooriad";
            // 
            // Toode_txt
            // 
            Toode_txt.Location = new Point(488, 34);
            Toode_txt.Name = "Toode_txt";
            Toode_txt.Size = new Size(152, 23);
            Toode_txt.TabIndex = 6;
            // 
            // Kogus_txt
            // 
            Kogus_txt.Location = new Point(488, 80);
            Kogus_txt.Name = "Kogus_txt";
            Kogus_txt.Size = new Size(152, 23);
            Kogus_txt.TabIndex = 7;
            // 
            // Hind_txt
            // 
            Hind_txt.Location = new Point(488, 130);
            Hind_txt.Name = "Hind_txt";
            Hind_txt.Size = new Size(152, 23);
            Hind_txt.TabIndex = 8;
            // 
            // Lisa_Kat_btn
            // 
            Lisa_Kat_btn.Location = new Point(384, 225);
            Lisa_Kat_btn.Name = "Lisa_Kat_btn";
            Lisa_Kat_btn.Size = new Size(127, 29);
            Lisa_Kat_btn.TabIndex = 10;
            Lisa_Kat_btn.Text = "Lisa kategooriat";
            Lisa_Kat_btn.UseVisualStyleBackColor = true;
            Lisa_Kat_btn.Click += Lisa_Kat_btn_Click;
            // 
            // kustuta_btn
            // 
            kustuta_btn.Location = new Point(517, 225);
            kustuta_btn.Name = "kustuta_btn";
            kustuta_btn.Size = new Size(126, 29);
            kustuta_btn.TabIndex = 11;
            kustuta_btn.Text = "Kustuta kategooriat";
            kustuta_btn.UseVisualStyleBackColor = true;
            kustuta_btn.Click += kustuta_btn_Click;
            // 
            // Uuenda_btn
            // 
            Uuenda_btn.Location = new Point(459, 260);
            Uuenda_btn.Name = "Uuenda_btn";
            Uuenda_btn.Size = new Size(73, 29);
            Uuenda_btn.TabIndex = 12;
            Uuenda_btn.Text = "Uuenda";
            Uuenda_btn.UseVisualStyleBackColor = true;
            // 
            // Lisa_btn
            // 
            Lisa_btn.Location = new Point(384, 260);
            Lisa_btn.Name = "Lisa_btn";
            Lisa_btn.Size = new Size(69, 29);
            Lisa_btn.TabIndex = 13;
            Lisa_btn.Text = "Lisa";
            Lisa_btn.UseVisualStyleBackColor = true;
            Lisa_btn.Click += Lisa_btn_Click;
            // 
            // otsi_fail_btn
            // 
            otsi_fail_btn.Location = new Point(46, 283);
            otsi_fail_btn.Name = "otsi_fail_btn";
            otsi_fail_btn.Size = new Size(79, 29);
            otsi_fail_btn.TabIndex = 14;
            otsi_fail_btn.Text = "Otsi fail";
            otsi_fail_btn.UseVisualStyleBackColor = true;
            otsi_fail_btn.Click += otsi_fail_btn_Click;
            // 
            // puhasta_btn
            // 
            puhasta_btn.Location = new Point(622, 260);
            puhasta_btn.Name = "puhasta_btn";
            puhasta_btn.Size = new Size(74, 29);
            puhasta_btn.TabIndex = 15;
            puhasta_btn.Text = "Puhasta";
            puhasta_btn.UseVisualStyleBackColor = true;
            // 
            // kust_btn
            // 
            kust_btn.Location = new Point(538, 260);
            kust_btn.Name = "kust_btn";
            kust_btn.Size = new Size(78, 29);
            kust_btn.TabIndex = 16;
            kust_btn.Text = "Kustuta";
            kust_btn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(46, 318);
            button8.Name = "button8";
            button8.Size = new Size(79, 29);
            button8.TabIndex = 17;
            button8.Text = "Maksta";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(131, 283);
            button9.Name = "button9";
            button9.Size = new Size(69, 29);
            button9.TabIndex = 18;
            button9.Text = "Valin";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(131, 318);
            button10.Name = "button10";
            button10.Size = new Size(69, 29);
            button10.TabIndex = 19;
            button10.Text = "Ostan";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(206, 283);
            button11.Name = "button11";
            button11.Size = new Size(79, 29);
            button11.TabIndex = 20;
            button11.Text = "Saada arve";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(206, 318);
            button12.Name = "button12";
            button12.Size = new Size(79, 29);
            button12.TabIndex = 21;
            button12.Text = "Pood";
            button12.UseVisualStyleBackColor = true;
            // 
            // tb_pood
            // 
            tb_pood.Location = new Point(291, 322);
            tb_pood.Name = "tb_pood";
            tb_pood.Size = new Size(154, 23);
            tb_pood.TabIndex = 22;
            tb_pood.TextChanged += textBox4_TextChanged;
            // 
            // Kat_box
            // 
            Kat_box.FormattingEnabled = true;
            Kat_box.Location = new Point(488, 178);
            Kat_box.Name = "Kat_box";
            Kat_box.Size = new Size(152, 23);
            Kat_box.TabIndex = 23;
            Kat_box.SelectedIndexChanged += Kat_box_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 603);
            Controls.Add(Kat_box);
            Controls.Add(tb_pood);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(kust_btn);
            Controls.Add(puhasta_btn);
            Controls.Add(otsi_fail_btn);
            Controls.Add(Lisa_btn);
            Controls.Add(Uuenda_btn);
            Controls.Add(kustuta_btn);
            Controls.Add(Lisa_Kat_btn);
            Controls.Add(Hind_txt);
            Controls.Add(Kogus_txt);
            Controls.Add(Toode_txt);
            Controls.Add(lbl_kateg);
            Controls.Add(lbl_hind);
            Controls.Add(lbl_kogus);
            Controls.Add(lbl_toode);
            Controls.Add(Toode_pb);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Toode_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox Toode_pb;
        private Label lbl_toode;
        private Label lbl_kogus;
        private Label lbl_hind;
        private Label lbl_kateg;
        private TextBox Toode_txt;
        private TextBox Kogus_txt;
        private TextBox Hind_txt;
        private Button Lisa_Kat_btn;
        private Button kustuta_btn;
        private Button Uuenda_btn;
        private Button Lisa_btn;
        private Button otsi_fail_btn;
        private Button puhasta_btn;
        private Button kust_btn;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox tb_pood;
        private ComboBox Kat_box;
    }
}
