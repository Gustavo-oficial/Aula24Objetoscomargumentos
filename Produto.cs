namespace Aula23Listas
{
    public class Produto
    {
        public string Nome { get; set; }

        public int codigo { get; set; }

        public float Preco { get; set; }


        public Produto(){

        }

        public Produto(string _nome, int _codigo, float _preco){
            this.Nome = _nome;
            this.codigo = _codigo;
            this.Preco = _preco;
        }
    }
}