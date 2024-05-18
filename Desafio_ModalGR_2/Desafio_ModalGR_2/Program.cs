using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_ModalGR_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String dados = "Ana, 89, 78, Maria Madalena, 45.8, 27, 56, Paula Pereira, 978, A, VIVA, 35, 125, 8999, ";
            String numericos = String.Empty;
            String strings = String.Empty;
            String subString = String.Empty;
            char ultimochar = dados[0];

            foreach (char c in dados) 
            {
                if (!Char.Equals(c, ',')) 
                {
                    if(!Char.IsWhiteSpace(c) || !Char.Equals(ultimochar, ',')) 
                        subString += c;                    
                }
                else
                {
                    if (Double.TryParse(subString, out double numericoDouble))
                    {
                        numericos += subString + ", ";
                    }
                    else
                        strings += subString + ", ";

                    subString = String.Empty;
                }
                ultimochar = c;
            }
            Console.WriteLine($"Strings: {strings}\n" +
                $"Numéricos: {numericos}");
            Console.ReadKey();
        }
    }
}
