using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OVRNavmeshBuilder : MonoBehaviour
{
    public OVRSceneManager sceneManager;

    // build the nav mesh when Scene is detected
    public NavMeshSurface ground;

    void Awake()
    {
        sceneManager.SceneModelLoadedSuccessfully += BuildNavMesh;
    }

    void BuildNavMesh()
    {
        ground.BuildNavMesh();
    }
}
