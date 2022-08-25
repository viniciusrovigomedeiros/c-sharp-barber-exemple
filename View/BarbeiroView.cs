using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia
{
    internal class BarbeiroView
    {
        public static void Executa()
        {
            Barbeiro barbeiro1 = new Barbeiro
            {
                Id = 1,
                Nome = "Ronaldo",
                Sobrenome = "Nazário",
                Peso = 150
            };
            Barbeiro barbeiro2 = new Barbeiro
            {
                Id = 2,
                Nome = "Adriano",
                Sobrenome = "Leite",
                Peso = 350
            };

            BarbeiroRepository repo = new BarbeiroRepository();
            repo.Create(barbeiro1);
            repo.Create(barbeiro2);

            foreach (var barbeiro in repo.Read())
            {
                Console.WriteLine(barbeiro);
            }

        }
    }
}
