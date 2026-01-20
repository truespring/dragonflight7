using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    public static SingletonTest instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void PlayerSound()
    {
        Debug.Log("This is Player Sound");
    }

    public void EnemySound()
    {
        Debug.Log("This is Enemy Sound");
    }
}
