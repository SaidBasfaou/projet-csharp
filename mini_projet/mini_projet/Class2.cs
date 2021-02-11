using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projet
{
    class Magazin
    {
        private int id;
        private string address;
        List<Produit> liste_produits = new List<Produit>();
        public Magazin()
        {}
        public Magazin(int a,string b,List<Produit>l)
        {
            this.id = a;
            this.address = b;
            this.liste_produits = l;
        }
        public Magazin(Magazin M)
        {
            this.id = M.id;
            this.address = M.address;
            this.liste_produits = M.liste_produits;
        }

        public int _id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string _address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public void ajouter(Produit P)
        {
            this.liste_produits.Add(P);
        }
        public void affichage_liste()
        {
            foreach (Produit p in this.liste_produits)
            {
                p.affichage();
            }
        }
        public int Recherche(int num)
        {
            int pos = -1;
            for (int i = 0; i < this.liste_produits.Count; i++)
            {
                if(this.liste_produits[i]._numP==num)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public void supprimer(int num)
        {
            int x = Recherche(num);
            if(x==-1)
            {
                Console.WriteLine("le num n'existe pas");
            }
            else
            {
                this.liste_produits.RemoveAt(x);
            }
        }
        public void modifier(int num,Produit p)
        {
            int y = Recherche(num);
            if(y==-1)
            {
                Console.WriteLine("le num n'existe pas");
            }
            else
            {
                this.liste_produits[y] = p;
            }
        }
        public void Repture_en_stock()
        {
            for (int i = 0; i < this.liste_produits.Count; i++)
            {
                if(liste_produits[i]._Qnt==0)
                {
                    liste_produits[i].affichage();
                }
            }
        }

    }
}
