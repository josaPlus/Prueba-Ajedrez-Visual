public class Dama : Pieza, ComerPieza
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
    public override bool movimientoValido(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        int distanciaVertical = Math.Abs(filaDestino - filaOrigen);
        int distanciaHorizontal = Math.Abs(columnaDestino - columnaOrigen);

        if (distanciaVertical == distanciaHorizontal || 
            (distanciaVertical == 0 && distanciaHorizontal != 0) || 
            (distanciaVertical != 0 && distanciaHorizontal == 0))
        {
            return true;
        }
        return false;
    }
    public override string ObtenerRutaImagen()
    {
        if (getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/DamaNegro.png";
        } else
        {
            return "Imagenes/DamaBlanco.png";
        }
    }

    public override string toString()
    {
        return "d";
    }

    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    }
}