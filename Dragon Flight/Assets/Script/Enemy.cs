using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1.3f;
    public GameObject effect;
    public int scoreValue = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, -distanceY, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // create effect
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1);

            SoundManager.instance.SoundDie();

            GameManager.instance.AddScore(scoreValue);

            // destroy both
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }

    }
}
