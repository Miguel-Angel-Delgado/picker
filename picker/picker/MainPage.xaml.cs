using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace picker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pickOper.Items.Add("Suma");
            pickOper.Items.Add("Resta");
            pickOper.Items.Add("Multiplicación");
            pickOper.Items.Add("División");
        }

        private void pickOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = pickOper.SelectedItem.ToString();
            int n1 = Int32.Parse(txt1.Text);
            int n2 = Int32.Parse(txt2.Text);
            double res = 0;

            if (op == "Suma")
                res = n1 + n2;
            else if (op == "Resta")
                res = n1 - n2;
            else if (op == "Multiplicación")
                res = n1 * n2; 
            else
                res = n1 / n2;

            lblres.Text = res + "";
        }
    }
}
