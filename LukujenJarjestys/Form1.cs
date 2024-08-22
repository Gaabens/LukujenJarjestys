using System.Linq.Expressions;

namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();

        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyDown(object sender, KeyEventArgs e)
        {

          

            if (e.KeyCode == Keys.Enter)

            {
                try
                {
                    


                if (uusiLukuTB.Text == "-999")
                    {
                        VastausLB.Text = "";

                        int[] taulukko = jono.ToArray();

                        Array.Sort(taulukko);

                        foreach (var jasen in taulukko)
                        {
                            VastausLB.Text += jasen + "" + " ";
                        }

                        VastausLB.Visible = true;

                    }

                    else
                    {
                        jono.Add(Int32.Parse(uusiLukuTB.Text));
                        uusiLukuTB.Text = "";
                    }
                }

                catch
                {

                    VastausLB.Text = "Virhe!";
                    VastausLB.Visible = true;
                }
            }

               
            }
        }

    }


