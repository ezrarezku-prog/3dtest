using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{

    [SerializeField] TMP_Text livesText;

    int hits = 0;
    int lives = 100;
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

       
    }



    
}
