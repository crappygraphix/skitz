using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    class EyeState {
        public bool leftX, rightX, leftY, rightY;
        public Sprite left, right;

        public void Stash(SpriteRenderer leftR, SpriteRenderer rightR) {
            leftX = leftR.flipX;
            leftY = leftR.flipY;
            left = leftR.sprite;
            rightX = rightR.flipX;
            rightY = rightR.flipY;
            right = rightR.sprite;
        }

        public void Apply(SpriteRenderer leftR, SpriteRenderer rightR) {
            leftR.flipX = leftX;
            leftR.flipY = leftY;
            leftR.sprite = left;
            rightR.flipX = rightX;
            rightR.flipY = rightY;
            rightR.sprite = right;
        }
    }
    public SpriteRenderer leftEye;
    public SpriteRenderer rightEye;
    public SpriteRenderer mouth;

    public Transform rightHand;
    public Transform leftHand;

    Vector3 here;
    Vector3 there;
    float travelDelta;
    float travelTime;

    Quaternion rotateFrom;
    Quaternion rotateTo;
    float turnDelta;
    float turnTime;

    Quaternion leftHandFrom;
    Quaternion leftHandTo;
    float leftHandDelta;
    float leftHandTime;

    Quaternion rightHandFrom;
    Quaternion rightHandTo;
    float rightHandDelta;
    float rightHandTime;

    public void TurnLeftTo(Vector3 v, float f) {
        leftHandFrom = leftHand.rotation;
        leftHandTo = Quaternion.Euler(v);
        leftHandDelta = 0f;
        leftHandTime = f;
    }

    public void TurnLeftFromTo(Vector3 v1, Vector3 v2, float f) {
        leftHand.rotation = Quaternion.Euler(v1);
        leftHandFrom = Quaternion.Euler(v1);
        leftHandTo = Quaternion.Euler(v2);
        leftHandDelta = 0f;
        leftHandTime = f;
    }

    public void TurnRightTo(Vector3 v, float f) {
        rightHandFrom = rightHand.rotation;
        rightHandTo = Quaternion.Euler(v);
        rightHandDelta = 0f;
        rightHandTime = f;
    }

    public void TurnRightFromTo(Vector3 v1, Vector3 v2, float f) {
        rightHand.rotation = Quaternion.Euler(v1);
        rightHandFrom = Quaternion.Euler(v1);
        rightHandTo = Quaternion.Euler(v2);
        rightHandDelta = 0f;
        rightHandTime = f;
    }

    public void MoveTo(Vector3 v, float f) {
      here = transform.position;
      there = v;
      travelDelta = 0f;
      travelTime = f;
    }

    public void TurnTo(Vector3 v, float f) {
        rotateFrom = transform.rotation;
        rotateTo = Quaternion.Euler(v);
        turnDelta = 0f;
        turnTime = f;
    }

    public void EyesBlink() {
        leftEye.flipX = false;
        leftEye.flipY = false;
        leftEye.sprite = SpriteCollector.GetEyeLine();
        rightEye.flipX = false;
        rightEye.flipY = false;
        rightEye.sprite = SpriteCollector.GetEyeLine();
    }

    public void EyesAngry() {
        leftEye.flipX = true;
        leftEye.flipY = false;
        leftEye.sprite = SpriteCollector.GetEyeMad();
        rightEye.flipX = false;
        rightEye.flipY = false;
        rightEye.sprite = SpriteCollector.GetEyeMad();
    }

    public void EyesSmile() {
        leftEye.flipX = false;
        leftEye.flipY = false;
        leftEye.sprite = SpriteCollector.GetEyeHappy();
        rightEye.flipX = true;
        rightEye.flipY = false;
        rightEye.sprite = SpriteCollector.GetEyeHappy();
    }

    public void EyesRound(bool left) {
        leftEye.flipX = left;
        leftEye.flipY = false;
        leftEye.sprite = SpriteCollector.GetEyeRound();
        rightEye.flipX = left;
        rightEye.flipY = false;
        rightEye.sprite = SpriteCollector.GetEyeRound();
    }

    public void MouthSmile() {
        mouth.flipX = false;
        mouth.flipY = false;
        mouth.sprite = SpriteCollector.GetMouthC();
    }

    public void MouthLine() {
        mouth.flipX = false;
        mouth.flipY = false;
        mouth.sprite = SpriteCollector.GetMouthLine();
    }

    public void MouthIdle() {
        mouth.flipX = false;
        mouth.flipY = false;
        mouth.sprite = SpriteCollector.GetMouthA();
    }

    public void MouthSad() {
        mouth.flipX = false;
        mouth.flipY = true;
        mouth.sprite = SpriteCollector.GetMouthB();
    }

    public void MouthShock() {
        mouth.flipX = false;
        mouth.flipY = false;
        mouth.sprite = SpriteCollector.GetMouthShock();
    }

    public void MouthOh() {
        mouth.flipX = false;
        mouth.flipY = false;
        mouth.sprite = SpriteCollector.GetMouthRound();
    }

    float blinkDelta;
    EyeState eyeState = new EyeState();
    public IEnumerator IdleBlinkCR(float t)
    {
        blinkDelta = Time.time;
        while(t > 0) {
            yield return new WaitForSeconds(Random.Range(1f, 3f));
            eyeState.Stash(leftEye, rightEye);
            EyesBlink();
            yield return new WaitForSeconds(0.05f);
            // Only reset if we are still blinking
            if(leftEye.sprite == SpriteCollector.GetEyeLine() && rightEye.sprite == SpriteCollector.GetEyeLine())
              eyeState.Apply(leftEye, rightEye);
            blinkDelta = Time.time - blinkDelta;
            t -= blinkDelta;
            blinkDelta = Time.time;
        }
        yield return null;
    }

    float lookDelta;
    public IEnumerator IdleLookCR(float t)
    {
        lookDelta = Time.time;
        while(t > 0) {
            if(Random.Range(0, 100) > 50) {
                EyesRound(false);
            } else {
                EyesRound(true);
            }
            yield return new WaitForSeconds(Random.Range(1f, Mathf.Min(t, 3f)));
            lookDelta = Time.time - lookDelta;
            t -= lookDelta;
            lookDelta = Time.time;
        }
        yield return null;
    }

    float talkDelta;
    public IEnumerator TalkCR(float t)
    {
        talkDelta = Time.time;
        while(t > 0) {
            switch(Random.Range(0, 3)) {
                case 0: mouth.sprite = SpriteCollector.GetMouthA(); break;
                case 1: mouth.sprite = SpriteCollector.GetMouthB(); break;
                case 2: mouth.sprite = SpriteCollector.GetMouthLine(); break;
            }
            yield return new WaitForSeconds(0.03f);
            talkDelta = Time.time - talkDelta;
            t -= talkDelta;
            talkDelta = Time.time;
        }
        yield return null;
    }

    float shoutDelta;
    public IEnumerator ShoutCR(float t)
    {
        shoutDelta = Time.time;
        while(t > 0) {
            mouth.flipY = true;
            switch(Random.Range(0, 3)) {
                case 0: mouth.sprite = SpriteCollector.GetMouthA(); break;
                case 1: mouth.sprite = SpriteCollector.GetMouthB(); break;
                case 2: mouth.sprite = SpriteCollector.GetMouthLine(); break;
            }
            yield return new WaitForSeconds(0.03f);
            shoutDelta = Time.time - shoutDelta;
            t -= shoutDelta;
            shoutDelta = Time.time;
        }
        yield return null;
    }

    // Start is called before the first frame update
    void Awake()
    {
        here = transform.position;
        there = transform.position;
        travelDelta = 0f;
        travelTime = 0f;
        rotateFrom = transform.rotation;
        rotateTo = transform.rotation;
        turnDelta = 0f;
        turnTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        bool traveling = false;
        bool turning = false;
        if(travelDelta < travelTime) {
            traveling = true;
            travelDelta += Time.deltaTime;

            // Location
            // Slide
            Vector3 pos = Vector3.Lerp(here, there, travelDelta / travelTime);
            // Hop
            pos.y = pos.y + Mathf.PingPong((3f * travelDelta) / travelTime, 0.1f);

            if (travelDelta >= travelTime) {
                pos = there;
            }

            // Apply
            transform.position = pos;
        }

        if(turnDelta < turnTime) {
            turning = true;
            turnDelta += Time.deltaTime;
            // Rotation
            transform.rotation = Quaternion.Slerp(rotateFrom, rotateTo, turnDelta / turnTime);

            if (turnDelta >= turnTime) {
                transform.rotation = rotateTo;
            }
        }

        if(rightHandDelta < rightHandTime) {
            rightHandDelta += Time.deltaTime;
            // Rotation
            rightHand.rotation = Quaternion.Slerp(rightHandFrom, rightHandTo, rightHandDelta / rightHandTime);

            if (rightHandDelta >= rightHandTime) {
                rightHand.rotation = rightHandTo;
            }
        }

        if(!traveling && turning) {
            // Hop
            Vector3 pos = there;
            pos.y = pos.y + Mathf.PingPong((0.4f * turnDelta) / turnTime, 0.1f);
            transform.position = pos;
            if (turnDelta >= turnTime) {
                transform.position = there;
            }
        }
    }
}
