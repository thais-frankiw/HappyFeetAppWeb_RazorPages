using HappyFeetAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HappyFeetAppWeb.Servicos.Memoria;

public class ProdutoServico : IProdutoServico
{
    public ProdutoServico()
        => CarregarListaInicial();

    private IList<Produto> _produtos;

    private void CarregarListaInicial()
    {
        _produtos = new List<Produto>()
    {
        new Produto()
        {
            ProdutoId = 1,
            ProdutoTitulo = "Chinelo Slider PenguinFace" ,
            ProdutoDescricao = "O Chinelo Slider PenguinFace é a união perfeita entre moda e consciência ambiental. Este chinelo, desenvolvido com material ecológico de alta durabilidade, é a escolha ideal para quem busca conforto sem abrir mão do compromisso com o meio ambiente. A palmilha confortável e adaptável se molda ao formato do seu pé, proporcionando suavidade e leveza a cada passo.\r\n\r\nO design moderno e minimalista, seguindo as últimas tendências, garante versatilidade ao seu visual. A tira larga oferece um ajuste seguro, proporcionando segurança e conforto ao caminhar. O solado, feito de borracha resistente, garante estabilidade em diversas superfícies, tornando este chinelo perfeito para relaxar ou passear.\r\n\r\nO Chinelo Slider PenguinFace se adapta a qualquer estilo, sendo o acessório que faltava para completar seu look de maneira consciente e elegante. Adquira já o seu e pise com estilo e responsabilidade ambiental!",
            ImagemUri = "/Images/1_chineloPretoRostoPinguim.jpeg",
            Preco = 129,
            TamanhosDisponiveis = "35, 36, 37, 38, 40, 41, 42, 44",
            ProdutoEmEstoque = true,
            DataDeEnvio = DateTime.Now.AddDays(2)
        },

        new Produto()
        {
            ProdutoId = 2,
            ProdutoTitulo = "Chinelo Slider BeachPenguin",
            ProdutoDescricao = "O Chinelo Slider BeachPenguin é a combinação perfeita de estilo e sustentabilidade. Este chinelo, feito com material ecológico de longa duração, é a opção ideal para quem procura conforto sem sacrificar o compromisso com a natureza. Sua palmilha macia e flexível se ajusta ao formato do seu pé, oferecendo suavidade e leveza a cada passo.\r\n\r\nO design moderno e despojado, inspirado na vibe praiana, confere versatilidade ao seu visual. A tira larga proporciona um ajuste firme, trazendo segurança e conforto ao caminhar. O solado, confeccionado em borracha resistente, assegura estabilidade em uma variedade de superfícies, tornando este chinelo perfeito para curtir momentos de lazer à beira-mar.\r\n\r\nO Chinelo BeachPenguin se adapta a qualquer estilo, sendo o complemento que faltava para completar seu look de praia de maneira consciente e charmosa. Adquira já o seu e desfrute do sol e do mar com estilo e responsabilidade ambiental!" ,
            ImagemUri = "/Images/3_chineloBrancoAzul.jpeg",
            Preco = 149,
            TamanhosDisponiveis = "38,39,40,41,42,43,44,45",
            ProdutoEmEstoque = false,
            DataDeEnvio = DateTime.Now.AddDays(10)
        },

        new Produto()
        {
            ProdutoId = 3,
            ProdutoTitulo = "Chinelo Slider Penguin Laranja Mecânica" ,
            ProdutoDescricao =  "O Chinelo Slider Penguin Laranja Mecânica é a combinação perfeita de estilo urbano e cultura pop. Este chinelo, inspirado no clássico \"Laranja Mecânica\", é a escolha ideal para quem procura conforto com uma pegada mais descolada para curtir a cidade nos fins de semana. \r\n\r\nSua cor laranja vibrante é um aceno ao filme icônico, enquanto o material de alta durabilidade garante que este chinelo resistirá ao ritmo acelerado da vida na cidade. A palmilha macia se ajusta ao formato do seu pé, proporcionando suavidade e leveza a cada passo.\r\n\r\nO design moderno e irreverente é perfeito para quem gosta de se destacar. A tira larga oferece um ajuste seguro, proporcionando segurança e conforto ao caminhar. O solado, feito de borracha resistente, garante estabilidade em diversas superfícies, tornando este chinelo ideal para explorar a cidade.\r\n\r\nO Chinelo Slider Penguin Laranja Mecânica se adapta a qualquer estilo, sendo o acessório que faltava para completar seu look urbano de maneira ousada e divertida. Adquira já o seu e caminhe pela cidade com estilo e personalidade!",
            ImagemUri = "/Images/4_chineloLaranja.jpeg",
            Preco = 129,
            TamanhosDisponiveis = "39,40,42,44,45",
            ProdutoEmEstoque = true,
            DataDeEnvio = DateTime.Now.AddDays(2)
        },

        new Produto()
        {
            ProdutoId = 4,
            ProdutoTitulo = "Chinelo Slider ALLBlackPenguin",
            ProdutoDescricao = "O Chinelo Slider ALLBlackPenguin combina elegância discreta e design sofisticado, inspirado na força dos All Blacks, ideal para quem valoriza o minimalismo com sofisticação. Todo preto, reflete um estilo sério e moderno, perfeito para os que buscam simplicidade e funcionalidade. Feito com material de alta qualidade, oferece durabilidade e conforto, com uma palmilha que se adapta ao pé para uma experiência leve. A marca \"Happy Feet\" é representada pela gravura sutil de um pinguim, simbolizando elegância.\r\n\r\nSeu design clean e acabamento de alta qualidade tornam o chinelo versátil para vários looks, desde casuais até mais sofisticados para noites de verão. A tira larga e solado de borracha resistente garantem ajuste e estabilidade. O Slider ALLBlackPenguin é o acessório ideal para manter estilo com perfil baixo. Adquira o seu e aproveite a combinação de minimalismo e distinção.",
            ImagemUri = "/Images/5_chineloPreto.jpeg" ,
            Preco = 159,
            TamanhosDisponiveis = "35,36,38,40,42,44",
            ProdutoEmEstoque = true,
            DataDeEnvio = DateTime.Now.AddDays(2)
        },

        new Produto()
        {
            ProdutoId = 5,
            ProdutoTitulo = "Pantufa Cosy Heaven Penguin",
            ProdutoDescricao = "Apresentamos a Pantufa Cozy Haven Penguin, o refúgio perfeito para seus pés em dias frios e preguiçosos. Esta pantufa é a definição de conforto e calor, ideal para envolver seus pés em um abraço suave e reconfortante sempre que você desejar relaxar em casa. Confeccionada com materiais de alta qualidade e um interior super macio, a Pantufa Cozy Haven é como uma nuvem para os seus pés. Sua textura \"fofinha\" proporciona uma sensação de aconchego imediato, enquanto a espessa camada de isolamento mantém o calor, garantindo que seus pés permaneçam deliciosamente aquecidos, mesmo nos dias mais gélidos.\r\n\r\nO design acolhedor e charmoso da Pantufa Cozy Haven, com seu visual plush e convidativo, faz dela não apenas uma peça de vestuário, mas também um acessório de conforto para o seu lar. A sola antiderrapante oferece segurança e estabilidade, permitindo que você se movimente tranquilamente pela casa.\r\n\r\nPerfeitas para longas maratonas de filmes, leituras ao lado da lareira ou simplesmente para curtir um relaxamento merecido, as Pantufas Cozy Haven são o complemento essencial para seus momentos de descanso. Adquira já a sua e transforme cada passo em casa numa experiência de puro prazer e calor.",
            ImagemUri = "/Images/pantufa_1BrancaPinguim.jpeg",
            Preco = 229,
            TamanhosDisponiveis = "34,35,35,39,41,42,44",
            ProdutoEmEstoque = true,
            DataDeEnvio = DateTime.Now.AddDays(2)
        },

        new Produto()
        {
            ProdutoId = 6,
            ProdutoTitulo = "Pantufa SoftSock Penguin",
            ProdutoDescricao = "A Pantufa SoftSock Penguin combina a simplicidade de uma meia com o conforto de uma pantufa. Seu design elegante na cor cinza oferece a sensação de estar usando uma meia grossa e quentinha. Com tecido respirável e sola emborrachada, proporciona calor sem superaquecer e segurança ao caminhar. Uma escolha prática e confortável para o dia a dia em casa. Experimente e sinta o abraço aconchegante em cada passo.",
            ImagemUri = "/Images/pantufa_2Cinza.jpeg",
            Preco = 199,
            TamanhosDisponiveis = "34,35,36,37,38,39,40",
            ProdutoEmEstoque = false,
            DataDeEnvio = DateTime.Now.AddDays(10)
        },

        new Produto()
        {
            ProdutoId = 7,
            ProdutoTitulo = "Pantufa Baby Penguin",
            ProdutoDescricao = "Conheça a Pantufa Baby Penguin, perfeita para os pequenos desfrutarem de conforto e diversão. Com um design alegre em cores claras, esta pantufa infantil é feita para parecer uma meia fofa e quentinha, mas com toda a segurança de uma pantufa tradicional. O material macio e o interior acolhedor mantêm os pés das crianças aquecidos, enquanto a sola antiderrapante garante brincadeiras seguras pela casa. Ideal para dias de brincadeira ou relaxamento, a Pantufa Baby Penguin é a combinação perfeita de conforto e estilo lúdico.",
            ImagemUri = "/Images/pantufa_5Infantil.jpeg",
            Preco = 179,
            TamanhosDisponiveis = "17,18,19,20,21,22,23",
            ProdutoEmEstoque = true,
            DataDeEnvio = DateTime.Now.AddDays(2)
        }
    };
    }

