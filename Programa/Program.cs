/*5.Realiza el análisis, diseño e implementación de un programa que pregunte el tipo de boleto (A, N, I), 
 * muestre su precio y luego pregunte si hay otro cliente, si el usuario contesta que sí, debe repetir el proceso. 
 * Considera lo siguiente:*/
/*Un parque de diversiones tiene una máquina para vender boletos de tres tipos:*/
/*A Adulto que cuestan $120*/
/*N Niños que cuestan $75*/
/*I Adultos con credencial del INSEN que cuestan $60*/
/*Para comprar los boletos en esta máquina debe solicitarse uno a la vez. Puedes suponer que la máquina tiene una cantidad ilimitada de boletos.*/

using System;
char boleto;
int op;
Console.WriteLine("Bienvenido a nuestro parque de diversiones ");
Console.WriteLine("A: Adulto - Costo: $120");
Console.WriteLine("N Niños - Costo: $75");
Console.WriteLine("I Adultos con credencial INSEN - Costo: $60");

do
{
    Console.WriteLine("Selecciona el tipo de boleto que deseas: ");
    boleto =Char.ToUpper(Console.ReadKey().KeyChar);

    switch (boleto)
    {
        case 'A':
            Console.WriteLine("\nEl boleto cuesta $120 ");
            break;

        case 'N':
            Console.WriteLine("\nEl boleto cuesta $75");
            break;

        case 'I':
            Console.WriteLine("\nEl boleto cuesta $60");
            break;

        default:
            Console.WriteLine("\nOpción no valida");
            break;

    }

    Console.WriteLine("\nSi deseas otro boleto introduce 1, de lo contrario digite 2 para terminar: ");
    op = Int32.Parse(Console.ReadLine());
} while (op == 1);
    


