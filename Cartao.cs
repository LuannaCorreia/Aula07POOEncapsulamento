namespace Aula07POOEncapsulamento
{
    public class Cartao
    {
         public string numero { get; set;}

        public string titular { get; set;}

        public string bandeira { get; set;}

        private string  token = "ksjdhksuhdausi sudygUSGD";

        protected string cvv { get; set;}


        public void AprovarCompra(){
            System.Console.WriteLine ("Compra Aprovada!");
        }

        private bool ValidarToken(){
            if (token != null){
                return true;
            } return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}