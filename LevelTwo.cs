using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelTwo : MonoBehaviour
{
    GameManager gm;
    [SerializeField] TMP_InputField passInput;
    public Slider loadSlider;
    public GameObject levelUp;
    bool increasedSlider = false;
    public AudioClip clip;
    void Start()
    {
        gm = GameManager.gm;
        if (!gm.maxedSliderOne)
        {
            loadSlider.value = .7f;
        }
        else if (gm.maxedSliderOne)
        {
            loadSlider.value = 1;
        }
        levelUp.SetActive(false);
    }

    void Update()
    {
        if (loadSlider.value < .5f && !increasedSlider)
        {
            increasedSlider = true;
            gm.sliderMaster++;
        }
    }

    public void LoadLV3()
    {
        Instantiate(Resources.Load("Canvases/CanvasLV3") as GameObject);
        Destroy(this.gameObject);
    }

    public void LevelUpPressed()
    {
        levelUp.SetActive(true);
    }

}
