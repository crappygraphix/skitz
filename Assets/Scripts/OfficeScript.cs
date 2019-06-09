using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeScript : MonoBehaviour
{
    public Actor disk;
    public Actor coffee;
    public Actor stapler;
    public Actor cube;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disk());
        StartCoroutine(Coffee());
        StartCoroutine(Stapler());
        StartCoroutine(Cube());
    }

    IEnumerator Disk()
    {
        disk.transform.position = new Vector3(3.522067f, 1.726267f, -5.134f);
        disk.leftHand.gameObject.SetActive(false);
        disk.rightHand.gameObject.SetActive(false);
        disk.EyesRound(true);
        disk.MouthLine();
        disk.MoveTo(new Vector3(1.792067f, 1.726267f, -5.134f), 4f);
        disk.TurnTo(new Vector3(0f, 270f, 0f), 0.1f);
        StartCoroutine(disk.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        disk.TurnTo(new Vector3(0f, 360f, 0f), 0.5f);
        yield return new WaitForSeconds(1f); // Starts talking at 5 seconds.
        disk.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(disk.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 7.5 seconds.
        StartCoroutine(disk.IdleLookCR(5f));
        disk.MouthIdle();
        disk.MoveTo(new Vector3(2f, 1.726267f, -5.134f), 1f);
        disk.TurnTo(new Vector3(0f, 310f, 0f), 0.5f);
        yield return new WaitForSeconds(20.5f); // Starts talking at 28 seconds.
        disk.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(disk.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 30.5 seconds.
        disk.MouthSmile();
        yield return new WaitForSeconds(9f); // Starts talking at 39.5 seconds.
        disk.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(disk.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 42 seconds.
        disk.MouthSmile();
        yield return new WaitForSeconds(7f);
        disk.leftHand.gameObject.SetActive(true);
        disk.TurnLeftFromTo(new Vector3(357.6f, 130.0f, 180.0f), new Vector3(309.3f, 310.0f, 0.0f), 0.5f);
        disk.TurnTo(new Vector3(0f, 300f, 0f), 0.25f);
        yield return new WaitForSeconds(4.5f); // Starts talking at 53.5 seconds.
        StartCoroutine(disk.TalkCR(2f));
        yield return new WaitForSeconds(2.5f); // Starts chase at 56 seconds.
        disk.MoveTo(new Vector3(-4f, 1.726267f, -5.134f), 3f);
        yield return null;
    }

    IEnumerator Coffee()
    {
        coffee.transform.position = new Vector3(3.03f, 1.571267f, -5.134f);
        coffee.leftHand.gameObject.SetActive(false);
        coffee.rightHand.gameObject.SetActive(false);
        coffee.EyesRound(true);
        coffee.MouthLine();
        coffee.MoveTo(new Vector3(1.3f, 1.571267f, -5.134f), 4f);
        coffee.TurnTo(new Vector3(0f, 270f, 0f), 0.1f);
        StartCoroutine(coffee.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        coffee.TurnTo(new Vector3(0f, 360f, 0f), 0.5f);
        yield return new WaitForSeconds(4f); // Starts talking at 8 seconds.
        coffee.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(coffee.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 10.5 seconds.
        StartCoroutine(coffee.IdleLookCR(6.5f));
        coffee.MouthIdle();
        coffee.MoveTo(new Vector3(1.5f, 1.571267f, -5.134f), 1f);
        coffee.TurnTo(new Vector3(0f, 300f, 0f), 0.5f);
        yield return new WaitForSeconds(6.5f); // Starts talking at 17 seconds.
        coffee.EyesAngry();
        yield return new WaitForSeconds(1f);
        coffee.leftHand.gameObject.SetActive(true);
        coffee.TurnLeftFromTo(new Vector3(15.0f, 172.1f, 29.0f), new Vector3(0f, 300f, 0f), 0.25f);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(coffee.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 20.5 seconds.
        coffee.MouthIdle();
        yield return new WaitForSeconds(10.5f); // Starts talking at 31 seconds.
        StartCoroutine(coffee.TalkCR(3f));
        yield return new WaitForSeconds(3f); // Stops talking at 34 seconds.
        coffee.MouthIdle();
        yield return new WaitForSeconds(4f); // Attack at 38 seconds.
        coffee.TurnTo(new Vector3(0f, 320f, 0f), 0.5f);
        coffee.MoveTo(new Vector3(1.299f, 1.571267f, -5.134f), 1f);
        coffee.TurnLeftTo(new Vector3(321.4f, 291.3f, 352.0f), 0.5f);
        coffee.MouthSmile();
        yield return new WaitForSeconds(0.5f);
        coffee.TurnTo(new Vector3(0f, 280f, 0f), 0.5f);
        coffee.TurnLeftTo(new Vector3(312.1f, 276.8f, 2.4f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        coffee.MouthIdle();
        yield return new WaitForSeconds(4f); // Attack at 43 seconds.
        coffee.TurnTo(new Vector3(0f, 320f, 0f), 0.5f);
        coffee.TurnLeftTo(new Vector3(321.4f, 291.3f, 352.0f), 0.5f);
        coffee.MouthSmile();
        yield return new WaitForSeconds(0.5f);
        coffee.TurnTo(new Vector3(0f, 280f, 0f), 0.5f);
        coffee.TurnLeftTo(new Vector3(312.1f, 276.8f, 2.4f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        coffee.MouthIdle();
        yield return new WaitForSeconds(4f); // Attack at 48 seconds.
        coffee.TurnTo(new Vector3(0f, 320f, 0f), 0.25f);
        coffee.TurnLeftTo(new Vector3(321.4f, 291.3f, 352.0f), 0.25f);
        coffee.MouthSmile();
        yield return new WaitForSeconds(0.25f);
        coffee.TurnTo(new Vector3(0f, 280f, 0f), 0.25f);
        coffee.TurnLeftTo(new Vector3(312.1f, 276.8f, 2.4f), 0.25f);
        yield return new WaitForSeconds(0.25f); // Finishing move at 48.5 seconds
        coffee.MouthIdle();
        coffee.TurnTo(new Vector3(0f, 300f, 0f), 0.5f);
        yield return new WaitForSeconds(0.5f); // Starts talking at 49 seconds.
        coffee.EyesAngry();
        yield return new WaitForSeconds(1f);
        StartCoroutine(coffee.TalkCR(3f));
        yield return new WaitForSeconds(3f); // Stops talking at 53 seconds.
        coffee.MouthSmile();
        yield return new WaitForSeconds(3f); // Starts chase at 56 seconds.
        coffee.MoveTo(new Vector3(-4f, 1.571267f, -5.134f), 3f);
        yield return null;
    }

    IEnumerator Stapler()
    {
        stapler.transform.position = new Vector3(-1.089f, 1.800267f, -5.134f);
        stapler.leftHand.gameObject.SetActive(false);
        stapler.rightHand.gameObject.SetActive(false);
        stapler.EyesRound(true);
        stapler.MouthLine();
        stapler.MoveTo(new Vector3(0.653f, 1.800267f, -5.134f), 4f);
        stapler.TurnTo(new Vector3(0f, 90f, 0f), 0.1f);
        StartCoroutine(stapler.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        stapler.TurnTo(new Vector3(0f, 360f, 0f), 0.5f);
        yield return new WaitForSeconds(7f); // Starts talking at 11 seconds.
        stapler.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(stapler.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 13.5 seconds.
        StartCoroutine(stapler.IdleLookCR(6.5f));
        stapler.MouthIdle();
        stapler.MoveTo(new Vector3(0.5f, 1.800267f, -5.134f), 1f);
        stapler.TurnTo(new Vector3(0f, -300f, 0f), 0.5f);
        yield return new WaitForSeconds(7.5f); // Starts talking at 21 seconds.
        stapler.EyesAngry();
        yield return new WaitForSeconds(1f);
        stapler.rightHand.gameObject.SetActive(true);
        stapler.TurnRightFromTo(new Vector3(37.5f, 197.9f, 331.2f), new Vector3(314.0f, 60.0f, 0.0f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(stapler.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 24.5 seconds.
        stapler.MouthIdle();
        yield return new WaitForSeconds(10f); // Starts talking at 34.5 seconds.
        StartCoroutine(stapler.TalkCR(3f));
        yield return new WaitForSeconds(3f); // Stops talking at 37.5 seconds.
        stapler.MouthIdle();
        yield return new WaitForSeconds(0.5f); // Attack at 38 seconds
        stapler.TurnTo(new Vector3(0f, -280f, 0f), 0.5f);
        stapler.MoveTo(new Vector3(0.659f, 1.800267f, -5.134f), 1f);
        stapler.TurnRightTo(new Vector3(320.8f, 144.1f, 301.5f), 0.5f);
        stapler.MouthSmile();
        yield return new WaitForSeconds(0.5f);
        stapler.TurnRightTo(new Vector3(329.5f, 95.3f, 323.8f), 0.5f);
        stapler.TurnTo(new Vector3(0f, -320f, 0f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        stapler.MouthIdle();
        yield return new WaitForSeconds(4f); // Attack at 43 seconds
        stapler.TurnTo(new Vector3(0f, -280f, 0f), 0.5f);
        stapler.TurnRightTo(new Vector3(320.8f, 144.1f, 301.5f), 0.5f);
        stapler.MouthSmile();
        yield return new WaitForSeconds(0.5f);
        stapler.TurnRightTo(new Vector3(329.5f, 95.3f, 323.8f), 0.5f);
        stapler.TurnTo(new Vector3(0f, -320f, 0f), 0.5f);
        yield return new WaitForSeconds(0.5f);
        stapler.MouthIdle();
        yield return new WaitForSeconds(4.5f); // Death spin at 48.5 seconds.
        stapler.EyesRound(false);
        stapler.MouthOh();
        stapler.TurnTo(new Vector3(0f, 90f, 0f), 0.25f);
        yield return new WaitForSeconds(0.25f);
        stapler.rightHand.gameObject.SetActive(false);
        stapler.TurnTo(new Vector3(0f, 180f, 0f), 0.25f);
        yield return new WaitForSeconds(0.25f);
        stapler.TurnTo(new Vector3(0f, 270f, 0f), 0.25f);
        yield return new WaitForSeconds(0.25f);
        stapler.TurnTo(new Vector3(0f, 360f, 0f), 0.25f);
        yield return new WaitForSeconds(4.25f); // Run away at 53.5
        stapler.MouthShock();
        stapler.TurnTo(new Vector3(0f, -30f, 0f), 0.5f);
        stapler.MoveTo(new Vector3(-4f, 1.800267f, -5f), 3f);
        yield return null;
    }

    IEnumerator Cube()
    {
        cube.transform.position = new Vector3(-1.638f, 1.568267f, -5.134f);
        cube.leftHand.gameObject.SetActive(false);
        cube.rightHand.gameObject.SetActive(false);
        cube.EyesRound(true);
        cube.MouthLine();
        cube.MoveTo(new Vector3(0.291f, 1.568267f, -5.134f), 4f);
        cube.TurnTo(new Vector3(0f, 90f, 0f), 0.1f);
        StartCoroutine(cube.IdleBlinkCR(60f));
        yield return new WaitForSeconds(4f);
        cube.TurnTo(new Vector3(0f, 360f, 0f), 0.5f);
        yield return new WaitForSeconds(10f); // Starts talking at 14 seconds.
        cube.EyesSmile();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(cube.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 16.5 seconds.
        StartCoroutine(cube.IdleLookCR(5f));
        cube.MouthIdle();
        cube.MoveTo(new Vector3(0.2f, 1.568267f, -5.134f), 1f);
        cube.TurnTo(new Vector3(0f, -310f, 0f), 0.5f);
        yield return new WaitForSeconds(8.5f); // Starts talking at 25 seconds.
        cube.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(cube.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 27.5 seconds.
        cube.MouthSmile();
        yield return new WaitForSeconds(17f); // Starts talking at 44.5 seconds.
        cube.EyesAngry();
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(cube.TalkCR(2f));
        yield return new WaitForSeconds(2f); // Stops talking at 47 seconds.
        cube.MouthSmile();
        yield return new WaitForSeconds(1.5f); // Death spin at 48.5 seconds.
        cube.EyesRound(false);
        cube.MouthOh();
        yield return new WaitForSeconds(5f); // Run away at 53.5 seconds.
        stapler.MouthShock();
        stapler.TurnTo(new Vector3(0f, -30f, 0f), 0.5f);
        cube.MoveTo(new Vector3(-4f, 1.568267f, -5.134f), 3f);

        // cube.TurnTo(new Vector3(0f, 320, 0f), 0.25f);
        // cube.MoveTo(new Vector3(-5f, 1.568267f, -5.134f), 3f);
        yield return null;
    }
}
