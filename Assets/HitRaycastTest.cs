using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitRaycastTest : MonoBehaviour
{
    public Transform m_tfTarget;

    void Update()
    {
        Vector3 dir = m_tfTarget.position - transform.position;
        dir = new Vector3(dir.x, 0f, dir.z);

        RaycastHit raycastHit;
        if( Physics.Raycast(transform.position + Vector3.up *0.5f, dir.normalized , out raycastHit))
        {
            Debug.Log(raycastHit.collider.name);
        }
    }
}
