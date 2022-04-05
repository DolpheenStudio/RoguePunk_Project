using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject scrapPrefab;
    public GameObject boltPrefab;
    public GameObject nutPrefab;
    public GameObject firstAidPrefab;
    public int crateHealth = 10;
    private Player player;
    private EndTeleport endTeleport;
    void Start()
    {
        player = FindObjectOfType<Player>();
        endTeleport = FindObjectOfType<EndTeleport>();
        if (Vector3.Distance(transform.position, player.transform.position) <= 15 || Vector3.Distance(transform.position, endTeleport.transform.position) <=3)
        {
            Destroy(gameObject);
        }
    }

    
    void Update()
    {
        if(crateHealth <= 0)
        {
            Destroy(gameObject);
            if(Random.value >= 0.33)
            {
                for(int i=0; i<(int) Random.Range(10,15); i++)
                {
                    if(Random.value > 0.66) Instantiate(scrapPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.5f, transform.position.z + Random.Range(-1f, 1f)), 
                                            Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));
                    else if(Random.value > 0.66) Instantiate(boltPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.5f, transform.position.z + Random.Range(-1f, 1f)), 
                                            Quaternion.Euler(0f, transform.rotation.y, transform.rotation.z));
                    else Instantiate(nutPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.5f, transform.position.z + Random.Range(-1f, 1f)), 
                                            Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));          
                }
            }
            else if(Random.value >= 0.33)
            {
                Instantiate(firstAidPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.Euler(0f, 0f, 0f));
            }
            else
            {
                
            }
        }
    }

    public void Damage()
    {
        crateHealth--;
    }
}
