using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataHandler : MonoBehaviour
{
    public static PlayerDataHandler Instance;
    public bool isNewAccount = false;
    public string playerName;
    private void Awake()
    {
        if (Instance!=null)
        {
            Destroy(gameObject);
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
