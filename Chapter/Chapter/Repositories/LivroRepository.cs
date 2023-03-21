using Chapter.Contexts;
using Chapter.Interfaces;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext context) 
        {
            _context = context;
        }

        public void Atualizar(int id, Livro livro)
        {
            Livro livroEncontrado = _context.Livros.Find(id);
            if (livroEncontrado != null) 
            {
                livroEncontrado.Titulo = livro.Titulo;
                livroEncontrado.QuantidadePaginas = livro.QuantidadePaginas;
                livroEncontrado.Disponivel = livro.Disponivel;
            }

            _context.Livros.Update(livroEncontrado);
            _context.SaveChanges();
        }

        public Livro BuscarPorId(int id)
        {
            return _context.Livros.Find(id);
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livro = _context.Livros.Find(id);
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
