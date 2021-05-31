using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermiKutusu : MonoBehaviour
{
    string[] silah = { "Magnum", "Pompali", "sniper", "Keles" };
    int[] mermiSayisi = { 20, 10, 30, 50, 100 };
    public string Olusan_silahin_Turu;
    public int Olusan_mermi_sayisi;

    void Start()
    {
        Olusan_silahin_Turu = silah[Random.Range(0, silah.Length - 1)];
        Olusan_mermi_sayisi = mermiSayisi[Random.Range(0, mermiSayisi.Length - 1)];
       
    }


}
