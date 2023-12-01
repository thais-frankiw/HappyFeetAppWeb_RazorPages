using HappyFeetAppWeb.Data;
using HappyFeetAppWeb.Models;
using System.Text.RegularExpressions;

namespace HappyFeetAppWeb.Servicos.Data;

public class ProdutoServico : IProdutoServico
{
    private HappyFeetDBContext _context;
    public ProdutoServico(HappyFeetDBContext context)
    {
        _context = context;
    }
    public void Alterar(Produto produto)
    {
        var produtoEncontrado = Obter(produto.ProdutoId);
        produtoEncontrado.ProdutoTitulo = produto.ProdutoTitulo;
        produtoEncontrado.ProdutoDescricao = produto.ProdutoDescricao;
        produtoEncontrado.ImagemUri = produto.ImagemUri;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.TamanhosDisponiveis = produto.TamanhosDisponiveis;
        produtoEncontrado.DataDeEnvio = produto.DataDeEnvio;
        produtoEncontrado.CategoriaId = produto.CategoriaId;
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _context.Produto.Remove(produtoEncontrado);
        _context.SaveChanges();
    }

    public void Incluir(Produto produto)
    {
        _context.Produto.Add(produto);
        _context.SaveChanges();
    }

    public Produto Obter(int id)
    {
        return _context.Produto.SingleOrDefault(item => item.ProdutoId == id);
    }

    public IList<Produto> ObterTodos()
    {
       return _context.Produto.ToList();
    }

    public IList<Categoria> ObterTodasCategorias() 
        => _context.Categoria.ToList();

    public Categoria ObterCategoria(int id)
        => _context.Categoria.SingleOrDefault(item => item.CategoriaId == id);
}
