using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class EnemyEntity : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    private int _currrentHealth;

    private PolygonCollider2D _polygonCollider2D;

    private void Awake()
    {
        _polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    private void Start()
    {
        _currrentHealth = _maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Attack");
    }

    public void TakeImage(int damage)
    {
        _currrentHealth -= damage;

        DetectDeath();
    }

    public void PolygonColliderTurnOff()
    {
        _polygonCollider2D.enabled = false;
    }

    public void PolygonColliderTurnOn()
    {
        _polygonCollider2D.enabled = true;
    }

    private void DetectDeath()
    {
        if (_currrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
