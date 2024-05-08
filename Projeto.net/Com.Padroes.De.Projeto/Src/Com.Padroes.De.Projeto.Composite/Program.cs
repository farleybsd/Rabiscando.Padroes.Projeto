
using Com.Padroes.De.Projeto.Composite;
/*
 * "Esta seção apresenta o padrão ​ ​Composite​ ​, cujo objetivo é prover uma solução para objetos que representam um conjunto de objetos, mas que compartilham a mesma abstração deles.
 */

TrechoSimples ts1 = new TrechoSimples("Sao Paulo","Brasilia",500);
TrechoSimples ts2 = new TrechoSimples("Brasilia", "Recife", 300);
TrechoSimples ts3 = new TrechoSimples("Recife", "Natal", 350);

TrechoComposto tc1 = new TrechoComposto(ts2,ts3,30);
tc1.getPreco(); 

TrechoComposto tc2 = new TrechoComposto(tc1, ts1, 50);
tc2.getPreco();
