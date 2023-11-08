using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 1.Variáveis e tipos de dados.1.2. Tipos de dados personalizados.1.2.1. Tipo class
{

      //Classes: As classes são o bloco básico de construção de tipos em C#. Você pode criar suas próprias classes para definir tipos de dados personalizados com atributos e métodos
    public class Carro 
    {
          public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public void StartEngine()
        {
            // Lógica para iniciar o motor do carro
            //Método que parte de uma ação do carro
        }
        
    }
}