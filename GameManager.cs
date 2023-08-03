using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public GMCanvas gmCanvas;
    
    public AudioSource source;
    [SerializeField] AudioSource sourceMusic;
    [SerializeField] AudioClip[] mouseSounds;

    public GameObject mscBx;
    public int curSceneLoaded;
    public bool maxedSliderOne;
    public int sliderMaster;
    public int mouseMaster;
    private void Awake()
    {
        Init();
        gmCanvas = GetComponentInChildren<GMCanvas>();
    }

    private void Init()
    {
        if (gm == null)
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        gmCanvas.UpdateStars();

        if (Input.GetMouseButtonDown(0))
        {
            UpdateMouseClick();
        }

        if (curSceneLoaded == 2 || curSceneLoaded == 3)
        {
            mscBx.SetActive(false);
        }
    }

    private void UpdateMouseClick()
    {
        switch (mouseMaster)
        {
            case 1:
                source.PlayOneShot(mouseSounds[1]);
                break;
            case 2:
                source.PlayOneShot(mouseSounds[2]);
                break;
            case 3:
                source.PlayOneShot(mouseSounds[3]);
                break;
            default:
                source.PlayOneShot(mouseSounds[0]);
                break;
        }
    }

    public void ResetGame()
    {
        gmCanvas.ResetStars(); //Hides stars
        maxedSliderOne = false; //fixes slider value in Level One
        mouseMaster = 0; //Resets Mouse Sounds
        sliderMaster = 0; //Resets Star Tracker, Wizard Rating, and Ascension Viability
    }
}
