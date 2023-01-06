using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;
    public string CurrentCol;
    public SpriteRenderer spriteRenderer;
    public Color colorCyan;
    public Color colorYellow;
    public Color colorMagenta;
    public Color colorPink;

    Rigidbody2D rb;
    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        SetRandomColor();
    }

    void SetRandomColor()
    {
        int index = Random.Range(0,3);
        switch (index)
        {
            case 0:
                CurrentCol = "Cyan";
                spriteRenderer.color = colorCyan;
                break;
            case 1:
                CurrentCol = "Yellow";
                spriteRenderer.color = colorYellow;
                break;
            case 2:
                CurrentCol = "Magenta";
                spriteRenderer.color = colorMagenta;
                break;
            case 3:
                CurrentCol = "Pink";
                spriteRenderer.color = colorPink;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        
    }
}
