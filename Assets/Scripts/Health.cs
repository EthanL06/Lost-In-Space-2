using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Image HealthBar;
    private float CurrentHealth = 100f;
    private float MaxHealth = 100f;
    public PlayerController Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Player.Health -= damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Health <= 0)
        {
            Player.Health = 0;
            
        }

        CurrentHealth = Player.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
