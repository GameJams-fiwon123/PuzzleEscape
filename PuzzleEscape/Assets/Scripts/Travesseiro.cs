using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travesseiro : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Animator>().Play("OpenTravesseiro");
        GetComponent<AudioSource>().Play();
    }
}
