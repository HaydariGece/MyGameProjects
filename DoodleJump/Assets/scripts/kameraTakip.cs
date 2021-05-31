using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    public Transform hedef;

    private void LateUpdate()
    {
        if (hedef.position.y > transform.position.y)
        {
            Vector3 yeniPozisyon = new Vector3(transform.position.x, hedef.position.y, transform.position.z);
            transform.position = yeniPozisyon;
        }
    }

}
