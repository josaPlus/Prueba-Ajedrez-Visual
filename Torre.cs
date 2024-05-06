public class Torre : Pieza
{
    public static ColoresPieza ConvertColorToColoresPieza(System.Drawing.Color color)
    {
        if (color == System.Drawing.Color.Black)
        {
            return ColoresPieza.NEGRO;
        }
        else if (color == System.Drawing.Color.White)
        {
            return ColoresPieza.BLANCO;
        }
        else
        {
            throw new ArgumentException("Invalid color");
        }
    }

    public Torre(System.Drawing.Color color) : base(ConvertColorToColoresPieza(color), TipoPieza.TORRE)
    {

    }

    public override bool movimientoValido(int filaDestino, int columnaDestin)
    {
        throw new NotImplementedException();
    }


    public override string toString()
    {
        return "t";
    }

    public override string ObtenerRutaImagen()
    {
        if (this.getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/torreNegra.png";
        }
        else
        {
            return "Imagenes/torreBlanca.png";
        }
    }

    // public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    // {
    //     return movimientoValido(filaDestino, columnaDestino);
    // }
}