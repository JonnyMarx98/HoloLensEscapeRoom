using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MorseTranslateTest {

	[Test]
	public void MorseTranslateTestSimplePasses() {
        // Use the Assert class to test conditions.
        GameObject morseGraph = GameObject.FindGameObjectWithTag("MorseCode");
        MorseCodeTranslator morseTranslator = morseGraph.GetComponent<MorseCodeTranslator>();
        morseTranslator.InitializeDictionary();
        Assert.AreEqual(morseTranslator.TranslateLetter("-.-"), "k");
        Assert.AreEqual(morseTranslator.TranslateLetter("-.-."), "kc");
        Assert.AreEqual(morseTranslator.TranslateLetter(".-."), "kcr");
    }

    [TearDown]
    /* Resets the morse translation text so next tests work properly */
    public void AfterEachTest()
    {
        GameObject morseGraph = GameObject.FindGameObjectWithTag("MorseCode");
        MorseCodeTranslator morseTranslator = morseGraph.GetComponent<MorseCodeTranslator>();
        morseTranslator.morseTextTranslation = null;
        morseTranslator.MorseLetter = null;
    }

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator MorseTranslateTestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        GameObject morseGraph = GameObject.FindGameObjectWithTag("MorseCode");
        MorseCodeTranslator morseTranslator = morseGraph.GetComponent<MorseCodeTranslator>();
        Assert.AreEqual(morseTranslator.TranslateLetter("-.-"), "k");
        Assert.AreEqual(morseTranslator.TranslateLetter("-.-."), "kc");
        Assert.AreEqual(morseTranslator.TranslateLetter(".-."), "kcr");
        yield return null;
	}
}
