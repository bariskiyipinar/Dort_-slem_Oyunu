using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dortislem : MonoBehaviour
{
    public Text �lkSayi, �kinciSayi, �slem,Cevap, Sonuc;
    int sayi1, sayi2, islemisareti;
    int islemsonucu;
    void Start()
    {
        YeniSoru();
    }
    public void CevapKontrol()
    {
        if (int.Parse(Cevap.text) == islemsonucu)
        {
            Sonuc.text="DOGRU";
        }
        else
        {
            Sonuc.text = "YANLIS";
        }
    }
    public void YeniSoru()
    {
        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islemisareti = Random.Range(1, 5);

        switch (islemisareti)
        {
            case 0:
                �slem.text = "+";
                islemsonucu = sayi1 + sayi2;
                break;
            case 1:
                �slem.text = "-";
                islemsonucu = sayi1 - sayi2;
                break;
            case 2:
                �slem.text = "*";
                islemsonucu = sayi1 * sayi2;
                break;
            case 3:
                �slem.text = "/";
                islemsonucu = (sayi1 / sayi2);
                break;
        }
        �lkSayi.text = sayi1 + "";
        �kinciSayi.text = sayi2 + "";
    }
   
    
    
   void Update()
    {
        
    }
}
