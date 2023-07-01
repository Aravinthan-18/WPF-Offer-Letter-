using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Offerletter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String Before = "";
            String After = $"This is delighted to offer you the full-time position of MANAGER with an anticipated start date of 01-01-2023, \r\n \r\ncontingent upon background check. \r\n \r\nAs the MANAGER, you will be responsible for the company management.\r\n \r\nYou will report directly to supervisor  at Company. Working hours are from 09:00Am-04:00Pm. \r\n \r\nThe starting salary for this position is '500000' per year. Payment is on a monthl basis by direct deposit. In addition,\r\n \r\n you will be eligible to receive discuss additional compensation potential. \r\n \r\n[BMW] offers a comprehensive benefits program, which includes medical insurance. \r\n \r\nYour employment with BMW will be on an at-will basis, which means you and the company are free to terminate employment at any time, with or without cause or advance notice. This letter is not a contract indicating employment terms or duration.\r\n \r\nPlease confirm your acceptance of this offer by signing and returning this letter by 25-12-2022.\";";         
            Before = $"Dear  {txtname.Text}";
            



            Offer oOffer = new Offer();
            oOffer.lbldear.Content = Before;
            oOffer.lblcontent.Content = After;
            oOffer.lblpage.Content = "Hi:  " + txtname.Text;
            oOffer.lbldate.Content = "Join Date:" + txtdate.Text;
            oOffer.lblname.Content = "Adress: " + txtadress.Text;
            oOffer.lblsign.Content = "Company Name:  " + txtcompany.Text;
            oOffer.lblbest.Content = "Adress:  " + txtcom.Text;
            oOffer.lbllvalue.Content = "Sincerely:";
            oOffer.lblneed.Content = "HR";
            oOffer.lbltittle.Content = "JOB OFFER LETTER";
            oOffer.Show();
        }
    }
}
