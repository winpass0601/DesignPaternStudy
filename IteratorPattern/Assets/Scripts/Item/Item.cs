[System.Serializable]
public class Item {

	public string m_Name;
	public string m_Description;
	public ItemEffect[] m_Effects;

	public Item(string name,string desc,params ItemEffect[] effects){
		m_Name = name;
		m_Description = desc;
		m_Effects = effects;
	}

	public bool HasEffect(){
		return (m_Effects != null && m_Effects.Length > 0);
	}
}
