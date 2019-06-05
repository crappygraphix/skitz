using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCollector : MonoBehaviour
{
  static SpriteCollector instance = null;

  void Awake(){
    instance = this;
  }

  void OnDestroy(){
    instance = null;
  }

  public Sprite eyeHappy;
  public Sprite eyeLine;
  public Sprite eyeMad;
  public Sprite eyeRound;
  public Sprite mouthA;
  public Sprite mouthB;
  public Sprite mouthC;
  public Sprite mouthLine;
  public Sprite mouthRound;
  public Sprite mouthShock;
}
