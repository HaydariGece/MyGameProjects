using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontroller : MonoBehaviour
{
    public Rigidbody2D Rb2d;
    public float hareketHizi = 5f;
    private float xEksenHareketi;

    private void Awake()
    {
        Rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xEksenHareketi = Input.GetAxis("Horizontal") * hareketHizi;
    }
    private void FixedUpdate()
    {
        Vector2 velocity = Rb2d.velocity;
        velocity.x = xEksenHareketi;
        Rb2d.velocity = velocity; 
    }
}
