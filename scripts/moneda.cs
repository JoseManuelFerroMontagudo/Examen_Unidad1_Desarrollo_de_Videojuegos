using UnityEngine;

public class moneda : MonoBehaviour
{
    // Este método se ejecuta cuando otro objeto entra en el trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si el objeto que tocó la moneda es el jugador
        if (other.CompareTag("Player"))
        {
            // Aquí puedes sumar puntos, reproducir sonido, etc.
            Debug.Log("Moneda recogida!");

            // Destruye la moneda
            Destroy(gameObject);
        }
    }
}

