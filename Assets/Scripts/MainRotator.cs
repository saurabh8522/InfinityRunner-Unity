using UnityEngine;
using System.Collections;

public class MainRotator : MonoBehaviour
{

    public float speed = -0.5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (speed > -2f)
        {
            speed = speed * 1.0009f;
            transform.Rotate(new Vector3(speed, 0, 0));
        }
        else
            transform.Rotate(new Vector3(speed, 0, 0));

    }
}
