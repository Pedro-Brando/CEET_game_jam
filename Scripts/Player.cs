using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    public float runSpeed = 20.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 

        if (GameInit.gameIsPlaying == false){
            runSpeed = 0.0f;
        }
    }

    private void FixedUpdate()
    {  
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
