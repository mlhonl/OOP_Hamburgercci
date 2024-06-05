using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci_WFA
{
    public class Fonksiyonlar
    {

        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if ( control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = ((NumericUpDown)control).Minimum;
                }
                else if(control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Name=="rdbKucuk")
                    {
                        radioButton.Checked = true;
                    }
                    else
                    {
                        radioButton.Checked = false;
                    }
                }
                else if (control is CheckBox) 
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if(control is GroupBox)
                {
                    Temizle(((GroupBox)control).Controls);
                }
                else if ( control is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)control).Controls);
                }
            }
        }



    }
}
