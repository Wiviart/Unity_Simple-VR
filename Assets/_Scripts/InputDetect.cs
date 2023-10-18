using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetect : MonoBehaviour
{
    Vector2 move = Vector2.zero;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) > 0)
        {
            Debug.Log("PrimaryHandTrigger");
        }

        move = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
    }
    void FixedUpdate()
    {
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime);
    }
}
