using UnityEngine;

public class LoopingScript : MonoBehaviour
{
    private AudioSource meuAudio;

    void Start()
    {
        meuAudio = GetComponent<AudioSource>(); // Pega o componente de som no mesmo GameObject
        StartCoroutine(LoopDeAcoes());
    }

    System.Collections.IEnumerator LoopDeAcoes()
    {
        while (true)
        {
            // Toca o som
            meuAudio.Play();

            // Espera o tempo do som ou um tempo fixo antes de repetir
            yield return new WaitForSeconds(meuAudio.clip.length); // ou: yield return new WaitForSeconds(2f);
        }
    }
}
