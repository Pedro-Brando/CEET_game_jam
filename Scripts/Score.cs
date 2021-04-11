using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{    
    //Código para display do score, se o score atual for maior que o high score, o score atualiza
    public GameObject scoreUI;
    public GameObject highScoreUI;
    public GameObject vidaUI;
    public GameObject RestartUI;
    
    public static int sheepLives = 5;

    void Start(){
        sheepLives = 5;
        GameInit.gameIsPlaying = true;
    }
    
    void Update()
    {

        if (DataManagement.datamanagement.currentScore > DataManagement.datamanagement.highScore){
            DataManagement.datamanagement.highScore = DataManagement.datamanagement.currentScore;
        }
        scoreUI.GetComponent<Text>().text = ("" + DataManagement.datamanagement.currentScore.ToString());        
        highScoreUI.GetComponent<Text>().text = ("High Score: " + DataManagement.datamanagement.highScore.ToString());
        vidaUI.GetComponent<Text>().text = ("" + Score.sheepLives.ToString());

        if (sheepLives <= 0){
            DataManagement.datamanagement.currentScore = 0;
            GameInit.gameIsPlaying = false;
            DataManagement.datamanagement.SaveData();
            RestartUI.gameObject.SetActive(true);
        }

    }
}
