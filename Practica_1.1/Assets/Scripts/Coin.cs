using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Moneda creada");
        Coin.countCoins++;
    }

    //varaibles
    public static int countCoins = 0;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        Coin.countCoins--;
        if (Coin.countCoins <= 0)
        {
            GameObject timer = GameObject.Find("GameTimer");
            Destroy(timer);
            Debug.Log("El juego ha terminado, has ganado");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Se ha recolectado la moneda " + Coin.countCoins);
        if (collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
