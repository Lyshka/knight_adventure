using UnityEngine;

public class EnemyEntity : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _currrentHealth;

    public void Start()
    {
        _currrentHealth = _maxHealth;
    }

    public void TakeImage(int damage)
    {
        _currrentHealth -= damage;

        DetectDeath();
    }

    public void DetectDeath()
    {
        if (_currrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
