using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonManager : MonoBehaviour
{

    public HealthBarScript healthBarObject; 
    public PlayerManager player;   

    private void OnTriggerEnter(Collider other){

        
        if(gameObject.CompareTag("Player")){

            Destroy(other.gameObject);
            player.TakeDamage(10);
            
        }
        if(gameObject.CompareTag("Projectile")){

            ScoreCard.scoreManager.AddScore(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }


    }

    
}
