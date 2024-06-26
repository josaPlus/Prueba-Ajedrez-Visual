interface ComerPieza
{
    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino);
}

public abstract class Pieza
{
    
    private ColoresPieza _color;
    public TipoPieza tipo;

    // constructor
    public Pieza(ColoresPieza color,TipoPieza tipo)
    {   
        this._color = color;
        this.tipo = tipo;
    }   
    public ColoresPieza Color { get { return _color; } set { _color = value; } }

    public ColoresPieza ObtenerColor()
    {
        return this._color;
    }
    public Button Boton { get; set; }


    public ColoresPieza getColor() 
    {
        return _color;
    }
    public TipoPieza getTipo() 
    {
        return tipo;
    }

    public abstract string ObtenerRutaImagen();

    public abstract String toString();

    public int fila { get; set; }
    public int columna { get; set; }

    public abstract bool movimientoValido(int filaDestino, int columnaDestin);

    // public bool comerPieza(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino) {
    //     return movimientoValido(filaOrigen, columnaOrigen, filaDestino, columnaDestino);
    // }
}