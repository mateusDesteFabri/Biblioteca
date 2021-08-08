using System.Collections.Generic;

namespace Biblioteca.Models
{
    public class CadEmprestimoViewModel
    {
        public ICollection<Livro> Livros { get; set; }
        public Emprestimo Emprestimo { get; set; }

        //Para resolver problema 7

        public ICollection<Livro> ListarDisponiveisCadastroEmprestimo(){

            LivroService livroService = new LivroService();
            return livroService.ListarDisponiveis();
        } 
    }
}