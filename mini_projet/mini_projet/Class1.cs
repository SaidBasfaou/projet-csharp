using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet
{
    class Produit
    {
        private int numP;
        private string nomP;
        private double prix;
        private int Qnt;

        public static int nb = 0;

        public Produit()
        { nb++; }
        public Produit(int a,string b,double c,int d)
        {
            this.numP = a;
            this.nomP = b;
            this.prix = c;
            if (d>=0)
            {
                this.Qnt = d;
            }
            else
            {
                throw new Exception("attention");
            }
            nb++;
        }
        public Produit(Produit P)
        {
            this.numP = P.numP;
            this.nomP = P.nomP;
            this.prix = P.prix;
            this.Qnt = P.Qnt;
            nb++;
        }
        public int _numP
        {
            get { return this.numP; }
            set { this.numP = value; }
        }
        public string _nomP
        {
            get { return this.nomP; }
            set { this.nomP = value; }
        }

        public double _prix
        {
            get { return this.prix; }
            set { this.prix = value; }
        }
        public int _Qnt
        {
            get { return this.Qnt; }
            set 
            { 
                if(value>=0)
                { 
                    this.Qnt = value;
                }
                else
                {
                    throw new Exception("attention");
                }
                     
            }
        }
        public void affichage()
        {
            Console.WriteLine("le num " + this.numP + " le nom " + this.nomP + " le prix " + this.prix + " la quantite " + this.Qnt);
        }
        public static bool Compare(Produit P1,Produit P2)
        {
            bool res = false;
            if(P1.numP==P2.numP)
            {
                res = true;
            }
            return res;
        }
        public void prix_aug(double a)
        {
            this.prix = this.prix + (this.prix = (a / 100));
        }
    }
}
