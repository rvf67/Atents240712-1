using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test08_ObjectPool : TestBase
{
    public BulletPool bulletPool;

    private void Start()
    {
        bulletPool.Initialize();
    }

    protected override void OnTest1(InputAction.CallbackContext context)
    {
        StopAllCoroutines();
    }

    protected override void OnTest2(InputAction.CallbackContext context)
    {
        StartCoroutine(PoolSpawn());
    }

    protected override void OnTest3(InputAction.CallbackContext context)
    {
        StartCoroutine(InstantiateSpawn());
    }

    IEnumerator PoolSpawn()
    {
        while (true)
        {
            bulletPool.GetObject();
            yield return null;
        }
    }

    IEnumerator InstantiateSpawn()
    {
        while (true)
        {
            SimpleFactory.Instance.GetBullet();
            yield return null;
        }
    }
}
