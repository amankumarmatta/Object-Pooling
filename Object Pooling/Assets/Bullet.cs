using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 20f;
    float lifeTime = 2f;

    private void OnEnable()
    {
        Invoke(nameof(Deactivate), lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void Deactivate()
    {
        BulletPool.Instance.ReturnBullet(gameObject);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
