using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorseCodeTranslator : MonoBehaviour {

    public string MorseLetter;
    public string morseTextTranslation;
    char Letter;
    string Word;
    public static Dictionary<char, string> morseCodeDictionary;
    public Text morseText;
    private GameObject textIns;
    private GameObject[] UIobjects;
    public GameObject UItext;



    // Use this for initialization
    void Start () {
        InitializeDictionary();
        morseText = GameObject.Find("MorseText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dash()
    {
        MorseLetter = MorseLetter + ("-");   
    }
    public void Dot()
    {
        MorseLetter = MorseLetter + (".");
    }
    public void NextWord()
    {
        morseText.text += " ";
        morseTextTranslation += " ";
        MorseLetter = null;
    }

    
    public void NextLetter()
    {
        morseText.text = TranslateLetter(MorseLetter);
    }

    /* Translates Morse Code to Text */
    public string TranslateLetter(string morseLetter)
    {
        // For each item in the morse code dictionary
        foreach (KeyValuePair<char, string> entry in morseCodeDictionary)
        {
            // check if the morse letter is equal to value in the dictionary
            if (morseLetter == entry.Value)
            {
                // if morse letter is equal add the key (the translation of the morse code) to the morseTextTranslation
                morseTextTranslation += entry.Key.ToString();
            }
        }
        MorseLetter = null;
        return morseTextTranslation;
    }

    public void Clear()
    {
        morseText.text = null;
        morseTextTranslation = null;
    }

    /* Displays text to the UI canvas */
    public void DisplayText(GameObject prefab, string text)
    {
        textIns = Instantiate(prefab);
        textIns.GetComponent<Text>().text = text;
        textIns.transform.SetParent(GameObject.Find("Canvas").transform);
        textIns.transform.localPosition = new Vector3(0.0f, 2.0f, 0.0f);
    }

    public void InitializeDictionary()
    {
        morseCodeDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };
    }
}
