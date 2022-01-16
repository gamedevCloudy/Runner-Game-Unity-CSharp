using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Joystick joyStk;
    [SerializeField] private float sideWayForce = 10f;
    [SerializeField] private float forwardForce = 10f;
    private float horizontalMove = 0f;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    private void Update()
    {
        horizontalMove = joyStk.Horizontal * sideWayForce * Time.deltaTime;
    }

    private void FixedUpdate() 
    {
       
        rb.AddForce(horizontalMove, 0, 0, ForceMode.VelocityChange);
        rb.AddForce(0,0,forwardForce * Time.deltaTime); 
    }
    
   
    
   
}
