using UnityEngine;

public class Drop : MonoBehaviour
{
    

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    

    //void Update()
   // {
       // if (Time.time > timeToWait)
       // {
           // myRigidbody.useGravity = true;
          //  myMeshRenderer.enabled = true;
      //  }
        
        
   // }
}
