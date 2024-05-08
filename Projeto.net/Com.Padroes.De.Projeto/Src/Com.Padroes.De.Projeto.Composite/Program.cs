
using Com.Padroes.De.Projeto.Composite;

TrechoSimples ts1 = new TrechoSimples("Sao Paulo","Brasilia",500);
TrechoSimples ts2 = new TrechoSimples("Brasilia", "Recife", 300);
TrechoSimples ts3 = new TrechoSimples("Recife", "Natal", 350);

TrechoComposto tc1 = new TrechoComposto(ts2,ts3,30);
tc1.getPreco(); 

TrechoComposto tc2 = new TrechoComposto(tc1, ts1, 50);
tc2.getPreco();
