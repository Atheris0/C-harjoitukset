using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

class Checker
{
    int wordCounter = 0;
    string line;
    int charCounter = 0;
    List<string> sanalista = new List<string>();
    List<string> searchList = new List<string>();

    public Checker(string filename)
    {
        // Lue tiedosto ja analysoi sisältö
        using (StreamReader file = new StreamReader(filename))
        {
            while ((line = file.ReadLine()) != null)
            {
                charCounter += line.Length;
                string trimmedLine = line.Trim();
                string[] sanalista = trimmedLine.Split(new char[] { ' ' });
                foreach (string item in sanalista)
                {
                    //Console.WriteLine(item);
                    searchList.Add(item);
                    wordCounter++;
                }
            }
        }

    }
    public int GetCounter()
    {
        return wordCounter;
    }
    public int GetCharacters() 
    { 
        return charCounter; 
    }
    public int SearchWords(string searchedWord)
    {
        //Jos haetua sanaa ei ole tiedostossa, tulostuu määräksi 0
        int count = 0;
        // Muunna haettava sana pieniksi kirjaimiksi
        searchedWord = searchedWord.ToLower();
        //Console.WriteLine(searchedWord);
        //Console.WriteLine(searchList.Count());
        count = searchList.Count(word => word.ToLower() == searchedWord);
        return count;
    }

    

}