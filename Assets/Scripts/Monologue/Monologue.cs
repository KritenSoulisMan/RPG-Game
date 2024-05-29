using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monologue : MonoBehaviour
{
    void Start()
    {
        Monologue = GameObject
    }

    IEnumerable WaitForDebug()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log(Monologue.instance.nodes[1]);
    }
}
