using IronPython;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
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

        try
        {
            // Create the Python engine
            ScriptEngine engine = Python.CreateEngine();

            // Create a simple Python script
            string code = @"
print('Hello from IronPython!')
x = 2 + 2
x
";

            // Run it and get the result
            ScriptScope scope = engine.CreateScope();
            object result = engine.Execute(code, scope);

            Debug.Log(" IronPython ran successfully. Result: " + result);
        }
        catch (System.Exception ex)
        {
            Debug.LogError("X IronPython test failed: " + ex.Message);
        }


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
