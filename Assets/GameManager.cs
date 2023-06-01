using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    [SerializeField]
    private Text winText;

    [SerializeField]
    private Text pointsText;

    const string POINTS= "POINTS: ";
    int score = 0;
    private AudioSource audioSource;
    public void ScoreUp()
    {
        score++;
        if (score >= 10) Win();
        pointsText.text = POINTS + score.ToString();
    }

    public void Win()
    {
        pointsText.enabled = false;
        winText.enabled = true;
        Time.timeScale = 0f; // Pausar el tiempo
    }

   

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape))
        {
            // Cierra la aplicación
            Application.Quit();
        }
    }
}
