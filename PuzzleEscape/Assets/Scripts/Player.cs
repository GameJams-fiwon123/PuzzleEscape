using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float velocity = 5f;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 motion = Vector2.zero;

        motion.x = Input.GetAxis("Horizontal");
        motion.y = Input.GetAxis("Vertical") ;

        Vector2 motionResult = motion.normalized * velocity * Time.deltaTime;

        Vector2 newPosition = new Vector2(transform.position.x + motionResult.x, transform.position.y + motionResult.y);

        //Vector2 motionForward = transform.forward * axisY;
        //Vector2 motionRight = transform.right * axisX;

        //transform.position.x += axisX;

        rb2d.MovePosition(newPosition);
    }
}
