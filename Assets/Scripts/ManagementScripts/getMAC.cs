using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System;
public class getMAC : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityEngine.Debug.Log(GetCrypt(SystemInfo.deviceUniqueIdentifier+SystemInfo.graphicsDeviceVendor+SystemInfo.graphicsDeviceVersion+SystemInfo.graphicsDeviceName+SystemInfo.processorType));
	}

	public static string GetCrypt(string text)
	{
		string hash = "";
		SHA512 alg = SHA512.Create();
		byte[] result = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
		return Convert.ToBase64String(result);
	}


	// Update is called once per frame
	void Update () {
	
	}
}
