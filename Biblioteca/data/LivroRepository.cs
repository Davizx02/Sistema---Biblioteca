namespace Biblioteca.data
{
    public class LivroRepository
    {
        private static List<Livro> _tabelaLivros = new List<Livro>()
        private static int proximoID = 1; // Variável auxiliar

        public void Adcionar(Livro livro) // Metódo: adiciona livros na lista
        {
           livro.Id = proximoID++;
           _tabelaLivros.Add(livro);
        }

       public List<Livro> Obtertodos()
        {
            return_tabelaLivros;
        } 
    }
}