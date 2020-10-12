using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1f;
    public float cameraedge;
    public float edgeOffset;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        if (direction != 0)
        {
            transform.localScale = new Vector3(direction, 1, 1);

        }
        Vector3 velocity = rb.velocity;
        velocity.x = direction * speed;
        rb.velocity = velocity;

        if(transform.position.x>=cameraedge)
        {
            transform.position = new Vector2(-cameraedge + edgeOffset, transform.position.y);
        }
        else if (transform.position.x <= -cameraedge)
        {
            transform.position = new Vector2(cameraedge - edgeOffset, transform.position.y);
        }
    }
}
