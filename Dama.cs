public class Dama : Pieza
{
    public static ColoresPieza ConvertirColorDrawingAColorPieza(System.Drawing.Color color)
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
        throw new ArgumentException("Color no válido");
    }
}

public Dama(System.Drawing.Color color) : base(ConvertirColorDrawingAColorPieza(color), TipoPieza.DAMA) { }

    public override bool movimientoValido(int filaDestino, int columnaDestin)
    {
        return false;
    }

    public override string ObtenerRutaImagen()
    {
        if (getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/damaNegra.png";
        } else
        {
            return "Imagenes/damaBlanca.png";
        }
    }

    public override string toString()
    {
        return "d";
    }

    // public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    // {
    //     return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    // }
}