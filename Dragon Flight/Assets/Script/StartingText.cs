using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartingText : MonoBehaviour
{
    private Text startText;
    private Coroutine blinkCoroutine;

    void Start()
    {
        startText = GetComponent<Text>();

        blinkCoroutine = StartCoroutine(BlinkText(0.5f));

        StartCoroutine(CountdownAndStopBlink(3));
    }

    IEnumerator BlinkText(float interval)
    {
        while (true)
        {
            if (startText != null)
            {
                startText.enabled = !startText.enabled;
            }
            yield return new WaitForSeconds(interval);
        }
    }

    IEnumerator CountdownAndStopBlink(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            if (startText != null)
            {
                startText.text = "CountDown: " + i;
                yield return new WaitForSeconds(1f);
            }
        }

            startText.text = "Go!";
            yield return new WaitForSeconds(1f);
            StopCoroutine(blinkCoroutine);
            startText.enabled = false;
    }
}
