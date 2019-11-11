using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using C07MTools;



namespace WndTester
{
    public sealed partial class CWndRoot : Window
    {
        public CWndRoot()
        {
            InitializeComponent();

            Loaded += ppLoaded;
        }

        private void ppLoaded(object sender, RoutedEventArgs e)
        {
            List<string> lstStr;
            string[] strArr;

            lstStr = MArr.ArrToLst(new string[] { "A01", "A02", "A03" });
            strArr = MArr.LstToArr(new List<string>() { "A01", "A02", "A03" });





            //string[] strArr = { "01", "02" };
            //strArr = null;
            //strArr = new string[1];
            //bool tb1 = MArr.Yes(strArr);
        }
    }
}
