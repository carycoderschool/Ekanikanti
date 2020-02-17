using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public int numPickedUp = 0;
    private int pickUpCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        pickUpCount = GameObject.FindGameObjectsWithTag("Pick Up").Length;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = numPickedUp.ToString() + " out of " + pickUpCount.ToString();
        if(numPickedUp == pickUpCount)
        {
            scoreText.text = "You Win!";
        }
    }
}
