using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Travesseiro : MonoBehaviour
{
    [SerializeField] GameObject item;

    private void OnMouseDown()
    {
        GetComponent<Animator>().Play("OpenTravesseiro");
        GetComponent<AudioSource>().Play();
    }

    public void FinishAnimation()
    {
        item.GetComponent<Item>().ChangeTake(true);
    }
}
