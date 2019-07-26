using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0, 400)]
    [SerializeField] int speed = 250;

    Vector3 rightScale = new Vector3(1.4f, 1.4f);
    Vector3 leftScale = new Vector3(-1.4f, 1.4f);


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

        Vector3 directionX = transform.localScale;

        if (motion.x > 0)
        {
            transform.localScale = rightScale;
        }
        else if (motion.x < 0)
        {
            transform.localScale = leftScale;
        }

            rb2d.velocity = motion.normalized * Time.deltaTime * speed;
    }
}
