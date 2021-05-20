using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Desafio_Dirmod
{
    public class Proceso
    {
        Dictionary<char, int> equivalentes = new Dictionary<char, int>();
        String texto;
        String texto2;

        public void diccionario() {
         
            equivalentes.Add('A', 2);
            equivalentes.Add('B', 22);
            equivalentes.Add('C', 222);
            equivalentes.Add('D', 3);
            equivalentes.Add('E', 33);
            equivalentes.Add('G', 4);
            equivalentes.Add('H', 44);
            equivalentes.Add('I', 444);
            equivalentes.Add('J', 5);
            equivalentes.Add('K', 55);
            equivalentes.Add('L', 55);
            equivalentes.Add('M', 6);
            equivalentes.Add('N', 66);
            equivalentes.Add('O', 666);
            equivalentes.Add('P', 7);
            equivalentes.Add('Q', 77);
            equivalentes.Add('R', 777);
            equivalentes.Add('S', 7777);
            equivalentes.Add('T', 8);
            equivalentes.Add('U', 88);
            equivalentes.Add('V', 888);
            equivalentes.Add('W', 9);
            equivalentes.Add('X', 99);
            equivalentes.Add('Y', 999);
            equivalentes.Add('Z', 9999);
            equivalentes.Add(' ', 0);
        }

        public void comparacion(){
            Console.WriteLine("Ingrese el texto a convertir: ");
            Console.WriteLine("                                            ");
            String texto;
            texto = Console.ReadLine();
            texto = texto.ToUpper();
            char[] array = texto.ToCharArray(); 

            foreach (char c in array)
	        {
	            foreach (var letra in equivalentes){
                    if( c == letra.Key)
                    {
                        texto2 = texto2 + letra.Value;
                    }
                }
            
            }
            Console.WriteLine("                                            ");
            Console.WriteLine("Se devolverá la cadena convertida: ");
            Console.WriteLine("                                            ");
            Console.WriteLine(texto2);
	    
        }
    }
}