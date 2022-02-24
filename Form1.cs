using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace szamologep
{

    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }
        double szam1 = 0;
        double szam2 = 0;
        double eredmeny = 0;
        bool szamegyjelen = false;
        bool szorzas = false;
        bool kivonas = false;
        bool osztas = false;
        double osztaseredmeny;
        int szorzaseredmeny;
        double szamnegyzet;
        bool negyzetetcsinal = false;
        double eredmenynegyzet;
        private void Form1_Load(object sender, EventArgs e)
        {
            szam1 = 0;
            szam2 = 0;
           
            textBox1.Focus();
        }

        private void egy_Click(object sender, EventArgs e)
        {
            try {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "1";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "1";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
            

        }

        private void osszead_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "";
            szamegyjelen = true;
            muveletmegjelenit.Text = "+";
            muveletmegjelenit.Visible = true;
            kivonas = false;
            szorzas = false;
            osztas = false;
            kk.Start();

        }

        private void ketto_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "2";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "2";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }

        }

        private void egyenlo_Click(object sender, EventArgs e)
        {
            kk.Stop();
            if(kivonas == false && szorzas == false && osztas == false)
            {
                eredmeny = szam1 + szam2;
                eredmenymegjelentio.Text = Convert.ToString(eredmeny);
            }
            if (kivonas == true && szorzas == false && osztas == false)
            {
                eredmeny = szam1 - szam2;
                eredmenymegjelentio.Text = Convert.ToString(eredmeny);
            }
            if(szorzas == true)
            {
                eredmeny = szam1 * szam2;
                eredmenymegjelentio.Text = Convert.ToString(eredmeny);
            }
            if (osztas == true && szorzas == false)
            {
                eredmeny = szam1 /szam2;
                eredmenymegjelentio.Text = Convert.ToString(eredmeny);
            }
        }

        private void torles_Click(object sender, EventArgs e)
        {
            eredmenymegjelentio.Text = "0";
            szam1 = 0;
            szam2 = 0;
            szm1.Text = Convert.ToString(szam1);
            szm2.Text = Convert.ToString(szam2);
            textBox1.Text = "0";
            eredmenymegjelentio.Text = "0";
            szamegyjelen = false;
            muveletmegjelenit.Visible = false;
            kivonas = false;
            szorzas = false;
            negyzetetcsinal = false;
        }

        private void harom_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "3";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "3";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void negy_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "4";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "4";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void ot_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "5";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "5";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void hat_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "6";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "6";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void het_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "7";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "7";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void nyolc_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "8";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "8";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void kilenc_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "9";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "9";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void nulla_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    textBox1.Text = textBox1.Text + "0";
                    szam1 = Convert.ToInt32(textBox1.Text);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    textBox1.Text = textBox1.Text + "0";
                    szam2 = Convert.ToInt32(textBox1.Text);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }
        }

        private void kivon_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = "";
            szamegyjelen = true;
            muveletmegjelenit.Text = "-";
            muveletmegjelenit.Visible = true;
            kivonas = true;
            szorzas = false;
            osztas = false;
            kk.Start();
        }

        private void gyok_Click(object sender, EventArgs e)
        {
            kk.Stop();
            try {
                if (szam2 == 0)
                {
                    double gyokelso = Math.Sqrt(szam1);
                    double gyokmasodik = Math.Round(gyokelso, 5);
                    eredmenymegjelentio.Text = ($"{gyokmasodik}");
                }
                if (szam2 > 0)
                {
                    double gyoketextnek = Convert.ToInt32(eredmenymegjelentio.Text);
                    double gyok = Math.Sqrt(gyoketextnek);
                    eredmenymegjelentio.Text = ($"{gyok}");
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }

        }

        private void eredmenymegjelentio_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "0";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "0";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "1";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "1";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "2";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "2";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "3";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "3";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "4";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "4";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "5";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "5";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "6";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "6";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad7)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "7";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "7";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "8";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "8";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.NumPad9)
            {
                try
                {
                    if (szamegyjelen == false)
                    {
                        textBox1.Text = textBox1.Text + "9";
                        szam1 = Convert.ToInt32(textBox1.Text);
                        szm1.Text = Convert.ToString(szam1);
                    }
                    if (szamegyjelen == true)
                    {
                        textBox1.Text = textBox1.Text + "9";
                        szam2 = Convert.ToInt32(textBox1.Text);
                        szm2.Text = Convert.ToString(szam2);
                    }
                }
                catch
                {
                    kk.Stop();
                    szmnagy.Text = "Az megadott érték túl nagy!";
                    Size = new Size(290, 330);
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                textBox1.Text = textBox1.Text = "";
                szamegyjelen = true;
                muveletmegjelenit.Text = "-";
                muveletmegjelenit.Visible = true;
                kivonas = true;
                szorzas = false;
                osztas = false;
                kk.Start();
            }
            if (e.KeyCode == Keys.Add)
            {
                textBox1.Text = textBox1.Text = "";
                szamegyjelen = true;
                muveletmegjelenit.Text = "+";
                muveletmegjelenit.Visible = true;
                kivonas = false;
                szorzas = false;
                osztas = false;
                kk.Start();
            }
            if (e.KeyCode == Keys.Enter)
            {
                kk.Stop();
                if (kivonas == false && szorzas == false && osztas == false)
                {
                    eredmeny = szam1 + szam2;
                    eredmenymegjelentio.Text = Convert.ToString(eredmeny);
                }
                if (kivonas == true && szorzas == false && osztas == false)
                {
                    eredmeny = szam1 - szam2;
                    eredmenymegjelentio.Text = Convert.ToString(eredmeny);
                }
                if (szorzas == true)
                {
                    eredmeny = szam1 * szam2;
                    eredmenymegjelentio.Text = Convert.ToString(eredmeny);
                }
                if (osztas == true && szorzas == false)
                {
                    eredmeny = szam1 / szam2;
                    eredmenymegjelentio.Text = Convert.ToString(eredmeny);
                }
            }
            if (e.KeyCode == Keys.Multiply)
            {
                szorzas = true;
                textBox1.Text = textBox1.Text = "";
                szamegyjelen = true;
                muveletmegjelenit.Text = "x";
                muveletmegjelenit.Visible = true;
                osztas = false;
                kk.Start();
            }
            if (e.KeyCode == Keys.Divide)
            {
                osztas = true;
                textBox1.Text = textBox1.Text = "";
                szamegyjelen = true;
                muveletmegjelenit.Text = "÷";
                muveletmegjelenit.Visible = true;
                szorzas = false;
                kk.Start();
            }
            if (e.KeyCode == Keys.C)
            {
                szam1 = 0;
                szam2 = 0;
                szm1.Text = Convert.ToString(szam1);
                szm2.Text = Convert.ToString(szam2);
                textBox1.Text = "0";
                eredmenymegjelentio.Text = "0";
                szamegyjelen = false;
                muveletmegjelenit.Visible = false;
                kivonas = false;
                szorzas = false;
                negyzetetcsinal = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            szorzas = true;
            textBox1.Text = textBox1.Text = "";
            szamegyjelen = true;
            muveletmegjelenit.Text = "x";
            muveletmegjelenit.Visible = true;
            osztas = false;
            kk.Start();
        }

        private void oszto_Click(object sender, EventArgs e)
        {
            osztas = true;
            textBox1.Text = textBox1.Text = "";
            szamegyjelen = true;
            muveletmegjelenit.Text = "÷";
            muveletmegjelenit.Visible = true;
            szorzas = false;
            kk.Start();
        }

        private void negyzet_Click(object sender, EventArgs e)
        {
            kk.Stop();
            try {
                if (szamegyjelen == false)
                {
                    szamnegyzet = (szam1) * (szam1);
                    eredmenymegjelentio.Text = ($"{szamnegyzet}");
                }
                if (szamegyjelen == true)
                {

                    double negyzeten = Convert.ToInt32(eredmenymegjelentio.Text) * Convert.ToInt32(eredmenymegjelentio.Text);

                    eredmenymegjelentio.Text = ($"{negyzeten}");
                }
            }catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }


            /* if (szamegyjelen == true)
             {
                 negyzetetcsinal = true;
                 int szamnegyzetek = szam1 * szam1;
                 int szamnegyzetekk = szam2 * szam2;
                 if(kivonas == false)
                 {
                    eredmenynegyzet = szamnegyzet + szamnegyzetekk;
                 }
                 if (kivonas == true)
                 {
                     eredmenynegyzet = szamnegyzet - szamnegyzetekk;
                 }
                 if (szorzas == true)
                 {
                     eredmenynegyzet = szamnegyzet * szamnegyzetekk;
                 }
                 if (osztas == true)
                 {
                     eredmenynegyzet = szamnegyzet / szamnegyzetekk;
                 }


                 eredmenymegjelentio.Text = ($"{eredmenynegyzet}");

             }
          
            */
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void egy_MouseHover(object sender, EventArgs e)
        {
            egy.ForeColor = Color.Orange;
        }

        private void egy_MouseLeave(object sender, EventArgs e)
        {
            egy.ForeColor = Color.LightGray;
        }

        private void ketto_MouseHover(object sender, EventArgs e)
        {
            ketto.ForeColor = Color.Orange;
        }

        private void ketto_MouseLeave(object sender, EventArgs e)
        {
            ketto.ForeColor = Color.LightGray;
        }

        private void harom_MouseHover(object sender, EventArgs e)
        {
            harom.ForeColor = Color.Orange;
        }

        private void harom_MouseLeave(object sender, EventArgs e)
        {
            harom.ForeColor = Color.LightGray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void negy_MouseHover(object sender, EventArgs e)
        {
            negy.ForeColor = Color.Orange;
        }

        private void negy_MouseLeave(object sender, EventArgs e)
        {
            negy.ForeColor = Color.LightGray;
        }

        private void ot_MouseHover(object sender, EventArgs e)
        {
            ot.ForeColor = Color.Orange;
        }

        private void ot_MouseLeave(object sender, EventArgs e)
        {
            ot.ForeColor = Color.LightGray;
        }

        private void hat_MouseHover(object sender, EventArgs e)
        {
            hat.ForeColor = Color.Orange;
        }

        private void hat_MouseLeave(object sender, EventArgs e)
        {
            hat.ForeColor = Color.LightGray;
        }

        private void het_MouseHover(object sender, EventArgs e)
        {
            het.ForeColor = Color.Orange;
        }

        private void het_MouseLeave(object sender, EventArgs e)
        {
            het.ForeColor = Color.LightGray;
        }

        private void nyolc_MouseHover(object sender, EventArgs e)
        {
            nyolc.ForeColor = Color.Orange;
        }

        private void nyolc_MouseLeave(object sender, EventArgs e)
        {
            nyolc.ForeColor = Color.LightGray;
        }

        private void kilenc_MouseHover(object sender, EventArgs e)
        {
            kilenc.ForeColor = Color.Orange;
        }

        private void kilenc_MouseLeave(object sender, EventArgs e)
        {
            kilenc.ForeColor = Color.LightGray;
        }

        private void nulla_MouseHover(object sender, EventArgs e)
        {
            nulla.ForeColor = Color.Orange;
        }

        private void nulla_MouseLeave(object sender, EventArgs e)
        {
            nulla.ForeColor = Color.LightGray;
        }

        private void torles_MouseHover(object sender, EventArgs e)
        {
            torles.ForeColor = Color.Red;
        }

        private void torles_MouseLeave(object sender, EventArgs e)
        {
            torles.ForeColor = Color.LightGray;
        }

        private void gyok_MouseHover(object sender, EventArgs e)
        {
            gyok.ForeColor = Color.Orange;
        }

        private void gyok_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void gyok_MouseLeave(object sender, EventArgs e)
        {
            gyok.ForeColor = Color.LightGray;
        }

        private void negyzet_MouseHover(object sender, EventArgs e)
        {
            negyzet.ForeColor = Color.Orange;
        }

        private void negyzet_MouseLeave(object sender, EventArgs e)
        {
            negyzet.ForeColor = Color.LightGray;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void reset_MouseHover(object sender, EventArgs e)
        {
            reset.ForeColor = Color.Brown;
        }

        private void reset_MouseLeave(object sender, EventArgs e)
        {
            reset.ForeColor = Color.LightGray;
        }

        private void label8_Click(object sender, EventArgs e)
        {
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            eredmenymegjelentio.Text = ($"{szam1} {muveletmegjelenit.Text} {szam2}");
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kk.Start();
           
        }

        private void egyenlo3_MouseHover(object sender, EventArgs e)
        {
            egyenlo3.ForeColor = Color.Black;
        }

        private void egyenlo3_MouseLeave(object sender, EventArgs e)
        {
            egyenlo3.ForeColor = Color.LightGray;
        }

        private void egyenlo_MouseHover(object sender, EventArgs e)
        {
            egyenlo3.ForeColor = Color.Black;
        }

        private void egyenlo_MouseLeave(object sender, EventArgs e)
        {
            egyenlo.ForeColor = Color.LightGray;
        }

        private void egyenlo2_MouseHover(object sender, EventArgs e)
        {
            egyenlo3.ForeColor = Color.Black;
        }

        private void egyenlo2_MouseLeave(object sender, EventArgs e)
        {
            egyenlo3.ForeColor = Color.LightGray;

        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            
            Size = new Size(290, 300);
        }

        private void osszead_MouseHover(object sender, EventArgs e)
        {
            osszead.ForeColor = Color.Black;
        }

        private void osszead_MouseLeave(object sender, EventArgs e)
        {
            osszead.ForeColor = Color.LightGray;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.LightGray;
        }

        private void kivon_MouseHover(object sender, EventArgs e)
        {
            kivon.ForeColor = Color.Black;
        }

        private void kivon_MouseLeave(object sender, EventArgs e)
        {
            kivon.ForeColor = Color.LightGray;
        }

        private void oszto_MouseHover(object sender, EventArgs e)
        {
            oszto.ForeColor = Color.Black;
        }

        private void oszto_MouseLeave(object sender, EventArgs e)
        {
            oszto.ForeColor = Color.LightGray;
        }

        private void pi_Click(object sender, EventArgs e)
        {
            try
            {
                if (szamegyjelen == false)
                {
                    double pi = 3.14159265;
                    szam1 = (pi);
                    szm1.Text = Convert.ToString(szam1);
                }
                if (szamegyjelen == true)
                {
                    double pi = 3.14159265;
                    szam2 = (pi);
                    szm2.Text = Convert.ToString(szam2);
                }
            }
            catch
            {
                kk.Stop();
                szmnagy.Text = "Az megadott érték túl nagy!";
                Size = new Size(290, 330);
            }

        }
    }
}
 
    