    public IList<Produto> ObterTodos()
        => _produtos;

    public Produto Obter(int id)
        => ObterTodos().SingleOrDefault(item => item.ProdutoId == id);

    public void Incluir(Produto produto)
    {
        var proximoId = _produtos.Max(item => item.ProdutoId) + 1;
        produto.ProdutoId = proximoId;
        _produtos.Add(produto);
    }

    public void Alterar(Produto produto)
    {
        var produtoEncontrado = _produtos.SingleOrDefault(item => item.ProdutoId == produto.ProdutoId);
        produtoEncontrado.ProdutoTitulo = produto.ProdutoTitulo;
        produtoEncontrado.ProdutoDescricao = produto.ProdutoDescricao;
        produtoEncontrado.Preco = produto.Preco;
        produtoEncontrado.ImagemUri = produto.ImagemUri;
        produtoEncontrado.TamanhosDisponiveis = produto.TamanhosDisponiveis;
        produtoEncontrado.ProdutoEmEstoque = produto.ProdutoEmEstoque;
        produtoEncontrado.DataDeEnvio = produto.DataDeEnvio;
    }

    public void Excluir(int id)
    {
        var produtoEncontrado = Obter(id);
        _produtos.Remove(produtoEncontrado);
    }

    public IList<Categoria> ObterTodasCategorias()
    {
        throw new NotImplementedException();
    }

    public object ObterCategoria(int id)
    {
        throw new NotImplementedException();
    }

    Categoria IProdutoServico.ObterCategoria(int id)
    {
        throw new NotImplementedException();
    }
}


