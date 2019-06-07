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
        yield return null;
    }
}
