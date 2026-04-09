//RPG - Evellyn Silva de Aquino
Console.WriteLine("Qual o nome do viajante?");
string nomeHeroi = Console.ReadLine();

int ataqueBase = 40;
int bonusArma = 10;
int ataqueTotal = ataqueBase + bonusArma;
double vidaInimigo = 150.5;
double dano = 50.5;
double vidaRestante = vidaInimigo - dano;
float moedas = 12.5f;
var moedasDobro = moedas * 2f;
long xpTotal = 1000000;
long mediaXP = xpTotal / 2;

Console.WriteLine($"\n{nomeHeroi} cresceu ouvindo o barulho do vento nas plantações, mas o mundo mudou quando o Rei Demônio trouxe o medo. " +
$"Não foi por coragem, mas por necessidade que ele partiu para essa missão. \n{nomeHeroi} carrega a força de quem já trabalhou muito a terra ({ataqueBase}) " +
$"e uma velha espada que pertenceu ao seu pai, garantindo {bonusArma} de confiança extra. Seu vigor total é de {ataqueTotal}! \n" +
$"Perto das ruínas de uma antiga ponte, {nomeHeroi} encontra alguém que se perdeu para a escuridão. O que você sente que deve fazer?");

Console.WriteLine("\n 1 - Observar o cansaço do oponente \n 2 - Agir com determinação ");
string escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.WriteLine($"\n{nomeHeroi} percebe que o outro lado ainda resiste com {vidaInimigo} de fôlego. " +
    $"Em um movimento rápido, ele desfere {ataqueTotal} de dano, deixando o oponente com apenas {vidaRestante} de vida.");
}
if (escolha == "2")
{
    Console.WriteLine($"\nCom as mãos trêmulas, mas firmes, {nomeHeroi} ataca causando {ataqueTotal} de dano. " +
    $"O inimigo recua, restando apenas {vidaRestante} de sua integridade.");
}

Console.WriteLine($"\nO confronto termina sem mais sangue; o inimigo foge para a neblina. {nomeHeroi} encontra {moedas} moedas caídas no barro, " +
$"mas sua bondade pelo caminho fez com que recebesse ajuda, totalizando {moedasDobro} moedas. A jornada lhe trouxe {xpTotal} de " +
$"aprendizado de vida, sendo {mediaXP} a marca deixada em sua alma até aqui.");

Console.WriteLine($"\nCom os pés cansados e o coração batendo forte, {nomeHeroi} avista o castelo negro. " +
$"O fim da estrada chegou, e ele só espera poder voltar para casa um dia.");
bool entendiMateria = true;