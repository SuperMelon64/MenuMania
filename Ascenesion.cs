using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ascenesion : MonoBehaviour
{
    [SerializeField] Slider finalSlider;
    bool slided = false;
    public void OnClever()
    {
        if (!slided)
        {
            GameManager.gm.sliderMaster++;
            slided = true;
        }
    }
}
