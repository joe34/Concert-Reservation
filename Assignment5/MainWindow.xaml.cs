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

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] reservations = new string[16];
        string name;
        public MainWindow()
        
        {
            InitializeComponent();
            ToolTipService.SetShowOnDisabled(checkBoxA1, true);
            ToolTipService.SetShowOnDisabled(checkBoxA2, true);
            ToolTipService.SetShowOnDisabled(checkBoxA3, true);
            ToolTipService.SetShowOnDisabled(checkBoxA4, true);
            ToolTipService.SetShowOnDisabled(checkBoxB1, true);
            ToolTipService.SetShowOnDisabled(checkBoxB2, true);
            ToolTipService.SetShowOnDisabled(checkBoxB3, true);
            ToolTipService.SetShowOnDisabled(checkBoxB4, true);
            ToolTipService.SetShowOnDisabled(checkBoxC1, true);
            ToolTipService.SetShowOnDisabled(checkBoxC2, true);
            ToolTipService.SetShowOnDisabled(checkBoxC3, true);
            ToolTipService.SetShowOnDisabled(checkBoxC4, true);
            ToolTipService.SetShowOnDisabled(checkBoxD1, true);
            ToolTipService.SetShowOnDisabled(checkBoxD2, true);
            ToolTipService.SetShowOnDisabled(checkBoxD3, true);
            ToolTipService.SetShowOnDisabled(checkBoxD4, true);

            if (textBoxName.Text == "")
            {
                checkBoxA1.IsEnabled = false;
                checkBoxA2.IsEnabled = false;
                checkBoxA3.IsEnabled = false;
                checkBoxA4.IsEnabled = false;

                checkBoxB1.IsEnabled = false;
                checkBoxB2.IsEnabled = false;
                checkBoxB3.IsEnabled = false;
                checkBoxB4.IsEnabled = false;

                checkBoxC1.IsEnabled = false;
                checkBoxC2.IsEnabled = false;
                checkBoxC3.IsEnabled = false;
                checkBoxC4.IsEnabled = false;

                checkBoxD1.IsEnabled = false;
                checkBoxD2.IsEnabled = false;
                checkBoxD3.IsEnabled = false;
                checkBoxD4.IsEnabled = false;
            }
            if (checkBoxA1.IsMouseOver)
            {
                textBoxHover.Text = reservations[0];
            }

        }

        private void buttonAddReservation_Click(object sender, RoutedEventArgs e)
        {    
            AddToReservation();
        }


        private void AddToReservation()
        {
              
            if ((bool)checkBoxA1.IsChecked && checkBoxA1.IsEnabled)
            {
                reservations.SetValue(name, 0);
                checkBoxA1.IsEnabled = false;
                checkBoxA1.ToolTip = reservations[0];
            }
            if ((bool)checkBoxA2.IsChecked && checkBoxA2.IsEnabled)
            {
                reservations.SetValue(name, 1);
                checkBoxA2.IsEnabled = false;
                checkBoxA2.ToolTip = reservations[1];
            }
            if ((bool)checkBoxA3.IsChecked && checkBoxA3.IsEnabled)
            {
                reservations.SetValue(name, 2);
                checkBoxA3.IsEnabled = false;
                checkBoxA3.ToolTip = reservations[2];
            }
            if ((bool)checkBoxA4.IsChecked && checkBoxA4.IsEnabled)
            {
                reservations.SetValue(name, 3);
                checkBoxA4.IsEnabled = false;
                checkBoxA4.ToolTip = reservations[3];
            }
            if ((bool)checkBoxB1.IsChecked && checkBoxB1.IsEnabled)
            {
                reservations.SetValue(name, 4);
                checkBoxB1.IsEnabled = false;
                checkBoxB1.ToolTip = reservations[4];
            }
            if ((bool)checkBoxB2.IsChecked && checkBoxB2.IsEnabled)
            {
                reservations.SetValue(name, 5);
                checkBoxB2.IsEnabled = false;
                checkBoxB2.ToolTip = reservations[5];
            }
            if ((bool)checkBoxB3.IsChecked && checkBoxB3.IsEnabled)
            {
                reservations.SetValue(name, 6);
                checkBoxB3.IsEnabled = false;
                checkBoxB3.ToolTip = reservations[6];
            }
            if ((bool)checkBoxB4.IsChecked && checkBoxB4.IsEnabled)
            {
                reservations.SetValue(name, 7);
                checkBoxB4.IsEnabled = false;
                checkBoxB4.ToolTip = reservations[7];
            }
            if ((bool)checkBoxC1.IsChecked && checkBoxC1.IsEnabled)
            {
                reservations.SetValue(name, 8);
                checkBoxC1.IsEnabled = false;
                checkBoxC1.ToolTip = reservations[8];
            }
            if ((bool)checkBoxC2.IsChecked && checkBoxC2.IsEnabled)
            {
                reservations.SetValue(name, 9);
                checkBoxC2.IsEnabled = false;
                checkBoxC2.ToolTip = reservations[9];
            }
            if ((bool)checkBoxC3.IsChecked && checkBoxC3.IsEnabled)
            {
                reservations.SetValue(name, 10);
                checkBoxC3.IsEnabled = false;
                checkBoxC3.ToolTip = reservations[10];
            }
            if ((bool)checkBoxC4.IsChecked && checkBoxC4.IsEnabled)
            {
                reservations.SetValue(name, 11);
                checkBoxC4.IsEnabled = false;
                checkBoxC4.ToolTip = reservations[11];
            }
            if ((bool)checkBoxD1.IsChecked && checkBoxD1.IsEnabled)
            {
                reservations.SetValue(name, 12);
                checkBoxD1.IsEnabled = false;
                checkBoxD1.ToolTip = reservations[12];
            }
            if ((bool)checkBoxD2.IsChecked && checkBoxD2.IsEnabled)
            {
                reservations.SetValue(name, 13);
                checkBoxD2.IsEnabled = false;
                checkBoxD2.ToolTip = reservations[13];
            }
            if ((bool)checkBoxD3.IsChecked && checkBoxD3.IsEnabled)
            {
                reservations.SetValue(name, 14);
                checkBoxD3.IsEnabled = false;
                checkBoxD3.ToolTip = reservations[14];
            }
            if ((bool)checkBoxD4.IsChecked && checkBoxD4.IsEnabled)
            {
                checkBoxD4.IsEnabled = false;
                reservations.SetValue(name, 15);
                checkBoxD4.ToolTip = reservations[15];
            }
        }
        private void buttonSaveName_Click(object sender, RoutedEventArgs e)
        {
            name = textBoxName.Text;
            if (textBoxName.Text != "")
            {
                checkBoxA1.IsEnabled = true;
                checkBoxA2.IsEnabled = true;
                checkBoxA3.IsEnabled = true;
                checkBoxA4.IsEnabled = true;

                checkBoxB1.IsEnabled = true;
                checkBoxB2.IsEnabled = true;
                checkBoxB3.IsEnabled = true;
                checkBoxB4.IsEnabled = true;

                checkBoxC1.IsEnabled = true;
                checkBoxC2.IsEnabled = true;
                checkBoxC3.IsEnabled = true;
                checkBoxC4.IsEnabled = true;

                checkBoxD1.IsEnabled = true;
                checkBoxD2.IsEnabled = true;
                checkBoxD3.IsEnabled = true;
                checkBoxD4.IsEnabled = true;

                if ((bool)checkBoxA1.IsChecked)
                {
                    checkBoxA1.IsEnabled = false;
                }
                if ((bool)checkBoxA2.IsChecked)
                {
                    checkBoxA2.IsEnabled = false;
                }
                if ((bool)checkBoxA3.IsChecked)
                {
                    checkBoxA3.IsEnabled = false;
                }
                if ((bool)checkBoxA4.IsChecked)
                {
                    checkBoxA4.IsEnabled = false;
                }
                if ((bool)checkBoxB1.IsChecked)
                {
                    checkBoxB1.IsEnabled = false;
                }
                if ((bool)checkBoxB2.IsChecked)
                {
                    checkBoxB2.IsEnabled = false;
                }
                if ((bool)checkBoxB3.IsChecked)
                {
                    checkBoxB3.IsEnabled = false;
                }
                if ((bool)checkBoxB4.IsChecked)
                {
                    checkBoxB4.IsEnabled = false;
                }
                if ((bool)checkBoxC1.IsChecked)
                {
                    checkBoxC1.IsEnabled = false;
                }
                if ((bool)checkBoxC2.IsChecked)
                {
                    checkBoxC2.IsEnabled = false;
                }
                if ((bool)checkBoxC3.IsChecked)
                {
                    checkBoxC3.IsEnabled = false;
                }
                if ((bool)checkBoxC4.IsChecked)
                {
                    checkBoxC4.IsEnabled = false;
                }
                if ((bool)checkBoxD1.IsChecked)
                {
                    checkBoxD1.IsEnabled = false;
                }
                if ((bool)checkBoxD2.IsChecked)
                {
                    checkBoxD2.IsEnabled = false;
                }
                if ((bool)checkBoxD3.IsChecked)
                {
                    checkBoxD3.IsEnabled = false;
                }
                if ((bool)checkBoxD4.IsChecked)
                {
                    checkBoxD4.IsEnabled = false;
                }
            }
            else
            {
                {
                    checkBoxA1.IsEnabled = false;
                    checkBoxA2.IsEnabled = false;
                    checkBoxA3.IsEnabled = false;
                    checkBoxA4.IsEnabled = false;

                    checkBoxB1.IsEnabled = false;
                    checkBoxB2.IsEnabled = false;
                    checkBoxB3.IsEnabled = false;
                    checkBoxB4.IsEnabled = false;

                    checkBoxC1.IsEnabled = false;
                    checkBoxC2.IsEnabled = false;
                    checkBoxC3.IsEnabled = false;
                    checkBoxC4.IsEnabled = false;

                    checkBoxD1.IsEnabled = false;
                    checkBoxD2.IsEnabled = false;
                    checkBoxD3.IsEnabled = false;
                    checkBoxD4.IsEnabled = false;
                }
            }
        }

        private void buttonSearchReservation_Click(object sender, RoutedEventArgs e)
        {
           if (textBoxRemoveSeat.Text == "A1")
            {
                reservations.SetValue("", 0);
                checkBoxA1.IsEnabled = true;
                checkBoxA1.IsChecked = false;
                checkBoxA1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "A2")
            {
                reservations.SetValue("", 1);
                checkBoxA2.IsEnabled = true;
                checkBoxA2.IsChecked = false;
                checkBoxA2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "A3")
            {
                reservations.SetValue("", 2);
                checkBoxA3.IsEnabled = true;
                checkBoxA3.IsChecked = false;
                checkBoxA3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "A4")
            {
                reservations.SetValue("", 3);
                checkBoxA4.IsEnabled = true;
                checkBoxA4.IsChecked = false;
                checkBoxA4.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "B1")
            {
                reservations.SetValue("", 4);
                checkBoxB1.IsEnabled = true;
                checkBoxB1.IsChecked = false;
                checkBoxB1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "B2")
            {
                reservations.SetValue("", 5);
                checkBoxB2.IsEnabled = true;
                checkBoxB2.IsChecked = false;
                checkBoxB2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "B3")
            {
                reservations.SetValue("", 6);
                checkBoxB3.IsEnabled = true;
                checkBoxB3.IsChecked = false;
                checkBoxB3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "B4")
            {
                reservations.SetValue("", 7);
                checkBoxB4.IsEnabled = true;
                checkBoxB4.IsChecked = false;
                checkBoxB4.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "C1")
            {
                reservations.SetValue("", 8);
                checkBoxC1.IsEnabled = true;
                checkBoxC1.IsChecked = false;
                checkBoxC1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "C2")
            {
                reservations.SetValue("", 9);
                checkBoxC2.IsEnabled = true;
                checkBoxC2.IsChecked = false;
                checkBoxC2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "C3")
            {
                reservations.SetValue("", 10);
                checkBoxC3.IsEnabled = true;
                checkBoxC3.IsChecked = false;
                checkBoxC3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "C4")
            {
                reservations.SetValue("", 11);
                checkBoxC4.IsEnabled = true;
                checkBoxC4.IsChecked = false;
                checkBoxC4.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "D1")
            {
                reservations.SetValue("", 12);
                checkBoxD1.IsEnabled = true;
                checkBoxD1.IsChecked = false;
                checkBoxD1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "D2")
            {
                reservations.SetValue("",13);
                checkBoxD2.IsEnabled = true;
                checkBoxD2.IsChecked = false;
                checkBoxD2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "D3")
            {
                reservations.SetValue("", 14);
                checkBoxD3.IsEnabled = true;
                checkBoxD3.IsChecked = false;
                checkBoxD3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == "D4")
            {
                reservations.SetValue("", 15);
                checkBoxD4.IsEnabled = true;
                checkBoxD4.IsChecked = false;
                checkBoxD4.ToolTip = null;
            }
            ///Redundant Should have used && above
            if(textBoxRemoveSeat.Text == reservations[0])
            {
                reservations.SetValue("", 0);
                checkBoxA1.IsEnabled = true;
                checkBoxA1.IsChecked = false;
                checkBoxA1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[1])
            {
                reservations.SetValue("", 1);
                checkBoxA2.IsEnabled = true;
                checkBoxA2.IsChecked = false;
                checkBoxA2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[2])
            {
                reservations.SetValue("", 2);
                checkBoxA3.IsEnabled = true;
                checkBoxA3.IsChecked = false;
                checkBoxA3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[3])
            {
                reservations.SetValue("", 3);
                checkBoxA4.IsEnabled = true;
                checkBoxA4.IsChecked = false;
                checkBoxA4.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[4])
            {
                reservations.SetValue("", 4);
                checkBoxB1.IsEnabled = true;
                checkBoxB1.IsChecked = false;
                checkBoxB1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[5])
            {
                reservations.SetValue("", 5);
                checkBoxB2.IsEnabled = true;
                checkBoxB2.IsChecked = false;
                checkBoxB3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[6])
            {
                reservations.SetValue("", 6);
                checkBoxB3.IsEnabled = true;
                checkBoxB3.IsChecked = false;
                checkBoxB3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[7])
            {
                reservations.SetValue("", 7);
                checkBoxB4.IsEnabled = true;
                checkBoxB4.IsChecked = false;
                checkBoxB4.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[8])
            {
                reservations.SetValue("", 8);
                checkBoxC1.IsEnabled = true;
                checkBoxC1.IsChecked = false;
                checkBoxC1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[9])
            {
                reservations.SetValue("", 9);
                checkBoxC2.IsEnabled = true;
                checkBoxC2.IsChecked = false;
                checkBoxC2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[10])
            {
                reservations.SetValue("", 10);
                checkBoxC3.IsEnabled = true;
                checkBoxC3.IsChecked = false;
                checkBoxC3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[11])
            {
                reservations.SetValue("", 11);
                checkBoxC4.IsEnabled = true;
                checkBoxC4.IsChecked = false;
                checkBoxC4.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[12])
            {
                reservations.SetValue("", 12);
                checkBoxD1.IsEnabled = true;
                checkBoxD1.IsChecked = false;
                checkBoxD1.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[13])
            {
                reservations.SetValue("", 13);
                checkBoxD2.IsEnabled = true;
                checkBoxD2.IsChecked = false;
                checkBoxD2.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[14])
            {
                reservations.SetValue("", 14);
                checkBoxD3.IsEnabled = true;
                checkBoxD3.IsChecked = false;
                checkBoxD3.ToolTip = null;
            }
            if (textBoxRemoveSeat.Text == reservations[15])
            {
                reservations.SetValue("", 15);
                checkBoxD4.IsEnabled = true;
                checkBoxD4.IsChecked = false;
                checkBoxD4.ToolTip = null;
            }
        }
    }
}
