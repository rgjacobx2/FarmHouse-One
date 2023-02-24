using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonManager : MonoBehaviour
{

    public HealthBarScript healthBarObject; 
    public PlayerManager player; 
    public AudioSource audioSource;

    void Start(){
        audioSource.Play();
    }
    private void OnTriggerEnter(Collider other){

        
        if(gameObject.CompareTag("Player")){
            Destroy(other.gameObject);
            player.TakeDamage(10);            
        }
        if(gameObject.CompareTag("Projectile")){

            ScoreCard.scoreManager.AddScore(10);
            Destroy(gameObject);
            
            // gameObject.SetActive(false);
            // other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }


    }

    
}
