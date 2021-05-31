using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kameraTakip : MonoBehaviour
{
    public GameObject target;
    public Vector3 distance;

    private void LateUpdate()
    {
       transform.position = Vector3.Lerp(transform.position, target.transform.position + distance, Time.deltaTime);   
    }
    public void againPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
