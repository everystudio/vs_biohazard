using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassB : ClassBase
{
    public InspectorTest script;
    protected override void initialize()
    {
        // static�ȃf�[�^�[�x�[�X�ւ̏�������
        save_chara_id = 10;

        Debug.Log(script.PriGameObject);
    }
    void Update()
    {
    }
}
