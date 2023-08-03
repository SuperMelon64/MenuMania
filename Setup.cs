using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setup : MonoBehaviour
{
    [SerializeField] Slider mscSlider;
    [SerializeField] Slider sfxSlider;
    [SerializeField] AudioMixer mixerMSC;
    [SerializeField] AudioMixer mixerSFX;

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
            SetSoundVolume();
        }
    }

    public void SetMusicVolume()
    {
        float volume = mscSlider.value;
        mixerMSC.SetFloat("MusicVolume", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetSoundVolume()
    {
        float volume = sfxSlider.value;
        mixerSFX.SetFloat("SoundVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("soundVolume", volume);
    }

    private void LoadVolume()
    {
        mscSlider.value = PlayerPrefs.GetFloat("musicVolume");
        sfxSlider.value = PlayerPrefs.GetFloat("soundVolume");
        SetMusicVolume();
        SetSoundVolume();
    }

    public void OnBegin()
    {
        SceneManager.LoadScene(1);
    }
}
