using Com.Padroes.De.Projeto.Builder._01.Entidade;

namespace Com.Padroes.De.Projeto.Builder._03.ProcessoCriacao
{
    public interface BuilderInterfaceGeradorPDF
    {
        public GeradorPdf getGeradorPDF();
        public void setPageConfiguration();
        public void setMargim();
        public void setHeader();
        public void setFooter();
    }
}
