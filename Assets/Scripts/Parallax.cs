using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer ;
    public float animationSpeedx = 1f;
    public float animationSpeedy = 1f;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeedx * Time.deltaTime, animationSpeedy * Time.deltaTime);
    }

}
