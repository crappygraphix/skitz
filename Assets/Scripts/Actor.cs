using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    public SpriteRenderer leftEye;
    public SpriteRenderer rightEye;
    public SpriteRenderer mouth;

    Vector3 here;
    Vector3 there;
    float arrivalTime;

    Vector3 rotateTo;
    float turnSpeed;

    public void MoveTo(Vector3 v, float f) {
      here = transform.position;
      there = v;
      rotateTo = transform.forward;
      arrivalTime = Time.time + f;
    }

    public void TurnTo(Vector3 r, float s) {
        rotateTo = r;
        turnSpeed = s;
    }

    // Start is called before the first frame update
    void Awake()
    {
        here = transform.position;
        there = transform.position;
        arrivalTime = Time.time;
        rotateTo = transform.forward;
        turnSpeed = 100;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.Lerp(here, there, Time.time / arrivalTime);
        if(Time.time <= arrivalTime) {
          pos.y = pos.y + Mathf.PingPong((3f * Time.time) / arrivalTime, 0.1f);
        }
        transform.position = pos;

        Vector3 targetDir = rotateTo - transform.position;
        // The step size is equal to speed times frame time.
        float step = turnSpeed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        // Move our position a step closer to the target.
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
