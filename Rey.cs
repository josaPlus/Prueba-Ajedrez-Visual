public class Rey : Pieza
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
    public override bool movimientoValido(int filaDestino, int columnaDestin)
    {
        throw new NotImplementedException();
    }
    public override string ObtenerRutaImagen()
    {
        if (getColor() == ColoresPieza.NEGRO)
        {
            return "Imagenes/reyNegro.png";
        } else
        {
            return "Imagenes/reyBlanco.png";
        }
    }
    public override string toString()
    {
        return "r";
    }

    // public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    // {
    //     return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    // }
}