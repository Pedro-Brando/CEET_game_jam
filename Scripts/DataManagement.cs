using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class DataManagement : MonoBehaviour
{
    //Armazenamento de score e high score do jogo
    public static DataManagement datamanagement;
    public int currentScore;
    public int highScore;
    public int coinsCollected;
    void Awake()
    {
        if (datamanagement == null){
            DontDestroyOnLoad (gameObject);
            datamanagement = this;
        }        
        else if (datamanagement != this) {
            Destroy (gameObject);
        }
    }
    
    public void SaveData () {
        BinaryFormatter binForm = new BinaryFormatter();
        FileStream file = File.Create (Application.persistentDataPath + "/gameinfo.dat");
        gameData data = new gameData();
        data.highScore = highScore;
        data.coinsCollected = coinsCollected;
        binForm.Serialize (file, data);
        file.Close ();
    }

    public void LoadData () {
        if (File.Exists (Application.persistentDataPath + "/gameinfo.dat")) {
            BinaryFormatter binForm = new BinaryFormatter();
            FileStream file = File.Open (Application.persistentDataPath + "/gameinfo.dat", FileMode.Open);
            gameData data = (gameData)binForm.Deserialize (file);
            file.Close();
            highScore = data.highScore;
            coinsCollected = data.coinsCollected;
        }
    }
}


[Serializable]
class gameData{
    public int highScore;
    public int coinsCollected;
}