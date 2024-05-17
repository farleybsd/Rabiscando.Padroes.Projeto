using Com.Padroes.De.Projeto.Builder._03.ProcessoCriacao;

namespace Com.Padroes.De.Projeto.Builder._04.Orquestrador
{
    public class GeradorPDFDirector
    {
        private BuilderInterfaceGeradorPDF BuilderGeradorPDF;

        //Guarda referência a um objeto do tipo BuilderInterfaceGeradorPDF.
        public GeradorPDFDirector(BuilderInterfaceGeradorPDF builderGeradorPDF)
        {
            BuilderGeradorPDF = builderGeradorPDF;
        }


        //Muda o Builder em tempo de execução.
        public void setBuilderGeradorPDF(BuilderInterfaceGeradorPDF builderGeradorPDF)
        {
            BuilderGeradorPDF = builderGeradorPDF;
        }
        //Configura completamente o objeto criado pelo Builder recebido no construtor.
        public void criarGeradorPDF()
        {
            BuilderGeradorPDF.setPageConfiguration();
            BuilderGeradorPDF.setMargim();
            BuilderGeradorPDF.setHeader();
            BuilderGeradorPDF.setFooter();
        }
        //Configura o objeto criado pelo Builde recebido no construtor sem cabeçalho.
        public void criarGeradorPDFNoHeader()
        {
            BuilderGeradorPDF.setPageConfiguration();
            BuilderGeradorPDF.setMargim();
            BuilderGeradorPDF.setFooter();
        }
        //Configura o objeto criado pelo Builde recebido no construtor sem cabeçalho e rodapé.
        public void criarGeradorPDFNoHeaderNoFooter()
        {
            BuilderGeradorPDF.setPageConfiguration();
            BuilderGeradorPDF.setMargim();
        }
    }
}
