using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private playerController movement; 
    [SerializeField] private GameObject winScreen; 
    [SerializeField] private GameObject loseScreen; 

    void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag == "Enemy")
        {
           movement.enabled = false; 
           loseScreen.SetActive(true); 
        }
       
    }

    private void OnTriggerEnter(Collider other) 
    {
       if(other.tag == "Finish")
        {
           movement.enabled = false; 
           winScreen.SetActive(true); 
        }
   }
}
