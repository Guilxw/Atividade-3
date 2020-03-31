using System.Collections.Generic;
using System.Text;
using System;

namespace atividade_3_POO
{
    class carimbo : Interacao
    {
        /*Atributos*/
        private string cor;
        private string texto;
        private int carga;

        /*contrutor*/
        public carimbo(string Ptexto)
        {
            trocaTexto(Ptexto);

        }

        /* Metodos Get Set*/

        private string Cor { 
        get {return cor;}
        set {cor = value; }}

        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public void usar()
        {
            if (carga >= 1)
                {if (!string.IsNullOrEmpty(texto))
                {
                    if (!string.IsNullOrEmpty(cor))
                    {
                        Console.WriteLine("(" + Texto + ") Carimbado na cor " + cor+ "\n");
                    }
                    else
                    {
                        Console.WriteLine("Impossivel Carimbar - Carimbo está sem cor.");
                    }
                }
                else
                {
                    Console.WriteLine("impossivel carimbar - carimbo sem texto");
                }
            }
            else
            {
                Console.WriteLine("impossivel carimbar - Carimbo sem carga");
            }
        }

        public void carregar(string Pcor, int Pcarga)
        {
            trocarcor(Pcor);


            if ((Pcarga < 1 && Pcarga > 10) && ((Carga + Pcarga) > 10))
            {
                Console.WriteLine("carga Atual: " + carga + ", A carga deve ser entre 1 e 10");
             }

            else
            {
                Carga = Pcarga;
            }
        }

        public void trocarcor (string Pcor)
        {
            if (Pcor == Cor)
            {
                Console.WriteLine("Carimbo já está com está cor!");
            }
            else
            {
                Cor = Pcor;
            }
        }

        public void trocaTexto (string Ptexto)
        {
            if (Ptexto == Texto)
            {
                Console.WriteLine("carimbo já está com está cor!");
            }

            else
            {
                Texto =Ptexto;
            }
        }

    }

}
