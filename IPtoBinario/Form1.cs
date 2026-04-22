using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPtoBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // Configura cada TextBox para aceitar no máximo 3 caracteres
            txtocteto1.MaxLength = 3;
            txtocteto2.MaxLength = 3;
            txtocteto3.MaxLength = 3;
            txtocteto4.MaxLength = 3;

            // Opcional: Adiciona um evento para bloquear a digitação de letras (apenas números)
            txtocteto1.KeyPress += ApenasNumeros_KeyPress;
            txtocteto2.KeyPress += ApenasNumeros_KeyPress;
            txtocteto3.KeyPress += ApenasNumeros_KeyPress;
            txtocteto4.KeyPress += ApenasNumeros_KeyPress;
        }

        // Evento do botão que fará a conversão
        private void btnConverter_Click(object sender, EventArgs e)
        {
            // Tenta converter e validar os 4 octetos
            if (ValidarEConverterOcteto(txtocteto1.Text, out string bin1) &&
                ValidarEConverterOcteto(txtocteto2.Text, out string bin2) &&
                ValidarEConverterOcteto(txtocteto3.Text, out string bin3) &&
                ValidarEConverterOcteto(txtocteto4.Text, out string bin4))
            {
                // Monta o IP final em binário
                string ipBinario = $"{bin1}.{bin2}.{bin3}.{bin4}";
                
                // Exibe na MessageBox
                MessageBox.Show($"O IP em binário é:\n\n{ipBinario} \n\n{txtocteto1.Text} = {bin1} \n{txtocteto2.Text} = {bin2} \n{txtocteto3.Text} = {bin3} \n{txtocteto4.Text} = {bin4}", "Conversão Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira valores numéricos válidos entre 0 e 255 em todos os campos.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Função auxiliar para validar se é número de 0 a 255 e converter para binário
        private bool ValidarEConverterOcteto(string texto, out string binario)
        {
            binario = string.Empty;

            // Verifica se está vazio
            if (string.IsNullOrWhiteSpace(texto))
            {
                return false;
                
            }
            
            // Tenta converter texto para número inteiro
            if (int.TryParse(texto, out int numero))
            {
                // Um IP real só vai de 0 a 255
                if (numero >= 0 && numero <= 255)
                {
                    // Converte para binário (base 2) e preenche com zeros à esquerda para ter 8 bits
                    binario = Convert.ToString(numero, 2).PadLeft(8, '0');
                    return true;
                }
            }
            return false;
        }

        // Função para garantir que o usuário não digite letras
        private void ApenasNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora o caractere digitado se não for número
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtocteto1.Text = null;
            txtocteto2.Text = null;
            txtocteto3.Text = null;
            txtocteto4.Text = null;
        }
    }
    
}