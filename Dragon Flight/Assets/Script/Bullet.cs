using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
