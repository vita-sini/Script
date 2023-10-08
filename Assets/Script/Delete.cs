using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private void Start()
    {
        GameObject Square = GameObject.Find("Square");

        Destroy(Square);

        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("DeleteCircle");

        foreach (GameObject gameObject in gameObjects)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }

}
