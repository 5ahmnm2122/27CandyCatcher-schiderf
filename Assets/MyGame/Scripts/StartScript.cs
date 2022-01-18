using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartScript : MonoBehaviour
{
    public Text nameText;
    public string nameString;
    public VariablesGlobal data;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextButtonPress()
    {

    data.playerNameString = nameText.text;
    SceneManager.LoadScene("MainScene");



    }
}
