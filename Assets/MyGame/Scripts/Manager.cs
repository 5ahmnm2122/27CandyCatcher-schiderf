using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public VariablesGlobal data;
    private string scoreString;
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
    data.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
    scoreString = data.score.ToString();
    scoreText.text = "Score: " + scoreString;

    }
}
