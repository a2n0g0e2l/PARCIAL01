// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Parcial1.Entidades;
using Parcial1.Negocio;



Usuario usuario = new Usuario();
ClsUsuario clsUsuario = new ClsUsuario();

Ventas venta = new Ventas();
ClsVentas clsVentas = new ClsVentas();




Console.WriteLine("Por favor ingrese su nombre ");
usuario.Nombre = Console.ReadLine();

Console.WriteLine("Seria amable de ingresar su contraseña");
usuario.Contraseña = Console.ReadLine();



bool Resultado = clsUsuario.Acreditacion(usuario);
if (Resultado == true)
{
    
    Console.WriteLine("Bienvenid@ a la tienda MAGICAL WORLD ");
    Console.WriteLine("Siente el espiritu de la magia");

    Console.Write("\nPor favor introdusca identificador del producto: ");
    venta.IdentificadorProducto = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nPor favor introdusca el nombre del producto: ");
    venta.NombreProducto = Console.ReadLine();

    Console.Write("\nPor favor introdusca descripcion del producto: ");
    venta.DescripcionProducto = Console.ReadLine();

    Console.Write("\nPor favor introdusca el valor del producto:  ");
    venta.PrecioProducto = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nPor favor introdusca la cantidad de producto que lleva: ");
    venta.CantidadProducto = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($@"El Identificador del producto es: {venta.IdentificadorProducto}
    El producto que va comprar es: {venta.NombreProducto}

    El valor que tiene el producto es: {venta.PrecioProducto}

    El total que tendra que cancelar es: {clsVentas.Pago(venta)}");

}
else
{
    Console.WriteLine("Tu contraseña o tu nombre no coincide por lo tanto es incorrectos lo que ingresaste");
}