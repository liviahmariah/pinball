using UnityEngine;

public class bola : MonoBehaviour
{

    public int pontua��oTotal;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("ch�o"))
        {
            Destroy(gameObject);
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaa");
        }
        Debug.Log("bateuuu");
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if(colisao.CompareTag("30 pontos"))
        {
            pontua��oTotal += 30;
        }
        else if(colisao.CompareTag("20 pontos"))
        {
            pontua��oTotal += 20;
        }
        else if(colisao.CompareTag("10 pontos"))
        {
            pontua��oTotal += 10;
        }
        Debug.Log(pontua��oTotal);
    }


}
