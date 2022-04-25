using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atendimentoo
{
    class Paciente
    {
        string escolha;

        public void cadastroFila(){ 
        Console.WriteLine("Digite a para cadastrar\nDigite b para atender ao paciente\nDigite s para listar \nDigite w para alterar os dados");
            escolha = Console.ReadLine();
            Console.ReadKey();

            if (escolha == "a") {

                Console.WriteLine("area de cadastro");
                Console.ReadKey();
            }
            else
            {

            }
        }
    }
}
