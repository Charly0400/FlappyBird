using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    [SerializeField]
    private float vel;
    [SerializeField]
    private int health;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector2 direccion = player.position - transform.position;
            direccion.Normalize();

            transform.Translate(direccion * vel * Time.deltaTime);
        }
    }

    private void Death()
    {

    }
}
