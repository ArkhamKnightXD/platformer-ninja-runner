using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float lastHorizontalAxis;

    float lastVerticalAxis;

    Animator animator;

    float speedX = 10f;

    Vector3 deltaPosition;

    Vector3 characterScale;
    
    GameController gameController;

    bool jumping = false;

    float jumpTime;
    
    float maxJumpingTime = 1f;

    bool canJump;

    float horizontalAxis;

    Rigidbody2D _rigidbody;


    void Start()
    {
        animator = GetComponent<Animator>();

        _rigidbody = GetComponent<Rigidbody2D>();

        gameController = GameObject.Find("GlobalScriptsText").GetComponent<GameController>();
    }

    
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");


        if (gameObject.tag != "Finish")
        {

            CharacterMovement();

            FlipTheCharacter();

            CharacterJump();            
        }

    }


    void CharacterMovement()
    {
        deltaPosition = new Vector3(horizontalAxis,0) * speedX * Time.deltaTime;

        gameObject.transform.Translate(deltaPosition);

        // Aqui obtenemos la ultima posicion del horizontal axis y se la mandamos a animator
        if (lastHorizontalAxis != horizontalAxis)
        {
            lastHorizontalAxis = horizontalAxis;

            animator.SetFloat("HorizontalAxis", lastHorizontalAxis);            
        }

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
