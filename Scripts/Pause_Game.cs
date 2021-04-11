using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pause_Game : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused;
    public AudioListener audio;
    void Update()
    {
        //Código para pause e unpause do game

        if (Input.GetKeyDown (KeyCode.Escape) && isPaused == false)    {
             Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
             pauseMenu.gameObject.SetActive (true);
             AudioListener.pause = true;
             isPaused = true;
        }
        else if (Input.GetKeyDown (KeyCode.Escape) && isPaused == true){
            Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
            pauseMenu.gameObject.SetActive (false);
            AudioListener.pause = false;
            isPaused = false;
        }
        
    }
}
