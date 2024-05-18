using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_ModalGR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFormatar_Click(object sender, EventArgs e)
        {
            List<String> listNomes = new List<String>();
            String[] conectores = { "de", "da", "das", "do", "dos", "e"};
            String subNome = String.Empty;
            int i = 0;

            foreach (char caracter in txtNome.Text) 
            {
                if (!Char.IsLetter(caracter) && !Char.IsWhiteSpace(caracter) && !Char.Equals(caracter, '\''))
                {
                    MessageBox.Show("Seu nome não deve conter números ou caracteres especiais, exceto \' como em d'Avila.");
                    return;
                }

                i++;       
                if (Char.IsLetter(caracter) || Char.Equals(caracter, '\''))
                    subNome += caracter;

                if (Char.IsWhiteSpace(caracter) || i == txtNome.Text.Length)
                {
                    if (!String.IsNullOrEmpty(subNome))
                        listNomes.Add(subNome);

                    subNome = String.Empty;                    
                }
            }

            for(int j = 0; j < conectores.Length; j++)
            {
                foreach (String nome in listNomes)
                {
                    if (conectores[j] == nome)
                    {
                        listNomes.Remove(nome);
                        j--;
                        break;
                    }                    
                }                               
            }

            int tamanhoLista = listNomes.Count - 1;
            for (int k = 0; k < tamanhoLista; k++)
            {
                subNome += listNomes[k].Substring(0, 1).ToUpper() + ". ";                
            }

            String sobrenome = listNomes[tamanhoLista].ToUpper();
            String nomeFormatado = sobrenome + ", "+ subNome;

            txtNomeFormatado.Text = nomeFormatado;
            MessageBox.Show(nomeFormatado);

            txtNome.Clear();
            txtNome.Focus();
        }
    }
}
