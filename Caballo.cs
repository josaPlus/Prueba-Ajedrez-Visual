public class Caballo : Pieza
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
public Caballo(System.Drawing.Color color) : base(ConvertirColorDrawingAColorPieza(color), TipoPieza.CABALLO) 
{
    
}
    public override bool movimientoValido(int filaDestino, int columnaDestin)
    {
        throw new NotImplementedException();
    }

    public override string ObtenerRutaImagen()
    {
        if (this.getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/caballoNegro.png";
        } else
        {
            return "Imagenes/caballoBlanco.png";
        }
    }

    public override string toString()
    {
        return "c";
    }

    // public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    // {
    //     return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    // }
}