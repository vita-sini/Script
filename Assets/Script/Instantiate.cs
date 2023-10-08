using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject InstantiatePrefab;

    private void Start()
    {
        GameObject newObject = Instantiate(InstantiatePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
