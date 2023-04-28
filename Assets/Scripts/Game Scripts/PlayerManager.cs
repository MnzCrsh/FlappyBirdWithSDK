using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            gameManager.PlayerScore++;
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            gameManager.PlayerHP--;
        }

        if (gameManager.PlayerHP <= 0)
        {
            Destroy(this.gameObject);
            gameManager.playerIsDead = true;
            Time.timeScale = 0f;
        }
    }
}
