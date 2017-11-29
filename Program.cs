using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppP
{interface IZarzadzanie
    {
        void WypiszWszystko();
        void WyszukajPoTytule(string tytul);
        void WyszukajPoid(int id);
}
    public class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja()
        {

        }
        public Pozycja(string tytul,int id,string wydawnictwo,int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Id:{0}, tytul:{1}, wydawnictwo:{2},rokWydania{3}",this.id,this.tytul,this.wydawnictwo,this.rokWydania);
        }
        public string PobierzTytul()
        {
            return this.tytul;
        }
        public int PobierzId()
        {
            return this.id;
        }
    }
    public class Czasopismo:Pozycja
    {
        private int numer;
        public Czasopismo()
        {

        }
        public Czasopismo(string tytul,int id,string wydawnictwo,int rokWydania,int numer):base(tytul,id,wydawnictwo,rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Id:{0}, tytul:{1}, wydawnictwo:{2},rokWydania{3}, numer{4}", this.id, this.tytul, this.wydawnictwo, this.rokWydania,this.numer);
        }
    }
    public class Ksiazka:Pozycja
    {
        private int liczbaStron;
        Autor nowy=new Autor();
        public Ksiazka()
        {

        }
        public Ksiazka(string tytul,int id,string wydawnictwo,int rokWydania,int numer,string imie,string nazwisko,string pochodzenie):base(tytul,id,wydawnictwo,rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
            this.imie=imie;
            this.nazwisko=nazwisko;
            this.pochodzenie=pochodzenie;
        }
        public void WypiszInfo()
        {

        }
    }
     public class Osoba
        {
           protected string imie;
           protected string nazwisko;

           public Osoba()
           {

           }
           public Osoba(string imie, string nazwisko)
           {
              this.imie = imie;
                this.nazwisko = nazwisko;
           }

    public class Autor:Osoba
    {
        private string narodowosc;
        public Autor();
        public Autor(string imie ,string nazwisko,string narodowosc):base(imie,nazwisko)
        {
            this.imie=imie;
            this.nazwisko=nazwisko;
            this.narodowosc=narodowosc;
        }

        public string PobierzAutora(){
        return "0";
        
}
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
