using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet;
using FishNet.Object;

public class PlayerController : NetworkBehaviour
{
    float velocity = 5f;
    public override void OnStartClient()
    {
        base.OnStartClient();

        if (base.IsOwner == false)
        {
            transform.Find("Main Camera").gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (base.IsOwner == false) return;

        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(horizontal, 0, vertical).normalized;
        movimento = movimento * velocity * Time.deltaTime;

        transform.Translate(movimento);
    }
}
