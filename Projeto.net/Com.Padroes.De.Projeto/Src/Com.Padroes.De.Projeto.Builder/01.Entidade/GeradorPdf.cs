namespace Com.Padroes.De.Projeto.Builder._01.Entidade
{
    public class GeradorPdf
    {
        private string pageOrientation = "portrait";
        private string unit = "mm";
        private int PageSizeX = 210;
        private int PageSizeY = 297;
        private int marginTop = 30;
        private int marginRight = 20;
        private int marginBottom = 30;
        private int marginLeft = 20;
        private bool hasHeader = false;
        private int headerHeigh = 0;
        private bool hasFooter = false;
        private int footerHeigh = 0;
        private string pageColor = "#ffffff";
        private string encode = "UTF-8";

        public string getPageOrientation()
        {
            return pageOrientation;
        }

        public void setPageOrientation(string _pageOrientation)
        {
            pageOrientation = _pageOrientation;
        }

        public string getUnit()
        {
            return unit;
        }

        public void setUnit(string _unit)
        {
            unit = _unit;
        }

        public int getPageSizeX()
        {
            return PageSizeX;
        }

        public void setPageSizeX(int _PageSizeX)
        {
            PageSizeX = _PageSizeX;
        }

        public int getPageSizeY()
        {
            return PageSizeY;
        }

        public void setPageSizeY(int _PageSizeY)
        {
            PageSizeY = _PageSizeY;
        }

        public int getMarginTop()
        {
            return marginTop;
        }

        public void setMarginTop(int _marginTop)
        {
            marginTop = _marginTop;
        }

        public int getMarginRight()
        {
            return marginRight;
        }

        public void setMarginRight(int _marginRight)
        {
            marginRight = _marginRight;
        }

        public int getMarginBottom()
        {
            return marginBottom;
        }

        public void setMarginBottom(int _marginBottom)
        {
            marginBottom = _marginBottom;
        }

        public int getMarginLeft()
        {
            return marginLeft;
        }

        public void setMarginLeft(int _marginLeft)
        {
            marginLeft = _marginLeft;
        }

        public bool getHasHeader()
        {
            return hasHeader;
        }

        public void setHasHeader(bool _hasHeader)
        {
            hasHeader = _hasHeader;
        }

        public int getHeaderHeigh()
        {
            return headerHeigh;
        }

        public void setHeaderHeigh(int _headerHeigh)
        {
            headerHeigh = _headerHeigh;
        }

        public bool getHasFooter()
        {
            return hasFooter;
        }

        public void setHasFooter(bool _hasFooter)
        {
            hasFooter = _hasFooter;
        }

        public int getFooterHeigh()
        {
            return footerHeigh;
        }

        public void setFooterHeigh(int _footerHeigh)
        {
            footerHeigh = _footerHeigh;
        }

        public string getPageColor()
        {
            return pageColor;
        }

        public void setPageColor(string _pageColor)
        {
            pageColor = _pageColor;
        }

        public string getEncode()
        {
            return encode;
        }

        public void setEncode(string _encode)
        {
            encode = _encode;
        }

        public string __toString()
        {
            var saida = "";
            saida += $"pageOrientation {getPageOrientation()}\n\n";
            saida += $"unit {getUnit()}\n\n";
            saida += $"PageSizeX {getPageSizeX()} mm\n\n";
            saida += $"PageSizeY{getPageSizeY()} mm\n\n";
            saida += $"maginTop{getMarginTop()} mm\n\n";
            saida += $"maginRight{getMarginRight()}mm\n\n";
            saida += $"maginBottom {getMarginBottom()} mm\n\n";
            saida += $"maginLeft {getMarginLeft()} mm\n\n";
            saida += getHasHeader() ? "hasHeader Sim\n\n" : "hasHeader Não\n\n";
            saida += $"headerHeigh {getHeaderHeigh()} mm\n\n";
            saida += getHasFooter() ? "hasFooter Sim\n\n" : "hasFooter Não\n\n";
            saida += $"footerHeigh {getFooterHeigh()} mm\n\n";
            saida += $"pageColor {getPageColor()} \n\n";
            saida += $"encode {getEncode()}\n\n";

            return saida;
        }
    }
}