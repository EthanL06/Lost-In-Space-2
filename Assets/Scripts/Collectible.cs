using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            // Get the player controller
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            // Call the collect item function
            player.CollectItem(gameObject.name);
            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
