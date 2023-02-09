using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Add slider between 0 and 100
    [Range(0, 100)]
    public float Health = 100f;

    [Range(0, 100)]
    public float JetpackFuel = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
