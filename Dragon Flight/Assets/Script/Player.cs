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
}
