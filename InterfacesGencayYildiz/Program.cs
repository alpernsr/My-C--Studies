using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGencayYildiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ornek ornek = new Ornek();
            IA a = new Ornek1();
            IB b = new Ornek1();
        }
    }
    interface IOrnek
    {
        int X();
        void Y();
        int OrnekProperty { get; set; }
    }

    class Ornek : IOrnek
    {
        public int OrnekProperty 
        { 
            get { throw new NotImplementedException(); } 
            set { throw new NotImplementedException(); }
        }

        public int X()
        {
            throw new NotImplementedException();
        }

        public void Y()
        {
            throw new NotImplementedException();
        }
    }
    interface IA
    {
        void x();
        void y();
        void z();
    }
    interface IB
    {
        void a();
        void b();
        void x();
    }
    class Ornek1 : IA, IB // implement expicility 
    {
        void IB.a()
        {
            throw new NotImplementedException();
        }

        void IB.b()
        {
            throw new NotImplementedException();
        }

        void IA.x()
        {
            throw new NotImplementedException();
        }

        void IB.x()
        {
            throw new NotImplementedException();
        }

        void IA.y()
        {
            throw new NotImplementedException();
        }

        void IA.z()
        {
            throw new NotImplementedException();
        }
    }

}
