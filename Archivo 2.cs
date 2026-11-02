using System;
using System.IO;

class Historial
{
    public static void Guardar(string accion)
    {
        File.AppendAllText(
            "historial.txt",
            DateTime.Now + " - " + accion + "\n"
        );
    }
}
