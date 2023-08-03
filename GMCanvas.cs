using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMCanvas : MonoBehaviour
{
    [SerializeField] GameObject[] stars;
    public AudioSource source;

    public void ResetStars()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            stars[i].SetActive(false);
        }
    }

    public void UpdateStars()
    {
        switch (GameManager.gm.sliderMaster)
        {
            case 1:
                stars[0].SetActive(true);
                break;
            case 2:
                stars[1].SetActive(true);
                break;
            case 3:
                stars[2].SetActive(true);
                break;
            case 4:
                stars[3].SetActive(true);
                break;
            case 5:
                stars[4].SetActive(true);
                break;
            case 6:
                stars[5].SetActive(true);
                break;

            default:
                stars[stars.Length - 1].SetActive(false);
                break;
        }
    }
}
