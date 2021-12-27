using System;

namespace Calculataor2{
    class program{
        static void Main(string[] args){

            Menu();
        }

        static void Menu(){
            Console.Clear();
            
            Console.WriteLine("Escolha a operação que deseja fazer:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Dividir");
            Console.WriteLine("4 - Multiplicar");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1 : somar();
                break;
                case 2 : subtracao();
                break;
                case 3 : divisao();
                break;
                case 4 : multiplicacao();
                break;
                case 0 : Environment.Exit(0);  
                break;
                default : Menu();
                break;
            }    

            
        }

        static void somar(){
            Console.Clear();
            
            Console.WriteLine("Informe o primeiro valor que deseja somar");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor que deseja somar");
            float v2 = float.Parse(Console.ReadLine());

            float soma = v1 + v2 ;

            Console.WriteLine($"O valor desta soma é igual a {soma}");

            Console.WriteLine(" ");

            Console.WriteLine("Quer fazer outra operação ? 1- Sim / 2 - Não");
            int selecao = int.Parse(Console.ReadLine());

            switch(selecao){
                case 1 : Menu();break;
                case 2 : Environment.Exit(2);break;
                default: Menu();break;
            }
            

            
        }
      

        static void subtracao(){
            Console.Clear();
            
            Console.WriteLine("Informe o primeiro valor que deseja subtrair");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor que deseja subtrair");
            float v2 = float.Parse(Console.ReadLine());

            float subtrair = v1 - v2 ;

            Console.WriteLine($"O valor desta soma é igual a {subtrair}");

            Console.WriteLine(" ");

            Console.WriteLine("Quer fazer outra operação ? 1- Sim / 2 - Não");
            int selecao = int.Parse(Console.ReadLine());

            switch(selecao){
                case 1 : Menu();break;
                case 2 : Environment.Exit(2);break;
                default: Menu();break;
            }
            
        }

        static void divisao(){
            Console.Clear();
            
            Console.WriteLine("Informe o primeiro valor que deseja dividir");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor que deseja dividir");
            float v2 = float.Parse(Console.ReadLine());

            float divisao = v1 / v2 ;

            Console.WriteLine($"O valor desta soma é igual a {divisao}");

            Console.WriteLine(" ");

            Console.WriteLine("Quer fazer outra operação ? 1- Sim / 2 - Não");
            int selecao = int.Parse(Console.ReadLine());

            switch(selecao){
                case 1 : Menu();break;
                case 2 : Environment.Exit(2);break;
                default: Menu();break;
            }
            
        }

        static void multiplicacao(){
            Console.Clear();
            
            Console.WriteLine("Informe o primeiro valor que deseja multiplicar");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor que deseja multiplicar");
            float v2 = float.Parse(Console.ReadLine());

            float multiplicar = v1 * v2 ;

            Console.WriteLine($"O valor desta soma é igual a {multiplicar}");

            Console.WriteLine(" ");

            Console.WriteLine("Quer fazer outra operação ? 1- Sim / 2 - Não");
            int selecao = int.Parse(Console.ReadLine());

            switch(selecao){
                case 1 : Menu();break;
                case 2 : Environment.Exit(2);break;
                default: Menu();break;
            }
        }
    
    }
}


