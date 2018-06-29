using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDesconto
{
    /**
     * DiscountManager
     * ------------------------
     * 
     * Sua responsabilidade � calcular o desconto para o consumidor 
     * quando esse est� em um processo de compra na loja online.
     * 
     * Dif�cil de ler, dif�cil manuten��o, dif�cil de extender.
     * 
     * - Nomes - Desperd�cio de tempo, gasto na tentativa de entender o c�digo.
     * - N�meros m�gicos - O tipo � relativo ao estado da conta do consumidor.
     * Mas qual estado � indicado por cada n�mero? 
     * - Bug n�o muito �bvio - E se um novo tipo de consumidor fosse adicionado?
     * - Mais n�meros m�gicos - O que significam o 0.1, o 0.7 e o 0.5? 
     * Valor m�ximo de desconto, em percentual, para aquele consumidor.
     * - DRY - disc * (amount - (0.1m * amount)); == disc * (amount - (0.5 * amount));
     * - M�ltiplas responsabilidades - 
     *      1. Escolha do algoritmo para o c�lculo
     *      2. C�lculo do desconto para um dado estado da conta do consumidor
     *      3. C�lculo do desconto para o tempo de cadastro do consumidor
     **/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
