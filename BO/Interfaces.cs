using System;

namespace BO
{
    interface IQ
    {
        bool Reserva();
        bool Reserva(Quarto quarto);
        Check CheckIn(Cliente client,DateTime chegada);

    }

   
   

   
}
