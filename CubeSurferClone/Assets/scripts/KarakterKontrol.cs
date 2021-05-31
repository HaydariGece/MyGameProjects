using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed = 10;
   /* [SerializeField]
    private float horizontalSpeed = 10;*/

    public Camera kameramiz;
    public GameObject karakterimiz;
    public toplayici toplayici2;
    private Rigidbody rb;

    private Touch touch;
    public float speedModifier = 0.005f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        #region anroid controlls
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + touch.deltaPosition.x * speedModifier);
            }
        }
        #endregion
        transform.position += new Vector3(-forwardSpeed * Time.deltaTime, 0, 0);
        #region pc controlls
        float zmove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, zmove * forwardSpeed);
        #endregion
        if (transform.position.z <= -4.4f) { transform.position = new Vector3(transform.position.x, transform.position.y, -4.4f); }
        if (transform.position.z >= 4.4f) { transform.position = new Vector3(transform.position.x, transform.position.y, 4.4f); }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel") && gameObject.transform.childCount < 3)
        {
            toplayici2.OyunBitir();
        }
    }
}


