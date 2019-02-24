using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    // Init variables
    int minNumber = 1;
    int maxNumber = 1000;
    int guess = 50;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard.");
        StartGame();
    }

    // (Re)Start the game
    void StartGame()
    {
        // (Re)Set variables
        maxNumber = 1000;
        minNumber = 1;
        guess = 50;

        Debug.Log("Pick a number between " + minNumber + " and " + maxNumber);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct.");
        maxNumber = maxNumber + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Minimum now set as previous guess.
            minNumber = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Maximum is now previous guess.
            maxNumber = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            // Return entered?
            Debug.Log("I am a genius ;)");
            StartGame();
        }
    }

    // Next guess
    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
