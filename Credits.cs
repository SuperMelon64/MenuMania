using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    GameManager gm;
    private void Start()
    {
        gm = GameManager.gm;
    }

    public void OnExitPressed()
    {
        gm.ResetGame();
        gm.mscBx.SetActive(true);
        gm.curSceneLoaded = 1;
        SceneManager.LoadScene(1);
    }
}
