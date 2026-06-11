using UnityEngine;

public class Scorer : MonoBehaviour
{

    int hits = 0;
    int lives = 60;
    void OnCollisionEnter(Collision other)
    {
        

        if (other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
        {
            hits++;
            Debug.Log("Hits: " + hits);
            lives -= 10;
            Debug.Log("Lives: " + lives);
        }

       
    }



    
}
