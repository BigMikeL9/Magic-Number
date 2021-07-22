using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    // Use this for initialization
    void Start()
    {
        StartGame();
    }


    // Update is called once per frame
    void Update()
    {

    }


    public void HigherButton()
    {
        min = guess + 1;
        NextGuess();
    }

    public void LowerButton()
    {
        max = guess - 1;
        NextGuess();
    }


    void StartGame()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString(); // "ToString()" allows us to convert an "int" to a "string", because ".text" only accepts strings to be displayed.
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
