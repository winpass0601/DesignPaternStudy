using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class InventoryIterator : Iterator<Item> {
	[SerializeField]
	private List<Item> m_ItemList;
	private int m_Index = 0;

	/// <summary>
	/// デフォルトコンストラクタは使用禁止
	/// </summary>
	private InventoryIterator(){
	}

	public InventoryIterator(List<Item> items){
		// 参照を受けることでAggregate側でサイズ変更された際に
		// Iteratorを作りなおす必要を無くす。
		m_ItemList = items;
	}

	void Iterator<Item>.SeekBegin(){
		m_Index = 0;
	}

	bool Iterator<Item>.HasNext() {
		return m_Index < m_ItemList.Count;
	}

	Item Iterator<Item>.Next() {
		return m_ItemList[m_Index++];
	}
}
