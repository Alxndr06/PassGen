using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PassGen
{
    class Passwords
    {
       public void GeneratePassword(bool min, bool maj, bool nmbrs, bool charSpec)
        {
			const int NMBRE_MDP_MAX = 10;
			var minuscules = "abcdefghijklmnopqrstuvwxyz";
            var majuscules = minuscules.ToUpper();
			var chiffres = "0123456789";
			var characteresSpeciaux = "@_-~#!?";
			string alphabet = "";
			string password = "";

			var longueurMotDePasse = 16;

			Random rand = new Random();
            
			if (!min && !maj && !nmbrs && !charSpec)
			{
				MessageBox.Show("Erreur ! Vous devez activer au moins une option pour générer votre mot de passe.");
			}
			else if (min && !maj && !nmbrs && !charSpec)
			{
				alphabet = minuscules;
			}
			else if (min && maj && !nmbrs && !charSpec)
			{
				alphabet = minuscules + majuscules;
			}
			else if (min && maj && nmbrs && !charSpec)
			{
				alphabet = minuscules + majuscules + chiffres;
			}
			else if (min && maj && nmbrs && charSpec)
			{
				alphabet = minuscules + majuscules + chiffres + characteresSpeciaux;
			}
				
			int longueurAlphabet = alphabet.Length;

            string[] listeMotsDePasse = new string[NMBRE_MDP_MAX];

            for (int j = 0; j < NMBRE_MDP_MAX; j++) // Boucle selon le nombre de MDP choisi dans NOMBRE_MDP.
			{
                password = "";
				for (int i = 0; i < longueurMotDePasse; i++)
				{
					int index = rand.Next(0, longueurAlphabet);
					password += alphabet[index];
				}
				listeMotsDePasse[j] = password;
            }
            // Construire le message avec tous les mots de passe
            string message = "Vos mots de passe générés :\n\n";
            foreach (string mdp in listeMotsDePasse)
            {
                message += mdp + "\n";
            }

            // Afficher le message
            MessageBox.Show(message);
        }

    }
}
