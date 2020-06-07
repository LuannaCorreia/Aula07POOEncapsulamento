namespace Aula07POOEncapsulamento
{
    public class Mastercard : Cartao
    {
         public int parcelas { get; set;} 

        public void ComprarComDescontoMastercard (float desconto) {

            //Ultilizando encapsulamento com assinatura "Protected"
            cvv = "456";


           System.Console.WriteLine ($"Compra realizada com {parcelas} e R$ {desconto} de desconto");
        }
    }
}