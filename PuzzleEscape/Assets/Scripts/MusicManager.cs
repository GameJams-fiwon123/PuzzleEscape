using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioClip tileAudio = null;
    [SerializeField] AudioClip level0Audio = null;
    [SerializeField] AudioClip level1Audio = null;

    // Start is called before the first frame update
    void Start()
    {
        if (FindObjectsOfType<MusicManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void StopMusic()
    {
        GetComponent<AudioSource>().Stop();
    }

    public void ChangeToTitleAudio()
    {
        GetComponent<AudioSource>().clip = tileAudio;
        GetComponent<AudioSource>().Play();
    }

    public void ChangeToLevel0Audio()
    {
        GetComponent<AudioSource>().clip = level0Audio;
        GetComponent<AudioSource>().Play();
    }

    public void ChangeToLevel1Audio()
    {
        GetComponent<AudioSource>().clip = level1Audio;
        GetComponent<AudioSource>().Play();
    }
}
