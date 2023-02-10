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

    private void OnTriggerEnter(Collider other) {
        // If the player collides with a collectible
        if (other.gameObject.tag == "Player") {
            // Call the CollectItem function on the player
            other.gameObject.GetComponent<PlayerController>().CollectItem(gameObject.name);
            // Destroy the collectible
            Destroy(gameObject);
        }
    }
}
