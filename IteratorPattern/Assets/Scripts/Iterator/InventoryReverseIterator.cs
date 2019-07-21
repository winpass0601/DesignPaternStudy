using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryReverseIterator : Iterator<Item> {
	[SerializeField]
	private List<Item> m_ItemList;
	private int m_Index = 0;

	/// <summary>
	/// デフォルトコンストラクタは使用禁止
	/// </summary>
	private InventoryReverseIterator() {
	}

	public InventoryReverseIterator(List<Item> items) {
		// 参照を受けることでAggregate側でサイズ変更された際に
		// Iteratorを作りなおす必要を無くす。
		m_ItemList = items;
	}

	void Iterator<Item>.SeekBegin() {
		m_Index = m_ItemList.Count - 1;
	}

	bool Iterator<Item>.HasNext() {
		return m_Index >= 0;
	}

	Item Iterator<Item>.Next() {
		return m_ItemList[m_Index--];
	}
}
