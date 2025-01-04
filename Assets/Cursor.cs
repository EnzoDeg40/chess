using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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

            // Si le rayon touche un objet
            if (Physics.Raycast(ray, out hit))
            {
                // Affiche le nom de l'objet touché dans la console
                Debug.Log("Objet cliqué : " + hit.collider.gameObject.name);
            }
        }
    }
}
