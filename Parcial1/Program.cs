// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Parcial1.Entidades;
using Parcial1.Negocio;

static void Main(string[] args)
{
    ClsUsuario usuarioNegocio= new ClsUsuario();  
    ClsVenta ventaNegocio = new ClsVenta();

    //pedir credenciales del usuario
    Console.WriteLine("Ingrese su nombre de usuario: ");
    string Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña: ");
    string Contraseña = Console.ReadLine();

    //Verificar las credenciales 
    if (usuarioNegocio.Acceso(Nombre, Contraseña))
    {
        Console.WriteLine("ingrese el identificador del producto: ");
        int identificador = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese el nombre del producto: ");
        string nombreProducto = Console.ReadLine();
        Console.WriteLine("Ingrese la descripcion del producto: ");
        string descripcionProducto = Console.ReadLine();
        Console.WriteLine("ingrese el precio del producto: ");
        decimal precioProducto = decimal.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la cantidad de productos: ");
        int cantidadProducto = int.Parse(Console.ReadLine());


        //crear una venta 
        Venta venta = new Venta
        {
            IdentificacionDProducto = identificador,
            NombreDProducto = nombreProducto,
            DescripcionDProducto = descripcionProducto,
            PrecioDProducto = precioProducto,
            CantidadDProducto = cantidadProducto,

        };

        // cobro de la venta
        ventaNegocio.Cobro(venta);


    }
    else
    {
        Console.WriteLine("el usuario a ingresado las credenciales incorrectas");
    }

           

}
