using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0, 400)]
    [SerializeField] int speed = 250; 


    private Rigidbody2D rb2d;
    private Vector2 motion;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        motion.x = Input.GetAxisRaw("Horizontal");
        motion.y = Input.GetAxisRaw("Vertical");

        rb2d.velocity = motion.normalized * Time.deltaTime * speed;
    }
}
