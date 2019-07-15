// Chad Weirick
// Grand Canyon University
// CST-117
// Dr. J's class!
//
// This is a simple program designed to convert units of weight on Earth to those on Mars.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Week_1_Assignment_3_and_Beyond
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string myEarthWeightString = earthWeightTextBox.Text;
            // this will reset to 0 if the text is invalid
            double myEarthWeightDouble = checkDouble.parseDouble(myEarthWeightString);
            double myMarsWeightDouble = myEarthWeightDouble / 9.81 * 3.711;
            marsWeightTextBox.Text = myMarsWeightDouble.ToString("0.###");
        }
    }

    public static class checkDouble
    {
        public static double parseDouble(this string value, double defaultValue = 0)
        {
            // initiate a return value
            double results = 0;
            if (double.TryParse(value, out results))
            {
                return results;
            }
            // if we made it this far, return 0
            return defaultValue;
        }

        public static double? nullDouble(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            // return the value through the parser.
            return value.parseDouble();
        }
    }
}
