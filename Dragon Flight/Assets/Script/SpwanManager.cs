using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public bool enableSpwan = false;
    public GameObject enemy;
    public float spawnDelay = 1f;
    public float spawnInterval = 0.5f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);       
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-2f, 2f);

        if (enableSpwan)
        {
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
        }
    }
}
