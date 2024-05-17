using Com.Padroes.De.Projeto.Builder._01.Entidade;
using Com.Padroes.De.Projeto.Builder._03.ProcessoCriacao;

namespace Com.Padroes.De.Projeto.Builder._02.Builders
{
    public class BuilderA3 : BuilderInterfaceGeradorPDF
    {
        private GeradorPdf geradorPDF;

        //Agora o construtor cria o objeto mas não o configura.
        public BuilderA3()
        {
            geradorPDF = new GeradorPdf();
        }

        //Retorna o Objeto.
        public GeradorPdf getGeradorPDF()
        {
            return geradorPDF;
        }

        //Configura o rodapé das páginas conforme A3;
        public void setFooter()
        {
            geradorPDF.setHasFooter(false);
            geradorPDF.setFooterHeigh(0);
        }

        //Configura o cabecalho das páginas conforme A3;
        public void setHeader()
        {
            geradorPDF.setHasHeader(false);
            geradorPDF.setHeaderHeigh(0);
        }
        //Configura as margens das páginas conforme A3
        public void setMargim()
        {
            geradorPDF.setMarginTop(60);
            geradorPDF.setMarginRight(40);
            geradorPDF.setMarginBottom(60);
            geradorPDF.setMarginLeft(40);
        }

        //Define as configurações das páginas conforme A3
        public void setPageConfiguration()
        {
            geradorPDF.setPageOrientation("portrait");
            geradorPDF.setUnit("mm");
            geradorPDF.setPageSizeX(297);
            geradorPDF.setPageSizeY(420);
            geradorPDF.setPageColor("#ffffff");
            geradorPDF.setEncode("UTF-8");
        }
    }
}
