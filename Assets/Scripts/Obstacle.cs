using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float maxDistFromPlayer;
    private GameObject player;
    [SerializeField] GameObject gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("MainCamera");
        gameManager = GameObject.FindWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) >= maxDistFromPlayer) 
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            gameManager.GetComponent<MainGameManager>().GameOver();
        }
    }
}
