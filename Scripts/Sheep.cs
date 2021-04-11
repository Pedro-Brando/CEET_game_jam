using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{

    public static int sheepSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.Translate(Vector3.left * sheepSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D col){
    if (col.gameObject.tag == "Ponto"){
            DataManagement.datamanagement.coinsCollected ++;
            DataManagement.datamanagement.currentScore ++;
            Destroy (this.gameObject);
        }
    }
}
