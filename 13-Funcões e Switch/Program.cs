using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Funcões_e_Switch
{

    class Program
    {
        static void Main(string[] args)
        {
            int s_tabuada;

            Console.WriteLine("\t\t\t Esse Sistema tem o Intuito Educacional");
            Console.WriteLine("\t\tDigite 1 para usar o sistema Tabuada");
            Console.WriteLine("\t\tDigite 2 para Contar");
            Console.WriteLine("\t\tDigite 3 para Sair");

            s_tabuada = int.Parse(Console.ReadLine());          

            switch (s_tabuada) //Sempre Converter o Objeto do Switch com o Parse.
            {
                case 1:
                    Fun_tabuada();
                    break;

                case 2:
                    Fun_contar();
                    break;

                case 3:
                    Fun_fechar();
                    break;



            }
        }

         static void Fun_tabuada()
        {
            int tab_num;

            Console.WriteLine("\t\t\t**\tTABUADA**");

            Console.WriteLine("\nDigite um Numero da Tabuada");
            tab_num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("\n" + tab_num + "X" + i + "=" + (tab_num * i));
            }         
        } //Funcões

        static void Fun_contar()
        {

            Console.WriteLine("Você deseja contar até...?");
            int contar = int.Parse(Console.ReadLine());

            for (int c = 0; c <= contar; c++)
            {
                Console.WriteLine("\n" + c);

               
            }
        }   //Funcões       

        static void Fun_fechar()
        {
            Console.WriteLine("Até mais xD");
            Console.ReadLine();
        } //Funcões
    }

    
}
