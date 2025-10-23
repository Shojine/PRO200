using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   
    [SerializeField] public int GuessScore;
    [SerializeField] public TMP_Text DiolougeText;
    [SerializeField] private bool hasGuess;
    [SerializeField] private string GuessedCharacter = "Omg It Work";
    [SerializeField] public GameObject EndGamePanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EndGamePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GuessScore >= 20)
        {
            hasGuess = true;
        }

        if(hasGuess)
        {
            DiolougeText.text = "I have a guess who your character is ! Is it " + GuessedCharacter + "?";
            StartCoroutine(EndGame());
        }
    }

    private IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3);
        EndGamePanel.SetActive(true);
    }

    
}
