using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        // function name, delay time, repeat time
        InvokeRepeating("Shoot", 0.5f, 0.3f);
    }

    void Shoot()
    {
        SoundManager.instance.SoundBullet();
        // 많이 사용되는 Instantiate 함수
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
