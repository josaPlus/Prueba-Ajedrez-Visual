public class Torre : Pieza, ComerPieza
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

    public override bool movimientoValido(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        int distanciaVertical = Math.Abs(filaDestino - filaOrigen);
        int distanciaHorizontal = Math.Abs(columnaDestino - columnaOrigen);

        if ((distanciaVertical == 0 && distanciaHorizontal != 0) ||
            (distanciaVertical != 0 && distanciaHorizontal == 0))
        {
            return true;
        }
        return false;
    }


    public override string toString()
    {
        return "t";
    }

    public string ObtenerRutaImagen()
{
    if (this.getColor() == ColoresPieza.NEGRO)
    {
        return "C:/Users/josaf/Downloads/torreNegro.png";
    }
    else
    {
        return "C:/Users/josaf/Downloads/torreBlanco.png";
    }
}

    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    }
}