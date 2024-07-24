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
        bulletPool.GetObject();
    }
}
