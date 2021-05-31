using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toplayici : MonoBehaviour
{
    public GameObject anakup;
    int yukseklik;
    public Text gameOverText;
    public Button tekrarOynaButonu;
    public GameObject OyunBittiKanvas;
    public AudioSource kutuKazanma;

    void Start()
    {
        Time.timeScale = 1;
        OyunBittiKanvas.SetActive(false);
        anakup = GameObject.Find("anaKup");
    }
    private void Update()
    {
        anakup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("toplanabilir") && other.GetComponent<kupToplayici>().getToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<kupToplayici>().toplandiYap();
            other.gameObject.GetComponent<kupToplayici>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anakup.transform;
            kutuKazanma.Play();
        }        
        if (other.gameObject.CompareTag("SýnýrCizgisi"))
        {
            OyunBitir();
        }
    }
    public void OyunBitir()
    {
        Time.timeScale = 0;
        OyunBittiKanvas.SetActive(true);
    }
    public void kupAzalat()
    {
        yukseklik--;
    }
}
