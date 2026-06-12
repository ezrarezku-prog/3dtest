using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Win : MonoBehaviour
{
    [SerializeField] TMP_Text YouWinText;

     void Start()
    {
        YouWinText.enabled = false;
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            YouWinText.enabled = true;
        }
    }

   
}
