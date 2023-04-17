using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public string myMessage;
    public Vector3 scaleChange;
    public Vector3 positionChange;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
        Debug.Log(myMessage);

    }
}
