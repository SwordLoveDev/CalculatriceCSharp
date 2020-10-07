using System;

class Calculatrice
{
    static void Main(string[] args)
    {
        float nombre1 = 0;
        float nombre2 = 0;
        float resultat = 0;
        string choix;

        Console.Write("[+] Entrez votre premier nombre : ");
        nombre1 = (float.Parse(Console.ReadLine()));

        Console.Write("[+] Entrez votre opérateur (+, -, *, /): ");
        choix = Console.ReadLine();

        Console.Write("[+] Entrez votre deuxieme nombre : ");
        nombre2 = (float.Parse(Console.ReadLine()));

        if(choix == "/" && nombre2 == 0)
        {
            Console.WriteLine("On ne peux pas diviser par 0 !");
        }
        else
        {
            if(choix == "+")
            {
                resultat = nombre1 + nombre2;
                Console.WriteLine("-->  " + nombre1 + " + " + nombre2 + " = " + resultat);
            }
            if(choix == "-")
            {
                resultat = nombre1 - nombre2;
                Console.WriteLine("-->  " + nombre1 + " - " + nombre2 + " = " + resultat);
            }
            if(choix == "*")
            {
                resultat = nombre1 * nombre2;
                Console.WriteLine("-->  " + nombre1 + " x " + nombre2 + " = " + resultat);
            }
            if(choix == "/")
            {
                resultat = nombre1 / nombre2;
                Console.WriteLine("-->  " + nombre1 + " / " + nombre2 + " = " + resultat);
            }
        }
    }
}
