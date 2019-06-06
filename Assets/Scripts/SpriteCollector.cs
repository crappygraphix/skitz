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

  public static Sprite GetEyeHappy(){
      if(null == instance) return null;
      return instance.eyeHappy;
  }

  public static Sprite GetEyeLine(){
      if(null == instance) return null;
      return instance.eyeLine;
  }

  public static Sprite GetEyeMad(){
      if(null == instance) return null;
      return instance.eyeMad;
  }

  public static Sprite GetEyeRound(){
      if(null == instance) return null;
      return instance.eyeRound;
  }

  public static Sprite GetMouthA(){
      if(null == instance) return null;
      return instance.mouthA;
  }

  public static Sprite GetMouthB(){
      if(null == instance) return null;
      return instance.mouthB;
  }

  public static Sprite GetMouthC(){
      if(null == instance) return null;
      return instance.mouthC;
  }

  public static Sprite GetMouthLine(){
      if(null == instance) return null;
      return instance.mouthLine;
  }

  public static Sprite GetMouthRound(){
      if(null == instance) return null;
      return instance.mouthRound;
  }

  public static Sprite GetMouthShock(){
      if(null == instance) return null;
      return instance.mouthShock;
  }
}
