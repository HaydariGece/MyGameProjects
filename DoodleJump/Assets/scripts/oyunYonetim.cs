using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunYonetim : MonoBehaviour
{
    public GameObject PrefabPlatform;
    public int platformSayisi = 300;

    void Start()
    {
        Vector3 OlusturmaPozisyonu = new Vector3();

        for (int i = 0; i < platformSayisi; i++)
        {
            OlusturmaPozisyonu.y += Random.Range(.5f, 2f);
            OlusturmaPozisyonu.x = Random.Range(-5f, 5f);
            Instantiate(PrefabPlatform, OlusturmaPozisyonu, Quaternion.identity);
        }

    }
}
