using Com.Padroes.De.Projeto.Builder._01.Entidade;
using Com.Padroes.De.Projeto.Builder._03.ProcessoCriacao;

namespace Com.Padroes.De.Projeto.Builder._02.Builders
{
    public class BuilderA4 : BuilderInterfaceGeradorPDF
    {
        private GeradorPdf geradorPDF;

        //Agora o construtor cria o objeto mas não o configura.
        public BuilderA4()
        {
            geradorPDF = new GeradorPdf();
        }

        //Retorna o Objeto.
        public GeradorPdf getGeradorPDF()
        {
            return geradorPDF;
        }

        //Configura o rodapé das páginas conforme A4
        public void setFooter()
        {
            geradorPDF.setHasFooter(true);
            geradorPDF.setFooterHeigh(15);
        }
        //Configura o cabecalho das páginas conforme A4;
        public void setHeader()
        {
            geradorPDF.setHasHeader(true);
            geradorPDF.setHeaderHeigh(15);
        }
        //Configura as margens das páginas conforme A4;
        public void setMargim()
        {
            geradorPDF.setMarginTop(30);
            geradorPDF.setMarginRight(20);
            geradorPDF.setMarginBottom(30);
            geradorPDF.setMarginLeft(20);
        }

        //Define as configurações das páginas conforme A4;
        public void setPageConfiguration()
        {
            geradorPDF.setPageOrientation("portrait");
            geradorPDF.setUnit("mm");
            geradorPDF.setPageSizeX(300);
            geradorPDF.setPageSizeY(597);
            geradorPDF.setPageColor("#ffffff");
            geradorPDF.setEncode("UTF-8");
        }
    }
}