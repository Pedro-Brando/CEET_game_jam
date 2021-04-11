using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiro : MonoBehaviour
{

    public float speed;
    private Transform sheep;
    private Vector2 alvo;
    public bool isReflected = false;
    public AudioClip somHit;

    // Start is called before the first frame update
    void Start()
    {
        sheep = GameObject.FindGameObjectWithTag("Sheep").transform;
        alvo = new Vector2(sheep.position.x - Random.Range (-7, 6), sheep.position.y -20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, alvo, speed * Time.deltaTime);
        if (transform.position.x == alvo.x && transform.position.y == alvo.y){
            Destroy (this.gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D col){
    if (col.gameObject.tag == "Shield"){
        alvo = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isReflected = true;
        }
    if (col.gameObject.tag == "Sheep"){
            AudioSource.PlayClipAtPoint(somHit, new Vector2(0, 0));
            DataManagement.datamanagement.coinsCollected --;
            DataManagement.datamanagement.currentScore --;
            Score.sheepLives --;
            Destroy (col.gameObject);
            Destroy (this.gameObject);
        }
    if ((col.gameObject.tag == "Enemy") && isReflected == true){
            DataManagement.datamanagement.coinsCollected ++;
            DataManagement.datamanagement.currentScore ++;
            AudioSource.PlayClipAtPoint(somHit, new Vector2(0, 0));
            Destroy (col.gameObject);
            Destroy (this.gameObject);
            
        }
    if ((col.gameObject.tag == "Player") && isReflected == false){
        Score.sheepLives = 0;
        AudioSource.PlayClipAtPoint(somHit, new Vector2(0, 0));
        Destroy (col.gameObject);
        Destroy (this.gameObject);
        GameInit.gameIsPlaying = false;
        //DataManagement.datamanagement.SaveData();
    }
    }
}
