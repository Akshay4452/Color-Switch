using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;

    Rigidbody2D rb;
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
