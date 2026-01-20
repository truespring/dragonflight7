using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        transform.Translate(distanceX, 0, 0);
    }

    // if not both triggers
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if (collision.gameObject.tag == "Enemy")
        // {
        //     Destroy(collision.gameObject);
        //     Destroy(gameObject);
        // }
    }

    // if one of the triggers
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
