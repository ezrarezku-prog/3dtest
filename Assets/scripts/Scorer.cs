using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{

    [SerializeField] TMP_Text livesText;
    [SerializeField] TMP_Text GameOverText;

    int hits = 0;
    int lives = 100;

    void Start()
    {
        GameOverText.enabled = false;
    }
    void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
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
            GetComponent<Mover>().enabled = false;
        }
    }



    
}
