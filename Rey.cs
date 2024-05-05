public class Rey : Pieza, ComerPieza
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
    public Rey(System.Drawing.Color color) : base(ConvertirColorDrawingAColorPieza(color), TipoPieza.REY) { }
    public override bool movimientoValido(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        int distanciaVertical = Math.Abs(filaDestino - filaOrigen);
        int distanciaHorizontal = Math.Abs(columnaDestino - columnaOrigen);

        if ((distanciaVertical == 1 && distanciaHorizontal == 1) ||
            (distanciaVertical == 1 && distanciaHorizontal == 0) ||
            (distanciaVertical == 0 && distanciaHorizontal == 1))
        {
            return true;
        }
        return false;
    }
    public override string ObtenerRutaImagen()
    {
        if (getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/ReyNegro.png";
        } else
        {
            return "Imagenes/ReyBlanco.png";
        }
    }
    public override string toString()
    {
        return "r";
    }

    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    }
}