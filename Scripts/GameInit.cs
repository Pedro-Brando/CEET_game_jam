using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInit : MonoBehaviour
{
    //Inicialização do jogo
    public static bool gameIsPlaying;
    void Start()
    {
        Score.sheepLives = 5;
        gameIsPlaying = true;
        DataManagement.datamanagement.LoadData();
    }
}
