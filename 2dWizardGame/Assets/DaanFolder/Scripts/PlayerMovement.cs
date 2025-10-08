using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    [SerializeField] public Collider2D PlayerCollider;
    [SerializeField] public Rigidbody2D PlayerRigidbody;




    public float MoveSpeed = 5f;
    public int health = 100;
    public int MeleeDamage = 10;












    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
