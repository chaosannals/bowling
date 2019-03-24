using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bolwing
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bolw : MonoBehaviour
    {
        private Rigidbody body;

        private void Awake()
        {
            body = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            body.AddForce(Vector3.forward * 20.0f, ForceMode.Impulse);
        }
    }
}
