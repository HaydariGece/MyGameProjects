using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipePool : MonoBehaviour
{
    public birdy birdScript;
    public GameObject borular;
    public float uzunluk;
    public float zaman;

    void Start()
    {
        StartCoroutine(boruSpawn(zaman));
    }

    public IEnumerator boruSpawn(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(borular, new Vector3(2, Random.Range(-uzunluk, uzunluk), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
