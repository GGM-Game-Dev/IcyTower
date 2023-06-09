using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] float moveSpeed =3f;
    [SerializeField] float jumpForce = 3f;
    [SerializeField] GameObject fireEffect;
    bool isInAir =false;
    float moveHorizontal = 0;
    bool death = false;
    [SerializeField] GameModeManager gameModeManager;
    [SerializeField] CameraShake cameraShake;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");


    }
    void FixedUpdate()
    {
        if ((moveHorizontal > 0.1f || moveHorizontal < -0.1f ) && !death)
        {
            rb.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
            animator.SetBool("Walking", true);
            if (moveHorizontal > 0.1f)
            {
                transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
            else 
            {
                transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            }
        }
        else
        {
            animator.SetBool("Walking", false);
        }
        if (!isInAir && Input.GetKey(KeyCode.Space) && rb.velocity.y<2f && !death)
        {
            rb.AddForce(new Vector2(0f , jumpForce), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            isInAir = false;
            animator.SetBool("InAir", false);
        }
        
        if (collision.gameObject.tag == "DeadGround") 
        {
            KillPlayer();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isInAir = true ;
            animator.SetBool("InAir", true);
        }
        
    }

    void KillPlayer() 
    {
        death = true;
        animator.SetBool("Death", true);
        Instantiate(fireEffect, transform.position - new Vector3(0,1,0), Quaternion.identity);
        gameModeManager.GameOver();
        StartCoroutine(cameraShake.Shake(0.8f, 0.3f));


    }


}
