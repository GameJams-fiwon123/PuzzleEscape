using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{

    [SerializeField] AudioClip effectSound = null;

    public void Start()
    {
        MusicManager.instance.ChangeToHistoriaAudio();
    }

    public void PauseAnimation()
    {
        GetComponent<Animator>().speed = 0;
    }

    public void ContinueAnimation()
    {
        GetComponent<Animator>().speed = 1;
    }

    public void NextDialogue()
    {
        FindObjectOfType<DialogueManager>().NextDialogue();
    }

    public void Finish()
    {
        FindObjectOfType<LevelLoader>().NextScene();
    }

    public void PlaySound()
    {
        GetComponent<AudioSource>().clip = effectSound;
        GetComponent<AudioSource>().Play();
    }
}
