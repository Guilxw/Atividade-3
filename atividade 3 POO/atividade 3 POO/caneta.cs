using System.Collections.Generic;
using System.Text;
using System;

namespace atividade_3_POO
{
    class caneta:Interacao
    {
        /*Atributos*/
        private string cor;
        private string texto;
        private int carga;

        /*contrutor*/
        public caneta(string Ptexto)
        {
            trocaTexto(Ptexto);

        }

        /* Metodos Get Set*/

        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

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
            {
                if (!string.IsNullOrEmpty(Texto))
                {
                    if (!string.IsNullOrEmpty(Cor))
                    {
                        Console.WriteLine("\n (" + Texto + ")  escrito na cor " + Cor+ "\n");
                    }
                    else
                    {
                        Console.WriteLine("Impossivel escrever - caneta está sem cor.");
                    }
                }
                else
                {
                    Console.WriteLine("impossivel escrever - caneta sem texto");
                }
            }
            else
            {
                Console.WriteLine("impossivel escrever - caneta sem carga");
            }
        }

        public void carregar(string Pcor, int Pcarga)
        {
            trocarcor(Pcor);


            if ((Pcarga < 1 && Pcarga > 10) && ((Carga + Pcarga) > 10))
            {
                Console.WriteLine("carga Atual: " + Carga + ", A carga deve ser entre 1 e 10");
            }

            else
            {
                Carga = Pcarga;
            }
        }

        public void trocarcor(string Pcor)
        {
            if (Pcor == Cor)
            {
                Console.WriteLine("Caneta já está com está cor!");
            }
            else
            {
                Cor = Pcor;
            }
        }

        public void trocaTexto(string Ptexto)
        {
            if (Ptexto == Texto)
            {
                Console.WriteLine("Caneta já está com está cor!");
            }

            else
            {
                texto = Ptexto;
            }
        }

    }

}
