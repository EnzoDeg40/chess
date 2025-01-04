using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ApplyRandomHeightToChildren();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ApplyRandomHeightToChildren()
    {
        foreach (Transform child in transform)
        {
            float randomHeight = Random.Range(-0.05f, 0.05f);
            Vector3 newPosition = child.localPosition;
            newPosition.y = randomHeight;
            child.localPosition = newPosition;
        }
    }
}
