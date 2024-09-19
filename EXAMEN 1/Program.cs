string nombre;
double venta = 0, salario = 0, comision = 0, descuento = 0,totalGanado=0;
int year = 0;
Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingrese su sueldo bruto: ");
salario=int.Parse(Console.ReadLine());
Console.Write("Ventas realizadas: ");
venta = int.Parse(Console.ReadLine());
Console.Write("Ingrese los años en la empresa: ");
year = int.Parse(Console.ReadLine());
if (venta < 600)
{
    comision = venta * 0.05;
}
else if (600 > venta && venta < 3000)
{
    comision = venta * 0.07;
}
else
    comision = 300 + (venta * 0.06);
totalGanado=salario+comision;
if (year >= 3)
{
    descuento = totalGanado * 0.065;
}
else
    descuento = totalGanado * 0.045;
Console.WriteLine($"Bienvenido {nombre}");
Console.WriteLine($"Su salario total es de: {totalGanado}");
Console.WriteLine($"Descuento por impuestos: {descuento}");
Console.WriteLine($"Salario neto: {totalGanado - descuento}");
