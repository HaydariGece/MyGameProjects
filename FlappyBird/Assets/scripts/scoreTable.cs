using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreTable : MonoBehaviour
{
    public int skor;
    public Text Skortext;
    public AudioSource startSesi;

    void Start()
    {
        Time.timeScale = 1;
        skor = 0;
        Skortext.text = skor.ToString();
    }
    public void Score()
    {
        skor++;
        Skortext.text = skor.ToString();
    }
    public void restartGame()
    {
        startSesi.Play();
        SceneManager.LoadScene(0);
    }
}
