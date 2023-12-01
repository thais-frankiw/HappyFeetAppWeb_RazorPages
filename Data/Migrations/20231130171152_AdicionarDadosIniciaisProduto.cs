using HappyFeetAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HappyFeetAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new HappyFeetDBContext();
            context.Produto.AddRange(ObterCargaInicalProduto());
            context.SaveChanges();
        }
        private IList<Produto> ObterCargaInicalProduto()
        {
            return new List<Produto>()
            {
                new Produto()
                {
                    ProdutoTitulo = "Chinelo Slider PenguinFace" ,
                    ProdutoDescricao = "O Chinelo Slider PenguinFace é a união perfeita entre moda e consciência ambiental. Desenvolvido com material ecológico de alta durabilidade, oferece conforto e compromisso com o meio ambiente. A palmilha adaptável se molda ao formato do pé, proporcionando suavidade a cada passo. O design moderno e minimalista garante versatilidade ao visual. A tira larga oferece ajuste seguro, enquanto o solado resistente garante estabilidade em diversas superfícies. Este chinelo é ideal para relaxar ou passear, adaptando-se a qualquer estilo. Adquira o seu e pise com responsabilidade ambiental!",
                    ImagemUri = "/Images/1_chineloPretoRostoPinguim.jpeg",
                    Preco = 129,
                    TamanhosDisponiveis = "35, 36, 37, 38, 40, 41, 42, 44",
                    ProdutoEmEstoque = true,
                    DataDeEnvio = DateTime.Now.AddDays(2)
                },

                new Produto()
                {
                    ProdutoTitulo = "Chinelo Slider BeachPenguin",
                    ProdutoDescricao = "O Chinelo Slider BeachPenguin é ideal para quem valoriza estilo e sustentabilidade. Fabricado com materiais duráveis e ecológicos, proporciona conforto e compromisso ambiental. A palmilha se molda ao pé, garantindo leveza. Seu design moderno e praiano traz versatilidade, e a tira larga assegura ajuste firme e seguro. O solado de borracha oferece estabilidade em várias superfícies. Perfeito para relaxar na praia, o chinelo combina com qualquer estilo, sendo o toque final para um look praiano consciente. Adquira o seu e desfrute do verão com estilo e cuidado com o ambiente!",
                    ImagemUri = "/Images/3_chineloBrancoAzul.jpeg",
                    Preco = 149,
                    TamanhosDisponiveis = "38,39,40,41,42,43,44,45",
                    ProdutoEmEstoque = false,
                    DataDeEnvio = DateTime.Now.AddDays(10)
                },

                new Produto()
                {
                    ProdutoTitulo = "Chinelo Slider Penguin Laranja Mecânica" ,
                    ProdutoDescricao =  "O Chinelo Slider Penguin Laranja Mecânica mescla estilo urbano com a estética de \"Laranja Mecânica\". A cor laranja remete ao filme, e o material durável é ideal para o cotidiano da cidade. A palmilha confortável se molda ao pé, e a tira larga assegura um ajuste firme. O solado de borracha proporciona estabilidade em várias superfícies. Este chinelo é perfeito para quem busca um visual descolado e quer se destacar com um acessório ousado e divertido. Completa seu look urbano, adicionando personalidade ao caminhar pelas ruas com estilo.",
                    ImagemUri = "/Images/4_chineloLaranja.jpeg",
                    Preco = 129,
                    TamanhosDisponiveis = "39,40,42,44,45",
                    ProdutoEmEstoque = true,
                    DataDeEnvio = DateTime.Now.AddDays(2)
                },

                new Produto()
                {
                    ProdutoTitulo = "Chinelo Slider ALLBlackPenguin",
                    ProdutoDescricao = "O Chinelo Slider ALLBlackPenguin é inspirado na força dos All Blacks, oferecendo um estilo minimalista e sofisticado. Com design todo preto, reflete seriedade e modernidade, ideal para quem busca simplicidade e funcionalidade. Feito de material de alta qualidade, proporciona durabilidade e conforto, com palmilha que se molda ao pé. A marca \"Happy Feet\" é simbolizada por um pinguim gravado discretamente, representando elegância. Seu design limpo e acabamento premium fazem deste chinelo uma escolha versátil para diversos looks, adequando-se a ocasiões casuais ou sofisticadas nas noites de verão. A tira larga e o solado de borracha asseguram um ajuste perfeito e estabilidade. Escolha o Slider ALLBlackPenguin para um estilo discreto e elegante. Adquira o seu e desfrute de uma combinação única de minimalismo e elegância.",
                    ImagemUri = "/Images/5_chineloPreto.jpeg" ,
                    Preco = 159,
                    TamanhosDisponiveis = "35,36,38,40,42,44",
                    ProdutoEmEstoque = true,
                    DataDeEnvio = DateTime.Now.AddDays(2)
                },

                new Produto()
                {
                    ProdutoTitulo = "Pantufa Cosy Heaven Penguin",
                    ProdutoDescricao = "Conheça a Pantufa Cozy Haven Penguin, ideal para dias frios. Com materiais de alta qualidade e um interior macio, essas pantufas oferecem conforto e calor excepcionais. Sua textura aconchegante e isolamento térmico mantêm seus pés aquecidos. O design elegante e acolhedor, além da sola antiderrapante, fazem dela um acessório de conforto e segurança para o lar. São perfeitas para relaxar, seja assistindo filmes, lendo ao lado da lareira, ou apenas descansando. Garanta já a sua Pantufa Cozy Haven e desfrute de calor e conforto em cada passo.",
                    ImagemUri = "/Images/pantufa_1BrancaPinguim.jpeg",
                    Preco = 229,
                    TamanhosDisponiveis = "34,35,35,39,41,42,44",
                    ProdutoEmEstoque = true,
                    DataDeEnvio = DateTime.Now.AddDays(2)
                },

                new Produto()
                {
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
    }
}
