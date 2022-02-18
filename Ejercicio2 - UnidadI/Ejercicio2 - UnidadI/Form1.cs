namespace Ejercicio2___UnidadI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] arregloNombre = new string[100];//Declaracion del arreglo para los nombres
        string[] arregloEdad = new string[100];//Declaracion del arreglo para las edades
        int contador= -1; //Contador para asignar la posicion de cada dato

        private void Ejecutar_Click(object sender, EventArgs e)
        {
            contador++;//Cada vez que se realice un registro, el contador sumará 1, para dar paso a la siguiente posición en los arreglos
            arregloNombre[contador]= tbNombre.Text;
            arregloEdad[contador] = tbEdad.Text;
        }

        private void Mostrar_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= contador; i++)//el ciclo for se repetirá el numero de veces al que llegó el contador
            {
                comboBox1.Items.Add(arregloNombre[i] + " - " + arregloEdad[i]);//Salida de los datos por medio de un comboBox
            }
        }
    }
}
