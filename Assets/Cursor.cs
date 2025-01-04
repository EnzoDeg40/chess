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
        // V�rifie si le bouton gauche de la souris est cliqu�
        if (Input.GetMouseButtonDown(0))
        {
            // Cr�e un rayon depuis la position de la cam�ra vers la direction du curseur de la souris
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Si le rayon touche un objet
            if (Physics.Raycast(ray, out hit))
            {
                // Affiche le nom de l'objet touch� dans la console
                Debug.Log("Objet cliqu� : " + hit.collider.gameObject.name);
            }
        }
    }
}
