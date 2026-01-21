using UnityEngine;
using System.Collections;

public class CoroutineTest : MonoBehaviour
{


   void Start()
    {
        StartCoroutine(ChangeText());    
    }

    // when using Coroutine, you must remember this
    IEnumerator ChangeText()
    {
        Debug.Log("Ready");

        yield return new WaitForSeconds(1f);

        Debug.Log("Start!");

        yield return new WaitForSeconds(1f);

        Debug.Log("Finish!");
    }
}
