using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public Text winText;
    public Text loseText;
    public GameObject winObj;
    public GameObject loseObj;
    public Text scoreText;
    private string scoreString;

    public VariablesGlobal data;
    public Button tryAgain;
    public int winCap = 5;
    // Start is called before the first frame update
    void Start()
    {
    winText.text = "Congratulations " + data.playerNameString + " you won!";
    loseText.text = "Sorry " + data.playerNameString + " you lost!";

    if(data.score > winCap)
    {
        winObj.SetActive(true);
    }
    else
    {
        loseObj.SetActive(true);
    }
    scoreString = data.score.ToString();
    scoreText.text = "Your score was:" + scoreString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TryAgain()
    {
    SceneManager.LoadScene("MainScene");
    }
}
