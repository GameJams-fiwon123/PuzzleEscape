using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [Range(0,1)]
    [SerializeField] float waitTime = 0.05f;

    [SerializeField] TextMeshProUGUI dialogueText;

    [SerializeField] List<string> dialogues = new List<string>();
    int index = -1;

    IEnumerator StartDialogue()
    {
        char[] dialogue = dialogues[index].ToCharArray();

        for (int i = 0; i < dialogue.Length; i++) {
            yield return new WaitForSeconds(waitTime);
            dialogueText.text += dialogue[i];
        }

        FindObjectOfType<CutSceneManager>().ContinueAnimation();
    }

    public void NextDialogue()
    {
        index++;
        if (index < dialogues.Count)
        {
            dialogueText.text = "";
            StartCoroutine(StartDialogue());
        }
    }
}
