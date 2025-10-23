using System;
using UnityEditor;
using UnityEngine;

public class ButtonLevel : MonoBehaviour
{
    [SerializeField] public int ScoreAmount;
    [SerializeField] public string SelectionValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void UpdateScore()
    {
        GameManager gameManager = FindFirstObjectByType<GameManager>();
        if (gameManager != null)
        {
            // Assuming GameManager has a public method to update the score
            gameManager.GuessScore += ScoreAmount;
            Debug.Log(ScoreAmount + " points added to GuessScore.");
            Debug.Log(SelectionValue + " was selected.");
        }
    }


    public void PlayAgain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}