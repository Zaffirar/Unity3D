using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(End());
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(5f);
        Application.Quit();
    }
}
