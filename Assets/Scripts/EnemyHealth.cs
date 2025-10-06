using UnityEngine;
using UnityEngine.UI; //Make sure this is here for ui

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

     void Die()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(20);
            GameManager.Instance.LoadNextScene();
        }
    }


}
