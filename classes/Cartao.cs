namespace Lista.classes
{
    public class Cartao
    {
        public string Titular {get;set;}

        public string Numero {get;set;}

        public string Bandeira {get;set;}

        public int Cvv {get;set;}

        public int Vencimento {get;set;}


        public Cartao(){

        }
        public Cartao(string titular, string numero, string bandeira,int cvv, int vencimento){
            Titular = titular;
            Numero = numero;
            Bandeira = bandeira;
            Cvv = cvv;
            Vencimento = vencimento;
        }

        
    }
}
    
