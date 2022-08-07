using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;

        }
    }

    //class Filho : SemFilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarFamilia()
        {
            return true;
        }
    }

    class Pai :Avo
    {
        public  override sealed bool HonrarFamilia()
        {
            return false;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarFamilia()
        //{
        //    return false;
        //}
    }


    class Sealed
    {

        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna() );

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarFamilia());
        }
    }
}
