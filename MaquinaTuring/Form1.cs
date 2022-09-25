using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaTuring
{
    public partial class Form1 : Form
    {
        List<char> cinta = new List<char>();
        List<char> alfabeto = new List<char>();
        int celdaActual = -1;
        public Form1()
        {
            InitializeComponent();
            dtgCinta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCinta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCinta.Columns.Add("Cinta","Cinta");

            dtgCinta.MultiSelect = false;
            

        }

        private void llenarDtg()
        {
            dtgCinta.Rows.Clear();
            foreach (char caracter in cinta)
            {
                dtgCinta.Rows.Add(caracter.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarAlfabeto_Click(object sender, EventArgs e)
        {
            alfabeto.Clear();
            bool flagComa = false;
            bool flagEspacio = false;
            int j = 0;
            for (int i = 0; i < txtAlfabeto.Text.Length; i++)
            {
                if (validarCaracter(txtAlfabeto.Text[i].ToString()))
                {
                    if (alfabeto.Contains(txtAlfabeto.Text[i]))
                    {
                        MessageBox.Show("No se admiten repetidos");
                        alfabeto.Clear();
                        break;
                    }
                    else
                    {
                        if (j < 3)
                        {
                            alfabeto.Add(txtAlfabeto.Text[i]);
                            j++;
                            flagComa = false;
                            flagEspacio = false;
                        }
                        else
                        {
                            MessageBox.Show("Solo se admiten 3 caracteres");
                            alfabeto.Clear();
                            break;
                        }

                    }
                }
                else if (txtAlfabeto.Text[i] == ',')
                {
                    if (flagComa)
                    {
                        MessageBox.Show("Utiliza la siguiente syntaxis: X, Y, Z");
                        alfabeto.Clear();
                        break;
                    }
                    flagComa = true;

                }
                else if (txtAlfabeto.Text[i] == ' ')
                {
                    if (flagEspacio)
                    {
                        MessageBox.Show("Utiliza la siguiente syntaxis: X, Y, Z");
                        alfabeto.Clear();
                        break;
                    }
                    flagEspacio = true;

                }
                else
                {
                    MessageBox.Show("La maquina solo acepta en su alfabeto a-z, A-Z, 0-9");
                    break;
                }
            }
            lblAlfabetoActual.Text = "Alfabeto actual: " + alfabeto[0] + ", "+alfabeto[1]+", "+alfabeto[2];
        }

        private bool validarCaracter(string cadena)
        {
            if (cadena != "")
            {
                bool flag = false;
                for (int i = 0; i < cadena.Length; i++)
                {
                    char c = cadena[i];
                    int cA = (int)c;

                    if (cA >= 97 && cA <= 122)//Valida que sean minusculas
                    {

                    }
                    else if (cA >= 65 && cA <= 90)//Valida que sean Mayusculas
                    {

                    }
                    else if (cA >= 48 && cA <= 57)//Valida que sean numeros
                    {

                    }
                    else
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {

                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        private char generarAlfabeto(int random)
        {

            if (random == 0)
            {
                return alfabeto[0];
            }
            else if(random == 1)
            {
                return alfabeto[1];
            }
            else if(random == 2)
            {
                return alfabeto[2];
            }
            else if (random == 3)
            {
                return '△';
            }
            
             return 'X';
        }

        private void btnAgregarCaracteres_Click(object sender, EventArgs e)
        {
            cinta.Clear();
            Random rand = new Random();
            for (int i = 0; i < int.Parse(txtCantidadCaracteres.Text); i++)
            {
                int random = rand.Next(0, 5);
                if (i == 0)
                {
                    cinta.Add('*');
                }
                else if (i == int.Parse(txtCantidadCaracteres.Text) - 1)
                {
                    cinta.Add('*');
                }
                else
                {
                    cinta.Add(generarAlfabeto(random));
                }
            }
            llenarDtg();
            celdaActual = 0;
            siguienteDerecha(ref celdaActual);
        }

        

        private void btnAgregarRandom_Click(object sender, EventArgs e)
        {
            cinta.Clear();
            Random rand = new Random();
            int random = rand.Next(30, 100);
            for (int i = 0; i < random; i++)
            {
                int random2 = rand.Next(0, 5);
                if (i == 0)
                {
                    cinta.Add('*');
                }else if (i == random - 1)
                {
                    cinta.Add('*');
                }
                else
                {
                    cinta.Add(generarAlfabeto(random2));
                    
                }
            }
            llenarDtg();
            celdaActual = 0;
            siguienteDerecha(ref celdaActual);
        }

        private void btnInsertarActual_Click(object sender, EventArgs e)
        {
            celdaActual = dtgCinta.CurrentCell.RowIndex;
            if (celdaActual == -1)
            {
                MessageBox.Show("Ningunna celda seleccionada");
                return;
            }
            if (celdaActual == 0)
            {
                MessageBox.Show("No se puede cambiar el delimitador");
                return;
            }

            if (alfabeto.Contains(char.Parse(txtCaracter.Text)))
            {
                cinta[celdaActual] = txtCaracter.Text[0];
                llenarDtg();
            }
            else
            {
                MessageBox.Show("El caracter no esta dentro del alfabeto");
            }
        }

        private async void btnEjecutar_Click(object sender, EventArgs e)
        {
            string comando = "";
            for (int i = 0; i < txtComandos.Text.Length; i++)
            {
                if (txtComandos.Text[i] == ',')
                {
                    if (await Ejecutar(comando))
                    {
                        comando = "";
                    }
                    else if (cinta[celdaActual] == '*')
                    {
                        MessageBox.Show("Se esta en el delimitador");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Comando no valido");
                        return;
                    }
                }
                else if (txtComandos.Text[i] == ' ')
                {
                }
                else
                {
                    comando = comando + txtComandos.Text[i];
                }
            }
        }

        private void  siguienteDerecha(ref int actual)
        {
            dtgCinta.Rows[actual].DefaultCellStyle.BackColor = Color.White;
            actual++;
            dtgCinta.Rows[actual].DefaultCellStyle.BackColor = Color.Green;
        }

        private void siguienteIzquierda(ref int actual)
        {
            dtgCinta.Rows[actual].DefaultCellStyle.BackColor = Color.White;
            actual--;
            dtgCinta.Rows[actual].DefaultCellStyle.BackColor = Color.Green;
        }

        private async Task<bool> Ejecutar(string comando)
        {
            int delay =  1000;           
            switch (comando)
            {
                case "R":
                    if (cinta[celdaActual] == '*' && celdaActual == cinta.Count - 1)
                    {

                        return false;
                    }
                    else
                    {
                        siguienteDerecha(ref celdaActual);
                        await Task.Delay(delay);
                        return true;
                    }
                case "L":
                    if (cinta[celdaActual] == '*' && celdaActual == 0)
                    {
                        return false;
                    }
                    else
                    {
                        siguienteIzquierda(ref celdaActual);
                        await Task.Delay(delay);
                        return true;
                    }
                case "X":
                    cinta[celdaActual] = 'X';
                    await Task.Delay(delay);
                    llenarDtg();
                    dtgCinta.Rows[celdaActual].DefaultCellStyle.BackColor = Color.Green;
                    return true;
                case "△":
                    cinta[celdaActual] = '△';
                    await Task.Delay(delay);
                    llenarDtg();
                    dtgCinta.Rows[celdaActual].DefaultCellStyle.BackColor = Color.Green;
                    return true;
                case "RX":
                    do
                    {
                        if (cinta[celdaActual] == '*' && celdaActual == cinta.Count - 1)
                        {
                            return false;
                        }
                        siguienteDerecha(ref celdaActual);
                        await Task.Delay(delay);
                    } while (cinta[celdaActual] != 'X');
                    return true;
                case "LX":
                    do
                    {
                        if (cinta[celdaActual] == '*' && celdaActual == 0)
                        {
                            return false;
                        }
                        siguienteIzquierda(ref celdaActual);
                        await Task.Delay(delay);
                    } while (cinta[celdaActual] != 'X');
                    return true;
                case "R-X":
                    do
                    {
                        if (cinta[celdaActual] == '*' && celdaActual == cinta.Count - 1)
                        {
                            return false;
                        }
                        siguienteDerecha(ref celdaActual);
                        await Task.Delay(delay);
                    } while (cinta[celdaActual] == 'X');
                    return true;
                case "L-X":
                    do
                    {
                        if (cinta[celdaActual] == '*' && celdaActual == 0)
                        {
                            return false;
                        }
                        siguienteIzquierda(ref celdaActual);
                        await Task.Delay(delay);
                    } while (cinta[celdaActual] == 'X');
                    return true;
                default:
                    return false; 
            }
        }
    }
}
