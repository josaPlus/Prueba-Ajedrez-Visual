
public class Alfil : Pieza
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

    public Alfil(System.Drawing.Color color) : base(ConvertColorToColoresPieza(color), TipoPieza.ALFIL)
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
            return "Imagenes/alfilNegro.png";
        }
        else
        {
            return "Imagenes/alfilBlanco.png";
        }
    }

    public override string toString()
    {
        return "a";
    }

    // public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    // {
    //     return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    // }
}