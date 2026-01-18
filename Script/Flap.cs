using UnityEngine;

public class Flap : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    public float Forcestrength = 20f;

    public float rotationspeed = 10f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        HandleFlap();

        HandleAnimation();
    }

    void HandleFlap()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * (-rb.linearVelocity.y +Forcestrength), ForceMode2D.Impulse);
        }
    }

    void HandleAnimation()
    {
        anim.SetFloat("Flight",rb.linearVelocity.y);
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,rb.linearVelocity.y * rotationspeed);
    }
}
