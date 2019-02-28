using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MorseCodeTranslator : MonoBehaviour {

    string MorseLetter;
    char Letter;
    string Word;
    private static Dictionary<char, string> morseCodeDictionary;
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
        MorseLetter = null;
    }


    public void NextLetter()
    {
        print(MorseLetter);
        //MorseLetter = null; // resets letter
        foreach(KeyValuePair<char, string> entry in morseCodeDictionary)
        {
            if (MorseLetter == entry.Value)
            {
                print(entry.Key);
                morseText.text += entry.Key.ToString();
                //DisplayText(UItext, Word);
            }
            // do something with entry.Value or entry.Key
        }
        MorseLetter = null;
    }

    public void Clear()
    {
        morseText.text = null;
    }

    public void DisplayText(GameObject prefab, string text)
    {
        textIns = Instantiate(prefab);
        textIns.GetComponent<Text>().text = text;
        textIns.transform.SetParent(GameObject.Find("Canvas").transform);
        textIns.transform.localPosition = new Vector3(0.0f, 2.0f, 0.0f);
    }

    private static void InitializeDictionary()
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
