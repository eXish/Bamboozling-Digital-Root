using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;

public class BamboozlingDigitalRoot : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;
    public KMSelectable[] Buttons;
    public TextMesh dsefcghvbjnmkjhvgcfxdcvghbnmjkjnhbvgfcdcgvhbn;
    public GameObject[] Connectors;
    public TextMesh[] ButtonTexts;
    public TextMesh Main;
    public GameObject[] Wires;
    public Material[] Colors;
    public KMSelectable[] WiresButobject;
    public KMSelectable LED;
    public TextMesh[] BottunsText;
    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;
    int JHKMG = 0;
    int jhkmg = 0;
    int BlananastwooncesaidWhyOnEarthAreTheyCalledBunnies = 0;
    int lazy = 0;
    int text = 0;
    int Colours = 0;
    int Colourname = 0;
    int next = 0;
    int number = 0;
    int numbernumber = 0;
    int then = 0;
    int letter = 0;
    int lettername = 0;
    int quote = 0;
    int TextColor = 0;
    int TextColor2 = 0;
    int TextColor3 = 0;
    int TextColor4 = 0;
    int TextColor5 = 0;
    int TextColor6 = 0;
    int TextColor7 = 0;
    int TextColor8 = 0;
    int TextColor9 = 0;
    int TextColor0 = 0;
    bool ColoredSwitches = false;
    private List<byte> Red = new List<byte>{205,9,58,24,99,104,255,255,255,255,255,0};
    private List<byte> Green = new List<byte>{0,11,44,60,99,255,185,167,0,255,248,234};
    private List<byte> Blue = new List<byte>{208,255,9,0,99,0,0,242,0,255,0,255};
    int random1 = 0;
    int random2 = 0;
    int random3 = 0;
    int random4 = 0;
    int random5 = 0;
    int random6 = 0;
    int fuck = 0;
    int fuck2 = 0;
    bool Wavecheck = false;

    void Awake () {
        moduleId = moduleIdCounter++;
        foreach (KMSelectable Button in Buttons){
            Button.OnInteract += delegate () { ButtonsPress(Button); return false; };
        }
        foreach (KMSelectable Wireo in WiresButobject){
            Wireo.OnInteract += delegate () { WireCut(Wireo); return false; };
        }
        LED.OnInteract += delegate () { PressLED(); return false; };
    }

    void Start () {
      BottunsText[0].text = BDRPBP.Phrases[UnityEngine.Random.Range(0,BDRPBP.Phrases.Count())];
      BottunsText[1].text = BDRPBP.Phrases[UnityEngine.Random.Range(0,BDRPBP.Phrases.Count())];
      BottunsText[2].text = BDRPBP.Phrases[UnityEngine.Random.Range(0,BDRPBP.Phrases.Count())];
      StartCoroutine(ButtonBullshit());
        fuck = UnityEngine.Random.Range(0,Colors.Count());
        fuck2 = UnityEngine.Random.Range(0,Colors.Count());
        Wires[0].GetComponent<MeshRenderer>().material = Colors[fuck];
        Wires[1].GetComponent<MeshRenderer>().material = Colors[fuck2];
      for (int i = 0; i < 4; i++) {
        Connectors[i].GetComponent<MeshRenderer>().material = Colors[UnityEngine.Random.Range(0,Colors.Count())];
      }
      quote = UnityEngine.Random.Range(0,BDRP.Quote.Count());
      text = UnityEngine.Random.Range(0,BDRP.Phrase.Count());
      Colours = UnityEngine.Random.Range(0,BDRP.Colour.Count());
      Colourname = UnityEngine.Random.Range(0,BDRP.ColorList.Count());
      next = UnityEngine.Random.Range(0,2);
      then = UnityEngine.Random.Range(0,2);
      number = UnityEngine.Random.Range(0,BDRP.Number.Count());
      numbernumber = UnityEngine.Random.Range(0,BDRP.NumberList.Count());
      letter = UnityEngine.Random.Range(0,BDRP.Letter.Count());
      lettername = UnityEngine.Random.Range(0,BDRP.LetterList.Count());
      TextColor = UnityEngine.Random.Range(0,Red.Count());
      TextColor2 = UnityEngine.Random.Range(0,Red.Count());
      TextColor3 = UnityEngine.Random.Range(0,Red.Count());
      TextColor4 = UnityEngine.Random.Range(0,Red.Count());
      TextColor5 = UnityEngine.Random.Range(0,Red.Count());
      TextColor6 = UnityEngine.Random.Range(0,Red.Count());
      TextColor7 = UnityEngine.Random.Range(0,Red.Count());
      TextColor8 = UnityEngine.Random.Range(0,Red.Count());
      TextColor9 = UnityEngine.Random.Range(0,Red.Count());
      TextColor0 = UnityEngine.Random.Range(0,Red.Count());
      StartCoroutine(RandomBullshit());
      StartCoroutine(Numberfucker());
	}
  void ButtonsPress(KMSelectable Button){
    if (moduleSolved == true) {
      return;
    }
      if (Button == Buttons[0]) {
        if (ColoredSwitches == true && lazy == BlananastwooncesaidWhyOnEarthAreTheyCalledBunnies) {
          moduleSolved = true;
          GetComponent<KMBombModule>().HandlePass();
        }
        else if (ColoredSwitches == true && lazy != BlananastwooncesaidWhyOnEarthAreTheyCalledBunnies) {
          ColoredSwitches = false;
          StartCoroutine(Numberfucker());
          GetComponent<KMBombModule>().HandleStrike();
        }
        else {
          ColoredSwitches = true;
          StartCoroutine(Wire());
        }
      }
      else if (Button == Buttons[1]) {
        if (ColoredSwitches == true && lazy != BlananastwooncesaidWhyOnEarthAreTheyCalledBunnies) {
          moduleSolved = true;
          GetComponent<KMBombModule>().HandlePass();
        }
        else {
          ColoredSwitches = false;
          StartCoroutine(Numberfucker());
          GetComponent<KMBombModule>().HandleStrike();
        }
      }
      else if (Button == Buttons[2] || Button == Buttons[3] || Button == Buttons[4]) {
      GetComponent<KMBombModule>().HandleStrike();
      }
  }
  void WireCut(KMSelectable Wireo){
    if (Wireo == WiresButobject[0]) {
      Wires[Array.IndexOf(WiresButobject, Wireo)].SetActive(false);
      Wires[Array.IndexOf(WiresButobject, Wireo) + 2].GetComponent<MeshRenderer>().material = Colors[fuck];
      Wires[Array.IndexOf(WiresButobject, Wireo) + 2].SetActive(true);
    }
    else {
      Wires[Array.IndexOf(WiresButobject, Wireo)].SetActive(false);
      Wires[Array.IndexOf(WiresButobject, Wireo) + 2].GetComponent<MeshRenderer>().material = Colors[fuck2];
      Wires[Array.IndexOf(WiresButobject, Wireo) + 2].SetActive(true);
    }
  }

  IEnumerator Numberfucker(){
    JHKMG = UnityEngine.Random.Range(0,10);
    jhkmg = UnityEngine.Random.Range(0,10);
    BlananastwooncesaidWhyOnEarthAreTheyCalledBunnies = UnityEngine.Random.Range(0,10);
    if (JHKMG + jhkmg > 9) {
      switch (JHKMG + jhkmg) {
        case 10:
        lazy = 0;
        break;
        case 11:
        lazy = 2;
        break;
        case 12:
        lazy = 3;
        break;
        case 13:
        lazy = 4;
        break;
        case 14:
        lazy = 5;
        break;
        case 15:
        lazy = 6;
        break;
        case 16:
        lazy = 7;
        break;
        case 17:
        lazy = 8;
        break;
        case 18:
        lazy = 9;
        break;
      }
    }
    else {
      lazy = JHKMG + jhkmg;
    }
    yield return null;
  }
  IEnumerator Wire(){
    dsefcghvbjnmkjhvgcfxdcvghbnmjkjnhbvgfcdcgvhbn.text = JHKMG.ToString();
    yield return new WaitForSeconds(.5f);
    dsefcghvbjnmkjhvgcfxdcvghbnmjkjnhbvgfcdcgvhbn.text = jhkmg.ToString();
    yield return new WaitForSeconds(.5f);
    dsefcghvbjnmkjhvgcfxdcvghbnmjkjnhbvgfcdcgvhbn.text = BlananastwooncesaidWhyOnEarthAreTheyCalledBunnies.ToString();
    yield return new WaitForSeconds(.5f);
    dsefcghvbjnmkjhvgcfxdcvghbnmjkjnhbvgfcdcgvhbn.text = "";
  }
  IEnumerator RandomBullshit(){
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor], Green[TextColor], Blue[TextColor],255);
    Main.text = BDRP.Quote[quote];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor2], Green[TextColor2], Blue[TextColor2],255);
    Main.text = BDRP.Phrase[text];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor3], Green[TextColor3], Blue[TextColor3],255);
    Main.text = BDRP.Colour[Colours];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor4], Green[TextColor4], Blue[TextColor4],255);
    Main.text = BDRP.ColorList[Colourname];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor5], Green[TextColor5], Blue[TextColor5],255);
    Main.text = BDRP.NextThen[next];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor6], Green[TextColor6], Blue[TextColor6],255);
    Main.text = BDRP.Number[number];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor7], Green[TextColor7], Blue[TextColor7],255);
    Main.text = BDRP.NumberList[numbernumber];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor8], Green[TextColor8], Blue[TextColor8],255);
    Main.text = BDRP.NextThenAgain[then];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor9], Green[TextColor9], Blue[TextColor9],255);
    Main.text = BDRP.Letter[letter];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.color = new Color32(Red[TextColor0], Green[TextColor0], Blue[TextColor0],255);
    Main.text = BDRP.LetterList[lettername];
    yield return new WaitForSeconds(1f);
    while(Wavecheck == true){
      yield return null;
    }
    Main.text = "";
    yield return new WaitForSeconds(1f);
    StartCoroutine(RandomBullshit());
  }
  IEnumerator ButtonBullshit(){
    random1 = UnityEngine.Random.Range(0,Colors.Count() + 1);
    random2 = UnityEngine.Random.Range(0,Colors.Count() + 1);
    random3 = UnityEngine.Random.Range(0,Colors.Count() + 1);
    random4 = UnityEngine.Random.Range(0,Colors.Count());
    random5 = UnityEngine.Random.Range(0,Colors.Count());
    random6 = UnityEngine.Random.Range(0,Colors.Count());
    if (random1 == 12) {
      Buttons[2].GetComponent<MeshRenderer>().material = Colors[UnityEngine.Random.Range(0,Colors.Count())];
    }
    else {
      StartCoroutine(ButtonFlash1());
    }
    if (random2 == 12) {
      Buttons[3].GetComponent<MeshRenderer>().material = Colors[UnityEngine.Random.Range(0,Colors.Count())];
    }
    else {
      StartCoroutine(ButtonFlash2());
    }
    if (random3 == 12) {
      Buttons[4].GetComponent<MeshRenderer>().material = Colors[UnityEngine.Random.Range(0,Colors.Count())];
    }
    else {
      StartCoroutine(ButtonFlash3());
    }
    yield return null;
  }
  IEnumerator ButtonFlash1(){
    Buttons[2].GetComponent<MeshRenderer>().material = Colors[random1];
    yield return new WaitForSeconds(1f);
    Buttons[2].GetComponent<MeshRenderer>().material = Colors[random4];
    yield return new WaitForSeconds(1f);
    StartCoroutine(ButtonFlash1());
  }
  IEnumerator ButtonFlash2(){
    Buttons[3].GetComponent<MeshRenderer>().material = Colors[random2];
    yield return new WaitForSeconds(1f);
    Buttons[3].GetComponent<MeshRenderer>().material = Colors[random5];
    yield return new WaitForSeconds(1f);
    StartCoroutine(ButtonFlash2());
  }
  IEnumerator ButtonFlash3(){
    Buttons[4].GetComponent<MeshRenderer>().material = Colors[random3];
    yield return new WaitForSeconds(1f);
    Buttons[4].GetComponent<MeshRenderer>().material = Colors[random6];
    yield return new WaitForSeconds(1f);
    StartCoroutine(ButtonFlash3());
  }
  void PressLED(){
    Wavecheck = !Wavecheck;
  }
}
