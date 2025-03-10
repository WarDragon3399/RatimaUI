using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField]
    AudioClip _playSfx;
    [SerializeField]
    AudioSource _audioSource;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GameObject.Find("Canvas").GetComponent<AudioSource>();
        {
            if (_audioSource == null)
            {
                Debug.Log("Aduio Source in Canvas missing");
            }
            else
            {
                _audioSource.clip = _playSfx;
            }
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

    public void Play()
    {
        _audioSource.Play();
        Debug.Log("Play");
    }

    public void Credits()
    {
        _audioSource.Play();
        Debug.Log("Credits");
    }

    public void Settings()
    {
        _audioSource.Play();
        Debug.Log("Settings");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
