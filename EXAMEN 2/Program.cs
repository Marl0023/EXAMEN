int contadorV=0, contadorA=0, contadorR=0;
do {
    Console.WriteLine("Ingrese los datos(0-9): ");
    char variable = char.Parse(Console.ReadLine().ToUpper());
    switch (variable) { 
        case '0':
        case '1':
        case '2':
        case '3':
            contadorV++;
                break;
        case '4':
        case '5':
        case '6':
            contadorA++;
            break;
        case '7':
        case '8':
        case '9':
            contadorR++;
            break;
        case 'F':
            Console.WriteLine("Finalizado");
            break;
        default:
            Console.WriteLine("Valor no reconocido , vuelva a intentarlo");
            break;
    }
    if (variable == 'F')
    {
        break;
    }
}while (true);