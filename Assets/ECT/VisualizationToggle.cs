using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualizationToggle : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public Material passthroughMaterial;
    public Material debugMaterial;

    public bool useDebugMaterial = false;
    private bool pressHandled = false;

    private void Awake()
    {
#if UNITY_EDITOR
        SetDebugMaterial(true);
#endif
    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.B))
        {
            if (!pressHandled)
            {
                pressHandled = true;
                SetDebugMaterial(!useDebugMaterial);
            }
        }
        else if (pressHandled)
        {
            pressHandled = false;
        }
    }

    public void SetDebugMaterial(bool debug)
    {
        useDebugMaterial = debug;
        if (useDebugMaterial)
        {
            ///Debug.LogError("SETTING DEBUG MAT");
            meshRenderer.material = debugMaterial;
        }
        else
        {
            //Debug.LogError("SETTING PASSTHROUGH MAT");
            meshRenderer.material = passthroughMaterial;
        }
    }
}
