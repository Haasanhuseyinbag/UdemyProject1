using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] float UcurmaGucu, HareketHizi;
    #region Unity Fonksiyonlarý
    private void Awake()
    {
        _rigidbody = GetComponentInChildren<Rigidbody>();
    }
    void Start()
    {

    }
    void Update()
    {
        Ucurma();
        YanaHareket();
    }
    #endregion
    #region Fonksiyonlar
    void Ucurma()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity += new Vector3(0, UcurmaGucu * Time.deltaTime, 0);
        }
    }
    void YanaHareket()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        _rigidbody.position += new Vector3(Horizontal * HareketHizi * Time.deltaTime, 0);
    }
    #endregion
}
