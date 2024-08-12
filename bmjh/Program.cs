/*using System.Runtime.InteropServices;

void Mensagem(){
    Console.WriteLine("olá, mundo");
}

Mensagem();

void Escreva(string msg)
{
    Console.WriteLine(msg);
}
Escreva("ho maigod");

void MostrarIdade(string nome, int idade)
{
    Escreva($"{nome} tem {idade}");
}
MostrarIdade("cr7",39);
MostrarIdade("ney",30);

void CalcularIdade(string nome, int ano)
{
    int idade = 2024 - ano; 
    MostrarIdade(nome,idade);
}
CalcularIdade("cr7", 6566);

int MaiorEntre(int a,int b)
{
    if(a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }

}
Console.WriteLine(MaiorEntre(329,87));

float resultado;

resultado = (100 + 50) / 2f;
 Console.WriteLine("a media é: " + resultado);
resultado = (30 + 45) / 2f;
Console.WriteLine("a media é: " + resultado);
resultado = (87 + 67) / 2f;
Console.WriteLine("a media é: " + resultado);

void CalcularMedia(int a,int b)
{
    float resultado = (a + b) / 2f;
    Console.WriteLine($"a media entre {a} e {b} é igual a: {resultado}");
}
CalcularMedia(100,50);
CalcularMedia(57,90);
CalcularMedia(500,70);

*/

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}




void Subtracao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}



void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}


void Divisao(float a, float b){
    if(b==0){
        Console.WriteLine("Erro de divisão por zero");
        return;
    }
    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
}










//Variáveis globais
float a;
float b;

void DigitarAeB(string operacao)
{Console.WriteLine(operacao);

    Console.WriteLine($"Digite o valor de a");
    a =  float.Parse(Console.ReadLine());
    Console.WriteLine($"Digite o valor de b");
    b =  float.Parse(Console.ReadLine());
}

/*
//Menu
Console.WriteLine("---calculadora---");
Console.WriteLine("1 - soma");
Console.WriteLine("2 - subtração");
Console.WriteLine("3 - multiplicação");
Console.WriteLine("4 - divisão");
Console.WriteLine("5 - sair");
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine("digite a opção desejada, siiiiiiiiuuuuuuuuu");

int opcao = int.Parse(Console.ReadLine());


if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}

else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a,b);
}


else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
}


else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a,b);
}

else if(opcao == 5){
    Console.WriteLine("Saindo...");
}

else {
    Console.WriteLine("Opção inválida");
}
*/



















































