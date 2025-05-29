using UnityEngine;

public class bola : MonoBehaviour
{

    public int pontuaçãoTotal;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("chão"))
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
            pontuaçãoTotal += 30;
        }
        else if(colisao.CompareTag("20 pontos"))
        {
            pontuaçãoTotal += 20;
        }
        else if(colisao.CompareTag("10 pontos"))
        {
            pontuaçãoTotal += 10;
        }
        Debug.Log(pontuaçãoTotal);
    }


}
