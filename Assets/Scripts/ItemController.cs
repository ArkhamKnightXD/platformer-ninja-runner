using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    GameController gameController;

    void Start()
    {
        gameController = GameObject.Find("GlobalScriptsText").GetComponent<GameController>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

       if ((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("InvulnerablePlayer"))  && gameObject.CompareTag("Coin"))
       {

            Destroy(gameObject);

            gameController.IncrementScore();

            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.FruitGet);   
       }


       if ((other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("InvulnerablePlayer")) && gameObject.CompareTag("Fruit"))
       {

            Destroy(gameObject);

            gameController.IncrementScore();

            gameController.IncrementLives();

            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.FruitGet);   
       }


       if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("InvulnerableFruit"))
       {

            Destroy(gameObject);

            gameController.IncrementScore();

            other.gameObject.tag = "InvulnerablePlayer";

            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Invulnerable);   
       }


       if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("FinalFlag"))
       {

            Destroy(gameObject);

            gameController.IncrementScore();

            gameController.Win();

            other.gameObject.tag = "Finish";

            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.FruitGet);   
       }
        
    }
}
