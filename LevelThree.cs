using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelThree : MonoBehaviour
{
    GameManager gm;
    [SerializeField] TextMeshProUGUI tRating;

    public Slider slider4;
    public TMP_Dropdown menuDrp;
    public GameObject menuButton;
    public GameObject wizardsDomain;
    public AudioClip clip;

    bool increasedSlider;
    private void Start()
    {
        gm = GameManager.gm;
        increasedSlider = false;
        menuButton.SetActive(false);
        wizardsDomain.SetActive(false);
    }

    private void Update()
    {
        UpdateWizRating();
        if (menuDrp.value == 2)
        {
            menuButton.SetActive(true);
        }
        else if (menuDrp.value == 1 && gm.sliderMaster == 4)
        {
            wizardsDomain.SetActive(true);
        }
        if (slider4.value < .5f && !increasedSlider)
        {
            increasedSlider = true;
            gm.sliderMaster++;
        }
    }

    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene(2);
        GameManager.gm.curSceneLoaded = 2;
    }

    public void IAmBecomeWizlord()
    {
        Instantiate(Resources.Load("Canvases/CanvasLV4") as GameObject);
        Destroy(this.gameObject);
    }

    private void UpdateWizRating()
    {
        switch (GameManager.gm.sliderMaster)
        {
            case 0:
                tRating.text = "Wizard Rating: Not worth my time.";
                break;
            case 1:
                tRating.text = "Wizard Rating: Shows Curiosity.";
                break;
            case 2:
                tRating.text = "Wizard Rating: Inquisitive, but weak.";
                break;
            case 3:
                tRating.text = "Wizard Rating: Nearing Perfection."; 
                break;
            case 4:
                tRating.text = "Wizard Rating: Proceed to the Mainu Menia.";
                break;
            default:
                break;
        }
    }
}
