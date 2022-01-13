using System;
using System.Collections.Generic;
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

namespace personalizacion.CustomControls
{
    /// <summary>
    /// Lógica de interacción para ParaValidaciones.xaml
    /// </summary>
    public partial class ParaValidaciones : UserControl
    {
        public ParaValidaciones()
        {
            InitializeComponent();

        }

        public String TipoValidacion { get; set; }
        public void LostFocusEventManager()
        {
            if (TipoValidacion == "cp" || TipoValidacion == "CP")
            {
                if (TextValidar.Text.Length != 5)
                {
                    LBError.Content = "El codigo postal debe tener 5 digitos";
                }
                else
                {
                    try
                    {
                        int.Parse(TextValidar.Text);
                        LBError.Content = "Correcto";
                    }
                    catch (FormatException)
                    {
                        LBError.Content = "El codigo postal no puede tener letras";
                    }
                }
            }
            if (TipoValidacion == "tlf" || TipoValidacion == "TLF")
            {
                {
                    if (TextValidar.Text.Length != 9)
                    {
                        LBError.Content = "El teléfono debe tener 9 digitos";
                    }
                    else
                    {
                        try
                        {
                            int.Parse(TextValidar.Text);
                            LBError.Content = "Correcto";
                        }
                        catch (FormatException)
                        {
                            LBError.Content = "El teléfono no puede tener números";
                        }
                    }
                }
            }
            if (TipoValidacion == "dni" || TipoValidacion == "DNI")
            {
                if (TextValidar.Text.Length != 9)
                {
                    LBError.Content = "El DNI debe tener 9 digitos";
                }else
                {
                    try
                    {
                        string DNI = TextValidar.Text.Substring(0, 8);
                        int.Parse(DNI);
                        try
                        {
                            string letra = TextValidar.Text.Substring(8, 1);
                            int.Parse(letra);
                            LBError.Content = "El ultimo digito debe ser una letra";
                        }
                        catch (Exception)
                        {

                            LBError.Content = "Correcto";
                        }
                    }
                    catch (FormatException)
                    {
                        LBError.Content = "Los primeros 8 digitos deben ser numeros y el ultimo una letra";
                    }
                }
                
               
                
            }
        }

        private void TextValidar_LostFocus(object sender, RoutedEventArgs e)
        {
            LostFocusEventManager();
        }
    }
}
