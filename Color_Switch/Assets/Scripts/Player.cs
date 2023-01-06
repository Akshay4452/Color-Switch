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
        
    }
}
