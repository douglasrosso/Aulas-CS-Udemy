#pragma once

/// <summary>
/// Estrutura utilizada nas funções
/// - RecebeEstrutura
/// - EnviaEstrutura
/// </summary>
struct MinhaEstrutura
{
    int valor1;
    double valor2;
    char valor3;
};

/// <summary>
/// Função Soma. Retorna a soma de dois números to tipo double
/// </summary>
/// <param name="a">Parâmetro de entrada do tipo double</param>
/// <param name="b">Parâmetro de entrada do tipo double</param>
/// <returns>Parâmetro de saída do tipo double. O número retornado é a soma dos parâmetros de entrada</returns>
extern "C" __declspec(dllexport) double Soma(double a, double b);

/// <summary>
/// Função Media. Retorna a média aritmética dos números passados no vetor a
/// </summary>
/// <param name="a">Vetor do tipo double. Este vetor contem os números usados para o cálculo da média</param>
/// <param name="quantidade">Número de elementos do vetor a</param>
/// <returns>Parâmetro de saída do tipo double. Retorna a média aritmética de todos os números passados no vetor a</returns>
extern "C" __declspec(dllexport) double Media(double* a, int quantidade);

/// <summary>
/// Função RecebeVetor. Esta função recebe um vetor e o preenche com números crescentes de 0 até n
/// </summary>
/// <param name="Vetor">Vetor do tipo int que será preenchido com números crescentes</param>
/// <param name="Tamanho">Número de elementos em Vetor</param>
extern "C" __declspec(dllexport) void RecebeVetor(int* Vetor, int Tamanho);

/// <summary>
/// Função EnviaFrase. Está função retorna "true" se o parâmetro de entrada for a string "EnviaFrase"
/// </summary>
/// <param name="Frase">Patâmetro de entrada do tipo ponteiro de chars. Deve ser terminada em nulo</param>
/// <returns>Retorna "true" se a Frase for "EnviaFrase"</returns>
extern "C" __declspec(dllexport) BOOL EnviaFrase(char* Frase);

/// <summary>
/// Função PegraFrase. Está função preenche uma string passada como parâmetro de entrada
/// </summary>
/// <param name="Frase">Parâmetro de entrada do tipo char*. Será preenchida com uma franse</param>
/// <param name="Tamanho">Tamanho da string de entrada</param>
extern "C" __declspec(dllexport) void PegaFrase(char* Frase, int Tamanho);

/// <summary>
/// Função RetornaString. Retorna um array de char terminado em nulo com uma frase
/// Chamar LimpaMemoria depois de usar essa função
/// </summary>
/// <returns></returns>
extern "C" __declspec(dllexport) char* RetornaString();

/// <summary>
/// Função RetornaArrayDeBytes. Função que retorna uma array de bytes de 3 posições.
/// O primeiro byte será 0
/// O segundo byte será 1
/// O terceiro byte será 2
/// Chamar LimpaMemoria depois de usar essa função
/// </summary>
/// <returns>Array de bytes retornado</returns>
extern "C" __declspec(dllexport) unsigned char * RetornaArrayDeBytes();

/// <summary>
/// Função RecebeEstrutura. Esta função recebe uma estrutura do tipo MinhaEstrutura e a preenche com:
/// - valor1 = 10
/// - valor2 = 20
/// - valor3 = 30
/// </summary>
/// <param name="minhaEstrutura">Estrutura de entrada do tipo MinhaEstrutura</param>
extern "C" __declspec(dllexport) void RecebeEstrutura(struct MinhaEstrutura* minhaEstrutura);

/// <summary>
/// Função EnviaEstrutura. Retorna true se a estrutura de entrada do tipo MinhaEstrutura tiver os seguintes valores:
/// - valor1 = 10
/// - valor2 = 20
/// - valor3 = 'a'
/// </summary>
/// <param name="minhaEstrutura">Parâmetro de entrada do tipo minhaEstrutura</param>
/// <returns></returns>
extern "C" __declspec(dllexport) BOOL EnviaEstrutura(struct MinhaEstrutura* minhaEstrutura);

/// <summary>
/// Função RetornaEstrutura. Retorna uma estrutura do tipo MinhaEstrutura com os seguintes valores:
/// - valor1 = 10
/// - valor2 = 20
/// - valor3 = 30
/// Chamar LimpaMemoria depois de usar essa função
/// </summary>
extern "C" __declspec(dllexport) struct MinhaEstrutura* RetornaEstrutura();

/// <summary>
/// Função LimpaMemoria.
/// Deve ser chamada após as funções :
/// - RetornaArrayDeBytes
/// - RetornaString
/// - RetornaEstrutura
/// </summary>
extern "C" __declspec(dllexport) void LimpaMemoria();
