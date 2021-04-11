using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //Código para os botões de trocar cena e abrir tutorial

    public void LoadToScene (string sceneToLoad) {
        Initiate.Fade(sceneToLoad, Color.white, 1.0f);
    }

    public void RestartGame (string sceneToLoad) {
        Initiate.Fade(sceneToLoad, Color.white, 1.0f);
        
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void OpenTutorial(GameObject tutorialMenu){
        tutorialMenu.gameObject.SetActive (true);
    }
    public void CloseTutorial(GameObject tutorialMenu){
        tutorialMenu.gameObject.SetActive (false);
    }
 
 
}
