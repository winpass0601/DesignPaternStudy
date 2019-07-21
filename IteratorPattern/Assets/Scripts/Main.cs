using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	[SerializeField]
	private Inventory m_Inventory;

	private void Awake() {
		m_Inventory = new Inventory();
		m_Inventory.AddItem(new Item("はじまりの剣", "ボロボロで心許無い", new ItemEffect("攻撃力アップ", StatusType.ATK, 5)));
		m_Inventory.AddItem(new Item("はじまりの盾", "お鍋の蓋", new ItemEffect("防御力アップ", StatusType.DEF, 5)));
		m_Inventory.AddItem(new Item("思い出のネックレス", "幼馴染からもらったネックレス。\n思い出すだけで軽やかに動けそう", new ItemEffect("素早さアップ", StatusType.SPD, 10)));

		Iterator<Item> iterator = m_Inventory.GetIterator();
		Iterator<Item> revIterator = m_Inventory.GetReverseIterator();
		while(iterator.HasNext()){
			Debug.Log(iterator.Next().m_Name);
		}

		while(revIterator.HasNext()){
			Debug.Log(revIterator.Next().m_Name);
		}
	}

}
