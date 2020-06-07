using System;

namespace Aula07POOEncapsulamento
{
    class Program
    {
        static void Main(string[] args)

        {
            Cartao card = new Cartao();
           card.AprovarCompra();

           Mastercard master = new Mastercard();
           master.parcelas = 5;
           master.ComprarComDescontoMastercard(50f);
        }
    }
}
