using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{

    [SerializeField] TMP_Text livesText;
    [SerializeField] TMP_Text GameOverText;

    [SerializeField] Button restartButton;
    [SerializeField] AudioClip GameOverSound1;
   


    int hits = 0;
    int lives = 100;

    void Start()
    {
        GameOverText.enabled = false;
        restartButton.gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground" && other.gameObject.tag != "Goal")
        {
            hits++;
            Debug.Log("Hits: " + hits);
            lives -= 10;
            Debug.Log("Lives: " + lives);
            livesText.text = "Lives: " + lives.ToString();
        }

       if (lives == 0)
        {
            GameOverText.enabled = true;
            GetComponent<AudioSource>().PlayOneShot(GameOverSound1);
        
            restartButton.gameObject.SetActive(true);
            GetComponent<Mover>().enabled = false;
        }
    }



    
}
