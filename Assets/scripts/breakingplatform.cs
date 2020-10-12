using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakingplatform : MonoBehaviour
{
  public float jumpforce=2.5f;
  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.relativeVelocity.y<=0)
    {
      Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

      rb.AddRelativeForce(new Vector2(0,jumpforce), ForceMode2D.Impulse);
            Destroy(gameObject);
    }
  }
}
