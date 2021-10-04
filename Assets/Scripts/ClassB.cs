using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassB : ClassBase
{
    protected override void initialize()
    {
        // staticなデーターベースへの書き込み
        save_chara_id = 10;
    }
    void Update()
    {
    }
}
