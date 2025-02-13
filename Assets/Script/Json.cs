using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Json : MonoBehaviour
{
    private string filepath;
    private GameSaveData saveData;
    private void Awake()
    {
        filepath = Path.Combine(Application.dataPath, "data.json");
        LoadData();
    }
    private void Update()
    {
        saveData.Score = GameObject.Find("Canvas").GetComponent<Score>().score;
        SaveData();
    }
    private void LoadData()
    {
        if (File.Exists(filepath))
        {
            string json = File.ReadAllText(filepath);
            saveData = JsonUtility.FromJson<GameSaveData>(json);
        }
        else
        {
            saveData = new GameSaveData();
        }
    }
    private void SaveData()
    {
        string json = JsonUtility.ToJson(saveData, true);
        File.WriteAllText(filepath, json);
    }

    [System.Serializable]
    public class GameSaveData
    {
        public int Score = 0;

    }
}

