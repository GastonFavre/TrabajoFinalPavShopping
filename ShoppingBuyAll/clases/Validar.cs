using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoppingBuyAll.clases;
using ShoppingBuyAll.Componentes;

namespace ShoppingBuyAll.clases
{
    class Validar
    {

        public enum estado_validacion { correcta, erronea }

        public estado_validacion validar_Form(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType().Name == "TextBoxDeControl")
                {
                    if (((TextBoxDeControl)item)._validable == true)
                    {
                        if (item.Text == "")
                        {
                            MessageBox.Show(((TextBoxDeControl)item)._mensaje_error);
                            ((TextBoxDeControl)item).Focus();
                            return estado_validacion.erronea;
                        }
                    }
                }
                if (item.GetType().Name == "ComboBoxDeControl")
                {
                    if (((ComboBoxDeControl)item)._validable == true)
                    {
                        if (((ComboBoxDeControl)item).SelectedIndex == -1)
                        {
                            MessageBox.Show(((ComboBoxDeControl)item)._mensaje_error);
                            ((ComboBoxDeControl)item).Focus();
                            return estado_validacion.erronea;
                        }
                    }
                }

                if (item.GetType().Name == "MaskedTextBokDeControl")
                {
                    if (((MaskedTextBokDeControl)item)._validable == true)
                    {
                        if (((MaskedTextBokDeControl)item).MaskFull == false)
                        {
                            MessageBox.Show(((MaskedTextBokDeControl)item)._mensaje_error);
                            ((MaskedTextBokDeControl)item).Focus();
                            return estado_validacion.erronea;
                        }
                    }
                }


            }
            return estado_validacion.correcta;
        }
        public void blanquear_objetos(Control.ControlCollection controles)
        {
            foreach (Control item in controles)
            {
                if (item.GetType().Name == "TextBoxDeControl")
                {
                    item.Text = "";
                }
                if (item.GetType().Name == "ComboBoxDeControl")
                {
                    ((ComboBoxDeControl)item).SelectedIndex = -1;
                }
                if (item.GetType().Name == "DateTimePickerDeControl")
                {
                    ((DateTimePickerDeControl)item).Text = "";
                }
                if (item.GetType().Name == "MaskedTextBokDeControl")
                {
                    ((MaskedTextBokDeControl)item).Text = "";
                }
            }
        }

      
        }
    }
