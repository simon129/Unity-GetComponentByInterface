using UnityEngine;
using System.Collections;

public class MyClass : MonoBehaviour, MyInterface
{
	public string GameObjectName { get { return name; } }
	public int MyInt { get { return value; } }

	public int value = 10;
}