using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PASSAPAROLA_OYUNU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int soruno = 0, dogru = 0, yanlis = 0,sayac=200;
        public void metot()
        {
            btngosterge.BackColor = Color.Black;                        
            lblgosterge.Visible = false;
            lblsonucdogru.Visible = true;
            lblsonucdogru.BackColor = Color.Black;
            lblsonucyanlis.BackColor = Color.Black;
            lblsonucyanlis.Visible = true;
            lblsonucdogru.Text = "Doğru:" + dogru.ToString();
            lblsonucyanlis.Text = "Yanlış:" + yanlis.ToString();
            btncevapla.Enabled = false;
            btnsonraki.Enabled = false;
            btntekrar.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtcevap.Focus();
            soruno++;
            btncevapla.Enabled = true;
            btnsonraki.Enabled = false;
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz hangisidir ?";
                btnB.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü haftanın hangi günüdür ?";
                btnC.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "C";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz ?";
                btnD.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı nedir ?";
                btnE.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                btnF.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                btnG.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencinin kötü karne getirince bakıştığı nesne ?";
                btnH.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                btnI.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "I";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi ?";
                btnİ.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "İ";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                btnJ.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "J";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi ?";
                btnK.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "K";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali ?";
                btnL.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "L";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı ?";
                btnM.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "M";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti ?";
                btnN.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "N";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi ?";
                btnO.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "O";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç,havuç gibi sebzeler ile yapılan yemek ?";
                btnP.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "P";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Onbir ayın sultanı ?";
                btnR.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "R";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan ?";
                btnS.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "S";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin megastarı ?";
                btnT.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "T";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ?";
                btnU.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "U";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz ?";
                btnV.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "V";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı ?";
                btnY.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "Y";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Kömür madenlerinin en çok bulunduğu ilimiz ?";
                btnZ.BackColor = Color.Gold;
                txtcevap.Clear();
                lblgosterge.Text = "Z";
            }

        }

        private void btntekrar_Click(object sender, EventArgs e)
        {
            btnA.BackColor = Color.Transparent;
            btnB.BackColor = Color.Transparent;
            btnC.BackColor = Color.Transparent;
            btnD.BackColor = Color.Transparent;
            btnE.BackColor = Color.Transparent;
            btnF.BackColor = Color.Transparent;
            btnG.BackColor = Color.Transparent;
            btnH.BackColor = Color.Transparent;
            btnI.BackColor = Color.Transparent;
            btnİ.BackColor = Color.Transparent;
            btnJ.BackColor = Color.Transparent;
            btnK.BackColor = Color.Transparent;
            btnL.BackColor = Color.Transparent;
            btnM.BackColor = Color.Transparent;
            btnN.BackColor = Color.Transparent;
            btnO.BackColor = Color.Transparent;
            btnP.BackColor = Color.Transparent;
            btnR.BackColor = Color.Transparent;
            btnS.BackColor = Color.Transparent;
            btnT.BackColor = Color.Transparent;
            btnU.BackColor = Color.Transparent;
            btnV.BackColor = Color.Transparent;
            btnY.BackColor = Color.Transparent;
            btnZ.BackColor = Color.Transparent;            
            lblgosterge.Visible = true;
            lblgosterge.Text = "";
            txtcevap.Clear();
            richTextBox1.Clear();
            lblsonucdogru.Visible = false;            
            lblsonucyanlis.Visible = false;
            lbluyarı.Visible = false;
            lbluyarı2.Visible = false;
            btncevapla.Enabled = false;
            btnsonraki.Enabled = false;
            btnbasla.Enabled = true;
            btntekrar.Visible = false;
            soruno = 0;
            dogru = 0;
            lbldogru.Text = dogru.ToString();
            yanlis = 0;
            lblyanlis.Text = yanlis.ToString();            
            sayac = 200;
            lblsure.Text = sayac.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblsure.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
                metot();
                lbluyarı.Visible = true;
                lbluyarı.BackColor = Color.Black;                
            }
        }

        private void btncevapla_Click(object sender, EventArgs e)
        {
            btncevapla.Enabled = false;
            btnsonraki.Enabled = true;
            switch (soruno)
            {
                case 1:
                    if (txtcevap.Text == "akdeniz")
                    {
                        btnA.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnA.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 2:
                    if (txtcevap.Text == "bursa")
                    {
                        btnB.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnB.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 3:
                    if (txtcevap.Text == "cuma")
                    {
                        btnC.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnC.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 4:
                    if (txtcevap.Text == "diyarbakır")
                    {
                        btnD.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnD.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 5:
                    if (txtcevap.Text == "eski")
                    {
                        btnE.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnE.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 6:
                    if (txtcevap.Text == "ferman")
                    {
                        btnF.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnF.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 7:
                    if (txtcevap.Text == "güneş")
                    {
                        btnG.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnG.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 8:
                    if (txtcevap.Text == "halı")
                    {
                        btnH.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnH.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 9:
                    if (txtcevap.Text == "ısparta")
                    {
                        btnI.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnI.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 10:
                    if (txtcevap.Text == "içel")
                    {
                        btnİ.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnİ.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 11:
                    if (txtcevap.Text == "jandarma")
                    {
                        btnJ.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnJ.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 12:
                    if (txtcevap.Text == "kayısı")
                    {
                        btnK.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnK.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 13:
                    if (txtcevap.Text == "lale")
                    {
                        btnL.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnL.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 14:
                    if (txtcevap.Text == "mart")
                    {
                        btnM.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnM.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 15:
                    if (txtcevap.Text == "ney")
                    {
                        btnN.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnN.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 16:
                    if (txtcevap.Text == "ozan")
                    {
                        btnO.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnO.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 17:
                    if (txtcevap.Text == "pırasa")
                    {
                        btnP.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnP.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 18:
                    if (txtcevap.Text == "ramazan")
                    {
                        btnR.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnR.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 19:
                    if (txtcevap.Text == "snake")
                    {
                        btnS.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnS.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 20:
                    if (txtcevap.Text == "tarkan")
                    {
                        btnT.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnT.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 21:
                    if (txtcevap.Text == "umut")
                    {
                        btnU.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnU.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 22:
                    if (txtcevap.Text == "van")
                    {
                        btnV.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnV.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 23:
                    if (txtcevap.Text == "yıldırım")
                    {
                        btnY.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                    }
                    else
                    {
                        btnY.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                    }
                    break;
                case 24:
                    if (txtcevap.Text == "zonguldak")
                    {
                        btnZ.BackColor = Color.Lime;
                        dogru++;
                        lbldogru.Text = dogru.ToString();
                        metot();
                        lbluyarı2.Visible = true;
                        lbluyarı2.BackColor = Color.Black;
                        timer1.Stop();
                    }
                    else
                    {
                        btnZ.BackColor = Color.Red;
                        yanlis++;
                        lblyanlis.Text = yanlis.ToString();
                        metot();
                        lbluyarı2.Visible = true;
                        lbluyarı2.BackColor = Color.Black;
                        timer1.Stop();
                    }
                    break;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            timer1.Start();
            txtcevap.Focus();
            btnbasla.Enabled = false;
            txtcevap.Enabled = true;
            btncevapla.Enabled = true;
            lblgosterge.ForeColor = Color.Gold;
            lblgosterge.BackColor = Color.Black;
            soruno++;
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi nedir ?";
                btnA.BackColor = Color.Gold;
                lblgosterge.Text = "A";
            }
        }
    }
}
