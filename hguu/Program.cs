bool Resposta()
{
    inicioPergunta:
    string resposta = Console.ReadLine();

    if(resposta == "s")
    {
        return true;
    }
    else if(resposta == "n")
    {
        return false;
    }
    else
    {
        Console.WriteLine("Não entendi, responda apenas s/n:");
        goto inicioPergunta;
    }

}
//Inicialização 
Console.WriteLine("Quer jogar um jogo ? s/n");
if(Resposta() == false) //se o jogador respondeu n, pula direto para o final do jogo
{
    goto finalJogo; //lembre de definar esta label la no final
}
inicioJogo: //label que marca o início da execução do jogo

int menor = 0; //do intervalo de números para sortear esse é o menor 
int maior = 100; //e esse é o maior
int numTentativas = 10; //defina quantas tentativas o jogador tem 
bool jogoRodando = true; //o jogo começa rodando, essa variável é verdadeira

Random rand = new Random();
int sorteado = rand.Next(menor, maior +1); // sorteio do número aleatório dentro do intervalo
Console.WriteLine($"Pensei em um número entre {menor} e {maior}. Tente adivinhar!");


while(jogoRodando) //loop de jogo
{
    Console.WriteLine($"Tentativa {numTentativas}: "); //mostrando quantas tentativas restam
    int numDigitado = int.Parse(Console.ReadLine()); //aqui o jogador digita seu número
    if(numDigitado < sorteado) //comparando o número digitado e o sorteado
    {
      Console.WriteLine("muito baixo. Tente novamente.");
      numTentativas --; //-1 tentativa, o número do jogador era menor que o sorteado 
    }
    else if(numDigitado > sorteado)
    {
      Console.WriteLine("muito alto. Tente novamente.");
      numTentativas --; //-1 tentativa, o número do jogador era maior que o sorteado
    }
    else
    {
      Console.WriteLine("Parabéns! você acertou!");
      jogoRodando = false; //jogador acertou, o programa encerra aqui
    }
 
    if(numTentativas > 0) //verificando tentativas restantes   
    {
        Console.WriteLine("Tente novamente."); //se ainda há tentativas 
    }

    else
    {
        Console.WriteLine("Acabaram as tentativas ");
        jogoRodando = false; //o programa encerra aqui se as tentativas chegam a 0
    } 
}

//Finalização
 
Console.WriteLine("Quer jogar de novo ? s/n"); //essa pergunta é feita independente se o jogador ganhou ou não
if(Resposta() == true)
{
    goto inicioJogo; //se o jogador quer jogar de novo o programa  volta para a inicialização
}

finalJogo: //label que marca o final do programa. A pergunta lá da inicialização encaminha o programa para cá
Console.WriteLine("Então até a próxima!");

























































































