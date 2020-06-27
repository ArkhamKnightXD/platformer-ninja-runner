using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public GameObject Player;

    public void OnTriggerEnted2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            Player.transform.parent = other.gameObject.transform;
        }
    }
}
