
namespace Agac_Kutusu_Calismalari
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Birinci Antrenman");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("İkinci Antrenmen");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Üçüncü Antrenman");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Antrenmanlar", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button8 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(33, 130);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "Düğüm1";
            treeNode13.Text = "Birinci Antrenman";
            treeNode14.Name = "Düğüm2";
            treeNode14.Text = "İkinci Antrenmen";
            treeNode15.Name = "Düğüm3";
            treeNode15.Text = "Üçüncü Antrenman";
            treeNode16.Name = "Düğüm0";
            treeNode16.Text = "Antrenmanlar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(167, 280);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anakök ve Çocuk Kök Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kaldır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(289, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Taşı";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "Mesaj Kutusunda Göster";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(486, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "Çarpım Tablosu Ekleme";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(486, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 40);
            this.button7.TabIndex = 7;
            this.button7.Text = "İkinci Taşıma İşlemi";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(223, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ağaç Kutusu Çalışmaları";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(539, 421);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Fen Fakültesi, Fizik, Kimya, Biyoloji                                            " +
    "                                                              \nMühendislik, Bilg" +
    "isayar, Makine, Çevre";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "İstanbul ",
            "İzmir ",
            "Samsun"});
            this.listBox1.Location = new System.Drawing.Point(681, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 160);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Ceyhan",
            "Mamak",
            "Beyoğlu",
            "Bornova",
            "Çarşamba"});
            this.listBox2.Location = new System.Drawing.Point(681, 210);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 160);
            this.listBox2.TabIndex = 12;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(486, 370);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 40);
            this.button8.TabIndex = 13;
            this.button8.Text = "İlet ";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Ahmet",
            "Mehmet",
            "Hüseyin",
            "Salih",
            "Furkan",
            "Gökhan"});
            this.listBox3.Location = new System.Drawing.Point(889, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(150, 160);
            this.listBox3.TabIndex = 14;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(889, 210);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(150, 160);
            this.listBox4.TabIndex = 15;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(390, 451);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 40);
            this.button9.TabIndex = 16;
            this.button9.Text = "Üçüncü Taşıma İşlemi";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(33, 471);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(167, 20);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1070, 574);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

