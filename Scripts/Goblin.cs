using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public GameObject[] sheeps;
    public GameObject projectile;
    private float shotTime = 2.0f;
    public AudioClip somTiro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        shotTime -= Time.deltaTime;
        if (shotTime< 0.01 && GameInit.gameIsPlaying == true) {
            Instantiate(projectile, transform.position, Quaternion.identity);
            shotTime = 2.0f;
            GetComponent<AudioSource>().PlayOneShot (somTiro, 0.5f);
        }

        //if (GameInit.gameIsPlaying == false) {
        //    gameObject.transform.Translate(Vector3.up * 10 * Time.fixedDeltaTime);
        //}      
        
    }
}
