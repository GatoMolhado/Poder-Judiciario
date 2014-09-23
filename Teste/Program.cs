using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.SetWindowSize(74, 34);
            Console.BufferWidth = 74;
            Console.BufferHeight = 34;
            A = Prologo();
            Console.ReadKey();
            Console.Clear();
            Dia1();
            Console.ReadKey();
            Console.Clear();
            B = Interlúdio(A);
            Console.ReadKey();
            Console.Clear();
            Dia2(B);
            Console.ReadKey();
            Console.Clear();
            Console.Write("\n\n----------------------------------------\n\n FIM \n\n----------------------------------------");
            Console.ReadKey();
        }
        static int Prologo()
        {
            int A;
            string text;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n----------------------------------------\n\n PRÓLOGO \n\n----------------------------------------\n\n");
            Console.Write(" O celular está vibrando em seu bolso. Olhando para a tela, você vê que é sua mulher chamando. Você está extremamente cansado e, sendo sua primeira vez em um tribunal como um juiz formado, está ");
            Console.Write("bastante tenso com o caso \nque terá que lidar daqui a 10 minutos. \n Vocês brigaram ontem a noite, e ela está ligando provavelmente para \nreclamar ");
            Console.Write("das bebidas que você tomou logo de manha. Se você não atender, \nela provavelmente ficará ainda mais brava, mas você realmente não está comsaco para ouvir horas ");
            Console.Write("de reclamações.....Por outro lado você pode utilizara desculpa de que você já estava em corte na hora que o celular tocou...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nAtender ou Não Atender?\n");
            Console.WriteLine("\n\n*Nota: Se tiver duvidas do que fazer durante o jogo, digite 'Ajuda'\n");
            text = (Console.ReadLine());
            while (text != "Atender" && text != "Não Atender")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nA decisão é tão importante que você nem consegue pensar direito...");
            }
            if (text == "Atender")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nEsposa: \"Porque demorou tanto para atender?!\"\nEssa é a primeira coisa que você ouve assim que atende");
                Console.Write("\nRespostas:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n1-Amor, cal...\n2-Não me venha co...\n");
                text = (Console.ReadLine());
                while (text == "Ajuda")
                    text = ComandoAjuda();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nEsposa: \"Você é sempre assim! Nunca me dá atenção, nem atenção a sua \nprópria filha!\"\nRespostas:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n1-Ei, calma, vamos con...\n2-Você está chegando no meu limite...\n");
                text = (Console.ReadLine());
                while (text == "Ajuda")
                    text = ComandoAjuda();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nEsposa: \"Você ama mais as suas bebidas e seu poker de sabádo a noite do \nque sua própria familia! E você quer saber o que mais? Esse foi o exato \nmotivo de eu ter traido você ano passado!\"");
                Console.Write("\n\n Ela realmente está chegando no seu limite. Você trabalha o dia inteiro e é assim que ela lhe trata?! Equanto ela está recuperando o folego, você vêa sua oportunidade para dar sua resposta.");
                Console.Write("\nQual será sua postura nessa situação? Você será:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAgressivo ou Calmo.\n");
                text = (Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                while (text != "Agressivo" && text != "Calmo")
                {
                    if (text == "Ajuda")
                        text = ComandoAjuda();
                    else
                        text = ComandoInvalido("\nA decisão é tão importante que você nem consegue mover sua boca...");
                }
                if (text == "Agressivo")
                {
                    A = 1;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nVocê: \"Não me venha com essas desculpas! Eu trabalho duro, pago todos \naqueles sapátos caros seus e você ainda me trai com a porra do VIZINHO?! \nVOCÊ é o motivo por eu beber tanto!\"");
                    Console.Write("\n\nEsposa: \"Seu Filho da...\"");
                    Console.Write("\n\nVocê: \"Sou EU que estou falando agora! E sabe a verdade?! Não existe pokernenhum. Aos sabádos eu vou para o puteiro! E nem isso consegue livrar \nminha cabeça dos problemas que VOCÊ me trás.\"");
                    Console.Write("\n\nEsposa: \"A Carla...\"");
                    Console.Write("\n\nVocê: \"Não OUSE trazer nossa filha nisso! Quer saber?! Foda-se: Aquela \ncasa é minha. Sou eu que pago e ela está no meu nome. Quando eu voltar \npara ela eu não quero ver você lá...\"");
                    Console.Write("\n\nEsposa: \"Você não pode...!\"");
                    Console.Write("\n\n*CLICK*");
                    Console.Write("\n\n Você desliga o celular na cara dela. Ela ainda estava falando quando vocêapertou o botão. Você não está exatamente se sentindo bem, mas pelo menos você sente um pouco de alívio, como se parte da pressão que estava em seusombros fossem embora.");
                    Console.Write(" Há algumas pessoas olhando para você (provavelmente você gritou enquanto discutia no celular). Você as iguinora. Está quase nahora de começar seu trabalho.");
                    Console.Write("\n\n...");
                    Console.Write("\n\nHoje não será um bom dia...");
                }
                else
                {
                    A = 2;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\nVocê: \"...\"");
                    Console.Write("\n\nEsposa: \"...\"");
                    Console.Write("\n\nVocê: \"Agata, escuta... Eu sei que nós tivemos problemas ontem a noite, \nmas grande parte do que eu disse foi a raiva falando.\"");
                    Console.Write("\n\nEsposa: \"Eu sei... Eu tambem falei coisas que não devia...\"");
                    Console.Write("\n\nVocê: \"Eu não quero que esse seja nosso futuro.\"");
                    Console.Write("\n\nAgata: \"Eu tambem não quero isso. Nem quero que isso seja o exemplo que \nvamos passar para a Carla. Me desculpa por ter falado aquilo sobre trair.\"");
                    Console.Write("\nVocê: \"Eu sei. Tambem sinto muito.\"");
                    Console.Write("\n\nAgata: \"...\"");
                    Console.Write("\n\nVocê: \"...\"");
                    Console.Write("\n\nAgata: \"Te vejo em casa...\"");
                    Console.Write("\n\nVocê: \"Okay\"");
                    Console.Write("\n\n Havia mais coisas as quais você queria falar, mas nada saia da sua boca. O seu casamento não ia bem fazia alguns anos, e você estaria mentindo se \ndissesse que o pensamento sobre separação nunca cruzou sua mente. A idéia nunca se");
                    Console.Write(" concretizou pois você tinha medo de como isso iria afetar o \ncrescimento de sua filha, Carla, mas desde que ele fez 19 anos, o \npensamento voltou a rondar sua mente. Você sai de seus desvaneios quando \nse da conta que está quase na hora de começar o tribunal.");
                    Console.Write(" Seus problemas \nterão que ficar para depois.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n Você sabia que talvez não era a coisa certa a se fazer, mas o fato de nãoter atendido o celular pode ter impedido uma briga muito pior de ter \nacontecido. Você só vai ter certeza absoluta quando chegar em casa... ");
                Console.Write("\n A verdade era que o seu casamento não ia bem fazia alguns anos, e você \nestaria mentindo se dissesse que a palavra divórcio nunca cruzou sua mente. Você nunca atuou na ideia, pois tinha medo de como isso iria \nafetar o crescimento de sua ");
                Console.Write("filha, Carla. Mas des de que ela fez 19 anos opensamento voltou a rondar sua mente. Talvez a separação fizesse todos se sentirem melhor...");
                Console.Write("\n\n Ainda faltavam 8 minutos para começar o julgamento, e o nervosismo está \ndeixando você suando frio e com a boca seca. Você poderia ir à loja em \nfrente ao tribunal e comprar algo e voltar a tempo (você realmente se");
                Console.Write(" \nbeneficiaria de um pouco de ar livre...), ou você poderia deixar para \ncomprar algo depois e, nesses 8 minutos que ainda restam, conversar com \nalguns conhecidos que você viu a pouco andando pelos corredores.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSair ou Não Sair?\n");
                text = (Console.ReadLine());
                while (text != "Sair" && text != "Não Sair")
                {
                    if (text == "Ajuda")
                        text = ComandoAjuda();
                    else
                        text = ComandoInvalido("\nA sede está começando a afetar a velocidade de seus pensamentos...");
                }
                if (text == "Sair")
                {
                    A = 3;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n Você se sente mais leve assim que coloca o pé para fora. Você não sabe \nexplicaro “porquê” exatamente, mas o visão da cidade agitada, com pessoas correndo de um lado para o outro como formigas, era  ");
                    Console.Write("relaxante. O mundo \nparecia estar seguindo uma ordem, e tudo funcionava bem.\n Mesmo antes de entrar na loja já se podia ouvir o radio lá de");
                    Console.Write(" dentro \ntocando uma musica pop que estava num volume um pouco acima do que você \nconsidera prazeroso. Não querendo perder tempo, você se move em direção aopequeno freezer no canto, onde todas as bebidas");
                    Console.Write(" estão. Antes mesmo de \nchegar lá, você ouve um grito vindo da entrada:\n\nLadrão: TODO MUNDO PARADO!\n\nVocê:...\n\nVocê estava paralisado, sem reação.");
                    Console.Write("\n\nLadrão: VOCÊ!\n\nUm homem de toca aponta para você.\n\nLadrão: PASSA A CARTEIRA AGORA!\n\nVocê: O-O-que...\n\nLadrão: CARTEIRA! AGORA!");
                    Console.ReadKey();
                    Console.Write("\n\n Você não havia notado até agora, mas o homem carregava um revolver, e o \nestava apontando para seu peito. ‘Será que consigo pegar a arma da mão \ndele? Mas, e se ele tiver uma faca?’. Seus");
                    Console.Write(" pensamentos traçavam planos de fuga, mas o seu corpo permanecia imóvel. No final a decisão tomada foi a \nmais segura: Você entregou sua carteira e celular. Sorte sua que seus \ndocumentos importantes ");
                    Console.Write("permaneciam na sua mesa de escritório durante o \ntrabalho...\n O Ladrão fez a mesma coisa com alguns outros clientes que estavam na lojano momento e com o caixa. Sem ligar se estava sendo visto ");
                    Console.Write("ou não, o homem pega o que ele quer e sai correndo pela porta da frente. Demora alguns \ninstantes para você se dar conta do que aconteceu:\n\nUm assalto!\n\nNo meio do dia!\n\nComo que a segurança da cidade chegou a esse ponto?!");
                    Console.Write("\n\n Você já foi assaltado antes, mas a sensação de impotência sempre parece \nnova. O fato de ter se tornado um juiz fez você achar que o medo pela sua segurança (e de seus conhecidos) diminuiria, mas a ");
                    Console.Write("verdade demorou para \nser aceita por você:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nNão há segurança absoluta.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Write("\n\nNão importa sua posição politica ou localidade geografica.\n\n Você costuma acordar a noite, suado, pensado que talvez aquela seja a \nnoite que alguem invadirá sua casa. O álcool e outros tipos de \nentretenimento são um bom ");
                    Console.Write("escapimos nas horas que esses pensamentos se \nfixam em sua mente...\n Com as mão um pouco tremules (em partes de medo, em partes de raiva), \nvocê volta para o tribunal. Hoje vai um longo dia...");
                }
                else
                {
                    A = 4;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n Você prefere ficar no tribunal mesmo. Você falando para si mesmo que é \npor causa do sol escaldante lá fora, mas a verdade soava em sua mente: O \nmedo de perder sua familia está crescendo nos ultimos tempos.");
                    Console.Write(" Mesmo que ascoisas não vão bem, você os ama e nunca iria querer ve-los machucados (nãode propósito, pelo menos). Vocês já estiveram felizes juntos um dia, mas ocurso da vida os separaram. Será que não");
                    Console.Write(" existe possiblidade nenhuma de \nvoltar a ser como era antes?\n Você decide que hoje você irá tirar essa preocupação de sua mente. Não \nimporta se ela decidir se separar ou dar outra chance a relação,");
                    Console.Write(" pelo \nmenos você saberá que fez o possivel para tentar resolver a situação.\n\n...\n\n Enquanto pensava sobre essas coisas, você nem percebeu que faltava apenas1 minuto para dar seu horário de entrar na corte.");
                    Console.Write(" Se apressando o maximo \nque pode,você pega seus papéis e corre em direção ao tribunal. Você esperaque o dia termine rápido, para ver sua mulher logo...");
                    Console.Write("\n\n...Droga, nem deu tempo ver os conhecidos que você tinha visto...");
                }
            }
            return A;
        }
        static void Dia1()
        {
            int A, B, C;
            string text;
            A = B = C = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n----------------------------------------\n\n TRIBUNAL: DIA 1\n\n----------------------------------------");
            Console.Write("\n Você entra no tribunal um pouco antes de começar o julgamento. As pessoasestão se acomodando em seus assentos e cochichando umas para as outras.");
            Console.Write(" Osjuízes organizam suas papeladas e, com caras preocupadas, revisam o caso. Assim que você entra na sala todos terminam de se ajeitar em suas cadeiras");
            Console.Write("e lhe olham fixamente. Todos se levantam. \n\n Você: \"Estamos aqui para julgar o caso DL-6/2014 referente a acusão de \nestupro por parte do acusado João Snigik");
            Console.Write(" para com a Anna Figaro.\"");
            Console.Write("\n\nJoão: \"Como se eu foss...\"");
            Console.Write("\n\n João, o homem acusado, começa a falar, mas é rapidamente interrompido porseu advogado, que fazia um olhar de desaprovação gigantesco. Você conseguever no");
            Console.Write(" rosto de João que é sua primeira vez em um tribunal.\n\nVocê: \"Bem, sem mais delongas...\"");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Vamos ouvir a defesa do acusado, João.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nB");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": Vamos ouvir os promotores em favor de Anna.\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            while (text != "A" && text != "B")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nVocê não sabe qual deles está falando a verdade...");
            }
            if (text == "A")
            {
                A++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nAnna: \"É isso que eu esperaria de um juíz novato...\"\n\nAnna fala, em um tom baixo.");
                Console.Write("\n\nVocê: \"O que foi que você disse, senhorita Anna?\"");
                Console.Write("\n\nAdvogado da promotoria: \"Me desculpe meritíssimo senhor juíz, minha \ncliente fez apenas um comentário sobre a cadeira que ela está sentada, a \nqual não tem nada a ver com o caso. Novamente, me deculpe meritissímo.\"");
                Console.Write("\n\n Você olha irritado para a mulher e seu advogado. Ele realmente achou que você não havia ouvido o comentário?! Para não causar desconfortos");
                Console.Write(" alem do necessário, você deixou passar essa.\n\nVocê: \"Tente falar apenas quando for necessário, senhorita Anna.\"");
                Console.Write("\n\nAnna:\"...\"");
                Console.Write("\n\nAdvogado da promotoria: \"Ela vai, meritíssimo senhor juíz.\"");
                Console.Write("\n\n Era evidente o nervosismo do promotor com o comentário de sua cliente, decerta maneira, isso até era engraçado...");
                Console.Write("\n\nVocê: \"Bem, vamos dar continuidade ao caso. Defesa, por favor, continue.\"");
                Console.Write("\n\nAdvogado de Defesa: \"Bem, meretissímo, a senhorita Anna, (que é uma antiganamorada do senhor João, diga-se de passagem) acusa o meu cliente de \nte-la estuprado em uma festa a qual ambos estavam presentes. Acusação");
                Console.Write(" estaque é obviamente falsa. Meu cliente, sendo um cidadão exemplar e \nparticipando de eventos de caridade, nunca faria tal coisa como agredir \noutra pessoa.\"");
                Console.ReadKey();
                Console.Write("\n\nPromotor: \"me poupe do discurso do bom cidadão! E a inocência do acusado \nfica a cargo do juiz, não de seus julgamentos premeditados, senhor \nLocke...\"");
                Console.Write("\n\nDefesa: \"Com licença senhor Shepard, eu estou apenas fazendo a abertura docaso e apresentando os fatos...\"");
                Console.Write("\n\nPromotor: \"É, o 'obviamente' mostra muit...\"");
                Console.Write("\n\n*PAW \n*PAW");
                Console.Write("\n\nVocê bate seu martelo para chamar a atenção dos dois advogados.");
                Console.Write("\n\nVocê: \"Ordem no tribunal! As avenças dos senhores devem ser resolvidas lá fora, por favor se mantenham profissionais enquanto estão aqui.\"");
                Console.Write("\n\nPromotor e Defesa: \"Sim senhor meritissimo\"");
                Console.Write("\n\n Você tem a impressão que de eles já se conhecem e você pegou uma \ndiscussão pela metade. Essas brigas devem ser frequentes entre eles. Mesmotendo que manter o profissionalismo e ordem na corte, você acha divertido essa situação.");
                Console.Write(" Talves deixe o caso menos pesado, levando em consideração oassunto que ele trata...");
                Console.Write("\n\nVocê: \"Ok, senhor Shepard, apresente o seu lado da história então.\"");
                Console.Write("\n\nPromotor: \"Como foi dito, o senhor João está sendo acusado de estuprar \nminha cliente em uma festa. Diferente do que as pessoas podem pensar, a \nsenhorita Anna não procura fama ou dinheiro com o processo, apenas trazer um monstro");
                Console.Write(" aos olhos da justiça...\"");
                Console.ReadKey();
                Console.Write("\n\nDefesa: \"Quem está fazendo o discurso do bom cidadão agora, hã?...\"");
                Console.Write("\n\nAnna: \"Eu posso falar por mim mesma!\"");
                Console.Write("\n\nVocê olha com um olhar de reprovação para Anna. O promotor vê isso e fica ainda mais nervoso.");
                Console.Write("\n\nVocê: \"Eu concordo que já é hora do autor dar seu depoimento.\"");
                Console.Write("\n\nPromotor: \"Como desejar, meretíssimo.\"");
                Console.ReadKey();
            }
            else
            {
                B++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nPromotor: \"Meretissímo senhor juíz, no caso que temos em mãos o senhor \nJoão está sendo acusado de estuprar minha cliente em uma festa. Diferente do que as pessoas podem pensar,");
                Console.Write(" a senhorita Anna não procura fama ou \ndinheiro com o processo, apenas trazer um monstro aos olhos da justiça...\"");
                Console.Write("\n\nDefesa: \"Fazendo o discurso do bom cidadão agora, hã?...\"");
                Console.Write("\n\nPromotor: \"Como o senhor deve ver nos papeis em sua mesa, Anna, quando \nreportou o crime na policia, ainda estava com semem em sua parte intima. \nSemem este que foi provado pertencer ao acusado, João Snigik. Isto já é \nprova sucifiente para mostrar quem é o culpado neste caso.\"");
                Console.Write("\n\n Havia um peso no ar depois das palavras do promotor serem ditas. Parecia que todos sentiram, ao mesmo tempo, o quão delicado seria este caso...");
                Console.Write("\n\nDefesa: \"Não há como dizer se foi realmente estupro. O semem poderia ter \nvindo de um sexo consensual entre João e Anna.\"");
                Console.Write("\n\nPromotor: \"Se este fosse o caso, nós não estariamos aqui hoje, senhor \nLocke.\"");
                Console.Write("\n\nDefesa: \"A não ser que ela queria vingança por meu cliente ter quebrado o relacionamente que eles tinham.\"");
                Console.Write("\n\nPromotor: \"O que o senhor acabou de dizer é não passa de acusações \ninfundadas!\"");
                Console.ReadKey();
                Console.Write("\n\nDefesa: \"O que eu acabei de dizer é o motivo prov....\"");
                Console.Write("\n\nAnna: \"Eu posso falar por mim mesma!\"");
                Console.Write("\n\n*PAW \n*PAW");
                Console.Write("\n\nVocê bate seu martelo para chamar a atenção de todos.");
                Console.Write("\n\nVocê: \"Ordem no tribunal! As avenças dos senhores devem ser resolvidas lá fora, por favor se mantenham profissionais enquanto estão aqui.\"");
                Console.Write("\n\nPromotor e Defesa: \"Sim senhor meritíssimo\"");
                Console.Write("\n\n Você tem a impressão que de eles já se conhecem e você pegou uma \ndiscussão pela metade. Essas brigas devem ser frequentes entre eles. Mesmotendo que manter o profissionalismo e ordem na corte, você acha divertido essa situação.");
                Console.Write(" Talves deixe o caso menos pesado, levando em consideração oassunto que ele trata...");
                Console.Write("\n\nVocê: \"E, senhorita Anna, tente falar apenas quando for necessário.\"");
                Console.Write("\n\nAnna:\"...\"");
                Console.Write("\n\nVocê: \"Mas eu concordo que já é hora do autor dar seu depoimento.\"");
                Console.Write("\n\nPromotor: \"Como desejar, meretíssimo.\"");
                Console.ReadKey();
            }
            Console.Clear();
            Console.Write("\n\n---------------------------------------\n\n");
            Console.Write(" Depois de um tempo para se ajeitarem, a autora, Anna Figaro, \nfinalmente está pronta para começar. O advogado de defesa, o senhor Locke,começa a questiona-lá.");
            Console.Write("\n\nDefesa: \"Senhorita Anna, você alega que, na segunda-feira dia 7, duas \nsemanas atrás, você foi à uma festa de um conhecido. Estou correto?\"");
            Console.Write("\n\nAnna:\"Sim. Um amigo em comum entre eu e João.\"");
            Console.Write("\n\nDefesa: \"E nesta festa havia bebidas alcoólicas?\"");
            Console.Write("\n\nAnna:\"Sim.\"");
            Console.Write("\n\nDefesa: \"Você bebeu esses drinks?\"");
            Console.Write("\n\nAnna:\"Sim.\"");
            Console.Write("\n\nDefesa: \"A ponto de ficar bêbada?\"");
            Console.Write("\n\nVocê vê que ela fica desconfortável quando ouve a pergunta.");
            Console.Write("\n\nAnna:\"Eu admito que passei um pouco dos limites, mas eu tenho controle \nsobre mim mesma. Eu não faço idioticies, igual algumas pessoas...\"");
            Console.Write("\n\n Ela fala isso olhando fixamente para João.");
            Console.Write("\n\nDefesa: \"É mesmo? Esses coméntarios que você coloca diariamente no \nfacebook dizem o contrário...\"");
            Console.ReadKey();
            Console.Write("\n\n O advogado pega três maços de papeis e entrega um para você, um para o \npromotor e segura um para sí mesmo.\"");
            Console.Write("\n\nDefesa: \"'Bebi para caramba, nem me lembro de ontem!','Quero beber até \ncair no chão', 'de tanto que tomei, vomitei na roupa de um cara que estavadançando comigo. lol.'\"");
            Console.Write("\n\nDefesa: \"Como vocês devem estar pensando, sim, estás são coisas que Anna \ncoloca em seu facebook.\"");
            Console.Write("\n\nPromotor: \"Objeção! A vida pessoal de minha cliente pertence só a ela e \nnão tem nada a ver com o caso atual!\"");
            Console.Write("\n\nDefesa: \"Pelo contrário, meretissímo! Isso prova que ela tem um histórico!É muito provavel que ela nem se lembre da noite do ocorrido!\"");
            Console.Write("\n\nPromotor: \"Ela já admitiu que tinha passado um pouco do ponto. Esse tipo \nde pergunta não vai levar a lugar nenhum!\"");
            Console.Write("\n\n Os advogados continuam a discutir, enquanto isso você analisa os papeis \nque a defesa lhe entregou. Realmente ela colocou aquelas coisa (com variospalavrões, que o advogado deixou de fora).");
            Console.Write(" Por um lado ela já admitiu que estava bêbada na ocasião, e os comentários no facebook seriam apenas \nexageiros. Deixar a defesa continuar essas perguntar pode simplismente \nocupar tempo.");
            Console.Write(" Por outro lado, se ela realmente tem um histórico de estar \nbêbada, é possivel que ela esteja inventando parte da história dela.");
            Console.ReadKey();
            Console.Write("\n\nVocê pode ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Aceitar a Objeção ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("e deixar a defesa continuar a perguntar\nou\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Recusar a Objeção ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("e continuar com o questionamento sobre outros tópicos.\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            while (text != "Aceitar a Objeção" && text != "Recusar a Objeção")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nAceitar ou não aceitar? Eis a questão...");
            }
            if (text == "Aceitar a Objeção")
            {
                C = 1;
                B++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nVocê: \"Eu concordo com o promotor, este questionamento não levará a muito longe. Anna já admitiu que estava bêbada na hora. Objeção aceita. Defesa, faça outra pergunta.\"");
                Console.Write("\n\nDefesa: \"Como desejar, meritissímo...\"");
                Console.Write("\n\n Você viu uma pontada de irritação nas palavras dele. Ele volta a se focarem Anna.");
                Console.Write("\n\nDefesa: \"Ok. A senhorita diz ter encontrado o meu cliente na festa, \ncorreto?\"");
                Console.Write("\n\nAnna: \"Sim, correto.\"");
                Console.Write("\n\nDefesa: \"Vocês chegaram a falar antes do suposto crime acontecer?\"");
                Console.Write("\n\nAnna: \"Não. Eu tenho certeza que ele me viu andar lá pelas 1:30 da manhã, mas não nos falamos.\"");
                Console.Write("\n\nDefesa: \"Hmmm, ok. Foi nessa hora que ele supostamente te estuprou?\"");
                Console.Write("\n\nAnna: \"Não, foi mais a noite. Umas 3 horas da manhã.\"");
                Console.Write("\n\nDefesa: \"E neste meio tempo você ficou fazendo o que exatamente?\"");
                Console.Write("\n\nAnna: \"Eu sai para tomar um ar lá fora, na esperança que, quando voltase, o João teria ido embora. Quando voltei, lá pelas 2, não vi ele, e dai \ncomecei a, hmmm, fazer o que se faz numa festa normalmente.");
                Console.ReadKey();
                Console.Write("\n\nDefesa: \"Beber, você quer dizer.\"");
                Console.Write("\n\nAnna olha para o chão, com um olhar com um misto de raiva e vergonha.");
                Console.Write("\n\nAnna: \"S-sim. Isso e conversar com algumas pessoas. Quero dizer, até o \nJoão chegar perto de mim...\"");
                Console.Write("\n\nDefesa: \"E como meu cliente atacou você, exatamente?\"");
                Console.Write("\n\nEla fica alguns segundos em silencio, olhando para baixo.");
                Console.Write("\n\nAnna: \"Ele... pediu para eu vir em uma sala com ele, que prescisávamos \nconversar sobre nossa relação. E quando eu cheguei lá, ele... Ele me \njogou na cama e... E...\"");
                Console.Write("\n\n Ela parou de falar. Diferente do que você esperava, ela não está chorandoou assustada, mas sim mantendo uma face fria. Você ouve um grito vindo de sua direita.\"");
                Console.Write("\n\nJoão: \"EU NÃO FIZ NADA! ELA QUE VEIO ATÉ MIM DIZENDO QUE SENTIA MINHA \nFALTA!\"");
                Console.Write("\n\n*PAW \n*PAW");
                Console.Write("\n\nVocê: \"Ordem! Ordem!\"");
                Console.Write("\n\n...\n\n");
                Console.ReadKey();
                Console.Write("\n\n Depois do que parecia uma eternidade, com muitas pessoas falando ao mesmotempo, você finalmente acalma a corte.");
                Console.Write("\n\nVocê: \"Essa vai ser a ultima vês que o caso vai ser interrompido por \ncomentários indevidos por parte da vítima ou do acusado! Dá próxima vez \nque algo assim acontecer haverá punições!\"");
                Console.Write("\n\nTodos ficam quietos. O silêncio toma conta do recinto.");
                Console.Write("\n\nVocê: \"Bom, acho que agora é hora do acusado dar o depoimento dele, a não ser que a defesa queria continuar a questiona-lá?\"");
                Console.Write("\n\nO advogado dá um pequeno pulo quando percebe que você está se referindo a ele.");
                Console.Write("\n\nDefesa: \"N-não, meretissímo...");
                Console.Write("\n\nVocê: \"Bom, vamos logo então! O acusado tem que depor.\"");
            }
            else
            {
                A++;
                C = 0;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nVocê: \"Promotor, você está dizendo que possíveis mentiras na corte não é \npara serem levadas a sério?\"");
                Console.Write("\n\nPromotor: \"N-não, meritissímo, eu só est...\"");
                Console.Write("\n\nVocê: \"Objeção negada. Continue com o questionamento, senhor Locke.\"");
                Console.Write("\n\nDefesa: \"Sim, senhor meritissímo. Senhorita Anna, você se lembra de onde \nera o local da festa?");
                Console.Write("\n\nAnna: \"Rua... Morais de Guilá, uma casa grande, com piscina.\"");
                Console.Write("\n\nDefesa: \"E o que você bebeu aquela noite?\"");
                Console.Write("\n\nPromotor: \"Meu deus do céu...\"");
                Console.Write("\n\nAnna: \"Cerveja, na maioria do tempo.\"");
                Console.Write("\n\nDefesa: \"A senhorita costuma perder a memória quando bêbe?\"");
                Console.Write("\n\nAnna: \"Bem, não. Apenas se eu beber muito, mas é muito raro.\"");
                Console.Write("\n\nDefesa: \"E a senhorita bebeu muito ontem?\"");
                Console.Write("\n\nAnna: \"Obviamente que não, se não eu teria mencionado isso.\"");
                Console.Write("\n\nDefesa: \"Mas a manhã seguinte você estava com ressaca...\"");
                Console.Write("\n\nPromotor: \"Sinceramente, senhor meritissímo, o senhor Locke está \nclaramente querendo tomar tempo. Tempo este que é precioso para minha \ncliente.\"");
                Console.ReadKey();
                Console.Write("\n\nDefesa: \"Eu não estou tomando tempo, estou apenas...\"");
                Console.Write("\n\nPromotor: \"...Procurando evidencias onde elas não existem.\"");
                Console.Write("\n\nDefesa: \"Indeferente de sua opinião, eu continuarei meu questionamento.\"");
                Console.Write("\n\n O questionamento não foi muito produtivo. A defesa não conseguiu tirar \nmuitas informações, e apenas alongou o tempo já exacaço que vocês tem.");
                Console.Write("\n\nDefesa: \"Vocês chegaram a falar antes do suposto crime acontecer?\"");
                Console.Write("\n\nAnna: \"Não. Eu tenho certeza que ele me viu andar lá pelas 1:30 da manhã, mas não nos falamos.\"");
                Console.Write("\n\nDefesa: \"Hmmm, ok. Foi nessa hora que ele supostamente te estuprou?\"");
                Console.Write("\n\nAnna: \"Não, foi mais a noite. Umas 3 horas da manhã.\"");
                Console.Write("\n\nVocê: \"Bem, acho que já é hora de continuar com o caso. Defesa, agradeço \npor suas perguntas.\"");
                Console.Write("\n\nDefesa: \"Mas senhor, eu ainda tenho mais perg...\"");
                Console.Write("\n\nVocê: \"Acho que agora é hora do acusado dar o depoimento dele. Por favor, senhor João.\"");

            }
            Console.ReadKey();
            Console.Clear();
            Console.Write("\n\n---------------------------------------\n\n");
            Console.Write(" Depois de um tempo para se ajeitarem (novamente...), o acusado João \nSnigik se senta e seu depoimento começa.");
            Console.Write("\n\nPromotor: \"Senhor Snigik...\"");
            Console.Write("\n\nJoão: \"Pode me chamar só de João, cara, é de boa.\"");
            Console.Write("\n\nPromotor: \"...então, senhor Snigik, você chegou na festa a que horas?\"");
            Console.Write("\n\nJoão: \"Lá pelas 00:30.\"");
            Console.Write("\n\nPromotor: \"Certeza?\"");
            Console.Write("\n\nJoão: \"Sim\"");
            Console.Write("\n\nPromotor: \"Continuando. Você encontrou a senhorita Anna a que horas?\"");
            Console.Write("\n\nJoão: \"Eu vi ela pela primeira vez lá pelas 1:30, mas voltei a \nconversar com ela uns 30 minutos depois.\"");
            Console.Write("\n\nPromotor: \"Então as 3 horas da manhã voc... Espera, o que você disse?!\"");
            Console.Write("\n\n Todos olham surpresos para João. A mulher não tinha dito que eles só \nvoltaram ase falar as 3 da manhã?! Até mesmo o advogado de defesa está \nespantado, aparentemente ele tambem não sabia que João diria isso.");
            Console.Write(" Isso \nquer dizer que um deles estava mentindo, mas qual?...");
            Console.ReadKey();
            Console.Write("\n\nJoão: \"Eu voltei a conversar com ela umas 2 da manhã. Sim, a Anna está \nmentindo.\"");
            Console.Write("\n\nPromotor: \"Senhor João, para você fazer tal acusação você precisará \nde provas.\"");
            Console.Write("\n\nJoão: \"Mas para ela me acusar de estupro não precisa de provas?! É só ela falar algo que eu passo uma semana na prisão antes de eu pelo menos ter umjulgamento?!\"");
            Console.Write("\n\nDefesa: \"João, por fa...\"");
            Console.Write("\n\nPromotor: \"O-que que voc... Senhor João, não é assim que a corte funciona.Nós temos provas de que você cometeu o crime e estamos aqui para mostrar \nisso diante o estado.\"");
            Console.Write("\n\nJoão: \"Muito legal, porque eu também tenho provas que sou inocente!\"");
            Console.Write("\n\nDefesa: \"João, do que você tá falando?\"");
            Console.Write("\n\nJoão: \"Chama o maluco lá para eles.\"");
            Console.Write("\n\nDefesa: \"De quem você está falando?\"");
            Console.Write("\n\nJoão: \"Aaaa,como é o nome?...Testemunha! Chama o Alex lá.\"");
            Console.Write("\n\n O advogado fica perplexo por alguns segundos, mas você não o culpa, todos na sala estão no mesmo estado. Você ficou tão surpreso que nem repreende João por se comportar de maneira indevida na corte.");
            Console.Write("\n Depois de alguns cochichos entres a defesa e João, eles se viram para \nvocê e falam.");
            Console.ReadKey();
            Console.Write("\n\nDefesa: \"Temos uma testemunha que gostariamos de trazer a corte, se o \nsenhor permitir.\"");
            Console.Write("\n\nPromotor: \"Meritissímo, o testemunho em questão vem de uma pessoa que \nestava bêbada no momento do ocorrido, o que torna seu testemunho altamenteduvidoso. E, antes que o senhor Locke fale algo: Sim, temos provas disso.\"");
            Console.Write("\nDefesa: \"É indiferente o estado da vítima na hora do crime.\"");
            Console.Write("\n\nPromotor: \"Há, e me explique como o estado da testemunha não influencia \nsua visão da cena?\"");
            if (C == 1)
            {
                C = 1;
                Console.Write("\n\nDefesa: \"Da mesma forma que o estado alterado da autora Anna Figaro não \nimportou quando ela fez seu testemunho. Se o juíz aceitou escutar Anna, é apenas lógico que ele tambem aceite o depoimento da testemunha.\"");
                Console.Write("\n\n Ele olha para você de forma sagás, esperando para ver o que você vai \nfalar.");
                Console.Write("\n\nPromotor: \"Ma-mas o caso é totalmente diferente entre as duas pessoas.\"");
                Console.Write("\n\nDefesa: \"Não, senhor Shepard, não é nenhum pouco diferente. Ambas as \npessoas estavam alteradas na hora do ocorrido e ambas tem informações \nimportantes sobre o suposto crime. Porque o testemunho de uma deveria \nvaler mais que de outra?\"");
                Console.Write("\n\nQuando o promotor ia dar seu contra argumento, o advogado de defesa \ncontinua.");
                Console.Write("\n\nDefesa: \"Como eu disse, se o juíz aceitou escutar Anna, é apenas lógico \nque ele tambem aceite o depoimento da testemunha. Caso contrário eu terei sérias duvidas sobre a imparcialidade do juíz.\"");
                Console.ReadKey();
                Console.Write("\n\nO sala fica em extremo silencio.");
                Console.Write("\n\n Você considera as palavras dele. É realmente verdade que você escutou \nAnna, mas o caso da testemunha é realmente o mesmo? E se a testemunha \ntiver algo importante a acrescentar no caso?");
                Console.Write(" E se a testemunha tiver sido comprada (afinal, ela e o acusado pareciam se conhecer.) e mentir?\n Por fim, este Este advogado é experiente, e provavelmente está sendo maisousado por que sabe que é sua primeira vez num tribunal como juíz.");
                Console.Write(" Ele \npode muito bem falar com as pessoas certas e retirar o caso de suas mãos \npela manhã...");
            }
            else
            {
                C = 0;
                Console.Write("\n\nDefesa: \"Você está sugerindo qu...\"");
                Console.Write("\n\nPromotor: \"Eu não estou sugerindo nada, senhor Locke, estou apenas \napontando uma incoêrencia em seu discurso. Durante o depoimento de Anna \nvocê apontou que o alcool que ela tinha bebida poderia afetar sua \npersepção dos eventos, ");
                Console.Write("e o senhor meritissímo juíz concordou com sua \nposição. Agora que nos encontramos em situação similar, acho que seria \ncoerente dar o mesmo desfeixo a ela. Você não concorda, meritissímo?\"");
                Console.Write("\n\n Você é um juíz. Deve se manter imparcial em todas as ocasiões e levar em consideração todas as opniões, mas ");
                Console.Write("você não gosta nenhum pouco do tom \npomposo e esnobe que o promotor tem. Conhecendo advogados desde pequeno \n(seus pais trabalhavam na area, afinal) você sabe dizer quando eles estão se utilizando das regras para virar a mesa a seu favor.");
                Console.Write(" Mas você tem que \nadmitir que o pensamento dele realmente fazem sentido...");
            }
            Console.Write("\n\nVocê:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nAceita");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" a testemunha ou");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Não aceita");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" a testemunha?\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            while (text != "Aceita" && text != "Não aceita")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nVocê realmente não deveria estar pensando sobre pôneis agora...");
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (text == "Aceita")
            {
                A++;
                if (C == 1)
                {
                    Console.Write("\n\n A defesa da um pequeno sorriso de canto de boca, equanto o promotor fica extremamente sério. Você sabe que a decisão que você acabou de tomar vai \ninfluenciar sua relação com a autora e o acusado no futuro.");
                    Console.Write(" Não apenas comeles, mas com os advogados tambem...");
                    Console.Write("\n Você está tremendo. É essa a sensação de tomar decisões grandes então? \nVocê só espera que, com o passar dos anos, faze-las fique mais facil...\n...Mas...");
                    Console.Write("\n Aceitar foi realmente a decisão certa a fazer? Você a fez por causa que \nacha justo os argumentos do senhor Locke, ou você estava com medo de ele \ninfluenciar sua carreira futura? Você realmente perderia sua carreira se \ntomasse a outra decisão?");
                    Console.Write("\n\n...\n\n");
                }
                else
                {
                    Console.Write("\n\nPromotor: \"Meritissímo, talvez o senhor não entendeu minha lógica. \nDeixe-me explica-la mais u...\"");
                    Console.Write("\n\nVocê: \"Eu entendo sua lógica, senhor Shepard, e discordo com ela.\"");
                    Console.Write("\n\nPromotor: \"Mas eu tenho certeza, meritissímo...\"");
                    Console.Write("\n\nVocê: \"A decisão está feita, promotor, e nada mudará minha visão.\nprossigamos com o caso, por favor.\"");
                    Console.Write("\n\n A defesa da um pequeno sorriso de canto de boca, equanto o promotor fica extremamente sério. Você sabe que a decisão que você acabou de tomar vai \ninfluenciar sua relação com a autora e o acusado no futuro.");
                    Console.Write(" Não apenas comeles, mas com os advogados tambem...");
                    Console.Write("\n Você está tremendo. É essa a sensação de tomar decisões grandes então? \nVocê só espera que, com o passar dos anos, faze-las fique mais facil...\n...Mas...");
                    Console.Write("\n Aceitar foi realmente a decisão certa a fazer? Você a fez por que acha \nque a testemunha vai realmente ajudar no caso, ou você se deixou levar porsua aversão a postura do promotor? Será que seus argumentos realmente não tinham validade?");
                    Console.Write("\n\n...\n\n");
                }
                Console.ReadKey();
                Console.Clear();
                Console.Write("\n\n---------------------------------------\n\n");
                Console.Write(" Demora um tempo para trazerem a testemunha e fazerem os preparativos, \ntempo o sufiente para você buscar um café e reerguer seus ânimos. Café nãoé sua bebida favorita, mas pelo simples fato de você ter um tempo para ");
                Console.Write("\npensar faz aquele liquido ter um gosto divino. Ter uma maquina de café \nexpresso em casa não seria uma má ideia...\n Mas tudo que é bom dura pouco, e é hora de continuar o caso.");
                Console.Write("\n\n---------------------------------------\n\n");
                Console.Write(" Você se vira para o mais novo integrante da corte: Um homem pequeno, \ncabelos curtos e volumosos, com uma barba que mais parecia um ninho de \npássaro.");
                Console.Write("\n\nVocê: \"Por favor, diga seu nome e sua ocupação.\"");
                Console.Write("\n\nAlex: \"Meu nome é Alex Baliart, sou mecânico.\"");
                Console.Write("\n\nVocê: \"Defesa, pode começar a questiona-lo.\"");
                Console.Write("\n\nDefesa: \"Com prazer, meritissímo. Senhor Baliart, você é amigo de meu \ncliente?\"");
                Console.Write("\n\nAlex: \"Tá falando do João? Sou sim, desdo ensino médio. E da Anna também.\"");
                Console.Write("\nDefesa: \"E você estava presente festa de duas semanas atrás, presumo eu?\"");
                Console.Write("\n\nAlex: \"Sim, fui eu que fiz a festa. Na minha casa.\"");
                Console.ReadKey();
                Console.Write("\n\nDefesa: \"E presumo tambem que o senhor esteja ciente do que aconteceu lá, correto?\"");
                Console.Write("\n\nAlex: \"...Sim...\"");
                Console.Write("\n\nDefesa: \"Você pode nos explicar, com as suas palavras o que aconteceu lá, do momento que Anna chegou até a manhã seguinte?\"");
                Console.Write("\n\nAlex: \"Bem, a festa estava indo na boa. A Anna chegou lá pelas 1 da manhã e o João já tinha chegado. Eu fui dizer um oi para ela, e começamos a \nconversar, mas assim que ela viu o João ela ficou um pouco nervosa e saiu lá para fora.\"");
                Console.Write("\n\nAlex: \"Ela ficou uns 30 minutos lá fora e, quando voltou, estava bêbada \npara cace... Desculpa, caramba*. Ela foi conversar com o João. Eles \npareciam que estavam se dando bem, abraçando e tals. Depois disso eles \nforam até um quarto e ficaram horas lá.\"");
                Console.Write("\n\nAlex: \"Só voltei a ver o João quando ele saiu as 5 da manhã da festa. A \nAnna só fui ver de manhã.\"");
                Console.Write("\n\nDefesa: \"Você disse que eles estavam se abraçando?\"");
                Console.Write("\n\nAlex: \"Estavam sim, mano. Eles tinham brigado uns mêses antes, mas parece que estavam bem agora.\"");
                Console.Write("\n\nDefesa: \"É verdade? E qual seria o motivo da briga?\"");
                Console.Write("\n\nPromotor: \"Objeção! Relevancia ao caso\".");
                Console.Write("\n\nVocê: \"Objeção negada. Isso pode ser importante.\"");
                Console.ReadKey();
                Console.Write("\n\nAlex: \"A, é porque o João plantou o pé na bunda dela. Ele disse que ela \nestava traindo ele com um velho rico lá.\"");
                Console.Write("\n\nDefesa: \"E você diria que vingança seria um motivo bem provavel para \nalguem fingir um estupro?\"");
                Console.Write("\n\nAlex: \"Oi? Como assim?\"");
                Console.Write("\n\nO advogado iguinora completamente o homem e se vira para você.");
                Console.Write("\n\nDefesa: \"Meritissímo, com o depoimento do senhor Baliart não apenas \ncomprovamos que Anna estava mentindo nos horários mencionados no seu \ndepoimento, mas tambem omitiu informações importantes para o caso.\"");
                Console.Write("\n\nPromotor: \"Este homem estava bebado na hora do crime. Ele pode muito bem \nter confundido os horários.\"");
                Console.Write("\n\nDefesa: \"Mas Anna não nega que ficou muito recentida para com o meu \ncliente por ele ter se separado dela?\"");
                Console.Write("\n\nAnna: \"Que tipo de pessoa você acha que sou para fingir um estupro?!\"");
                Console.Write("\n\nPromotor: \"O caso extraconjungal não importa. No minimo, daria um motivo \npara João cometer o crime!\"");
                Console.Write("\n\nJoão: \"Ela que quis fazer sexo comigo! Eu nunca roubei uma bala de um \nmercado, imagine estuprar uma pessoa!\"");
                Console.Write("\n\nDefesa: \"Se houve realmente um estupro durante a festa, alguem teria \nouvido ela gritar!\"");
                Console.Write("\n\nPromotor: \"Não se ela estava desacordada.\"");
                Console.ReadKey();
                Console.Write("\n\nAnna: \"Eu nunca faria sexo sem camisinha para ficar grávida depois!\"");
                Console.Write("\n\nJoão: \"O-o-que?...\"");
                Console.Write("\n\nAnna: \"Eu estou grávida...\"");
                Console.Write("\n\n...\n\n");
                Console.Write("\n\n Um silêncio paira sobre a sala. Ela estava grávida?! De quem era o bêbe? Era do estupro?! Em um instante todas as pessoas na sala começam a falar \nao mesmo tempo, e vira um inferno na terra.\nVocê não tem outra escolha: ");
                Console.Write("\n\nVocê: \" ORDEM! ORDEM! Eu prorrogarei este caso até o dia de amanhã. \nAdvogados, preparem seus casos e argumentos, e, por favor, sem mais \nsurpresas no meio do caminho...\"");
                Console.Write("\n\n Com um pouco de esforço você consegue conter a agitação da sala e \nterminar estasessão do caso. Se hoje foi dessa forma, imagine como será \namanhã...");
                Console.Write(" Neste momento você só quer voltar para casa e tomar um banho \nquente...\n\n");
            }
            else
            {
                B++;
                if (C == 1 )
                {
                    Console.Write("\n\nDefesa: \"Meritissímo, tomando esta decisão o senhor está se contradizendo,se o senhor me...\"");
                    Console.Write("\n\nVocê: \"Senhor Locke, sou eu que estou encarregado de tomar as decisões. Seeu tomei a decisão que tomei, eu tenho meus motivos.\"");
                    Console.Write("\n\nDefesa: \"Motivos esses que são altam...\"");
                    Console.Write("\n\nVocê: \"A decisão está feita. Nada mudará minha visão. prossigamos com o \ncaso. Caso o senhor continue a confrontar minha decisão, terei que pedir \nque se retireda corte.\"");
                    Console.Write("\n\n Ele fica quieto por alguns segundos, e então simplismente faz um 'sim' \ncom a cabeça e volta a seu lugar. Enquanto isso, o promotor estava com um sorriso no canto de sua boca.");
                    Console.Write(" Você sabe que a decisão que você acabou de \ntomar vai influenciar sua relação com a autora e o acusado no futuro. Não apenas com eles, mas com os advogados tambem...");
                    Console.Write("\n Você está tremendo. É essa a sensação de tomar decisões grandes então? \nVocê só espera que, com o passar dos anos, faze-las fique mais facil...\n...Mas...");
                    Console.Write("\n Não aceitar foi realmente a decisão certa a fazer? Você a fez por causa \nque acha justo os argumentos do senhor Shepard, ou você se deixou levar \npor sua aversão a postura do advogado? Será que seus argumentos realmente não tinham validade?");
                    Console.Write("\n\n...\n\n");
                }
                else
                {
                    Console.Write("\n\nDefesa: \"Meritissímo, a testemunha é de extrema importancia ao ca...\"");
                    Console.Write("\n\nVocê: \"De que adianta uma testemunha se eu não posso confiar no que ela \ndiz, senhor Locke?\"");
                    Console.Write("\n\nPromotor: \"Mas eu tenho certeza, meritissímo...\"");
                    Console.Write("\n\nVocê: \"A decisão está feita, e nada mudará minha visão. prossigamos com o caso, por favor.\"");
                    Console.Write("\n\n Ele fica quieto por alguns segundos, e então simplismente faz um 'sim' \ncom a cabeça e volta a seu lugar. Enquanto isso, o promotor estava com um sorriso no canto de sua boca.");
                    Console.Write(" Você sabe que a decisão que você acabou de \ntomar vai influenciar sua relação com a autora e o acusado no futuro. Não apenas com eles, mas com os advogados tambem...");
                    Console.Write("\n Você está tremendo. É essa a sensação de tomar decisões grandes então? \nVocê só espera que, com o passar dos anos, faze-las fique mais facil...\n...Mas...");
                    Console.Write("\n Não aceitar foi realmente a decisão certa a fazer? Você a fez por causa \nque acha justo os argumentos do senhor Shepard, ou você queria parecer um juíz sério e imparcial no seu primeiro caso? Será mesmo que a testemunha \nnão acrescentaria nada ao caso?");
                    Console.ReadKey();
                    Console.Write("\n\n...\n\n");
                }
                Console.ReadKey();
                Console.Clear();
                Console.Write(" Equanto você pensava, o promotor discutia algo com sua cliente. Algo que eles pareciam estar descordando sobre. Quando eles terminam, ele se vira ávocê.");
                Console.Write("\n\nPromotor: \"Meritissímo, há uma nova informação, a qual gostaria de \nconfirma-lá com o senhor João. Se me permite questiona-lo rapidamente...\"");
                Console.Write("\n\nVocê: \"Prossiga.\"");
                Console.Write("\n\nPromotor: \"Senhor João, qual é o motivo da separação entre você e Anna?\"");
                Console.Write("\n\nDefesa: \"Objeção! Relevancia ao caso.\"");
                Console.Write("\n\nVocê: \"Objeção negada. Isso pode ser importante.\"");
                Console.Write("\n\nJoão: \"Ela...Ela me traiu com um velho rico. Me apunhalou pelas costas...\"");
                Console.Write("\nPromotor: \"E você diria que vingança seria um motivo bem provavel para \nalguem estuprar outra pessoa?\"");
                Console.Write("\n\nJoão: \"O-o que? Você está insinuando que...\"");
                Console.Write("\n\nO advogado ignora completamente o homem e se vira para você.");
                Console.Write("\n\nPromotor: \"Meritissímo, com o depoimento do senhor João podemos traçar um motivo para ele cometer o crime.");
                Console.Write("\n\nDefesa: \"Se fosse simples assim a maioria das pessoas estaria cometendo \nestupros por ai.\"");
                Console.ReadKey();
                Console.Write("\n\nPromotor: \"Mas João não nega que ficou muito irritado para com a minha \ncliente por ela ter traido ele?\"");
                Console.Write("\n\nAnna: \"Que tipo de pessoa você acha que sou para fingir um estupro?!\"");
                Console.Write("\n\nDefesa: \" O caso extraconjungal não importa. Se for assim Anna tambem tem um motivo para fingir ser estuprada, estando recentida por ele ter se \nseparado dela!\"");
                Console.Write("\n\nJoão: \"Ela que quis fazer sexo comigo! Eu nunca roubei uma bala de um \nmercado, imagine estuprar uma pessoa!");
                Console.Write("\n\nDefesa: \"Se houve realmente um estupro durante a festa, alguem teria \nouvido ela gritar!\"");
                Console.Write("\n\nPromotor: \"Não se ela estava desacordada.\"");
                Console.Write("\n\nAnna: \"Eu nunca faria sexo sem camisinha, para ficar grávida depois!\"");
                Console.Write("\n\nJoão: \"O-o-que?...\"");
                Console.Write("\n\nAnna: \"Eu estou grávida...\"");
                Console.Write("\n\n...\n\n");
                Console.Write("\n\n Um silêncio paira sobre a sala. Ela estava grávida?! De quem era o bêbe? Era do estupro?!\n Em um instante todas as pessoas na sala começam a falar ao mesmo tempo, evira um inferno na terra.\nVocê não tem outra escolha: \n");
                Console.ReadKey();
                Console.Write("\n\nVocê: \" ORDEM! ORDEM! Eu prorrogarei este caso até o dia de amanhã. \nAdvogados, preparem seus casos e argumentos, e, por favor, sem mais \nsurpresas no meio do caminho...\"");
                Console.Write("\n\n Com um pouco de esforço você consegue conter a agitação da sala e \nterminar estasessão do caso. Se hoje foi dessa forma, imagine como será \namanhã...");
                Console.Write(" Neste momento você só quer voltar para casa e tomar um banho \nquente...\n\n");
            }
        }
        static int Interlúdio(int A)
        {
            int B;
            string text;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n----------------------------------------\n\n INTERLÚDIO \n\n----------------------------------------\n\n");
            Console.Write("\n Você chega em casa, extremamente cansado, querendo apenas deitar-se e \nesquecer o mundo...");
            if (A == 1)
            {
                Console.Write("\n Quando entra em sua casa, você nota uma série de malas paradas na porta. Olhando-as de perto, você percebe que elas pertencem a sua mulher. Por um breve momento você se pergunta o que elas estariam fazendo ali, mas a \nresposta, trazia pela sua memória de hoje de manhâ, vem rápido a sua \nmente.");
                Console.Write(" Sua mulher passa por você, com passos apressados, sem nem olhar em sua cara.");
                Console.Write("\n\nVocê: \"Agata...\"");
                Console.Write("\n\nAgata: \"Não fale nada, por favor... Eu já ouvi o suficiente de você.\"");
                Console.Write("\n\nVocê: \"Você fala como se eu fosse o total culpado.\"");
                Console.Write("\n\nEla apenas olha para você.");
                Console.Write("\n\nVocê: \"A Carla...\"");
                Console.Write("\n\nAgata: \"Ela está na casa de uma amiga. Já expliquei tudo para ela.\"");
                Console.Write("\n\nVocê: \"...\"");
                Console.Write("\n\nEla está claramente com raiva e com pressa. Você vai...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nTentar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" falar com ela ou");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Deixar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ela ir?\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                text = (Console.ReadLine());
                while (text != "Deixar" && text != "Tentar")
                {
                    if (text == "Ajuda")
                        text = ComandoAjuda();
                    else
                        text = ComandoInvalido("\nMesmo se você tentar, ela realmente irá te escutar?...");
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (text == "Tentar")
                {
                    B = 1;
                    Console.Write("\n\nVocê: \"Eu não sei como fui acreditar em você em todos esses anos. Eu \ntentei o meu máximo por você e tudo acaba assim?!\"");
                    Console.Write("\n\nEla se levanta, com furia em seus olhos, e fica face-a-face com você.");
                    Console.Write("\n\nAgata: \"Se o seu máximo é pegar uma garrafa de whisky e beber toda vez queum problema aparece, então sim, o nosso relacionamento acaba assim!\"");
                    Console.Write("\n\nVocê: \"Eu comecei a beber por culpa SUA! Foi após você me trair! Se alguemé o culpado, esse é VOCÊ!\"");
                    Console.Write("\n\nAgata: \"Até quando você vai continuar se enganando?! Eu te trai porque \nvocê tambem me traia! Toda noite você saía de casa! E nem venha me diser \nque era por uma causa nobre qualquer, que nem você sempre diz.\"");
                    Console.Write("\n\nVocê: \"Eu estava estudando! Eu estava estudando para conseguir esse \nemprego e assim satisfazer SEUS caprichos!\"");
                    Console.Write("\n\nAgata: \"Você mesmo admitiu no celular que ia, e ainda vai, no puteiro todosábado a noite!\"");
                    Console.Write("\n\nVocê: \"Como eu disse, isso foi depois, caralho! Antes eu acreditava no \nnosso relacionamento! Você me trai e eu não posso te dar o troco na mesma moeda?\"");
                    Console.Write("\n\nAgata: \"O problema é que eu não acretido mais em você.\"");
                    Console.Write("\n\nVocê ouve uma buzina lá fora e sua esposa pega as malas do chão e se \ndireciona a porta.");
                    Console.Write("\n\nVocê: \"Não ouse virar as costas para mim!\"");
                    Console.ReadKey();
                    Console.Write("\n\n Lá fora, você nota que há um taxi parado em frente a sua casa. Antes de \nAgata entrar no carro, ela vira para você e fala uma ultima coisa.");
                    Console.Write("\n\nAgata: \"Eu realmente não deveria ter traido você. Eu deveria ter me \nseparado logo de uma vez. Tenho pena da próxima mulher que ficar com você\"");
                    Console.Write("\n\nVocê: \"AGATA! VOLTE AQUI!\"");
                    Console.Write("\n\n O taxi simplesmente acelera, continuando a andar até sumir de sua vista.");
                    Console.Write("\n\n...\n\n");
                    Console.Write("\n\n Voltando para dentro de sua casa, apenas agora você nota que está muito \nfrio. Você pega o seu melhor whisky da sua gaveta e o serve em um copo.");
                    Console.Write(" \nEsse não era o tipo de situação que o seu eu que havia acabado de se casarimaginaria que ocorreria, mas a vida é cheia de surpresas. Você é livre \nnovamente. O peso do mundo saiu de suas costas, e");
                    Console.Write(" de uma maneira estranha,você sente que Agata está sentindo a mesma coisa.");
                    Console.Write(" Você bêbe a farta dose \nde seu copo com whisky, e o calor volta a seu corpo.");
                    Console.Write("\n\n...Será que os textos em sua cabeça estão sendo sinceros sobre seus \nsentimentos? Ou estão apenas tentando te fazer se sentir melhor?\nVocê não sabe mais dizer...");
                    Console.Write("\n\n...\n\n\n");
                }
                else
                {
                    B = 1;
                    Console.Write("\n\n Você apenas olha enquanto ela arruma as malas. O que você poderia dizer \nque mudaria isto? Nada. Esta situação já está com um final definido a \nmuito tempo, muito antes do dia de hoje.");
                    Console.Write(" Você não é o tipo de pessoa que \ntenta consertar vasos quebrados.");
                    Console.Write("\n\nVocê ouve uma buzina lá fora e sua esposa pega as malas do chão e se \ndireciona a porta. Você a acompanha até lá, totalmente calado.");
                    Console.Write(" Lá, você \nnota que há um taxi parado em frente a sua casa. Antes de Agata entrar no carro, ela vira para você e fala uma ultima coisa.");
                    Console.Write("\n\nAgata: \"Eu realmente não deveria ter traido você. Eu deveria ter me \nseparado logo de uma vez. Me desculpa por alongar o relacionamento e \ndeixar chegar a esse ponto.\"");
                    Console.Write("\n\nVocê: \"Eu sinto o mesmo.\"");
                    Console.Write("\n\n O taxi acelera, continuando a andar até sumir de sua vista.");
                    Console.Write("\n\n...");
                    Console.Write("\n\n Voltando para dentro de sua casa, apenas agora você nota que está muito \nfrio. Você pega o seu melhor whisky da sua gaveta e o serve em um copo.");
                    Console.Write(" \nEsse não era o tipo de situação que o seu eu que havia acabado de se casarimaginaria que ocorreria, mas a vida é cheia de surpresas. Você é livre \nnovamente. O peso do mundo saiu de suas costas, e");
                    Console.Write(" de uma maneira estranha,você sente que Agata está sentindo a mesma coisa.");
                    Console.Write(" Você bêbe a farta dose \nde seu copo com whisky, e o calor volta a seu corpo.");
                    Console.Write("\n\n...Será que os textos em sua cabeça estão sendo sinceros sobre seus \nsentimentos? Ou estão apenas tentando te fazer se sentir melhor?\nVocê não sabe mais dizer...");
                }
            }
            else if (A == 2)
            {
                B = 0;
                Console.Write("\n Quando entra em sua casa, você nota uma série de malas paradas na porta. Olhando-as de perto, você percebe que elas pertencem a sua mulher. Por um breve momento você se pergunta o que elas estariam fazendo ali, mas a \nresposta, trazia pela sua memória de hoje de manhâ, vem rápido a sua \nmente.");
                Console.Write("\n Sua mulher está sentada na mesa de jantar, conversando com sua filha (queestá com os olhos molhados do que você presume ser choro). Assim que sua \nesposa vê você, ela termina de falar com a garota e a manda subir as \nescadas. Assim que estavam sozinhos no recinto, ela começa a falar.");
                Console.Write("\n\nAgata: \"O-oi... Eu...Bem, eu estou de mudança...\"");
                Console.Write("\n\nVocê: \"O-o que? Quer dizer que...\"");
                Console.Write("\n\nAgata: \"Sim, estou me separando.\"");
                Console.Write("\n\nVocê: \"Mas eu achei que nós tivemos uma boa conversa hoje no telefone.\"");
                Console.Write("\n\nAgata: \"Por favor, para...\"");
                Console.Write("\n\nVocê: \"Que tudo tinha ficado bem.\"");
                Console.Write("\n\nAgata: \"Não tem como ficar bem!\"");
                Console.Write("\n\n Ela grita isso enquanto lagrimas escorriam por seu rosto. Após um tempo, ela volta a se acalmar.");
                Console.ReadKey();
                Console.Write("\n\nAgata: \"Não dá para reparar nosso relacionamento, por mais que tentamos.\"");
                Console.Write("\n\n A voz dela saia tremida. Falar aquelas palavras doiam tanto quanto \nouvi-las.");
                Console.Write("\n\nAgata: \"Nós... nós cometemos muitos erros, e a confiança que agente teve \num dia não existe mais.\"");
                Console.Write("\n\nVocê: \"Eu sei. Eu tambem sinto isso.\"");
                Console.Write("\n\n As suas ultimas palavras sairam em seco e doiam em sua garganta, mas erama verdade. Você pensava a mesma coisa, apenas não as falava.");
                Console.Write("\n\nAgata: \"Eu tenho que continuar com a minha vida, e você tambem. Não \npodemos ficar paradas na mesma situação para sempre.\"");
                Console.Write("\n\n A sala fica silenciosa por alguns segundos, sem ninguem falar nada. Os \nsegundos pareciam ions para você...\"");
                Console.Write("\n\nVocê: \"Eu presumo que você já contou para a Carla.\"");
                Console.Write("\n\nAgata: \"Sim. Mas não se preocupe, nossa filha é forte. Talvez seja a unicacoisa certa que fizemos juntos.\"");
                Console.Write("\n\n Você ouve uma buzina lá fora e sua esposa pega as malas do chão e se \ndireciona a porta. Você a acompanha até lá, totalmente calado.");
                Console.Write(" Lá, você \nnota que há um taxi parado em frente a sua casa. Antes de Agata entrar no carro, ela vira para você e fala uma ultima coisa.");
                Console.Write("\n\nAgata: \"Eu realmente não deveria ter traido você. Eu deveria ter me \nseparado logo de uma vez. Me desculpa por alongar o relacionamento e \ndeixar chegar a esse ponto.\"\n");
                Console.ReadKey();
                Console.Write("\n\nVocê: \"A culpa não é só sua, eu tambem errei. Mas não se aflinja pelos \nerros do passado, apenas os deixe para trás e continue com sua vida. Que \nvocê tenha longos dias e belas noites daqui para frente.\"");
                Console.Write("\n\nEla olha surpresa para você, dando um pequeno sorriso.\"");
                Console.Write("\n\nAgata: \"Você ainda se lembra daquele livro?\"");
                Console.Write("\n\nVocê: \"Ele foi o motivo de ter conhecido você não foi? Não vou esquecer \nele jamais.\"");
                Console.Write("\n\n Agata lhe solta o sorriso mais inocente e sincero que você vê em muito \ntempo, e por alguns segundos o mundo parecia mais colorido. então o taxi \nacelera, continuando a andar até sumir de sua vista.");
                Console.Write("\n\n...");
                Console.Write("\n\n Voltando para dentro de sua casa, apenas agora você nota que está muito \nfrio. Você pega o seu melhor whisky da sua gaveta e o serve em um copo.");
                Console.Write(" \nEsse não era o tipo de situação que o seu eu que havia acabado de se casarimaginaria que ocorreria, mas a vida é cheia de surpresas. Você é livre \nnovamente. O peso do mundo saiu de suas costas, e");
                Console.Write(" de uma maneira estranha,você sente que Agata está sentindo a mesma coisa.");
                Console.Write(" Você bêbe a farta dose \nde seu copo com whisky, e o calor volta a seu corpo.");
                Console.Write("\n\n...Será que os textos em sua cabeça estão sendo sinceros sobre seus \nsentimentos? Ou estão apenas tentando te fazer se sentir melhor?\nVocê não sabe mais dizer...");
                Console.Write("\n\n...\n\n");
            }
            else
            {
                Console.Write("\n Assim que você coloca o pé dentro de casa, sua esposa vem da cosinha, comos olhos em fúria.");
                Console.Write("\n\nAgata: \"Onde você estava que não atendeu meu celular hoje de manhã?! Eu \nsei que você só ia entrar no tribunal umas 3 da tarde!\"");
                if (A == 3)
                {
                    Console.Write("\n\n Bem, você foi assaltado hoje mais cedo. Se você falar para ela que não \natendeu por esse motivo, provavelmente será bem mais facil acalmar ela. \nVocê vai:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\nFalar que foi");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Assaltado");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" ou Tentar");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" Explicar");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" o porque de você não ter \naterndido?\n\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    text = (Console.ReadLine());
                    while (text != "Assaltado" && text != "Explicar")
                    {
                        if (text == "Ajuda")
                            text = ComandoAjuda();
                        else
                            text = ComandoInvalido("\nMesmo se você tentar, ela realmente irá te escutar?...");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    if (text == "Assaltado")
                    {
                        Console.Write("\n\nVocê: \"Eu não pude atender porque eu fui assaltado! Como eu iria saber quevocê estava ligando?!\"");
                        Console.Write("\n\nAgata: \"Sério?! Essa é a desculpa mais velha que existe.\"");
                        Console.Write("\n\nVocê: \"Procura minha carteira nos meus bolsos então! Eu não largaria minhacarteira e dinheiro só por causa de uma mentira!\"");
                        Console.Write("\n\nVocê fala olhando para os olhos dela, com a cara totalmente séria.");
                        Console.Write("\n\nAgata: \"Espera...É sério? Você foi assaltado mesmo? por isso não atendeu?\"");
                        Console.Write("\nVocê: \"Sim.\"");
                        Console.Write("\n\nMeias verdades continuão sendo verdades, não?");
                    }
                    else
                    {
                        Console.Write("\n\nVocê: \"Agata, eu não atendi o celular porque sabia que exatamente isso \niria acontecer. Brigar naquela hora não iria levar a lugar nenhum.\"");
                        Console.Write("\n\nAgata: \"Você só não queria me ouvir, igual faz sempre! Você sabe o quão \npreocupada eu fiquei?! Sabe o quão chatiada?\"");
                        Console.Write("\n\nVocê: \"Amor...eu...\"");
                        Console.Write("\n\nAgata: \"Eu sei que nosso relacionamento foi por aguá abaixo a muito tempo.Depois que eu te trai, tudo ficou estranho.\"");
                        Console.Write("\n\nVocê não gostava de ouvir sobre o ocorrido, era uma ferida que ainda doía em você. Mas, mesmo descobrindo sobre a traição, você continuou o \nrelacionamento. Esperança de um futuro melhor, talves?");
                        Console.Write("\n\nVocê: \"Agata, agente teve nossos problemas, mas eu ainda te amo.\"");
                    }
                }
                else
                {
                    Console.Write("\n\nVocê: \"Agata, eu não atendi o celular porque sabia que exatamente isso \niria acontecer. Brigar naquela hora não iria levar a lugar nenhum.\"");
                    Console.Write("\n\nAgata: \"Você só não queria me ouvir, igual faz sempre! Você sabe o quão \npreocupada eu fiquei?! Sabe o quão chatiada?\"");
                    Console.Write("\n\nVocê: \"Amor...eu...\"");
                    Console.Write("\n\nAgata: \"Eu sei que nosso relacionamento foi por aguá abaixo a muito tempo.Depois que eu te trai, tudo ficou estranho.\"");
                    Console.Write("\n\nVocê não gostava de ouvir sobre o ocorrido, era uma ferida que ainda doía em você. Mas, mesmo descobrindo sobre a traição, você continuou o \nrelacionamento. Esperança de um futuro melhor, talves?");
                    Console.Write("\n\nVocê: \"Agata, agente teve nossos problemas, mas eu ainda te amo.\"");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.Write("\n\n Agata agora está com os olhos vermelhos e lagrimas escorrendo pelo rosto.");
                Console.Write("\nAgata: \"Eu..Eu não sei mais se acredito em você. Não sei mais se confio ounão. Não sei mais de nada.\"");
                Console.Write("\n\nVocê: \"Agata, o que voc...\"");
                Console.Write("\n\nAgata: \"Eu estou saindo. Estou indo embora. Preciso de um tempo longe.\"");
                Console.Write("\n\nVocê: \"A Carla...\"");
                Console.Write("\n\nAgata: \"Ela está na casa de uma amiga. Já expliquei tudo para ela.\"");
                Console.Write("\n\nVocê: \"...\"");
                Console.ReadKey();
                Console.Write("\n\nEla passa por você e pega umas malas que estavam na porta. No seu cansaço,você nem as percebeu. Você vai...");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nTentar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" falar com ela ou");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Deixar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ela ir?\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                text = (Console.ReadLine());
                while (text != "Deixar" && text != "Tentar")
                {
                    if (text == "Ajuda")
                        text = ComandoAjuda();
                    else
                        text = ComandoInvalido("\nMesmo se você tentar, ela realmente irá te escutar?...");
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (text == "Tentar")
                {
                    B = 0;
                    Console.Write("\n\nVocê: \"Agata, me escuta.\"");
                    Console.Write("\n\nAgata: \"Agente não tem mais nada para falar.\"");
                    Console.Write("\n\n Ela começa a arrastar a mala lá para fora a passos lentos, já que as \nmalas estavam bem pesadas. Uma das bolsas cai no chão e você se abaixa \npara pega-lá. Quando volta a se levantar, Agata está de joelhos, chorando.");
                    Console.Write("\n\nVocê: \"Agata...\"");
                    Console.Write("\n\n Você a abraça. Não importa todos os problemas que você teve até agora, \nvocê queria que este momento durasse para sempre. Os minutos que passam \nali parecem horas. Em meio a soluços, ela fala.");
                    Console.Write("\n\nAgata: \"Eu sinto muito! Eu não sei mais o que fazer.\"");
                    Console.Write("\n\nVocê: \"Eu tambem sinto muito. Eu sinto muito.\"");
                    Console.Write("\n\n Você nem havia percebido que suas próprias lágrimas tinham começado a \ncair.");
                    Console.Write("\n\n...\n");
                    Console.Write("\n\n Passou-se horas dês de que você chegou em casa, e agora você e sua esposaestão na mesa. Fazia muito tempo que você não tinha uma conversa mais \ndescontraida com ela. Vocês haviam decidido dar mais uma chance");
                    Console.Write(" ao \nrelacionamento de vocês, mas se essa chance realmente iria durar era \nincerto. O futuro sempre foi um lugar nebuloso e frio para você, mas, \nestranhamente, hoje ele parece claro...");
                }
                else
                {
                    B = 1;
                    Console.Write("\n\n Você apenas olha enquanto ela arruma as malas. O que você poderia dizer \nque mudaria isto? Nada. Esta situação já está com um final definido a \nmuito tempo, muito antes do dia de hoje.");
                    Console.Write(" Você não é o tipo de pessoa que \ntenta consertar vasos quebrados.");
                    Console.Write("\n\nVocê ouve uma buzina lá fora e sua esposa pega as malas do chão e se \ndireciona a porta. Você a acompanha até lá, totalmente calado.");
                    Console.Write(" Lá, você \nnota que há um taxi parado em frente a sua casa. Antes de Agata entrar no carro, ela vira para você e fala uma ultima coisa.");
                    Console.Write("\n\nAgata: \"Eu realmente não deveria ter traido você. Eu deveria ter me \nseparado logo de uma vez. Me desculpa por alongar o relacionamento e \ndeixar chegar a esse ponto.\"");
                    Console.Write("\n\nVocê: \"Eu sinto o mesmo.\"");
                    Console.Write("\n\n O taxi acelera, continuando a andar até sumir de sua vista.");
                    Console.Write("\n\n...");
                    Console.Write("\n\n Voltando para dentro de sua casa, apenas agora você nota que está muito \nfrio. Você pega o seu melhor whisky da sua gaveta e o serve em um copo.");
                    Console.Write(" \nEsse não era o tipo de situação que o seu eu que havia acabado de se casarimaginaria que ocorreria, mas a vida é cheia de surpresas. Você é livre \nnovamente. O peso do mundo saiu de suas costas, e");
                    Console.Write(" de uma maneira estranha,você sente que Agata está sentindo a mesma coisa.");
                    Console.Write(" Você bêbe a farta dose \nde seu copo com whisky, e o calor volta a seu corpo.");
                    Console.Write("\n\n...Será que os textos em sua cabeça estão sendo sinceros sobre seus \nsentimentos? Ou estão apenas tentando te fazer se sentir melhor?\nVocê não sabe mais dizer...");
                }
            }
            return B;
        }
        static void Dia2(int B)
        {
            int C, D;
            string text;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n---------------------------------------\n\n");
            if (B == 1)
            {
                Console.Write(" Você chega ao tribunal no horário de sempre. Cumprimenta Sergio, o \nporteiro. É meio vergonhoso que, após sete anos de vê-lo diariamente, vocêainda não sabe nada sobre ele. O cara até te dá um ovo de pascoa todo ano,");
                Console.Write("e você nem pra saber o nome completo dele! Você segue para sua câmara, \nabre uma garrafa de Roberts Bourbon Whisky, sua bebida favorita. Afinal \nseu dia de hoje não será muito melhor que ontem.\n Falta um gelinho. Melhor pedir para sua secretaria buscar um pouco. Você pega no telefone e disca o ramal.");
                Console.Write("\n\nArlete: \"Oi meritíssimo\"");
                Console.Write("\n\nVocê: \"Você pode trazer um copo de gelo pra mim?\"");
                Console.Write("\n\nArlete: \"Claro. Quer uma coca também?\"");
                Console.Write("\n\nVocê: \"Não.\"");
                Console.Write("\n\nArlete: \"Mas, só gelo?\"");
                Console.Write("\n\nVocê: \"Não foi o que falei?\"");
                Console.Write("\n\nArlete: \"Desculpa doutor\"");
                Console.Write("\n\n Você desliga o telefone. Incrível como qualquer pessoa passa em concurso publico hoje. Você passa anos de sua carreira para se tornar um juiz em \numa área respeitável, e ainda tem gente que te chama de “doutor”. O \ncritério de avaliação para SUA secretaria deveria ser maior que uma de um juiz do interior.");
                Console.ReadKey();
                Console.Clear();
                Console.Write("\n Ela entra na sua câmara com uma bandeja com um só copo. E é claro que elase desequilibra toda ao entrar. Não da pra abrir a porta com as duas mãos ocupadas... A égua não pensa em trazer o copo em uma mão e usar a outra \nabrir o trinco? Você discretamente coloca sua garrafa no chão, atrás de \nsua mesa.");
                Console.Write("\n\nArlete: \"Desculpa por te chamar de doutor. Habito velho. Aonde coloco seu copo?\"");
                Console.Write("\n\nVocê: \"Pode deixar ao lado da porta.\"");
                Console.Write("\n\n Ela pode até ser meio lerda e ignorante. Mas sua bunda compensa. E COMO \ncompensa. Você poderia morder aquela bunda. Sua forma esférica lembra até uma bola de futebol. O tecido de sua calça, levemente forçando sua pele a deformar, demonstrando a mistura perfeita de musculo e gordura. Eu poderiadormir");
                Console.Write(" naquela bunda, usá-la como travesseiro. Seu calor gostoso sendo \ntransferido para minha bochecha. Será que você finalmente deve fazer algumcomentário?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSim");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ou");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Não");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("?\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                text = (Console.ReadLine());
                while (text != "Sim" && text != "Não")
                {
                    if (text == "Ajuda")
                        text = ComandoAjuda();
                    else
                        text = ComandoInvalido("\nVocê não vai se rebaixar a esse nivel, vai?...");
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (text == "Sim")
                {
                    Console.Write("\n\nVocê: \"Arlete, juro para você que nunca vi uma bunda tão perfeita como a \nsua...\"");
                }
                Console.Write("\n\n\nArlete: \"Bom meritíssimo, se for só isso, vou retornar para minha mesa...\"");
                Console.ReadKey();
                Console.Write("\n\n Ela sai e fecha a porta. Mas que bunda perfeita. Você não vai conseguir \nse concentrar o resto do dia, parando para pensar na bunda dela. Ela \nmerece um prêmio por aquele traseiro. Não duvidaria que ela já ganhou um \ntroféu por aquele corpo. Pior que ela não deve ser muito mais velha que \nsua filha.");
                Console.Write(" Se sua filha tem 19 anos, e ela comentou que já viu sua \nsecretária na faculdade, isso deve fazer ela ter, no máximo, uns 25 anos. Bom, chega disso. Para as tarefas do dia. Você abre o envelope em sua \nmesa:");
            }
            else
            {
                Console.Write(" Você acorda com o sol batendo em sua cara. Um cochilo é sempre bem vindo depois do almoço, mas depois do que aconteceu ontem a noite em sua casa, \nvocê não sabe se está totalmente restaurado...");
                Console.Write(" Olhando para sua mesa você nota que um papel que não estava lá antes. Sua secretária deve ter \ncolocado ele aqui enquanto você dormindo. Antes de ler, você abre um \nwhisky que tinha guardado e o serve em um copo.");
            }
            Console.Write("\n\n\"Caro meritíssimo, a defesa vem por esta requisitar um\n exame de DNA para comprovar se o bebe da Autora é\n ou não o primogênito de meu cliente. A Autora se recusa\n fazer um exame de DNA, porem meu cliente detém o\n");
            Console.Write(" direito de saber se a criança contém ou não seu sangue.\n A defesa se compromete a cobrir qualquer custo\n envolvido, e por esta já informa que trouxe os\n equipamentos necessários para o teste. O resultado\n deve demorar pouco menos de duas horas, viabilizando\n");
            Console.Write(" uma resposta durante o julgamento.\"");
            Console.Write("\n\nA carta veio do advogado da defesa. Você irá forçar Anna a fazer o exame?");
            Console.Write("\n\nVocê:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nAssina");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" e aprova o exame\nou\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Não Assina");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" e não aprova o exame\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            while (text != "Assina" && text != "Não Assina")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nEstou cansado de fazer mensagens de erro...");
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (text == "Assina")
                D = 1;
            else
                D = 0;
            Console.Clear();
            Console.Write("\n\n----------------------------------------\n\n TRIBUNAL: DIA 2\n\n----------------------------------------\n");
            Console.Write(" Bom, hora de entrar na Corte. Você vira o copo de whisky, que é meio que um desperdício, afinal ele era mais velho que sua filha.");
            Console.Write(" Você entra na \nsala. Todos presentes na corte se levantam para reverencia-lo. Quando vocêse senta, todos se ajeitam em suas cadeiras tambem.");
            Console.Write("\n\nVocê: \"Estamos aqui para julgar o caso DL-6/2014 referente à acusação de \nestupro por parte do acusado João Snigik. Como apela o réu?\"");
            Console.Write("\n\nDefesa: \"Não culpado meritíssimo. Gostaríamos de chamar a autora para \ndepor.\"");
            Console.Write("\n\nPromotor: \"Nós já não fizemos isto ontem?\"");
            Console.Write("\n\nDefesa: \"Bem, no final do dia anterior tivemos várias informações novas.\nAcho que é valido nós ouvirmos os depoimentos novamente.\"");
            Console.Write("\n\nVocê: \"Concordo. E tambem acho que nos benificiariamos em refrescar um \npouco a memória... Anna, por favor, sente-se na cadeira aqui do lado para depor.\"");
            Console.Write("\n\n Você está começando a se acostumar com a maneira que o tribunal funciona.Mas, sendo apenas seu segundo dia, você ainda fica um pouco irritado com \nalgumas coisas. Assim que Anna termina de se ajeitar, a defesa começa a \nquestiona-lá.\"");
            Console.ReadKey();
            Console.Write("\n\nDefesa: \"Você diria que antes do acontecimento você tinha um bom \nrelacionamento com meu cliente?\"");
            Console.Write("\n\nAnna: \"Sim. Nós eramos bem próximos.\"");
            Console.Write("\n\nDefesa: \"Você conhece meu cliente já faz quantos anos?\"");
            Console.Write("\n\nAnna: \"A sete anos.\"");
            Console.Write("\n\nDefesa: \"Imagino eu que você já conhece a família de meu cliente.\"");
            Console.Write("\n\nAnna: \"Conheço sim, nós mantemos contato até hoje. Quer dizer, mantinhamos...\"");
            Console.Write("\n\nDefesa: \"Como começou seu relacionamento com meu cliente?\"");
            Console.Write("\n\nPromotor: \"Objeção!\"");
            Console.Write("\n\nVocê: \"E qual é o motivo?\"");
            Console.Write("\n\nPromotor: \"Ele está saindo do tópico do caso.\"");
            Console.Write("\n\nDefesa: \"Meu deus do céu, como está corte adora objeção...\"");
            Console.Write("\n\n Você olha de soslaio para a defesa. Mesmo você dando varios sermões, \neles nunca param de fazer esses comentários. Mas o promotor levantou uma \nobjeção e está esperando sua resposta. Você acho que este tipo de perguntavai beneficiar o caso?\"");
            Console.Write("\n\nVocê:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nAceita");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" a Objeção ou");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Recusa");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ?\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            while (text != "Aceita" && text != "Recusa")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nEstás objeções já estão te irritando...");
            }
            Console.ForegroundColor = ConsoleColor.White;
            if (text == "Aceita")
            {
                C = 1;
                Console.Write("\n\nVocê: \"Objeção aceita. Estas Perguntas são irrelevantes para o caso, dado que o passado de uma pessoa não interfere em ações legais, como julgado \npela jurisprudência de Whitman contra Malumini.\"");
                Console.Write("\n\n Os advogados olham surpresos, não esperando seu discurso. Você sabia que aquelas horas de estudos serviriam para alguma coisa!\"");
                Console.Write("\n\nDefesa: \"Bem, hmmmm...O réu descansa, então.\"");
                Console.Write("\n\nVocê não consegue conter um pequeno sorriso da sua cara.\"");
            }
            else
            {
                C = 0;
                Console.Write("\n\nVocê: \"Objeção negada. O relacionamento anterior afeta sim os \nacontecimentos. Pode prosseguir.\"");
                Console.Write("\n\nDefesa: \"Por que seu relacionamento anterior com meu cliente acabou?\"");
                Console.Write("\n\nAnna: \"A gente se desentendeu.\"");
                Console.Write("\n\nDefesa: \"Não é verdade que você reclamava varias vezes de meu cliente, \ndizendo que seu poder aquisitivo era baixo?\"");
                Console.Write("\n\nAnna: \"O-o quê?\"");
                Console.Write("\n\nDefesa: \"Você não falou varias vezes para sua amigas, via mensagens de \ntexto, que iria largar meu cliente por que ele era pobre?\"");
                Console.Write("\n\nPromotor: \"Objeção! Essas evidencias são inadmissíveis, já que invadem a \nprivacidade do meu cliente.\"");
                Console.Write("\n\nVocê:\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nAceita");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" a Objeção ou");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Recusa");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" ?\n\n");
                Console.ForegroundColor = ConsoleColor.Green;
                text = (Console.ReadLine());
                while (text != "Aceita" && text != "Recusa")
                {
                    if (text == "Ajuda")
                        text = ComandoAjuda();
                    else
                        text = ComandoInvalido("\nQuantas objeções, meu deus...");
                }
                Console.ForegroundColor = ConsoleColor.White;
                if (text == "Aceita")
                {
                    Console.Write("\n\nDefesa: \"Objeção aceita.\"");
                    Console.Write("\n\nDefesa: \"De acordo com artigo 52/1980, se uma das partes estiver ciente \nque uma conversa esta sendo gravada, ele é admissível. Além disso, toda \nconversa de texto é gravada e a autora assinou");
                    Console.Write(" um contrato com a provedorade serviço dizendo estar ciente do material sendo gravado.\"");
                    Console.Write("\n\nVocê: \"Baseado nas informações providas, devo aceitar as mensagens como \nevidencia. Pode prosseguir.\"");
                }
                else
                {
                    Console.Write("\n\nVocê: \"Objeção negada, pode prosseguir.\"");
                }
                Console.Write("\n\nAnna: \"É verdade.\"");
                Console.Write("\n\nDefesa: \"Você também não disse ao meu cliente que a razão de largar ele \nfoi o fato de ele ser pobre?\"");
                Console.Write("\n\nAnna: \"Sim.\"");
                Console.Write("\n\nDefesa: \"Você não trocou meu cliente por um homem mais rico?\"");
                Console.Write("\n\nAnna: \"Sim, mas isso é um crime?\"");
                Console.Write("\n\nDefesa: \"De jeito nenhum. Cada um pode exercer sua liberdade como bem \ndesejar.\"");
                Console.Write("\n\nAnna: \"Mas não foi só por isso. Ele também é mais gentil, engraçado e \nmuito mais educado. Até estudou fora!\"");
                Console.Write("\n\nDefesa: \"Eu não posso defender que meu cliente seja um melhor partido ou \nnão. A escolha é sua.\"");
                Console.Write("\n\nAnna: \"Ele também é bem mais velho. Um cara com mais experiência. Mais \nvivido.\"");
                Console.Write("\n\nDefesa: \"Bom que você tocou no assunto. Ele é tão mais velho, que ele tem mais que o dobro de sua idade. Não é correto?\"");
                Console.ReadKey();
                Console.Write("\n\nAnna: \"Sim, mas o amor não tem idade.\"");
                Console.Write("\n\nDefesa: \"Não é correto que quando você o conheceu, foi numa clinica em quevocê trabalha?\"");
                Console.Write("\n\nAnna: \"Sim, eu trabalho numa clinica de quimioterapia.\"");
                Console.Write("\n\nDefesa: \"Então você conheceu ele por que ele tinha câncer.\"");
                Console.Write("\n\nPromotor: \"Isso é tudo. Minha cliente vai se utilizar dos seus direito se manter calada para futuras perguntas.\"");
                Console.Write("\n\nDefesa: \"O réu descansa.\"");
                Console.Write("\n\nPromotor: \"Eu gostaria de fazer algumas perguntas para Anna. Anna, não é \nverdade que você já se casou com seu novo relacionamento?\"");
                Console.Write("\n\nAnna: \"Sim.\"");
                Console.Write("\n\nPromotor: \"A defesa quer fazer parecer que você casou com um homem mais \nrico, velho e doente por dinheiro.\"");
                Console.Write("\n\nAnna: \"Eu nunca faria isso. Nosso acordo pré-nupcial deixa bem claro que \ntoda a riqueza dele ira para fundos de caridade quando ele falecer.\"");
                Console.Write("\n\nPromotor: \"Isso é tudo.\"");
                Console.ReadKey();
                Console.Clear();
            }
            Console.Write("\n\nDefesa: \"Bem, então eu gostaria de chamar meu cliente para depor.\"");
            Console.Write("\n\nPromotor: \"Sério? mas um depoimento?\"");
            Console.Write("\n\nDefesa: \"O novo depoimento do meu cliente fornecerá novas informações, \nassim como o de Anna.\"");
            if (C == 1)
            {
                Console.Write("\n\nPromotor: \"Eu não sei aonde você achou o depoimento de Anna construtivo. \nSó deu informações que nós já sabiamos.\"");
                Console.Write("\n\nDefesa: \"E a quem devemos culpar disso? Quem cortou minhas questões?\"");
                Console.Write("\n\nPromotor: \"Eu apenas parei você de continuar com mais perguntas que tambemnão levariam a lugar nenhum.\"");
                Console.Write("\n\nDefesa: \"Como o senhor poderia saber disso se nem foi feito as perguntar?\"");
                Console.Write("\nPromotor: \"Mas eu...\"");
                Console.ReadKey();
                Console.Write("\n\nVocê: \"A discussão foi longe o suficiente. Por favor, senhores, \ncontinuemos com o caso.\"");
                Console.Write("\n\nDefesa: \"Como eu disse, eu gostaria de chamar meu cliente para depor.\"");
            }
            else
            {
                Console.Write("\n\nPromotor: \"Bem, concordo que Anna deu informações novas e relevantes. \nEspero que João faça a mesma coisa.\"");
                Console.Write("\n\nVocê: \"O que aconteceu aqui?! Promotor e Defesa pela primeira vez \nconcordando! Deve ser um milagre!\"");
                Console.Write("\n\nVocê diz isso em tom sarcástico, jogando suas mãos para o ar, como em uma prece.");
                Console.Write("\n\nDefesa: \"Pois é. Parece que a razão finalmente decidiu dar suas graças na mente de nosso amigo promotor.\"");
                Console.Write("\n\nPromotor: \"Por favor, paremos com comentários sarcásticos baratos e vamos voltar ao trabalho?\"");
                Console.Write("\n\n Você sente uma pontada de irritação na voz do promotor. Eles realmente \ndevem ser antigos inimigos...");
                Console.ReadKey();
            }
            Console.Write("\n\nVocê: \"Ok. Mas nos apressemos, por favor. Desejo dar esse caso como \nconcluido ainda hoje.\"");
            Console.Write("\n\nJoão: \"Ok, já estou indo sentar na caderinha. Já estou indo.\"");
            Console.Write("\n\n...");
            Console.Write("\n\nDefesa: \"Você sabia que Anna está casada com o homem que ela estava tendo um caso?\"");
            Console.Write("\n\nJoão: \"Sim, é uma vagabunda mesmo!\"");
            Console.Write("\n\nVocê: \"Cuidado com seu linguajar, não irei permitir isso no meu tribunal!\"");
            Console.Write("\nJoão: \"Desculpa doutor.\"");
            Console.Write("\n\n O advogado de defesa olha com medo para João. Você presume que ele sabia que João estava com paviu curto hoje, e resava para que ele não explodissena corte. A revelação de ontem deve telo chocado...");
            Console.Write("\n\nDefesa: \"Você esta ciente que ele morreu?\"");
            Console.Write("\n\nJoão: \"Sim, é por isso que a vadia está me processando! Ela não tem \ndinheiro pra cuidar da criança!\"");
            Console.Write("\n\nVocê: \"Senhor Snigik, este é seu ultimo aviso.\"");
            Console.Write("\n\nJoão: \"É Snigik com K mudo.\"");
            Console.ReadKey();
            Console.Write("\n\nComo se isso fosse mudar o fato dele ter estuprado alguém...");
            Console.Write("\n\nDefesa: \"Senhor João...\"");
            Console.Write("\n\nJoão: \"E é verdade! A vagabunda me disse que o cara era infértil. E só um bebê faria tudo dar certo! Algum blah blah blah sobre ser herdeiro \nlegítimo.\"");
            Console.Write("\n\nVocê: \"Basta. O Senhor será multado por difamação!\"");
            Console.Write("\n\nJoão: \"Isso é um absurdo! Que porra de...!\"");
            Console.Write("\n\nDefesa: \"João! Peço que você pare de...\"");
            Console.Write("\n\n A defesa tenta falar algo para seu cliente, mas o mar de vozes e opiniõesque a \"plateia\" estava produzindo faz com que niguem consiga ouvir nada.");
            Console.Write("\n\n*PAW \n*PAW");
            Console.Write("\n\nVocê: \"Silencio! Ordem!\"");
            Console.Write("\n\n*PAW \n*PAW");
            Console.Write("\n\nVocê: \"CALADOS!\"");
            Console.Write("\n\n Após o seu ultimo grito todos ficam calados. Estes ultimos minutos \nrealmente sairam fora de seu controle. Você não tem outra escolha:");
            Console.Write("\n\nVocê: \"Agora nós teremos uma pequena pausa para que todos recomponham-se. Quando eu voltar terei um veredito final sobre o caso.\"");
            Console.ReadKey();
            Console.Write("\n\nAnna: \"Mas, meretissímo, isso é injus...\"");
            Console.Write("\n\nVocê: \"Recesso de 1 hora, começando agora.\"");
            Console.Write("\n\n Você nem espera as respostas. Elas não levariam a lugar nenhum e gerariamapenas mais discussões. Talves, para sobrever nesse emprego, você deverá \nser mais duro com seus casos.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\n\n---------------------------------------\n\n");
            if (D == 1)
            {
                Console.Write(" Enquanto você está tomando um ar em seu escritório, sua secretária entra e lhe entrega um papel. Vendo o envelope, você vê que é do laboratório de DNA, contendo o resuldado do exame da paternidade do filho de Anna.");
                Console.Write("\nAbrindo e lendo o papel, você demora para entender o que aqueles simbolos representam, mas depois de alguns minutos você decifra a mensagem: João é o pai do bebê.");
                Console.Write("\n\n...\n\n Isso irá mudar o resultado de sua sentença?\n...\n");
            }
            Console.Write(" O mundo lá fora parece mais cinza. Você tem tanta coisa em sua mente que a menor das luzes parece um holofote aos seus olhos. O caso se estende em sua frente, em forma de papeis com letras minusculas.");
            Console.Write(" Quando você começou a pensar em cursar esta carreira, o trabalho de um juiz era algo elegante e mágico. Julgar os culpados e melhorar a sociedade atual, praticamente \nsendo um herói. Há, que sonhos infantis eram aqueles!");
            Console.Write(" Você anda se \nperguntando se você não seguiu esta carreira para, de forma inconciente, \naliviar sua culpa do passado...\n Você queria saber quem está falando a verdade e quem está mentindo no \ncaso. Mas o mundo não é tão simples,");
            Console.Write(" e heróis não existem...");
            Console.Write(" Um relógio nasua cabeça mostra os minutos passando, susurrando preocupações e fazendo \npressão sobre seus ombros. A decisão final deve ser tomada, queira você ounão. Dando um gole na bebida sobre sua mesa,");
            Console.Write(" você pega uma caneta e \nescreve, de olhos fechados, num papel seu veredito para o acusado. Quando a caneta parar de se mexer, a frase que estará escrita será:");
            Console.Write("\n\nO acusado é ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Culpado");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nou\nO acusado é ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inocente\n\n");
            text = (Console.ReadLine());
            while (text != "Culpado" && text != "Inocente")
            {
                if (text == "Ajuda")
                    text = ComandoAjuda();
                else
                    text = ComandoInvalido("\nAgora é a hora. Não erre...");
            }
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (text == "Culpado")
            {
                Console.Write("\n\n---------------------------------------\n\n");
                Console.Write("Todos na sala estão muito quietos. Eles tambem sentem a tensão no ar. Vocêdemora um pouco para se sentar em sua mesa e arrumar os papéis em cima \ndela.");
                Console.Write("\n\nVocê: \"Senhor João Snigik, por favor, levante-se.\"");
                Console.Write("\n\nEle levanta, receoso. Você ve as mãos dele tremerem.");
                Console.Write("\n\nVocê: \"Senhor João Snigik, pelo poder a mim investido pelo governo e \nestado, eu o declaro culpado das acusações de estrupro relacionadas ao \ncaso DL-6/2014.");
                Console.Write("\n\nVocê: \" Você cumprirá 15 anos de prisão. O senhor poderá apelar por boa \ncondu...\"");
                Console.Write("\n\nJoão: \"O QUE?! MAS EU NÃO FIZ NADA! ELA ESTÁ MENTINDO!\"");
                Console.Write("\n\n Ele começa a falar, mas logo as palavras saem de sua boca e ele fica em \nsilêncio. Ele simplismento senta, lentamente, em sua cadeira novamente.");
                Console.Write("\n\nVocê: \"Alem disso, o senhor será multado por difamação. Difamação vista \nanteriormente neste mesmo caso. Senhores oficiais, podem retirar o \nacusado, por favor.\"");
                Console.Write("\n\n Você diz isso aos policiais na porta da sala. Equanto você ia se \nlevantando e se preparando para voltar a sua sala, Anna se aproxima de \nvocê.");
                Console.ReadKey();
                Console.Write("\n\nAnna: \"Muito obrigada, meretissímo. Eu estou muito feliz de ver que aquelemonstro não vai ficar perto de mim. O senhor até que é legal. Se quiser \nvir na festa");
                Console.Write(" que vai ter na minha casa hoje a noite, eu vou ter bastante \nbebida para comemorar o caso!\"");
                Console.Write("\n\n Anna ouve seu advogado chama-lá e vai encontra-lo, nem dando tempo de \nvocê dar uma resposta a ela.\n.....\n\nVocê está satisfeito com sua decisão?\n\nVocê chega a conclusão");
                Console.Write(" de que você nunca terá uma resposta concreta para \nessa pergunta.");
            }
            else
            {
                Console.Write("\n\n---------------------------------------\n\n");
                Console.Write("Todos na sala estão muito quietos. Eles tambem sentem a tensão no ar. Vocêdemora um pouco para se sentar em sua mesa e arrumar os papéis em cima \ndela.");
                Console.Write("\n\nVocê: \"Senhor João Snigik, por favor, levante-se.\"");
                Console.Write("\n\nEle levanta, receoso. Você ve as mãos dele tremerem.");
                Console.Write("\n\nVocê: \"Senhor João Snigik, pelo poder a mim investido pelo governo e \nestado, eu o declaro inocênte das acusações de estrupro relacionadas ao \ncaso DL-6/2014.");
                Console.Write("\n\n Ele e seu advogado soltam um suspiro que parecia está guardado a anos em seus peitos. Eles se abração e comemoram o caso.");
                Console.Write("\n\nAnna: \"O QUE?! ESSE POBRE DO CARALHO MENTE EM CORTE E TODO MUNDO ACREDITA,E EU VENHO FALAR A VERDADE E TODO MUNDO ME TRATA MAL?!\"");
                Console.Write("\n\n Os gritos de Anna ecoam pela sala, mas logo morrem. Ela fica com a boca \naberta, olhando o você com fúria em seus olhos. O advogado dela, vendo queela falar algo errado");
                Console.Write(" poderia piorar a situação naquele momento, a leva \npara fora da sala. Enquanto você se preparava para sair tambem, João se \naproxíma:");
                Console.ReadKey();
                Console.Write("\n\nJoão: \"Velho, valeu mesmo pelo que tu fez! Eu sabia que ela ia mentir, mastentar me colocar na prisão é algo novo! Mas, de qualquer maneira, vem \npara o churraco que irá ter");
                Console.Write(" na minha casa nesse final de semana. Vou \ncomemorar o caso e preparar um processo muito bom para fuder aquela vadia.Depois de tudo que ela me fez passar, eu deveria comer o cu dela com \nareia...\"");
                Console.Write("\n\nDefesa: \"Senhor João, por favor me acompanhe. Vamos discutir os processos que você quer fazer contra Anna...\"");
                Console.Write("\n\nJoão: \"Bom, tenho que ir nessa. Depois te passo o indereço do churras lá. Falou senhor meritíssimo.\"");
                Console.Write("\n\n...\n\n");
                Console.Write("\n\nVocê está satisfeito com sua decisão?\n\nVocê chega a conclusão de que você nunca terá uma resposta concreta para \nessa pergunta.");
            }
        }
        static string ComandoInvalido(string texto)
        {
            string text;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(texto);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n*Comando Inválido\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            return text;
        }
        static string ComandoAjuda()
        {
            string text;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n As decisões que podem ser feitas estão em verde no final do texto. Digiteuma delas para prosseguir no jogo.");
            Console.Write("\n Em caso do texto parar no meio e não der decisão alguma, aperte qualquer tecla para continuar.");
            Console.Write(" Foi feito assim para que você não prescise ficar \nmechendo na barra de rolagem para ler todo texto.\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            text = (Console.ReadLine());
            return text;
        }
    }
}
