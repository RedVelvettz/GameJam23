using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class MovimientoProtagonista : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 8f;
    private bool isFacingRight = true;
    public Color Colorinvi;
    public Color Normal;
    public SpriteRenderer rend;
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    private Animator Animator;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();

    }

    private void Update()
    {
        
        if (isDashing)
        {
            return;
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        transform.gameObject.tag = "Player";

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            Animator.SetBool("Jump",true);
        }
        else
        {
            Animator.SetBool("Jump", false);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            
        }
     

        if (Input.GetKeyDown(KeyCode.E) && canDash)
        {
            transform.gameObject.tag = "Bull";
            StartCoroutine(Dash());
            Animator.SetBool("Bull", true);
            rend = GetComponent<SpriteRenderer>();
            rend.color = Normal;

        }
        else
        {
            Animator.SetBool("Bull", false);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.gameObject.tag = "Invi";
            rend = GetComponent<SpriteRenderer>();
            rend.color = Colorinvi;
            

        }
        else
        {
            rend = GetComponent<SpriteRenderer>();
            rend.color = Normal;

        }




        Flip();

        Animator.SetBool("Run", horizontal != 0.0f);
        
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    /// <summary>
    /// //////////////////////////// HABILIDAD 1 
    /// </summary>
    /// <returns></returns>
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
    /// //////////////////////////// HABILIDAD 2
    
}
