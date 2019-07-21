using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory : Aggregate<Item> {

	// note: ゲーム的にはインベントリサイズ固定が良いのかも
	[SerializeField]
	private List<Item> m_ItemList = new List<Item>();
	Iterator<Item> m_Iterator;
	Iterator<Item> m_RevIterator;

	public Inventory(){
		// 各種Iteratorを作成してキャッシュしておく
		m_Iterator = new InventoryIterator(m_ItemList);
		m_RevIterator = new InventoryReverseIterator(m_ItemList);
	}

	public void AddItem(Item item){
		m_ItemList.Add(item);
	}

	public void RemoveItem(Item item){
		m_ItemList.Remove(item);
	}

	public Iterator<Item> GetIterator() {
		m_Iterator.SeekBegin();
		return m_Iterator;
	}

	public Iterator<Item> GetReverseIterator(){
		m_RevIterator.SeekBegin();
		return m_RevIterator;
	}
}
