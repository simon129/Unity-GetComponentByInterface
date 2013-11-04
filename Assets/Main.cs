using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour
{
	void Start()
	{
		Debug.LogWarning("GetInterfaceComponent()");
		var obj = GetInterfaceComponent<MyInterface>();
		if (obj == null)
		{
			Debug.Log("null");
		}
		else
		{
			Debug.Log(obj.GameObjectName + ", " + obj.MyInt);
		}

		Debug.LogWarning("GetInterfaceComponentInChildren()");
		obj = GetInterfaceComponentInChildren<MyInterface>();
		if (obj == null)
		{
			Debug.Log("null");
		}
		else
		{
			Debug.Log(obj.GameObjectName + ", " + obj.MyInt);
		}

		Debug.LogWarning("GetInterfaceComponentsInChildren()");
		var objs = GetInterfaceComponentsInChildren<MyInterface>();
		if (objs == null)
		{
			Debug.Log("null");
		}
		else
		{
			foreach (var o in objs)
			{
				Debug.Log(o.GameObjectName + ", " + o.MyInt);
			}
		}
	}

	public I GetInterfaceComponent<I>() where I : class
	{
		return GetComponent(typeof(I)) as I;
	}

	public I GetInterfaceComponentInChildren<I>() where I : class
	{
		return GetComponentInChildren(typeof(I)) as I;
	}

	public I[] GetInterfaceComponentsInChildren<I>() where I : class
	{
		var t = GetComponentsInChildren(typeof(I));

		if (t.Length == 0)
			return null;
		else
		{
			var r = new I[t.Length];
			for (int i = 0; i < t.Length; i++)
				r[i] = t[i] as I;
			return r;
		}
	}
}