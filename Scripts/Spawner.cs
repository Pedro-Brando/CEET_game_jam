using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sheepPrefab;
    private float sheepSpawnTimer = 2.0f;
    public GameObject goblinPrefab;
    private float goblinSpawnTimer = 4.0f;
    public GameObject goblinDeBaixoPrefab;
    private float goblinDeBaixoSpawnTimer = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sheepSpawnTimer -= Time.deltaTime;
        if (sheepSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnSheep();
        }
        goblinSpawnTimer -= Time.deltaTime;
        if (goblinSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnGoblin();
        }
        goblinDeBaixoSpawnTimer -= Time.deltaTime;
        if (goblinDeBaixoSpawnTimer < 0.01 && GameInit.gameIsPlaying == true) {
            SpawnGoblinDeBaixo();
        }
    }
    void SpawnSheep () {
        Instantiate (sheepPrefab, new Vector2 (10, Random.Range(1.3f, -1.6f)), Quaternion.identity);
        sheepSpawnTimer = Random.Range (1.0f, 3.0f);
    }
    void SpawnGoblin () {
        Instantiate (goblinPrefab, new Vector2 (Random.Range(-8.12f, 8.12f), 6.9f), Quaternion.identity);
        goblinSpawnTimer = Random.Range (4.0f, 6.0f);
    }
    void SpawnGoblinDeBaixo() {
        Instantiate (goblinDeBaixoPrefab, new Vector2 (Random.Range(-8.12f, 8.12f), -5.6f), Quaternion.identity);
        goblinDeBaixoSpawnTimer = Random.Range (4.0f, 6.0f);
    }
}
