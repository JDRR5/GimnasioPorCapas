namespace CapaDatos
{
    public class Cliente
    {
        //Todo en un archivo plano sera txt
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Edad { get; set; }
        public string Correo { get; set; }

        public Cliente() { }

        public Cliente(string iD, string nombre, string apellido, string edad, string correo)
        {
            ID = iD;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Correo = correo;
        }

        //Metodo para convertir los atributos en una linea de texto
        public string LinearArchivo()
        {
            return $"{ID}, {Nombre}, {Apellido}, {Edad}, {Correo}";
        }

        //Metodo para separar los datos del archivo
        public Cliente SepararLinea(string linea)
        {
            var datos = linea.Split(',');
            return new Cliente(datos[0], datos[1], datos[2], datos[3], datos[4]);
        }

    }//Clase
}




