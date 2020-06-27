using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementController : MonoBehaviour
{
    
    // Position del objeto 1
    public Transform FirstPosition;

    // Position del objeto 2
    public Transform FinalPosition;

    // Position en la que iniciara la plataforma
    public Transform PlatformStartPosition;

    public float Speed;

    private Vector3 nextPosition;

    void Start()
    {
        //Aqui asigno le asigno el vector de la posicion de mi plataforma
        nextPosition = PlatformStartPosition.position;
    }


    void Update()
    {
        PlatformMovement();   
    }


    private void PlatformMovement()
    {
        //Si el objecto tiene la misma posicion que el limite inicial, entonces al vector que dictara 
        //la sigte position se le asignara la position del limite final y se hara el mismo proceso cuando se llegue al otro extremo
        if (gameObject.transform.position == FirstPosition.position)
        {
            nextPosition = FinalPosition.position;
        }
       
        if (gameObject.transform.position == FinalPosition.position)
        {
            nextPosition = FirstPosition.position;
        }

        // Le damos una posicion inicial, una posicion final y una distancia y esto hara que nuestro objeto se mueva hacia la posicion final
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,nextPosition,Speed*Time.deltaTime);
    
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(FirstPosition.position,FinalPosition.position);
    }

}
