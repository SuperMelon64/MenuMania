using UnityEngine;
using UnityEngine.UI;

public class LevelOne : MonoBehaviour
{
    GameManager gm;
    public Slider loadSlider;
    bool increasedSlider;
    public AudioClip clip;
    void Start()
    {
        gm = GameManager.gm;
        increasedSlider = false;
        loadSlider.value = .7f;
    }

    void Update()
    {
        if (loadSlider.value >= .98 && !increasedSlider)
        {
            increasedSlider = true;
            gm.sliderMaster++;
            gm.maxedSliderOne = true;
            LoadLV2();
        }
    }

    public void LoadLV2()
    {
        Instantiate(Resources.Load("Canvases/CanvasLV2") as GameObject);
        Destroy(this.gameObject);
    }

}
