using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kupToplayici : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public toplayici toplayici;
    KarakterKontrol karakter;
    public AudioSource KutuDusurme;

    void Start()
    {
        toplandiMi = false;
        karakter = GameObject.Find("anaKup").GetComponent<KarakterKontrol>();
    }
    private void Update()
    {
        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        if (transform.position.y <= 1)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            toplayici.kupAzalat();
            transform.parent = null;
            transform.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(this.gameObject, 2f);
            KutuDusurme.Play();

        }

    }
    public bool getToplandiMi()
    {
        return toplandiMi;
    }
    public void toplandiYap()
    {
        toplandiMi = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}
