livro livro1 = new livro();
livro1.titulo = "SPQR";
livro1.autor = "Mary Beard";
livro1.ano = 2015;
livro1.paginas = 560;

livro1.informacoes();

livro livro2 = new livro();
livro2.titulo = "Arte da Guerra";
livro2.autor = "Sun Tzu";
livro2.ano = 400;
livro2.paginas = 128;

livro2.informacoes();
livro2.TemMaisDe300Paginas();

if(livro2.TemMaisDe300Paginas())
{
    Console.WriteLine("Tem mais de 300 páginas!");
}
else
{
    Console.WriteLine("Tem menos de 300 páginas!");
}