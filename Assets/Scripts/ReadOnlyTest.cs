using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnlyTest : MonoBehaviour
{
    [ReadOnly, SerializeField]
    int _intTest = 0;

    [ReadOnly, SerializeField]
    string _stringTest ="default" ;
}
