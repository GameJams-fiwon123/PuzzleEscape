using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [Range(0, 3)]
    [SerializeField] int frame = 0;

    [SerializeField] bool teleportPlayer = false;
    [SerializeField] float posX = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<FrameManager>().MoveCamToFrame(frame);

        if (teleportPlayer)
        {
            Player player = FindObjectOfType<Player>();

            Vector3 newPos = player.transform.position ;
            newPos.x = posX;

            player.transform.position = newPos;
        }
    }
}
