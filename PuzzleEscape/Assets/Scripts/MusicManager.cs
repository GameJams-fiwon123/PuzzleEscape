using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioClip tileAudio = null;
    [SerializeField] AudioClip level1Audio = null;
    [SerializeField] AudioClip level2Audio = null;

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

    public void ChangeToLevelAudio(int level)
    {
        switch (level)
        {
            case 1:
                GetComponent<AudioSource>().clip = level1Audio;
                break;
            case 2:
                GetComponent<AudioSource>().clip = level2Audio;
                break;
        }
        
        GetComponent<AudioSource>().Play();
    }
}
