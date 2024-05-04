namespace PruebaAjedrezVisual;

interface ComerPieza
{
    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino);
}

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
}
