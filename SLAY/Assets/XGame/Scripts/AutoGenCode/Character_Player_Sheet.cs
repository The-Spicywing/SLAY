﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EasyExcel.
//     Runtime Version: 4.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using UnityEngine;
using EasyExcel;

namespace XGame
{
	[Serializable]
	public class Player_Record : EERowData
	{
		[EEKeyField]
		[SerializeField]
		private int _Level;
		public int Level { get { return _Level; } }

		[SerializeField]
		private int _Exp;
		public int Exp { get { return _Exp; } }

		[SerializeField]
		private int _Hp;
		public int Hp { get { return _Hp; } }

		[SerializeField]
		private int _Hunger;
		public int Hunger { get { return _Hunger; } }

		[SerializeField]
		private int _Speed;
		public int Speed { get { return _Speed; } }


		public Player_Record()
		{
		}

#if UNITY_EDITOR
		public Player_Record(List<List<string>> sheet, int row, int column)
		{
			TryParse(sheet[row][column++], out _Level);
			TryParse(sheet[row][column++], out _Exp);
			TryParse(sheet[row][column++], out _Hp);
			TryParse(sheet[row][column++], out _Hunger);
			TryParse(sheet[row][column++], out _Speed);
		}
#endif
		public override void OnAfterSerialized()
		{
		}
	}

	public class Character_Player_Sheet : EERowDataCollection
	{
		[SerializeField]
		private List<Player_Record> elements = new List<Player_Record>();

		public override void AddData(EERowData data)
		{
			elements.Add(data as Player_Record);
		}

		public override int GetDataCount()
		{
			return elements.Count;
		}

		public override EERowData GetData(int index)
		{
			return elements[index];
		}

		public override void OnAfterSerialized()
		{
			foreach (var element in elements)
				element.OnAfterSerialized();
		}
	}
}