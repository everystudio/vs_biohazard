using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassBase : MonoBehaviour
{
    protected int save_chara_id = 0;
    protected virtual void initialize()
    {

    }

    private void Awake()
    {
        initialize();
    }
    void Update()
    {
        
    }
}
