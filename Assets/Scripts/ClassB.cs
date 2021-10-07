using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassB : ClassBase
{
    public InspectorTest script;
    protected override void initialize()
    {
        // staticなデーターベースへの書き込み
        save_chara_id = 10;

        Debug.Log(script.PriGameObject);
    }
    void Update()
    {
    }
}
