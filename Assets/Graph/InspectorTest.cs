using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

public class InspectorTest : MonoBehaviour
{
    public InputField f;
    public TMP_InputField a;

    public GameObject pubGameObject;
    private int count;

    [SerializeField]
    private GameObject priGameObject;
    public GameObject PriGameObject {
        get {
            count += 1;
            Debug.Log(count);
            return priGameObject;
        }
        
    }

    void Start()
    {
    }

    void Update()
    {
        
    }
}
