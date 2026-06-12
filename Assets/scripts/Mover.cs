using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }
    void MovePlayer()
    {
        Rigidbody myRigidbody = GetComponent<Rigidbody>();
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float yValue = Input.GetAxis("Jump")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue, yValue, zValue);
        
        
    }

    

}

