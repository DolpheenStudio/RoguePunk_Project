using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletScript : MonoBehaviour
{
    float distance = 0f;
    Vector3 beginPos;
    private Player player;
    public GameObject damagePopupPrefab;
    public GameObject shotParticle;
    public GameObject bulletBreakSound;

    void Start()
    {
        player = FindObjectOfType<Player>();
        beginPos = transform.position;
    }
    void Update()
    {
        distance += Vector3.Distance(transform.position, beginPos);
        beginPos = transform.position;
        if (distance >= player.playerRange)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Enemy")
        {
            Enemy enemy = coll.gameObject.GetComponentInParent<Enemy>();
            enemy.Damage(player.playerDamage);
            GameObject damagePopup = Instantiate(damagePopupPrefab, transform.position, Quaternion.identity);
            TextMeshPro textMesh = damagePopup.GetComponentInChildren<TextMeshPro>();
            textMesh.SetText(player.playerDamage + "");

        }
        if(coll.gameObject.tag == "Crate")
        {
            Crate crate = coll.gameObject.GetComponentInParent<Crate>();
            crate.Damage();
        }
        if(coll.gameObject.tag == "Crush")
        {
            Crush crush = coll.gameObject.GetComponentInParent<Crush>();
            crush.Damage(player.playerDamage);
            GameObject damagePopup = Instantiate(damagePopupPrefab, transform.position, Quaternion.identity);
            TextMeshPro textMesh = damagePopup.GetComponentInChildren<TextMeshPro>();
            textMesh.SetText(player.playerDamage + "");
        }
        Instantiate(shotParticle, transform.position, transform.rotation);
        Instantiate(bulletBreakSound, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
