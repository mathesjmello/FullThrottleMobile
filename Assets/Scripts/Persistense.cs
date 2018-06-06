using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Persistense
{
	public static int LastCena;
	public static int HaveKey;
	public static int PortaOpen;
	public static void SaveData()
	{
		PlayerPrefs.SetInt("HaveKey", HaveKey);
		PlayerPrefs.SetInt("PortaOpen", PortaOpen);
		PlayerPrefs.SetInt("LastCena",LastCena);
	}

	public static void LoadData()
	{
		HaveKey = PlayerPrefs.GetInt("HaveKey");
		PortaOpen = PlayerPrefs.GetInt("PortaOpen");
		LastCena = PlayerPrefs.GetInt("LastCena");
	}
}
