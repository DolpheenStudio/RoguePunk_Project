using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperMovement : MonoBehaviour
{
    public Player player;
    public PlayerMovement playerController;
    public CharacterController enemyController;
    public float bumperSpeed = 3f;
    public float bumperAttackSpeed = 1.5f;
    private float nextAttack = 0f;

    void Start()
    {
        enemyController = gameObject.GetComponent<CharacterController>();
        player = FindObjectOfType<Player>();
        playerController = FindObjectOfType<PlayerMovement>();
    }
    
    void Update()
    {
        transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        if(Vector3.Distance(transform.position, player.transform.position) <= 20)
        {
            enemyController.Move(transform.forward * bumperSpeed * Time.deltaTime);
        }
        if(nextAttack > 0)
        {
            nextAttack -= Time.deltaTime;
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= 2 && nextAttack <= 0)
        {
            nextAttack = bumperAttackSpeed;
            playerController.PlayerDamage();
            playerController.PlayerKnockback(gameObject.transform);
        }
        Debug.Log(Vector3.Distance(transform.position, player.transform.position));
    }
}
