using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFour : MonoBehaviour
{
    GameManager gm;
    public Slider arise;
    bool isIncreased;
    [SerializeField] GameObject ariseButton;
    private void Start()
    {
        gm = GameManager.gm;
        ariseButton.SetActive(false);
        isIncreased = false;
        arise.value = .3f;
    }
    private void Update()
    {
        if (arise.value > .9 && !isIncreased)
        {
            isIncreased = true;
            gm.sliderMaster++;
            ariseButton.SetActive(true);
        }
    }

    public void OnAscension()
    {
        SceneManager.LoadScene(3);
        gm.curSceneLoaded = 3;
    }

}
