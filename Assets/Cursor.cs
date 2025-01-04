using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    GameObject lastObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    void changeChessPieceColor(GameObject chessPiece, Color color)
    {
        // trouve le material dans les objets enfants
        foreach (Transform child in chessPiece.transform)
        {
            if (child.GetComponent<Renderer>() != null)
            {
                child.GetComponent<Renderer>().material.color = color;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Vérifie si le bouton gauche de la souris est cliqué
        if (Input.GetMouseButtonDown(0))
        {
            // Crée un rayon depuis la position de la caméra vers la direction du curseur de la souris
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (lastObject != null)
            {
                changeChessPieceColor(lastObject, Color.blue);
            }

            // Si le rayon touche un objet
            if (Physics.Raycast(ray, out hit))
            {
                lastObject = hit.collider.gameObject;

                Debug.Log("Objet : " + lastObject.name);

                // si le nom commance par "low-poly-"
                if (lastObject.name.StartsWith("low-poly-"))
                {
                    changeChessPieceColor(lastObject, Color.red);
                }

            }
        }
    }
}
