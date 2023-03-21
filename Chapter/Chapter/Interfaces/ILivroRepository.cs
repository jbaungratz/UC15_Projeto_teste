using Chapter.Models;

namespace Chapter.Interfaces
{
/*    public interface ILivroRepository
    {
        List<Livro> Ler();
    }*/
    public interface ILivroRepository
    {
        List<Livro> Listar();

        Livro BuscarPorId(int id);

        void Cadastrar(Livro livro);

        void Atualizar(int id, Livro livro);

        void Deletar(int id);
    }


}
