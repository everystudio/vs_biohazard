using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MouseInputTest : MonoBehaviour
{
    void Update()
    {
        CinemachineFreeLook look;

        bool bHoldLeft = Input.GetMouseButton(0);
        bool bHoldRight = Input.GetMouseButton(1);

        if( bHoldLeft && bHoldRight)
        {
            Debug.Log("“¯‰Ÿ‚µ¬Œ÷");
        }
    }

    public void Setup()
    {
        Debug.Log("setup");
    }
}
