using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScroller : MonoBehaviour
{
    private ParticleSystem ps;


    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        var main = ps.main;

    }
}
