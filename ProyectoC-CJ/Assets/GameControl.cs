using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public Rigidbody BalonRigidBody;
    public float Fuerza = 10f;
    public Transform BalonTransform;
    public Transform DestinoTransform;

    public Animator IndicadorAnimator;

    public Transform TransformIndicador;
    public float NivelDeFuerza1;
    public float NivelDeFuerza2;
    // capturar la posicion del indicador
    public void DetenerBarraFuerza()
    {
        IndicadorAnimator.speed = 0;
        IndicadorAnimator.Update(0);

        NivelDeFuerza1 = TransformIndicador.localPosition.y;
        NivelDeFuerza2 = Mathf.InverseLerp(0f, 2030f, NivelDeFuerza1);
    }

    public void PatearPelota()
    {
        Vector3 direccion = (DestinoTransform.position  - BalonTransform.position).normalized;

        // print("Pelota pateada.");
        BalonRigidBody.AddForce(direccion * Fuerza, ForceMode.Impulse);
    }
   
}
