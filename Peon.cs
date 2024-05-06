public class Peon : Pieza
{
    Button boton;
    private bool primerMovimiento = true;

    public Peon(ColoresPieza color, int fila, int columna) : base(color, TipoPieza.PEON)
    {
        boton = new Button();
        boton.Tag = new Point(fila, columna);
    }
    public override string ObtenerRutaImagen()
    {
        if (getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/peonNegro.png";
        }
        else
        {
            return "Imagenes/peonBlanco.png";
        }
    }
    public override string toString()
    {
        return "p";
    }

    public override bool movimientoValido(int filaDestino, int columnaDestin)
    {
        throw new NotImplementedException();
    }

    // public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    // {
    //     // Implementación del método comer
    //     // Aquí puedes poner la lógica para comer una pieza en el juego de ajedrez
    //     throw new NotImplementedException();
    // }
}