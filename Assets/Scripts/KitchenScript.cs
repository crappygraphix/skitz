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
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Banana()
    {
        banana.MoveTo(new Vector3(-1.950782f, 2.159547f, -3.974f), 5f);
        banana.TurnTo(new Vector3(-1.950782f, 2.159547f, -10.974f), 5f);
        yield return new WaitForSeconds(5f);
        banana.TurnTo(new Vector3(-11.950782f, 2.159547f, -3.974f), 5f);
    }
}
