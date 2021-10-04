using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchGround : MonoBehaviour
{
    public int m_iHitCount;
    public List<string> names = new List<string>();
    void Update()
    {
        checkGround();
    }

    private void checkGround()
    {
        RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.down);
        foreach(RaycastHit hit in hits)
        {
            if(hit.collider.tag == "CameraFloor")
            {
                Debug.Log(hit.collider.gameObject.name);
            }
            if( !names.Contains(hit.collider.name))
            {
                names.Add(hit.collider.name);
            }
        }
        m_iHitCount = hits.Length;




    }
}
