using HappyFeetAppWeb.Models;

namespace HappyFeetAppWeb.Servicos;

public interface IProdutoServico
{
    IList<Produto> ObterTodos();
    Produto Obter(int id);
    void Incluir(Produto produto);
    void Alterar(Produto produto);
    void Excluir(int id);

    IList<Categoria> ObterTodasCategorias();
    Categoria ObterCategoria(int id);
}
