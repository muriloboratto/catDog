using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] SpriteRenderer visual;
    const float MOVEMENT_SPEED = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        FlipSprite(x);

        transform.position += new Vector3(x, y) * Time.deltaTime * MOVEMENT_SPEED;
    }

    private void FlipSprite(float _x)
    {
        if (_x > 0) visual.flipX = false;
        else if (_x < 0) visual.flipX = true;
    }
}
