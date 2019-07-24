using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;

        //print(direction);

        //direction.x = Mathf.Clamp(direction.x, -0.3f, 0.3f);
        //direction.y = Mathf.Clamp(direction.y, 0.5f, -0.5f);

        transform.localPosition = direction.normalized/3;
    }
}
