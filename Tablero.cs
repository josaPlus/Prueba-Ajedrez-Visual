
public class Tablero
{
    public Pieza?[,] tablero;
    private Panel[,] casillas;
    private Form form;


    public Tablero(Form form)
    {
        this.form = form;
        tablero = new Pieza[8,8];
        inicializarTablero();
    }

    public System.Drawing.Color ConvertirColorPiezaAColorDrawing(ColoresPieza colorPieza)
    {
        switch (colorPieza)
        {
            case ColoresPieza.BLANCO:
                return System.Drawing.Color.White;
            case ColoresPieza.NEGRO:
                return System.Drawing.Color.Black;
            default:
                throw new ArgumentException("Color de pieza no reconocido");
        }
    }

    public void inicializarTablero()
    {
        // colocar piezas
        tablero[0,0] = new Torre(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,1] = new Caballo(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,2] = new Alfil(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,3] = new Dama(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,4] = new Rey(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,5] = new Alfil(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,6] = new Caballo(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        tablero[0,7] = new Torre(ConvertirColorPiezaAColorDrawing(ColoresPieza.NEGRO));
        for (int i = 0; i < 8; i++) {
            tablero[1,i] = new Peon(ColoresPieza.NEGRO);
        }

        tablero[7,0] = new Torre(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,1] = new Caballo(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,2] = new Alfil(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,3] = new Dama(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,4] = new Rey(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,5] = new Alfil(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,6] = new Caballo(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        tablero[7,7] = new Torre(ConvertirColorPiezaAColorDrawing(ColoresPieza.BLANCO));
        for (int i = 0; i < 8; i++) {
            tablero[6,i] = new Peon(ColoresPieza.BLANCO);
        }

        for (int fila = 2; fila < 6; fila++) {
            for (int columna = 0; columna < 8; columna++) {
                tablero[fila,columna] = null;
            }
        }
    }

    public Pieza[,] getTablero() 
    {
        return tablero;
    }

    public void mostrarTablero()
    {
        casillas = new Panel[8, 8];
    
        for (int fila = 0; fila < 8; fila++)
        {
            for (int columna = 0; columna < 8; columna++)
            {
                casillas[fila, columna] = new Panel();
                casillas[fila, columna].Size = new Size(100, 100);
                casillas[fila, columna].Location = new Point(columna * 100 + 150, fila * 100); // Mover 200 píxeles a la derecha y 20 para abajo
                casillas[fila, columna].BackColor = (fila + columna) % 2 == 0 ? Color.White : Color.Brown;
    
                // Crear un botón y asignarle la imagen correspondiente a la pieza
                Button boton = new Button();
                boton.Size = new Size(100, 100);
                Pieza pieza = tablero[fila, columna];
                switch (pieza)
                {
                    case Torre torre:
                        boton.Image = Image.FromFile(torre.ObtenerRutaImagen());
                        break;
                    case Alfil alfil:
                        boton.Image = Image.FromFile(alfil.ObtenerRutaImagen());
                        break;
                    case Caballo caballo:
                        boton.Image = Image.FromFile(caballo.ObtenerRutaImagen());
                        break;
                    case Dama dama:
                        boton.Image = Image.FromFile(dama.ObtenerRutaImagen());
                        break;
                    case Rey rey:
                        boton.Image = Image.FromFile(rey.ObtenerRutaImagen());
                        break;
                    case Peon peon:
                        boton.Image = Image.FromFile(peon.ObtenerRutaImagen());
                        break;
                    default:
                        break;
                }
    
                // Agregar el botón de torres al panel
                casillas[fila, columna].Controls.Add(boton);
    
                // Agregar el panel a form.Controls después de agregar el botón
                form.Controls.Add(casillas[fila, columna]);
            }
        }

        
    }
}