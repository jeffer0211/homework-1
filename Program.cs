using System;

namespace Swimming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Competition of Swimming.");

            Competition o = new Competition();
            o.newPerson();
            
            Pool ob = new Pool();
            ob.poolCompetition();

            Coch obj = new Coch();
            obj.info();

            Category obje = new Category();
            obje.categoryPerson();

            Equipmenst objec = new Equipmenst();
            objec.equipmenstSwim();
            
        }   
    }
}
