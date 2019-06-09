using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenScript : MonoBehaviour
{
    public float talkScale = 1f;

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
        banana.transform.position = new Vector3(-1.950782f, 2.159547f, -2.482f);
        banana.EyesRound(true);
        banana.MouthLine();
        banana.MoveTo(new Vector3(-1.950782f, 2.159547f, -3.974f), 4f);
        banana.TurnTo(new Vector3(0f, 180f, 0f), 0.1f);
        StartCoroutine(banana.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        banana.TurnTo(new Vector3(0f, 240f, 0f), 0.5f);
        yield return new WaitForSeconds(1f * talkScale); // Starts talking at 5 seconds.
        banana.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(banana.TalkCR(2f * talkScale));
        yield return new WaitForSeconds(2f * talkScale); // Stops talking at 7.5 seconds.
        banana.MouthIdle();
        yield return new WaitForSeconds(1f);
        StartCoroutine(banana.IdleLookCR(5f));
        yield return new WaitForSeconds(5f); // Turns at 13.5 seconds.
        banana.TurnTo(new Vector3(0f, 210f, 0f), 0.5f);
        yield return new WaitForSeconds(0.5f); // Starts talking at 14 seconds.
        banana.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(banana.TalkCR(3f * talkScale));
        yield return new WaitForSeconds(3f * talkScale); // Stops talking at 17.5 seconds.
        banana.MouthIdle();
        yield return new WaitForSeconds(1.5f);
        banana.EyesRound(false);
        yield return new WaitForSeconds(4f);
        banana.EyesRound(true); // Surprise at 23 seconds
        banana.MouthOh();
        yield return new WaitForSeconds(2.5f); // Shock at 25.5 seconds
        banana.MouthShock();
        yield return new WaitForSeconds(4f); // Shout at 29.5 seconds.
        banana.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(banana.ShoutCR(4f * talkScale));
        yield return new WaitForSeconds(4f * talkScale); // Stops talking at 34 seconds.
        banana.MouthLine();
        yield return new WaitForSeconds(2f);
        banana.EyesRound(true);
        banana.MouthSad();
        yield return new WaitForSeconds(6.5f); // Starts talking at 42.5 seconds.
        StartCoroutine(banana.ShoutCR(3f * talkScale));
        yield return new WaitForSeconds(3f * talkScale); // Stops talking at 45.5 seconds.
        banana.MouthSad();
        yield return new WaitForSeconds(4f); // Runs away at 49.5 seconds.
        banana.MouthShock();
        banana.TurnTo(new Vector3(0f, -60f, 0f), 0.25f);
        banana.MoveTo(new Vector3(-1.950782f, 2.159547f, -2.482f), 3f);
        yield return null;
    }

    IEnumerator Apple1()
    {
        apple1.rightHand.gameObject.SetActive(false);
        apple1.transform.position = new Vector3(-1.927f, 1.898f, -6.611f);
        apple1.EyesRound(true);
        apple1.MouthLine();
        apple1.MoveTo(new Vector3(-1.927f, 1.898f, -4.637f), 4f);
        apple1.TurnTo(new Vector3(0f, 0f, 0f), 0.1f);
        StartCoroutine(apple1.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        apple1.TurnTo(new Vector3(0f, -90f, 0f), 0.5f);
        yield return new WaitForSeconds(4f * talkScale); // Starts talking at 8 Seconds
        apple1.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple1.TalkCR(2f * talkScale));
        yield return new WaitForSeconds(2f * talkScale); // Stops talking at 10.5 seconds.
        apple1.MouthIdle();
        StartCoroutine(apple1.IdleLookCR(7f));
        yield return new WaitForSeconds(5.5f); // Turns at 16 Seconds
        apple1.TurnTo(new Vector3(0f, -70f, 0f), 0.5f);
        apple1.EyesRound(false);
        yield return new WaitForSeconds(1.5f); // Starts talking at 17.5 seconds.
        apple1.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple1.TalkCR(5f * talkScale));
        yield return new WaitForSeconds(5f * talkScale); // Stops talking at 23 seconds.
        apple1.MouthIdle();
        yield return new WaitForSeconds(1f); // Turns at 24 seconds.
        apple1.TurnTo(new Vector3(0f, -110f, 0f), 0.5f);
        StartCoroutine(apple1.IdleLookCR(6f));
        yield return new WaitForSeconds(6f); // Turns at 30 seconds.
        apple1.TurnTo(new Vector3(0f, 319f, 0f), 0.5f);
        yield return new WaitForSeconds(4.5f); // Starts talking at 34.5 seconds.
        apple1.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple1.TalkCR(3f * talkScale));
        yield return new WaitForSeconds(3f * talkScale); // Stops talking at 38 seconds.
        apple1.MouthIdle();
        yield return new WaitForSeconds(8); // Starts talking at 46 seconds.
        StartCoroutine(apple1.TalkCR(3f * talkScale));
        apple1.rightHand.gameObject.SetActive(true);
        apple1.TurnRightFromTo(
            new Vector3(18.5f, 145.2f, 0f),
            new Vector3(-63.2f, 0f, 0f),
            0.5f);
        yield return new WaitForSeconds(3f * talkScale); // Stops talking at 49 seconds.
        apple1.MouthSmile();
        yield return new WaitForSeconds(1f); // Runs away at 50 seconds.
        apple1.TurnTo(new Vector3(0f, -60f, 0f), 0.25f);
        apple1.MoveTo(new Vector3(-1.950782f, 1.898f, -2.482f), 3.5f);
        yield return null;
    }

    IEnumerator Apple2()
    {
        apple2.rightHand.gameObject.SetActive(false);
        apple2.transform.position = new Vector3(-1.927f, 1.898f, -7.455f);
        apple2.EyesRound(true);
        apple2.MouthLine();
        apple2.MoveTo(new Vector3(-1.927f, 1.898f, -5.3f), 4f);
        apple2.TurnTo(new Vector3(0f, 0f, 0f), 0.1f);
        StartCoroutine(apple2.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        apple2.TurnTo(new Vector3(0f, 284f, 0f), 0.5f);
        yield return new WaitForSeconds(7f * talkScale); // Starts talking at 11 seconds.
        apple2.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple2.TalkCR(2f * talkScale));
        yield return new WaitForSeconds(2f * talkScale); // Stops talking at 13.5 seconds.
        apple2.MouthIdle();
        StartCoroutine(apple2.IdleLookCR(7.5f));
        yield return new WaitForSeconds(7.5f); // Turns at 21 seconds.
        apple2.TurnTo(new Vector3(0f, 300f, 0f), 0.5f);
        yield return new WaitForSeconds(2.5f); // Starts talking at 23.5 seconds.
        apple2.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple2.TalkCR(5f * talkScale));
        yield return new WaitForSeconds(5f * talkScale); // Stops talking at 29 seconds.
        apple2.MouthIdle();
        yield return new WaitForSeconds(1f);
        apple2.EyesRound(false);
        apple2.TurnTo(new Vector3(0f, 320f, 0f), 0.5f);
        yield return new WaitForSeconds(8.5f); // Starts talking at 38.5 seconds.
        apple2.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(apple2.TalkCR(3f * talkScale));
        yield return new WaitForSeconds(1.5f * talkScale);
        apple2.rightHand.gameObject.SetActive(true);
        apple2.TurnRightFromTo(
            new Vector3(18.5f, 145.2f, 0f),
            new Vector3(-63.2f, 0f, 0f),
            0.5f);
        yield return new WaitForSeconds(1.5f * talkScale); // Stops talking at 42 seconds.
        apple2.MouthSmile();
        yield return new WaitForSeconds(8f); // Runs away at 50 seconds.
        apple2.TurnTo(new Vector3(0f, -60f, 0f), 0.25f);
        apple2.MoveTo(new Vector3(-1.950782f, 1.898f, -2.482f), 4.25f);
        yield return null;
    }
}
