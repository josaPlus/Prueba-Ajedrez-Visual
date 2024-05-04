public class Caballo : Pieza, ComerPieza
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
    public override bool movimientoValido(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        int distanciaVertical = Math.Abs(filaDestino - filaOrigen);
        int distanciaHorizontal = Math.Abs(columnaDestino - columnaOrigen);

        if ((distanciaVertical == 2 && distanciaHorizontal == 1) || (distanciaVertical == 1 && distanciaHorizontal == 2))
        {
            return true;
        }
        return false;
    }

    public override string toString()
    {
        return "c";
    }

    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    }
}