using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordGenerator : MonoBehaviour
{
    
    private static string[] wordlist; 

    static WordGenerator()
    {
        string path = "/Users/jacobturner/Documents/SCHOOL/PROJECTS/FallingWordGame/Assets/TxtFiles/words.txt"; //path
        string content = File.ReadAllText(path); //reads file
        wordlist = content.Split(new[] {' '}, System.StringSplitOptions.RemoveEmptyEntries);
    }

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordlist.Length);
        string randomWord = wordlist[randomIndex];
        return randomWord;
    }
}