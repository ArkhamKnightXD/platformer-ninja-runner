using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeFloorController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }

}
