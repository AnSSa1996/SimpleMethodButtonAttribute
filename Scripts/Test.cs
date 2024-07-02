using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Button("Test")]
    private void TestMethod()
    {
        Debug.Log("TestMethod");
    }
}
