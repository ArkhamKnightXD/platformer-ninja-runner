using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeFloorController : MonoBehaviour
{

    Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!CompareTag("Falling"))
        {
            Destroy(gameObject);    
        }

        else
        {
            _rigidbody2D.isKinematic = false;   
        }
        
    }

}
