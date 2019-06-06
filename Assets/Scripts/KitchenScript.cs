using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenScript : MonoBehaviour
{
    public Actor banana;
    public Actor apple1;
    public Actor apple2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Banana());
        StartCoroutine(Apple1());
        StartCoroutine(Apple2());
    }

    IEnumerator Banana()
    {
        banana.EyesRound(true);
        banana.MouthLine();
        banana.MoveTo(new Vector3(-1.950782f, 2.159547f, -3.974f), 4f);
        banana.TurnTo(new Vector3(0f, 180f, 0f), 0.1f);
        StartCoroutine(banana.IdleBlinkCR(30f));
        yield return new WaitForSeconds(4f);
        banana.TurnTo(new Vector3(0f, 240f, 0f), 0.5f);
        yield return new WaitForSeconds(1f);
        // Starts talking at 5 seconds.
        banana.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(banana.TalkCR(2f));
        yield return new WaitForSeconds(2f);
        // Stops talking at 7.5 seconds.
        banana.MouthIdle();
        yield return new WaitForSeconds(1f);
        StartCoroutine(banana.IdleLookCR(5f));
        yield return new WaitForSeconds(5f);
        // Turns at 13.5 seconds.
        banana.TurnTo(new Vector3(0f, 210f, 0f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        // Starts talking at 14 seconds.
        banana.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(banana.TalkCR(3f));
        yield return new WaitForSeconds(3f);
        // Stops talking at 17.5 seconds.
        banana.MouthIdle();
        yield return new WaitForSeconds(1.5f);
        banana.EyesRound(false);
        yield return new WaitForSeconds(4f);
        banana.EyesRound(true);
        // Surprise at 23 seconds
        banana.MouthOh();
        yield return new WaitForSeconds(2.5f);
        // Shock at 25 seconds
        banana.MouthShock();
        yield return new WaitForSeconds(4f);
        // Shout at 29.5 seconds.
        banana.EyesAngry();
        StartCoroutine(banana.ShoutCR(4f));
        yield return new WaitForSeconds(4f);
        // Stops talking at 32 seconds.
        banana.MouthLine();
    }

    IEnumerator Apple1()
    {
        apple1.EyesRound(true);
        apple1.MouthLine();
        apple1.MoveTo(new Vector3(-1.927f, 1.898f, -4.637f), 4f);
        apple1.TurnTo(new Vector3(0f, 0f, 0f), 0.1f);
        StartCoroutine(apple1.IdleBlinkCR(30f));
        yield return new WaitForSeconds(4f);
        apple1.TurnTo(new Vector3(0f, -90f, 0f), 0.5f);
        yield return new WaitForSeconds(4f);
        // Starts talking at 8 Seconds
        apple1.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple1.TalkCR(2f));
        yield return new WaitForSeconds(2f);
        // Stops talking at 10.5 seconds.
        apple1.MouthIdle();
        yield return new WaitForSeconds(1f);
        apple1.EyesRound(false);
        yield return new WaitForSeconds(0.75f);
        apple1.EyesRound(true);
        yield return new WaitForSeconds(0.75f);
        apple1.EyesRound(false);
        yield return new WaitForSeconds(1f);
        apple1.EyesRound(true);
        yield return new WaitForSeconds(2f);
        // Turns at 16 Seconds
        apple1.TurnTo(new Vector3(0f, -70f, 0f), 0.5f);
        apple1.EyesRound(false);
        yield return new WaitForSeconds(1.5f);
        // Starts talking at 17.5 seconds.
        apple1.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple1.TalkCR(5f));
        yield return new WaitForSeconds(5f);
        // Stops talking at 23 seconds.
        apple1.MouthIdle();
        yield return new WaitForSeconds(1f);
        // Turns at 24 seconds.
        apple1.TurnTo(new Vector3(0f, -110f, 0f), 0.5f);
        apple1.EyesRound(false);
        yield return new WaitForSeconds(4f);
        apple1.EyesRound(true);
        yield return null;
    }

    IEnumerator Apple2()
    {
        apple2.EyesRound(true);
        apple2.MouthLine();
        apple2.MoveTo(new Vector3(-1.927f, 1.898f, -5.3f), 4f);
        apple2.TurnTo(new Vector3(0f, 0f, 0f), 0.1f);
        StartCoroutine(apple2.IdleBlinkCR(30f));
        yield return new WaitForSeconds(4f);
        apple2.TurnTo(new Vector3(0f, 284f, 0f), 0.5f);
        yield return new WaitForSeconds(7f);
        // Starts talking at 11 seconds.
        apple2.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple2.TalkCR(2f));
        yield return new WaitForSeconds(2f);
        // Stops talking at 13.5 seconds.
        apple2.MouthIdle();
        StartCoroutine(apple2.IdleLookCR(7.5f));
        yield return new WaitForSeconds(7.5f);
        // Turns at 21 seconds.
        apple2.TurnTo(new Vector3(0f, 300f, 0f), 0.5f);
        yield return new WaitForSeconds(2.5f);
        // Starts talking at 23.5 seconds.
        apple2.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple2.TalkCR(5f));
        yield return new WaitForSeconds(5f);
        // Stops talking at 29 seconds.
        apple2.MouthIdle();
        yield return new WaitForSeconds(1f);
        apple2.EyesRound(false);

        yield return null;
    }
}
