using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    GameObject _mainMenu;
    [SerializeField]
    GameObject _settingMenu;
    [SerializeField]
    GameObject _audioMenu;
    [SerializeField]
    GameObject _videoMenu;
    [SerializeField]
    GameObject _inputsMenu;
    [SerializeField]
    AudioClip _playSfx;
    [SerializeField]
    AudioSource _audioSourceSfx;
    [SerializeField]
    GameObject _audioBtn;
    [SerializeField]
    GameObject _videoBtn;
    [SerializeField]
    GameObject _inputsBtn;
    [SerializeField]
    GameObject _exitBtn;
    GameObject _masterVolume;
    public Dropdown resolutionDropdown;
    public Dropdown qualityDropdown;
    public Dropdown aaDropdown; //aa mean anti aliasing
    Resolution[] resolutions;
    // Start is called before the first frame update
    void Start()
    {
        _audioSourceSfx = GameObject.Find("Canvas").GetComponent<AudioSource>();
        _mainMenu = GameObject.Find("MainMenu");
        _settingMenu = GameObject.Find("SettingMenu");
        _audioBtn = GameObject.Find("Audio");
        _audioMenu = GameObject.Find("AudioMenu");
        _masterVolume = GameObject.Find("MasterVolumeSlider");
        _videoBtn = GameObject.Find("Video");
        _videoMenu = GameObject.Find("VideoMenu");
        _inputsBtn = GameObject.Find("Inputs");
        _inputsMenu = GameObject.Find("InputsMenu");
        _exitBtn = GameObject.Find("Exit");
        resolutionDropdown = GameObject.Find("ResolutionDropdown").GetComponent<Dropdown>();
        qualityDropdown = GameObject.Find("GraphicsDropdown").GetComponent<Dropdown>();
        aaDropdown = GameObject.Find("AntiAliasingDropdown").GetComponent<Dropdown>();
        {
            if (_mainMenu == null)
            {
                Debug.Log("Mainmenu missing");
            }
            if (_settingMenu == null)
            {
                Debug.Log("settingmenu missing");
                if(_audioBtn == null)
                {
                    Debug.Log("Audiobtn missing");
                }
                if (_audioMenu == null)
                {
                    Debug.Log("Audiomenu missing");
                }
                else 
                {
                    if (_masterVolume == null)
                    {
                        Debug.Log("MasterVolume missing");
                    }
                }
                if (_videoBtn == null)
                {
                    Debug.Log("Videobtn missing");
                }
                if (_videoMenu == null)
                {
                    Debug.Log("Videomenu missing");
                }
                else
                {
                    if (resolutionDropdown == null)
                    {
                        Debug.Log("ResolutionDropdown missing");
                    }
                    if (qualityDropdown == null)
                    {
                        Debug.Log("QualityDropdown missing");
                    }
                    if (aaDropdown == null)
                    {
                        Debug.Log("AntiAliasingDropdown missing");
                    }
                }
                if (_inputsBtn == null)
                {
                    Debug.Log("Inputsbtn missing");
                }
                if (_inputsMenu == null)
                {
                    Debug.Log("Inputsmenu missing");
                }
                if (_exitBtn == null)
                {
                    Debug.Log("Exitbtn missing");
                }
            }
            else
            {
                _settingMenu.SetActive(false);
            }
            if (_audioSourceSfx == null)
            {
                Debug.Log("Aduio Source in Canvas missing");
            }
            else
            {
                _audioSourceSfx.clip = _playSfx;
                _audioSourceSfx.volume = 1.0f;
            }
            GameObject.Find("MainCamera").GetComponent<AudioSource>().volume = 1.0f;
            _masterVolume.GetComponent<Slider>().value = 1.0f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
        
    }
    public void PlayGame()
    {
        _audioSourceSfx.Play();
        Debug.Log("PlayGame");
    }
    public void Credits()
    {
        _audioSourceSfx.Play();
        Debug.Log("Credits");
    }
    public void Settings()
    {
        _audioSourceSfx.Play();
        Debug.Log("Settings");
        _mainMenu.SetActive(false);
        _settingMenu.SetActive(true);
        _audioMenu.SetActive(true);
        _videoMenu.SetActive(false);
        _inputsMenu.SetActive(false);
        _audioBtn.GetComponent<Image>().color = new Color(166.0f, 0.0f, 0.0f);
        _audioBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(1.0f, 1.0f, 1.0f);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void CloseSetting()
    {
        _audioSourceSfx.Play();
        Debug.Log("SettingClose");
        _settingMenu.SetActive(false);
        _mainMenu.SetActive(true);
        _audioBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _audioBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _videoBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _videoBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _inputsBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _inputsBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _exitBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _exitBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
    }
    public void AudioSetting()
    {
        _audioSourceSfx.Play();
        Debug.Log("Audio Settings");
        _audioMenu.SetActive(true);
        _videoMenu.SetActive(false);
        _inputsMenu.SetActive(false);
        _audioBtn.GetComponent<Image>().color = new Color(166.0f, 0.0f, 0.0f);
        _audioBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(1.0f, 1.0f, 1.0f);
        _videoBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _videoBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _inputsBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _inputsBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _exitBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _exitBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
    }
    public void VideoSetting()
    {
        _audioSourceSfx.Play();
        Debug.Log("Video Settings");
        _audioMenu.SetActive(false);
        _videoMenu.SetActive(true);
        _inputsMenu.SetActive(false);
        _audioBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _audioBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _videoBtn.GetComponent<Image>().color = new Color(166.0f, 0.0f, 0.0f);
        _videoBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(1.0f, 1.0f, 1.0f);
        _inputsBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _inputsBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _exitBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _exitBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
    }
    public void InputsSetting()
    {
        _audioSourceSfx.Play();
        Debug.Log("Inputs Settings");
        _audioMenu.SetActive(false);
        _videoMenu.SetActive(false);
        _inputsMenu.SetActive(true);
        _audioBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _audioBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _videoBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _videoBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
        _inputsBtn.GetComponent<Image>().color = new Color(166.0f, 0.0f, 0.0f);
        _inputsBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(1.0f, 1.0f, 1.0f);
        _exitBtn.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 244.0f);
        _exitBtn.GetComponentInChildren<TextMeshProUGUI>().color = new Color(166.0f, 0.0f, 0.0f);
    }
    public void BackgroundToggle()
    {
        GameObject BGmute = GameObject.Find("BackgroundMusicCheck");
        if(BGmute.GetComponent<Toggle>().isOn)
        {
            GameObject.Find("MainCamera").GetComponent<AudioSource>().Play();
        }
        else if (!BGmute.GetComponent<Toggle>().isOn)
        {
            GameObject.Find("MainCamera").GetComponent<AudioSource>().Stop();
        }
        else
        {
            Debug.Log("Background Music Toggle Error");
        }
    }
    public void SfxToggle()
    {
        GameObject Sfxmute = GameObject.Find("SFXCheck");
        if (Sfxmute.GetComponent<Toggle>().isOn)
        {
            _audioSourceSfx.mute = false;
        }
        else if (!Sfxmute.GetComponent<Toggle>().isOn)
        {
           _audioSourceSfx.mute = true;
        }
        else
        {
            Debug.Log("SFX Toggle Error");
        }
    }
    public void MasterVolume()
    {
        GameObject.Find("MainCamera").GetComponent<AudioSource>().volume = _masterVolume.GetComponent<Slider>().value;
        _audioSourceSfx.volume = _masterVolume.GetComponent<Slider>().value;
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,
                  resolution.height, Screen.fullScreen);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}