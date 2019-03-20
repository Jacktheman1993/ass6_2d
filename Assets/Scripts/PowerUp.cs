using UnityEngine.SceneManagement;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Power up.... To defiet the enemy, jump over.......");
            GetComponent<AudioSource>().Play();
        }
    }
}
