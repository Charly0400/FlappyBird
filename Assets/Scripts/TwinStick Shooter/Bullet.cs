using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeToDespawn;
    private float despawnTimer;

    private void Start()
    {
        despawnTimer = 0;
    }

    public void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        despawnTimer += Time.deltaTime;
        if (despawnTimer >= timeToDespawn)
        {
            transform.GetComponent<PoolScript>().Despawn(gameObject);
            despawnTimer = 0;
        }
        //Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Vector2 direction = (Player1.Instance.transform.position - collision.transform.position).normalice;
            collision.getComponent<Zombie>().Hit(damage, direction, pusgForce);
            Destroy(gameObject);
        }


        Destroy(collision.gameObject);
        Destroy(gameObject);

    }


}
