using System;

public class TiposDeDadosPrimitivos
{
    public static void Main()
    {
        string nome = "Monkey D. Luffy"; // tipo de dado que representa uma sequência de caracteres (texto).
        int anos = 19; // tipo de dado numérico inteiro que representa números inteiros.
        double altura = 1.75; // tipo de dado numérico de ponto flutuante que representa números com casas decimais.
        float temperatura = 26.5f; // tipo de dado numérico de ponto flutuante, porém, com precisão menor que o double.
        bool estaChovendo = false; // tipo de dado booleano que representa os valores true ou false.
        char letra = 'A'; // tipo de dado que representa um caractere Unicode.
        byte codigo = 65; // tipo de dado numérico inteiro não negativo, com valores na faixa de 0 a 255.
        short distancia = 1500; // tipo de dado numérico inteiro que representa números inteiros menores que o tipo int.
        long populacaoMundial = 7800000000; // tipo de dado numérico inteiro que representa números inteiros maiores que o tipo int.

        Console.WriteLine(nome);
    }
}
