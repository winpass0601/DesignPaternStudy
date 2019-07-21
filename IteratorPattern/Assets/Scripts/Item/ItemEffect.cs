[System.Serializable]
public struct ItemEffect {
	public string effectName;
	public StatusType statusType;
	public int effectParam;

	public ItemEffect(string name,StatusType type,int param){
		effectName = name;
		statusType = type;
		effectParam = param;
	}
}