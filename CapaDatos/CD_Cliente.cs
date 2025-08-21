namespace CapaDatos
{
    using System.IO;
    //Importar librerias

    public class CD_Cliente
    {
        //Crear objeto cliente
        private Cliente cliente = new Cliente();

        //Indicar ruta del archivo;
        private string ruta = @"C:\Users\usuario\Downloads\Gimnasio por capas\Archivos planos\clientes.txt";

        //Metodo para registrar al cliente en un archivo plano
        public void RegistraCliente(Cliente cliente)
        {
            //Validar que la carpeta y el archivo exista
            var carpeta = Path.GetDirectoryName(ruta);
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }


            //Almacenar cada linea en el archivo plano
            File.AppendAllText(ruta, cliente.LinearArchivo() + Environment.NewLine);
        }


        //Buscar cliente por id
        public List<Cliente> BuscarCliente(string id)
        {
            var lista = new List<Cliente>();

            //Verificar si el archivo existe
            if (!File.Exists(ruta))
            {
                return lista;

            }

            var lineas = File.ReadAllLines(ruta);

            foreach (var linea in lineas)
            {

                var cli = cliente.SepararLinea(linea);
                if(cli.ID == id)
                {
                    lista.Add(cliente.SepararLinea(linea));
                }
            }
            return lista;
        }

    }
}
