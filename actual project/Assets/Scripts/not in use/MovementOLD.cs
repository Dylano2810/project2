using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    public GameObject platform;
    public Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (moveInput > 0)
        {
            gameObject.transform.localScale = new Vector3(2, 2, 2);
        }

        if (moveInput < 0)
        {
            gameObject.transform.localScale = new Vector3(-2, 2, 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        animator.SetFloat("Speed", Mathf.Abs(moveInput)); 

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            JumpAudio.Play();
            isJumping = true;
            animator.SetBool("IsJumping", true);
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            animator.SetTrigger("TakeOf");
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                JumpAudio.Stop();
                isJumping = false;
                animator.SetBool("IsJumping", false);
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

    }

    public AudioSource JumpAudio;
    public AudioSource Run;

    void Audio()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAudio.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            JumpAudio.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpAudio.Play();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            JumpAudio.Stop();
        }
         
    
         if (Input.GetKeyDown(KeyCode.D))
        {
            Run.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Run.Stop();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Run.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Run.Stop();
        }

    }

    // Update is called once per frame
    void StopSound()
    {

    }

}

  
