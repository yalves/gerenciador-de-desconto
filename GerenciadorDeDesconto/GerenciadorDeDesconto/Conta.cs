using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDesconto
{
    public class Conta
    {
        public TipoDeConta Tipo { get; private set; }
        public int TempoDeCadastroEmAnos { get; private set; }

        public Conta(TipoDeConta tipo, int tempoDeCadastroEmAnos)
        {
            Tipo = tipo;
            TempoDeCadastroEmAnos = tempoDeCadastroEmAnos;
        }
    }
}
