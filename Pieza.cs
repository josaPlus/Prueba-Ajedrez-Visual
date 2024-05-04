interface ComerPieza
{
    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino);
}

public abstract class Pieza
{
    public ColoresPieza color;
    public TipoPieza tipo;

    // constructor
    public Pieza(ColoresPieza color,TipoPieza tipo)
    {   
        this.color = color;
        this.tipo = tipo;
    }  

    public ColoresPieza color { get; set; }

    public ColoresPieza getColor()
    {
        return this.color;
    }

    public ColoresPieza ObtenerColor()
    {
        return this.color;
    }

    public ColoresPieza getColor() 
    {
        return color;
    }

    public TipoPieza getTipo() 
    {
        return tipo;
    }

    public abstract String toString();

    public abstract bool movimientoValido(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino);


    public bool comerPieza(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino) {
        return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    }
}