using UnityEngine;

public class TriggerDrop : MonoBehaviour
{
    [SerializeField] GameObject drop;
        MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = drop.GetComponent<MeshRenderer>();
        myRigidbody = drop.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
    void Update()
    {
        
    }
}
