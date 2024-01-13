using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirJumpRefill : MonoBehaviour
{
    enum Disable
    {
        None,
        OnCollect,
        Duration
    }

    [SerializeField] Disable disableType;
    [SerializeField] float disableTime;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Platformer2DController pc = collision.GetComponent<Platformer2DController>();
        if (pc != null)
        {
            pc.RefillAirJump();
            switch (disableType)
            {
                case Disable.OnCollect:
                    Destroy(gameObject);
                    break;
                case Disable.Duration:
                    SetEnable(false);
                    Invoke(nameof(SetEnableTrue), disableTime);
                    SetEnable(true);
                    break;
            }
        }
    }
    void SetEnableTrue() { SetEnable(true); }

    void SetEnable(bool enable)
    {
        Renderer renderer = GetComponent<Renderer>();
        Collider2D collider = GetComponent<Collider2D>();

        if (renderer != null)
            renderer.enabled = enable;
        if (collider != null)
            collider.enabled = enable;
    }
}
