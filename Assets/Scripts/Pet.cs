using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Rigidbody rb;
    public string name = "Pet";
    public float hunger = 0.5f;
    public float thirst = 0.5f;
    public float speed = 3f;
    public float love = 5f;

    public void Move(Vector2 direction)
    {
        rb.MovePosition(rb.position + speed * Time.deltaTime * new Vector3(direction.x, 0, direction.y));
    }

    public void Feed()
    {
        hunger = 0.0f;
    }

    public void Update()
    {
        hunger += Time.deltaTime;
        thirst += Time.deltaTime;
    }

    public virtual void MakeNoise()
    {
        Debug.Log("???");
    }

    public virtual void GivePets()
    {
        love += 0.1f;
    }
}
