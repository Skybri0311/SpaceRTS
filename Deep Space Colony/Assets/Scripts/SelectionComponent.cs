using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().material.color = Color.red;
    }

    private void OnDestroy()
    {
        GetComponent<SpriteRenderer>().material.color = Color.white;
    }
}
