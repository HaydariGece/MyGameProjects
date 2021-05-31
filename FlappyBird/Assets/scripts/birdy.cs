using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 2f;
    public Rigidbody2D rb2D;
    public scoreTable Skortablosu;
    public GameObject OlumPaneli;
    public AudioSource carpmaSesi;
    public AudioSource ucmaSes; 
    public AudioSource puanSesi; 

    void Update()
    {
        if (Input.GetMouseButton(0))
        {            
            rb2D.velocity = Vector2.up * velocity;
            ucmaSes.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "skorCollider")
        {
            puanSesi.Play();
            Skortablosu.Score();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("deathArea"))
        {
            carpmaSesi.Play();
            Time.timeScale = 0;
            OlumPaneli.SetActive(true);
        }
    }
}
