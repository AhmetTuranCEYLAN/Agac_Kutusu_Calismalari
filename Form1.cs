using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agac_Kutusu_Calismalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode anakok = treeView1.Nodes.Add("İktisadi ve İdari Bilimler Fakültesi");
            
            anakok.Nodes.Add("İşletme");
            anakok.Nodes.Add("İktisat");
            anakok.Nodes.Add("Muhasebe");

            TreeNode altkok = anakok.Nodes.Add("Yönetim Bilişim Sistemleri");
            altkok.Nodes.Add("Gündüz");
            altkok.Nodes.Add("Gece");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode ekle = treeView1.SelectedNode;
            ekle.Nodes.Add("Gündüz");
            ekle.Nodes.Add("Gece");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                var satir = richTextBox1.Lines[i].Split(',');
                var kok = treeView1.Nodes.Add(satir[0]);

                for (int j = 1; j <satir.Length; j++)
                {
                    kok.Nodes.Add(satir[j]);
                }
            }
           

            
         
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <treeView1.Nodes.Count; i++)
            {
                MessageBox.Show(treeView1.Nodes[i].Text);

                for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                {
                    MessageBox.Show(treeView1.Nodes[i].Nodes[j].Text);

                    for (int k = 0; k < treeView1.Nodes[i].Nodes[j].Nodes.Count; k++)
                    {
                        MessageBox.Show(treeView1.Nodes[i].Nodes[j].Nodes[k].Text);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            for(int i = 1; i < 11; i++)
            {
                TreeNode carpilan = treeView1.Nodes.Add(string.Format("{0}'in Çarpımları",i));

                for (int j = 1; j < 11; j++)
                {
                    carpilan.Nodes.Add(string.Format("{0} * {1} = {2}", i, j, i * j));
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            object[] sehirler = new object[listBox1.Items.Count];
            listBox1.Items.CopyTo(sehirler, 0);
            object[] sehirler2 = new object[listBox2.Items.Count];
            listBox2.Items.CopyTo(sehirler2, 0);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                TreeNode tasi = treeView1.Nodes.Add(sehirler[i].ToString());
                tasi.Nodes.Add(sehirler2[i].ToString());
            }

            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(maskedTextBox1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[listBox3.Items.Count];
            listBox3.Items.CopyTo(isimler, 0);
            string[] numaralar = new string[listBox4.Items.Count];
            listBox4.Items.CopyTo(numaralar, 0);

            for (int i = 0; i < listBox4.Items.Count; i++)
            {
                if (numaralar[i].Length > 0)
                {
                    TreeNode tasi = treeView1.Nodes.Add(isimler[i].ToString());
                    tasi.Nodes.Add(numaralar[i].ToString());
                }
                
            }

        }
    }
}
