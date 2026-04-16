using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public Rigidbody BalonRigidBody;
    public float Fuerza = 10f;
    public Transform BalonTransform;
    public Transform DestinoTransform;
    public void PatearPelota()
    {
        Vector3 direccion = (DestinoTransform.position  - BalonTransform.position).normalized;

        // print("Pelota pateada.");
        BalonRigidBody.AddForce(direccion * Fuerza, ForceMode.Impulse);
    }
   
}
