using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    Rigidbody2D _rigidbody;

    Vector3 deltaPosition;

    Vector3 characterScale;

    bool jumping = false;

    float jumpTime;
    
    float maxJumpingTime = 1.25f;

    float horizontalAxis;

    float speedX = 10f;


    void Start()
    {
        animator = GetComponent<Animator>();

        _rigidbody = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        if (gameObject.tag != "Finish")
        {

            CharacterMovement();

            FlipTheCharacter();

            CharacterJump();            
        }

        if (gameObject.tag == "DeadPlayer")
        {
            CharacterIsDead();
        }

    }


    void CharacterMovement()
    {
        horizontalAxis = Input.GetAxis("Horizontal");

        deltaPosition = new Vector3(horizontalAxis,0) * speedX * Time.deltaTime;

        gameObject.transform.Translate(deltaPosition);

        animator.SetFloat("HorizontalAxis", Mathf.Abs(horizontalAxis));            

    }


    void FlipTheCharacter()
    {
        characterScale = transform.localScale;

       if (horizontalAxis < 0)
        {
            characterScale.x = -1;
        }

        if (horizontalAxis > 0)
        {
            characterScale.x = 1;
        }

        transform.localScale =characterScale;
    }


    // Lograr hacer funcionar bien esta animacion
    void CharacterIsDead()
    {
        animator.SetBool("IsDead", true);
    }

    void CharacterJump()
    {
        if (Input.GetButton("Jump") && !jumping)
        {
            jumpTime = 0f;

            _rigidbody.AddForce(transform.up * 300f);

            animator.SetBool("Jump", true);

            jumping = true;

            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.PlayerJump);
        }

        if (jumping)
        {
            jumpTime += Time.deltaTime;

            if (jumpTime > maxJumpingTime)
            {
                jumping = false;

                animator.SetBool("Jump", false);

            }   
        }   
    }
}
