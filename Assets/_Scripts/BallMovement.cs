using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool moveUp = OVRInput.Get(OVRInput.Button.One);
        bool moveDown = OVRInput.Get(OVRInput.Button.Two);

        if (moveUp)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        else if (moveDown)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
