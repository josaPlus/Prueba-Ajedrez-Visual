public class Peon : Pieza, ComerPieza
{
public Peon(ColoresPieza color) : base(color, TipoPieza.PEON) 
{

}
    public override string toString()
    {
        return "p";
    }

    public override bool movimientoValido(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        int distanciaVertical = filaDestino - filaOrigen;
        int distanciaHorizontal = Math.Abs(columnaDestino - columnaOrigen);
        ColoresPieza colorBlanco = new ColoresPieza();

        if (getColor() == colorBlanco)
        {
            if (distanciaVertical == -1 && distanciaHorizontal == 0)
            {
                return true;
            }
            if (filaOrigen == 6 && distanciaVertical == -2 && distanciaHorizontal == 0)
            {
                return true;
            }
            if (distanciaVertical == -1 && distanciaHorizontal == 1)
            {
                return true;
            }
        }
        else
        {
            if (distanciaVertical == 1 && distanciaHorizontal == 0)
            {
                return true;
            }
            if (filaOrigen == 1 && distanciaVertical == 2 && distanciaHorizontal == 0)
            {
                return true;
            }
            if (distanciaVertical == 1 && distanciaHorizontal == 1)
            {
                return true;
            }
        }
        return false;
    }

    public bool comer(int filaOrigen, int columnaOrigen, int filaDestino, int columnaDestino)
    {
        // Implementación del método comer
        // Aquí puedes poner la lógica para comer una pieza en el juego de ajedrez
        throw new NotImplementedException();
    }
}