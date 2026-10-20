using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace HNI_TPmoyennes
{
    class Program
    {
        // Ne pas modifier
        static void Main(string[] args)
        {
            // Création d'une classe
            //Classe eleve
            public class Eleve
        {
            public string prenom { get; set; };
            public string nom { get; set; };
            public List<Note> notes { get; set; };

            public Eleve(string pnom, string nnom)
            {
                this.prenom = pnom;
                this.nom = nnom;
                notes = new List<Note>();
            }
            public ajouterNotes(Note n)
            { if (notes.length < 200)
                {
                    notes.Add(n);
                }
                else
                {
                    Console.WriteLine("erreur maximum notes autorisé 200")
                }
            }
            public double moyenneMatiere(int m)
            {
                double temp = 0;
                double nbnote = 0;
                for (int i = 0; i < notes.Length; i++)
                {
                    if (notes[i].matiere == m)
                    {
                        temp += notes[i].note;
                        nbnotes += 1;
                    }
                }
                return Math.Round(temp / nbnote,2);
            }
            public double moyenneGeneral()
            {
                double temp = 0;
                double nbnote = 0;
                for (int i = 0; i < notes.Length; i++)
                {
                    temp += notes[i].note;
                    nbnotes += 1;
                }
                return Math.Round(temp / nbnote,2);
            }
        }
            //class Classe
            public class Classe {

            public List<Eleve> eleves { get; set; };
            public List<string matiere> matieres { get; set; };
            public Classe(string classe)
            {
                eleves= new List<Eleve>();
                matieres= new List<string>();
            }
            public void ajouterEleve(string prenom, string nom)
            {
                    if (eleves.Count == 30)
                    {
                        Console.WriteLine("erreur max eleves par classe 30");
                    }
                    else
                    {
                        temp = Eleve(prenom, nom);
                    }
                eleves.Add(temp);
            }
            public void ajouterMatiere(string matiere)
            {
                    if (matiere.Length == 10)
                    {

                        Console.WriteLine("erreur max matiere 10");
                    }
                    else
                    {
                        matieres.Add(matiere);
                    }
            }
            public double moyenneMatiere(int m)
            {
                double temp = 0;
                double nbeleve = (double)eleves.Length;
                for(int i = 0; i < eleves.Length; i++)
                {
                    temp += eleves.moyenneMatiere(m);
                }
                return Math.Round(temp / nbeleve, 2);
            }
            public double moyenneGeneral()
            {
                double temp = 0;
                double nbeleve = (double)eleves.Length;
                for (int i = 0; i < eleves.Length; i++)
                {
                    temp += eleves.moyenneGeneral();
                }
                return Math.Round(temp / nbeleve, 2);
            }
        }
            Classe sixiemeA = new Classe("6eme A");
            // Ajout des élèves à la classe
			//comment
            sixiemeA.ajouterEleve("Jean", "RAGE");
            sixiemeA.ajouterEleve("Paul", "HAAR");
            sixiemeA.ajouterEleve("Sibylle", "BOQUET");
            sixiemeA.ajouterEleve("Annie", "CROCHE");
            sixiemeA.ajouterEleve("Alain", "PROVISTE");
            sixiemeA.ajouterEleve("Justin", "TYDERNIER");
            sixiemeA.ajouterEleve("Sacha", "TOUILLE");
            sixiemeA.ajouterEleve("Cesar", "TICHO");
            sixiemeA.ajouterEleve("Guy", "DON");
            // Ajout de matières étudiées par la classe
            sixiemeA.ajouterMatiere("Francais");
            sixiemeA.ajouterMatiere("Anglais");
            sixiemeA.ajouterMatiere("Physique/Chimie");
            sixiemeA.ajouterMatiere("Histoire");
            Random random = new Random();
            // Ajout de 5 notes à chaque élève et dans chaque matière
            for (int ieleve = 0; ieleve < sixiemeA.eleves.Count; ieleve++)
            {
                for (int matiere = 0; matiere < sixiemeA.matieres.Count; matiere++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sixiemeA.eleves[ieleve].ajouterNote(new Note(matiere, (float)((6.5 +
                       random.NextDouble() * 34)) / 2.0f));
                        // Note minimale = 3
                    }
                }
            }

            Eleve eleve = sixiemeA.eleves[6];
            // Afficher la moyenne d'un élève dans une matière
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
            eleve.moyenneMatiere(1) + "\n");
            // Afficher la moyenne générale du même élève
            Console.Write(eleve.prenom + " " + eleve.nom + ", Moyenne Generale : " + eleve.moyenneGeneral() + "\n");
            // Afficher la moyenne de la classe dans une matière
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne en " + sixiemeA.matieres[1] + " : " +
            sixiemeA.moyenneMatiere(1) + "\n");
            // Afficher la moyenne générale de la classe
            Console.Write("Classe de " + sixiemeA.nomClasse + ", Moyenne Generale : " + sixiemeA.moyenneGeneral() + "\n");
            Console.Read();
        }
    }
}



