using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{
    public Slider slider;
    public GameObject levelPanel;
    bool increasedSlider = false;
    public AudioClip clip;
    void Start()
    {
        slider.value = 1;
    }

    void Update()
    {
        if (slider.value < 1 && !increasedSlider)
        {
            increasedSlider = true;
            GameManager.gm.sliderMaster++;
            //GameManager.gm.gmCanvas.source.PlayOneShot(clip);
        }
    }

    public void LoadLV3()
    {
        Instantiate(Resources.Load("Canvases/CanvasLV3") as GameObject);
        Destroy(this.gameObject);
    }

    public void LevelUpOne()
    {
        LockLevels();
        GameManager.gm.mouseMaster = 1;

    }

    public void LevelUpTwo()
    {
        LockLevels();
        GameManager.gm.mouseMaster = 2;
    }

    public void LevelUpThree()
    {
        LockLevels();
        GameManager.gm.mouseMaster = 3;
    }

    public void LockLevels()
    {
        levelPanel.SetActive(false);
    }
}
