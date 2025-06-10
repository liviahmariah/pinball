using UnityEngine;

public class ReiniciarBola : MonoBehaviour
{
    // Defina aqui a posição que você quer que a bola reapareça
    private Vector3 posicaoDeRespawn = new Vector3(9.4f, 14f, 0f); // X, Y, Z

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            ReiniciarPosicao();
        }
    }

    private void ReiniciarPosicao()
    {
        transform.position = posicaoDeRespawn;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
            rb.angularVelocity = 0f;
        }
    }
}
