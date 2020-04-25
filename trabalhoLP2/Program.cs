///  <author> Joao Freitas (16968) & Ricardo Azevedo (17632) </author>
///  <date>15-04-2020</date>
///  <version>0.1</version>
///  <author>a16968@alunos.ipca.pt & a17632@alunos.ipca.pt </author>
///  <desc></desc> 

using System;

namespace trabalhoLP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado emp = new Empregado(45, "Joao", 123456789, 500);
            
            Console.WriteLine(emp.NIF);
            Console.WriteLine(emp.InicioTrabalho);

            Cliente c = new Cliente();
            Hotel hotel = new Hotel("Mercury", "Travessia", 30);
            Console.WriteLine(hotel.MaxQuartos);
            Quarto q1 = new Quarto(c, "02-02-2020");
            q1.Reserva();
            
            Console.WriteLine(hotel.Nome);
            
         
            Console.ReadKey();
           
        }
    }
}
