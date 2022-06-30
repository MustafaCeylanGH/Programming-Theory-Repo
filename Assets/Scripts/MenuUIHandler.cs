using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI inputPlayerName;

    public void NewStartGame()
    {
        SceneManager.LoadScene(1);

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        PlayerDataHandler.Instance.isNewAccount = false;
    }

    public void SetPlayerName()
    {

        PlayerDataHandler.Instance.playerName = inputPlayerName.text;
        PlayerDataHandler.Instance.isNewAccount = true;
    }
}
