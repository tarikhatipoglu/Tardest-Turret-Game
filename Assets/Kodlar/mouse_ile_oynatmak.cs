using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_ile_oynatmak : MonoBehaviour
{
    public Camera cam;
    public float maxLength;

    private Ray Mouse;
    private Vector3 pos;
    private Vector3 direction;
    private Quaternion rotasyon;

    void Update()
    {
        if(cam != null)
        {
            if(transform.rotation.y > Quaternion.Euler(new Vector3(0,-90,0)).y || transform.rotation.y < Quaternion.Euler(new Vector3(0, 90, 0)).y)
            {
                RaycastHit hit;
                var mousePoz = Input.mousePosition;
                Mouse = cam.ScreenPointToRay(mousePoz);

                if (Physics.Raycast(Mouse.origin, Mouse.direction, out hit, maxLength))
                {
                    MouseDondur(gameObject, hit.point);
                }
                else
                {
                    var poz = Mouse.GetPoint(maxLength);
                    MouseDondur(gameObject, pos);
                }
            }
        }
        else
        {
            Debug.Log("Kamera yok");
        }
    }

    void MouseDondur(GameObject obje, Vector3 lokasyon)
    {
        direction = lokasyon - obje.transform.position;
        rotasyon = Quaternion.LookRotation(direction);
        obje.transform.localRotation = Quaternion.Lerp(obje.transform.rotation, rotasyon, 1);
    }
}
