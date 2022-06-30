using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class MainManager : MonoBehaviour
{
    private static string currentPlayerName;

    public TextMeshProUGUI currentName;

    

    private void Awake()
    {
        if (PlayerDataHandler.Instance.isNewAccount)
        {
            currentPlayerName = PlayerDataHandler.Instance.playerName;
            currentName.text = "Current Player: " + currentPlayerName;
            SavePlayerName();
        }
        else
        {
            LoadPlayerName();
            currentName.text = "Current Player: " + currentPlayerName;
        }
              
       

    }

   

    public void SavePlayerName()
    {
        SaveData data = new SaveData();
        data.playername = currentPlayerName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerName()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
           
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            currentPlayerName = data.playername;
            
        }
    }



    [System.Serializable]
    class SaveData
    {
       public string playername;
       
    }
}
